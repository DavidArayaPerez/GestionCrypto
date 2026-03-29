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
        '
        Dim Ruta As String = RutaLocal & "\" & NombreMatriz & ".txt"
        Dim ColMatriz As Integer
        '
        If Not ExisteArchivo(Ruta) Then End
        Dim Lineas() As String = File.ReadAllLines(Ruta, Encoding.GetEncoding(1252))
        '
        Dim TotalFilas As Integer = Lineas.Length
        If TotalFilas = 0 Then
            MsgBox("El archivo está vacío", vbCritical, NombreProcedimiento)
            End
        End If
        '
        CargaColumnasMatriz(NombreMatriz, ColMatriz)                                            'NUMERO DE COLUMNAS
        ReDim Matriz(TotalFilas + 1, ColMatriz)
        '
        Dim i, j, Contador As Integer
        Contador = -1
        For i = 0 To TotalFilas - 1
            Dim Linea = Lineas(i).Trim
            If Linea = "" Then Continue For 'Si la línea está vacía, continuar con la siguiente iteración
            '
            Dim Elementos() As String = Linea.Split(vbTab)
            If Elementos.Length > ColMatriz Then
                'Si hay mas columnas, se ignoran las columnas extras
            ElseIf Elementos.Length < ColMatriz Then
                'Si hay menos columnas, se rellenan con espacios en blanco
                For j = Elementos.Length To ColMatriz
                    Elementos = Elementos.Concat(New String() {""}).ToArray()
                Next j
            End If
            '
            RellenarElementos(Elementos)
            Contador += 1
            For j = 0 To ColMatriz - 1
                Matriz(Contador, j) = Elementos(j).Trim()
            Next j
        Next i
        '
        CargaFilasMatriz(NombreMatriz, Contador)
    End Sub
    '
    Private Sub CargaColumnasMatriz(ByVal NombreMatriz As String, ByRef ColMatriz As Integer)
        Dim NombreProcedimiento As String = MethodBase.GetCurrentMethod().Name
        Select Case NombreMatriz
            Case "Billeteras" : ColMatriz = Matriz_BilleterasTC
            Case "Compras" : ColMatriz = Matriz_ComprasTC
            Case "Depositos" : ColMatriz = Matriz_DepositosTC
            Case "Exchange" : ColMatriz = Matriz_ExchangeTC
            Case "Monedas" : ColMatriz = Matriz_MonedasTC
            Case "Movimientos" : ColMatriz = Matriz_MovimientosTC
            Case "PoolLiquidez" : ColMatriz = Matriz_PoolLiquidezTC
            Case "Traspasos" : ColMatriz = Matriz_TraspasosTC
            Case "ValorDolar" : ColMatriz = Matriz_ValorDolarTC
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
            Case "Depositos" : Matriz_DepositosTF = Filas
            Case "Exchange" : Matriz_ExchangeTF = Filas
            Case "Monedas" : Matriz_MonedasTF = Filas
            Case "Movimientos" : Matriz_MovimientosTF = Filas
            Case "PoolLiquidez" : Matriz_PoolLiquidezTF = Filas
            Case "Traspasos" : Matriz_TraspasosTF = Filas
            Case "ValorDolar" : Matriz_ValorDolarTF = Filas
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
            If MatrizAuxActual(i, 1) = "" Then
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
        Dim RutaArchivo As String = RutaLocal & "\TxT\" & NombreMatriz & ".txt"
        File.WriteAllLines(RutaArchivo, ArchivoFinal, System.Text.Encoding.UTF8)
    End Sub
    Public Sub Guardar_MatrizValor(ByVal NombreMatriz As String)
        'Se utiliza para guardar el valor del dólar, que se almacena en la matriz Matriz_Valor_Dolar, que tiene una sola fila y dos columnas: Fecha y Valor
        'Valor_Dolar    =   Valor_Dolar.txt
        '
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
            If MatrizAuxActual(i, 1) = "" Then
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
        Dim RutaArchivo As String = RutaLocal & "\TxT\" & NombreMatriz & ".txt"
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
            Case "Depositos"
                MatrizAuxActual = Matriz_Depositos
                TotalFilas = Matriz_DepositosTF
                TotalColumnas = Matriz_DepositosTC
            Case "Exchange"
                MatrizAuxActual = Matriz_Exchange
                TotalFilas = Matriz_ExchangeTF
                TotalColumnas = Matriz_ExchangeTC
            Case "Monedas"
                MatrizAuxActual = Matriz_Monedas
                TotalFilas = Matriz_MonedasTF
                TotalColumnas = Matriz_MonedasTC
            Case "Movimientos"
                MatrizAuxActual = Matriz_Movimientos
                TotalFilas = Matriz_MovimientosTF
                TotalColumnas = Matriz_MovimientosTC
            Case "PoolLiquidez"
                MatrizAuxActual = Matriz_PoolLiquidez
                TotalFilas = Matriz_PoolLiquidezTF
                TotalColumnas = Matriz_PoolLiquidezTC
            Case "Traspasos"
                MatrizAuxActual = Matriz_Traspasos
                TotalFilas = Matriz_TraspasosTF
                TotalColumnas = Matriz_TraspasosTC
        End Select
    End Sub
    '
    Public Function CargaRTF(Directorio As String, NombreArchivo As String, Control As RichTextBox) As Boolean
        Dim RutaCompleta As String = Directorio & "\" & NombreArchivo
        If ExisteArchivo(RutaCompleta, False) Then
            Control.LoadFile(RutaCompleta, RichTextBoxStreamType.RichText)
            Return True
        Else
            Control.Text = ""
            Return False
        End If
    End Function
    '
    Public Sub GuardarMatrizEnArchivoTXT(ByVal RutaArchivo As String, ByVal Arreglo() As String)
        Dim ArregloSinEspacios(1) As String
        Dim Contador As Integer = -1
        For i As Integer = 0 To Arreglo.Length - 1
            If Not Arreglo(i) Is Nothing Then
                Contador += 1
                If Contador > 1 Then ReDim Preserve ArregloSinEspacios(Contador)
                ArregloSinEspacios(Contador) = Arreglo(i)
            End If
        Next i
        '
        File.WriteAllLines(RutaArchivo, ArregloSinEspacios, System.Text.Encoding.UTF8)

        'File.WriteAllText(NombreArchivo, Mensaje)
        'No utilizo WriteAllText porque No agrega saltos de línea automáticamente

        'En cambio la instruccion   File.WriteAllLines(
        'Cada elemento del array se escribe como una línea separada en el archivo
        'Agrega saltos de línea automáticamente entre cada elemento
    End Sub
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
End Module
'
'
'