'
'
'
Imports System.ComponentModel
Imports System.IO
Imports System.Reflection
Imports System.Text
'
'
'
Module xFunciones_Archivo
    '
    '
    '
    Public Function ExisteArchivo(Rutacompleta As String, Optional ConMensaje As Boolean = True) As Boolean
        If File.Exists(Rutacompleta) Then
            Return True
        Else
            If ConMensaje Then MsgBox("No se encuentra el archivo" & vbCrLf & Rutacompleta, vbInformation, "No se encuentra Archivo")
            Return False
        End If
    End Function
    '
    Public Sub CargarTXT(ByVal NombreMatriz As String, ByRef Matriz(,) As String)
        Dim NombreProcedimiento As String = MethodBase.GetCurrentMethod().Name
        If NombreMatriz = Nothing Then Exit Sub

        Dim Ruta As String = RutaLocal & "\" & NombreMatriz & ".txt"
        Dim ColMatriz As Integer

        If Not File.Exists(Ruta) Then End
        Dim Lineas() As String = File.ReadAllLines(Ruta, System.Text.Encoding.UTF8)

        Dim TotalFilas As Integer = Lineas.Length
        If TotalFilas = 0 Then
            MsgBox("El archivo está vacío", vbCritical, NombreProcedimiento)
            End
        End If

        CargaColumnasMatriz(NombreMatriz, ColMatriz)
        ReDim Matriz(TotalFilas + 1, ColMatriz)

        Dim i, j, Contador As Integer
        Contador = 0  ' ← Empieza en 0 para que el encabezado quede en fila 0

        For i = 0 To TotalFilas - 1
            Dim Linea = Lineas(i).Trim
            If Linea = "" Then Continue For

            Dim Elementos() As String = Linea.Split(vbTab)
            If Elementos.Length > ColMatriz Then
                ' Si hay más columnas, se ignoran las extras
            ElseIf Elementos.Length < ColMatriz Then
                For j = Elementos.Length To ColMatriz
                    Elementos = Elementos.Concat(New String() {""}).ToArray()
                Next j
            End If

            RellenarElementos(Elementos)
            For j = 0 To ColMatriz - 1
                Matriz(Contador, j) = Elementos(j).Trim()
            Next j
            Contador += 1  ' ← Incrementa después de grabar
        Next i

        ' TF apunta al último dato real (el encabezado queda en fila 0, datos desde fila 1)
        CargaFilasMatriz(NombreMatriz, Contador - 1)
    End Sub
    '
    Private Sub CargaColumnasMatriz(ByVal NombreMatriz As String, ByRef ColMatriz As Integer)
        Dim NombreProcedimiento As String = MethodBase.GetCurrentMethod().Name
        Select Case NombreMatriz
            Case "Billeteras" : ColMatriz = Matriz_BilleterasTC
            Case "Compras" : ColMatriz = Matriz_ComprasTC
            Case "Exchange" : ColMatriz = Matriz_ExchangeTC
            Case "Monedas" : ColMatriz = Matriz_MonedasTC
            Case "PoolLiquidez" : ColMatriz = Matriz_PoolLiquidezTC
            Case "Traspasos" : ColMatriz = Matriz_TraspasosTC
            Case "Redes" : ColMatriz = Matriz_RedesTC
            Case "ValorUSD" : ColMatriz = Matriz_ValorUSDTC
            Case "BilleteraSaldo" : ColMatriz = Matriz_BilleteraSaldosTC
            Case "Traspasos" : ColMatriz = Matriz_TraspasosTC
            Case Else
                ColMatriz = 0
                MsgBox("Sin Clasificar", vbCritical, NombreProcedimiento)
        End Select
    End Sub
    '
    Public Sub CargaFilasMatriz(ByVal NombreMatriz As String, ByVal Filas As Integer)
        Dim NombreProcedimiento As String = MethodBase.GetCurrentMethod().Name
        Select Case NombreMatriz
            Case "Billeteras" : Matriz_BilleterasTF = Filas
            Case "Compras" : Matriz_ComprasTF = Filas
            Case "Exchange" : Matriz_ExchangeTF = Filas
            Case "Monedas" : Matriz_MonedasTF = Filas
            Case "PoolLiquidez" : Matriz_PoolLiquidezTF = Filas
            Case "Traspasos" : Matriz_TraspasosTF = Filas
            Case "Redes" : Matriz_RedesTF = Filas
            Case "ValorUSD" : Matriz_ValorUSDTF = Filas
            Case "BilleteraSaldo" : Matriz_BilleteraSaldosTF = Filas
            Case "Traspasos" : Matriz_TraspasosTF = Filas
            Case Else
                MsgBox("Sin Clasificar", vbCritical, NombreProcedimiento)
        End Select
    End Sub
    '
    Public Sub Guardar_Matrices(ByVal NombreMatriz As String)
        Dim NombreProcedimiento As String = MethodBase.GetCurrentMethod().Name
        If NombreMatriz = Nothing Then Exit Sub
        '
        Dim TotalFilas, TotalColumnas As Integer
        Dim MatrizAuxActual(,) As String
        ReDim MatrizAuxActual(1, 1) 'Para evitar que el Compilador alege
        '
        AsignarMatrizAuxiliar(NombreMatriz, MatrizAuxActual, TotalFilas, TotalColumnas)
        If TotalFilas = 0 Or TotalColumnas = 0 Then Exit Sub
        '
        Dim i, j, Contador As Integer
        Dim ArchivoFinal() As String
        Dim T As String
        ReDim ArchivoFinal(TotalFilas)
        Contador = -1
        For i = 0 To TotalFilas
            If MatrizAuxActual(i, 0) = "" Then
                Continue For
            Else
                T = MatrizAuxActual(i, 0)
                For j = 1 To TotalColumnas - 1
                    MatrizAuxActual(i, j) = If(String.IsNullOrEmpty(MatrizAuxActual(i, j)), "0", MatrizAuxActual(i, j))
                    T &= vbTab & MatrizAuxActual(i, j)
                Next j
                Contador += 1
                ArchivoFinal(Contador) = T
            End If
        Next i
        ReDim Preserve ArchivoFinal(Contador)
        '
        Dim RutaArchivo As String = RutaLocal & "\" & NombreMatriz & ".txt"
        File.WriteAllLines(RutaArchivo, ArchivoFinal, System.Text.Encoding.UTF8)
    End Sub
    '
    Private Sub AsignarMatrizAuxiliar(ByVal NombreMatriz As String, ByRef MatrizAuxActual(,) As String, ByRef TotalFilas As Integer, ByRef TotalColumnas As Integer)
        TotalFilas = 0
        TotalColumnas = 0
        Select Case NombreMatriz
            Case "Billeteras"
                MatrizAuxActual = Matriz_Billeteras
                TotalFilas = Matriz_BilleterasTF
                TotalColumnas = Matriz_BilleterasTC
            Case "Compras"
                MatrizAuxActual = Matriz_Compras
                TotalFilas = Matriz_ComprasTF
                TotalColumnas = Matriz_ComprasTC
            Case "Exchange"
                MatrizAuxActual = Matriz_Exchange
                TotalFilas = Matriz_ExchangeTF
                TotalColumnas = Matriz_ExchangeTC
            Case "Monedas"
                MatrizAuxActual = Matriz_Monedas
                TotalFilas = Matriz_MonedasTF
                TotalColumnas = Matriz_MonedasTC
            Case "PoolLiquidez"
                MatrizAuxActual = Matriz_PoolLiquidez
                TotalFilas = Matriz_PoolLiquidezTF
                TotalColumnas = Matriz_PoolLiquidezTC
            Case "Traspasos"
                MatrizAuxActual = Matriz_Traspasos
                TotalFilas = Matriz_TraspasosTF
                TotalColumnas = Matriz_TraspasosTC
            Case "Redes"
                MatrizAuxActual = Matriz_Redes
                TotalFilas = Matriz_RedesTF
                TotalColumnas = Matriz_RedesTC
            Case "BilleteraSaldo"
                MatrizAuxActual = Matriz_BilleteraSaldos
                TotalFilas = Matriz_BilleteraSaldosTF
                TotalColumnas = Matriz_BilleteraSaldosTC
            Case "Traspasos"
                MatrizAuxActual = Matriz_Traspasos
                TotalFilas = Matriz_TraspasosTF
                TotalColumnas = Matriz_TraspasosTC
        End Select
    End Sub
    '
    Public Function CargaRTF(Directorio As String, NombreArchivo As String, Control As RichTextBox) As Boolean
        Dim RutaCompleta As String = Directorio & "\" & NombreArchivo
        If File.Exists(RutaCompleta) Then
            Control.LoadFile(RutaCompleta, RichTextBoxStreamType.RichText)
            Return True
        Else
            Control.Text = ""
            Return False
        End If
    End Function
    Public Function GuardarRTF(Directorio As String, NombreArchivo As String, Control As RichTextBox) As Boolean
        Try
            If Len(Control.Text) < 1 Then Return False
            Dim RutaCompleta As String = Directorio & "\" & NombreArchivo
            Control.SaveFile(RutaCompleta, RichTextBoxStreamType.RichText)
            Return True
        Catch ex As Exception
            MsgBox("Error guardando RTF: " & ex.Message)
            Return False
        End Try
    End Function
    '
    '
    Public Sub RellenarElementos(ByRef Elementos() As String)
        Dim i As Integer
        For i = 0 To Elementos.Length - 1
            Elementos(i) = If(String.IsNullOrEmpty(Elementos(i)), "0", Elementos(i))
        Next i
    End Sub
    '
    '
    '
    '-------------------------------------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------------------------------------
    Public Matriz_Billeteras(,) As String
    Public Matriz_BilleterasTF As Integer = 0
    Public Matriz_BilleterasTC As Integer = 3
    Public Sub CargaBilleteras()
        Dim Arreglo(1) As String
        Dim Nombre As String = "Billeteras"
        Dim Ruta As String = RutaLocal & "\" & Nombre & ".txt"
        '
        If Not File.Exists(Ruta) Then
            Dim Encabezado As String = String.Join(vbTab,
                "Codigo_Billetera",    '0 Codigo de la Billetera
                "Nombre",              '1 Nombre que tendra la Billetera para identificarla
                "Link")                '2 Para visualizar la Billetera en alguna Web ya configurada como Uniswap o MetaMask
            File.WriteAllText(Ruta, Encabezado & vbCrLf, System.Text.Encoding.UTF8)
        End If
        CargarTXT(Nombre, Matriz_Billeteras)
    End Sub
    '
    '
    '
    '-------------------------------------------------------------------------------------------------------------------------------------------
    Public Matriz_BilleteraSaldos(,) As String
    Public Matriz_BilleteraSaldosTF As Integer = 0
    Public Matriz_BilleteraSaldosTC As Integer = 9
    Public Sub CargaBilleteraSaldo()
        Dim Nombre As String = "BilleteraSaldo"
        Dim Ruta As String = RutaLocal & "\" & Nombre & ".txt"
        '
        If Not File.Exists(Ruta) Then
            Dim Encabezado As String = String.Join(vbTab,
                "ID",                   '0
                "ID_Billetera",         '1
                "ID_Red",               '2
                "Fecha_Hora",           '3
                "Simbolo",              '4
                "ID_Moneda",            '5
                "Cantidad",             '6
                "Precio_USD",           '7
                "Valor_USD")            '8
            File.WriteAllText(Ruta, Encabezado & vbCrLf, System.Text.Encoding.UTF8)
        End If
        CargarTXT(Nombre, Matriz_BilleteraSaldos)
    End Sub
    '
    '
    '
    '-------------------------------------------------------------------------------------------------------------------------------------------
    Public Matriz_Compras(,) As String
    Public Matriz_ComprasTF As Integer = 0
    Public Matriz_ComprasTC As Integer = 12
    Public Sub CargaCompras()
        Dim Arreglo(Matriz_ComprasTC) As String
        Dim Nombre As String = "Compras"
        Dim Ruta As String = RutaLocal & "\" & Nombre & ".txt"
        '
        If Not File.Exists(Ruta) Then
            Dim Encabezado As String = String.Join(vbTab,
                "ID",                   '0
                "Fecha",                '1
                "Hora",                 '2
                "Plataforma",           '3 MetraMask, Uniswap, etc
                "Moneda_Origen",        '4
                "Valor_Origen",         '5
                "Moneda_Destino",       '6
                "Valor_Destino",        '7
                "Comision",             '8
                "Gas",                  '9
                "Precio")               '10
            File.WriteAllText(Ruta, Encabezado & vbCrLf, System.Text.Encoding.UTF8)
        End If
        CargarTXT(Nombre, Matriz_Compras)
    End Sub
    '
    '
    '
    '-------------------------------------------------------------------------------------------------------------------------------------------
    Public Matriz_Exchange(,) As String
    Public Matriz_ExchangeTF As Integer = 0
    Public Matriz_ExchangeTC As Integer = 3
    Public Sub CargaExchange()
        Dim Arreglo(Matriz_ExchangeTC) As String
        Dim Nombre As String = "Exchange"
        Dim Ruta As String = RutaLocal & "\" & Nombre & ".txt"
        '
        If Not File.Exists(Ruta) Then
            Dim Encabezado As String = String.Join(vbTab,
                "ID",       '0
                "Nombre",   '1
                "Link")     '2
            File.WriteAllText(Ruta, Encabezado & vbCrLf, System.Text.Encoding.UTF8)
        End If
        CargarTXT(Nombre, Matriz_Exchange)
    End Sub
    '
    '
    '
    '-------------------------------------------------------------------------------------------------------------------------------------------
    Public Matriz_Monedas(,) As String
    Public Matriz_MonedasTF As Integer = 0
    Public Matriz_MonedasTC As Integer = 24
    Public Sub CargaMonedas()
        Dim Arreglo(Matriz_MonedasTC) As String
        Dim Nombre As String = "Monedas"
        Dim Ruta As String = RutaLocal & "\" & Nombre & ".txt"
        '
        If Not File.Exists(Ruta) Then
            Dim Encabezado As String = String.Join(vbTab,
                "ID",                               '0
                "ID_Despliegue",                    '1
                "Simbolo",                          '2
                "Nombre_Oficial",                   '3
                "Slug_API",                         '4
                "Tipo_Activo",                      '5
                "Subtipo_Stablecoin",               '6 Solo para stablecoins: fiat, crypto, algoritmica (DAI es crypto-backed, USDT es fiat, etc.)
                "Moneda_Paridad",                   '7 
                "Centralizada",                     '8 
                "Activo_Subyacente",                '9 Solo para wrapped: WBTC → BTC, WETH → ETH
                "ID_Red",                           '10 Es el ID de la Matriz_Red
                "Supply_Maximo",                    '11
                "Contract_Address",                 '12
                "Market_Cap_Rank",                  '13
                "Link CoinGecko",                   '14
                "Current_Price",                    '15
                "Hight24h",                         '16
                "Low24h",                           '17
                "Price_Change_24h",                 '18
                "Price_Change_Percentage_24h",      '19
                "Circulating_Supply",               '20
                "Fecha_Actualizacion",              '21
                "Actualizacion_Automatica",         '22 (SI/NO) sirve para saber si se actualiza automaticamente o es una moneda personalizada que no se actualiza
                "Tipo_Moneda")                      '23 Moneda / CryptoMoneda
            File.WriteAllText(Ruta, Encabezado & vbCrLf, System.Text.Encoding.UTF8)
        End If
        CargarTXT(Nombre, Matriz_Monedas)
    End Sub
    '
    '
    '
    '-------------------------------------------------------------------------------------------------------------------------------------------
    Public Matriz_PoolLiquidez(,) As String
    Public Matriz_PoolLiquidezTF As Integer = 0
    Public Matriz_PoolLiquidezTC As Integer = 17
    Public Sub CargaPoolLiquidez()
        Dim Arreglo(Matriz_PoolLiquidezTC) As String
        Dim Nombre As String = "PoolLiquidez"
        Dim Ruta As String = RutaLocal & "\" & Nombre & ".txt"
        '
        If Not File.Exists(Ruta) Then
            Dim Encabezado As String = String.Join(vbTab,
                "ID",                       '0  
                "Fecha",                    '1  
                "Hora",                     '2  
                "Plataforma",               '3  MetraMask, Uniswap, etc
                "Billetera",                '4  
                "Moneda_Uno",               '5  
                "Valor_Uno",                '6  
                "Moneda_Dos",               '7  
                "Valor_Dos",                '8  
                "Comision",                 '9  
                "Gas",                      '10 
                "Monto_Uno_Resultante",     '11 
                "Monto_Dos_Resultante",     '12 
                "Porcentaje_Uno",           '13 
                "Porcentaje_Dos",           '14 
                "Minimo",                   '15 
                "Maximo")                   '16 
            File.WriteAllText(Ruta, Encabezado & vbCrLf, System.Text.Encoding.UTF8)
        End If
        CargarTXT(Nombre, Matriz_PoolLiquidez)
    End Sub
    '
    '
    '
    '-------------------------------------------------------------------------------------------------------------------------------------------
    Public Matriz_Redes(,) As String
    Public Matriz_RedesTF As Integer = 0
    Public Matriz_RedesTC As Integer = 20
    Public Sub CargaRedes()
        Dim Arreglo(Matriz_RedesTC) As String
        Dim Nombre As String = "Redes"
        Dim Ruta As String = RutaLocal & "\" & Nombre & ".txt"
        '
        If Not File.Exists(Ruta) Then
            Dim Encabezado As String = String.Join(vbTab,
                "ID",                       '0   ID 
                "Chain_ID",                 '1   Identificador único para redes EVM
                "Nombre_Oficial",           '2   Nombre completo
                "Nombre_Corto",             '3   Para mostrar en pantalla
                "Slug_API",                 '4   Identificador en APIs como CoinGecko
                "Tipo_Capa",                '5   Arquitectura de la red, L1 / L2 / Sidechain
                "L1_Padre",                 '6   Solo aplica si es L2 — a qué L1 está anclada
                "Tipo_Rollup",              '7   Solo aplica a L2s
                "Compatible_EVM",           '8   Define si usa el estándar de Ethereum           Sí / No
                "Mecanismo_Consenso",       '9   Cómo valida la red                              PoW, PoS, PoH
                "Token_Nativo",             '10  En ARB el token nativo es ETH, no ARB. El token ARB existe, pero es el token de gobernanza del protocolo, no el que se usa para pagar el gas. Esto aplica también a otras redes como Base y Optimism, que también usan ETH como gas aunque tengan su propio token de gobernanza.
                "Decimales",                '11  Crítico para cálculos — cada red usa distinto   Pueden ser; 18 decimales, 6 decimales, etc.
                "Tiempo_Bloque",            '12  Velocidad de confirmación                       12 seg, 0.4 seg
                "Color_Marca",              '13  Para mostrar en la UI                           #627EEA                     
                "URL_Explorador",           '14  Para consultar transacciones                    etherscan.io
                "URL_Logo",                 '15  Ícono de la red                                 https://...
                "URL_RPC",                  '16  Para conectarse a la red programáticamente      https://...
                "Activa",                   '17  Para desactivar redes sin borrarlas             Sí / No
                "URL_API",                  '18  x
                "chainHex")                 '19  Para sascar valores de Moralis
            File.WriteAllText(Ruta, Encabezado & vbCrLf, System.Text.Encoding.UTF8)
        End If

        CargarTXT(Nombre, Matriz_Redes)
    End Sub
    '
    '
    '
    '-------------------------------------------------------------------------------------------------------------------------------------------
    Public Matriz_Traspasos(,) As String
    Public Matriz_TraspasosTF As Integer
    Public Matriz_TraspasosTC As Integer = 12
    Public Sub CargaTraspasos()
        Dim Arreglo(Matriz_TraspasosTC) As String
        Dim Nombre As String = "Traspasos"
        Dim Ruta As String = RutaLocal & "\" & Nombre & ".txt"
        '
        If Not File.Exists(Ruta) Then
            Dim Encabezado As String = String.Join(vbTab,
                "ID",                   '1  x
                "Fecha",                '2  x
                "Hora",                 '3  x
                "Plataforma",           '4  MetraMask, Uniswap, etc
                "Billetera_Origen",     '5  x
                "Moneda_Origen",        '6  x
                "Valor_Origen",         '7  x
                "Billetera_Destino",    '8  x
                "Moneda_Destino",       '9  x
                "Valor_Destino",        '10 x
                "Comision",             '11 x
                "Gas")                  '12 x
            File.WriteAllText(Ruta, Encabezado & vbCrLf, System.Text.Encoding.UTF8)
        End If
        CargarTXT(Nombre, Matriz_Traspasos)
    End Sub
    '
    '
    '
    '-------------------------------------------------------------------------------------------------------------------------------------------
    Public Matriz_ValorUSD(,) As String
    Public Matriz_ValorUSDTF As Integer = 0
    Public Matriz_ValorUSDTC As Integer = 2
    '
    Public Sub CargaValorUSD()
        Dim Arreglo(Matriz_ValorUSDTC) As String
        Dim Nombre As String = "ValorUSD"
        Dim Ruta As String = RutaLocal & "\" & Nombre & ".txt"
        '
        If Not File.Exists(Ruta) Then
            Dim Encabezado As String = String.Join(vbTab,
                "Fecha",        '0
                "Valor")        '1
            File.WriteAllText(Ruta, Encabezado & vbCrLf, System.Text.Encoding.UTF8)
        End If
        CargarTXT(Nombre, Matriz_ValorUSD)
    End Sub
    '
    '
    '
    '-------------------------------------------------------------------------------------------------------------------------------------------

    '
    '
End Module
'
'
'