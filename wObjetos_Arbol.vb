'
'
'
Imports Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions
Imports OfficeOpenXml.ExcelErrorValue
'
'
'
Module wObjetos_Arbol
    '
    '
    '
    Public Sub CargArbolDeposito(ByRef Arbol As TreeView)
        ' 
        If Matriz_DepositoTF = 0 Or Matriz_SolicitudesTF = 0 Then
            MsgBox("No existen datos en la Matriz: Matriz_Alias ó Matriz_Solicitudes", vbCritical, "Error en Sistema")
            Exit Sub
        End If
        '
        '
        '
        Dim i, j, k As Integer
        Dim T As String
        Dim MatrizAux(Matriz_SolicitudesTF, 4) As String
        Dim Contador As Integer = -1
        Dim SW As Boolean
        '
        '-------------------------------------------------------------------------------------------------
        'Llenado de MatrizAux
        For i = 1 To Matriz_SolicitudesTF
            SW = False
            If Filtro = "Todo" Then SW = True
            If Filtro = "Gestion" And Matriz_Solicitudes(i, 19) = "SI" Then SW = True
            If Filtro = "Vigente" And Matriz_Solicitudes(i, 6) = "VIGENTE" Then SW = True
            '
            If SW Then
                Contador += 1
                MatrizAux(Contador, 0) = Matriz_Solicitudes(i, 2)                                   '0   /   2      Alias
                MatrizAux(Contador, 1) = Matriz_Solicitudes(i, 6)                                   '1   /   6      ESTADO
                MatrizAux(Contador, 2) = Matriz_Solicitudes(i, 19)                                  '2   /   19     Gestion
                MatrizAux(Contador, 3) = Matriz_Solicitudes(i, 34)                                  '3   /   34     Fecha YYYYMMDD
                MatrizAux(Contador, 4) = Matriz_Solicitudes(i, 2) & "\" & Matriz_Solicitudes(i, 34) '4   -          Alias\ Fecha       
            End If
        Next i
        Dim TotalFilasMatrizAux = Contador
        '
        '-------------------------------------------------------------------------------------------------
        'Ordenar
        For i = 0 To TotalFilasMatrizAux
            For j = i + 1 To TotalFilasMatrizAux
                SW = False
                If MatrizAux(i, 0) > MatrizAux(j, 0) Then           '2      Alias
                    SW = True
                ElseIf MatrizAux(i, 0) = MatrizAux(j, 0) Then       '2      Alias
                    If MatrizAux(i, 3) > MatrizAux(j, 3) Then       '34     Fecha YYYYMMDD
                        SW = True
                    End If
                End If
                '
                If SW Then
                    For k = 0 To 4
                        T = MatrizAux(i, k)
                        MatrizAux(i, k) = MatrizAux(j, k)
                        MatrizAux(j, k) = T
                    Next k
                End If
            Next j
        Next i
        '
        '
        '-------------------------------------------------------------------------------------------------
        'NIVEL 1
        Dim DirectorioPrincipal() As String
        ReDim DirectorioPrincipal(1)
        Contador = -1
        For i = 1 To TotalFilasMatrizAux
            BuscaAgrega_Arreglo(DirectorioPrincipal, Contador, MatrizAux(i, 0)) '0   /   2      Alias
        Next i
        '
        Arbol.Nodes.Clear()
        For i = 0 To Contador
            Arbol.Nodes.Add(DirectorioPrincipal(i))
        Next i
        '
        '
        '
        'NIVEL 2
        Dim DirectorioSecndario() As String
        ReDim DirectorioSecndario(1)
        Dim TotalArbol = Arbol.Nodes.Count - 1
        For i = 0 To TotalArbol
            Dim vAlias = Arbol.Nodes(i).Text 'Recorrer el Arbol
            Contador = -1
            For j = 0 To TotalFilasMatrizAux
                If vAlias = MatrizAux(j, 0) Then
                    BuscaAgrega_Arreglo(DirectorioSecndario, Contador, MatrizAux(j, 3)) '3   /   34     Fecha YYYYMMDD
                End If
            Next j
            '
            Ordenar_Arreglo(DirectorioSecndario, Contador)
            '
            For k = 0 To Contador
                T = DirectorioSecndario(k)
                Arbol.Nodes(i).Nodes.Add(T)
            Next k
        Next
    End Sub
    '
    '
    '
End Module
'
'
'
