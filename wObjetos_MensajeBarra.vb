'
'
'
Module wObjetos_MensajeBarra
    '
    '
    '
    Public Sub MensajeBarraLimpíar(ByRef Control As StatusStrip)
        MensajeBarra_Hora(Control)
        Control.Items(0).Text = ""
        Control.Items(1).Text = ""
        Control.Items(2).Text = ""
        Control.Items(3).Text = ""
        Control.Items(4).Text = ""
        'Control.Items(5).Text = ""
        Control.Items(6).Text = ""
        Control.Items(7).Text = ""
        Control.Items(8).Text = ""
        Control.Items(9).Text = ""
        Control.Items(10).Text = ""
    End Sub
    '

    '
    Public Sub MensajeBarraAcceso(ByRef Control As StatusStrip)
        MensajeBarra_Hora(Control)
        If HabilitadoParaGrabar Then
            Control.Items(1).Text = "Acceso FULL"
        Else
            Control.Items(1).Text = "Acceso Lectura"
        End If
    End Sub
    '
    Public Sub MensajeBarra(ByRef Control As StatusStrip, Clave As String, Mensaje As String)
        If Clave.Trim = "" Or Mensaje.Trim = "" Then
            MensajeBarraLimpíar(Control)
        Else
            MensajeBarra_Hora(Control)
            Control.Items(2).Text = Clave & ":"
            Control.Items(3).Text = Mensaje
            Control.Items(4).Text = " / "
        End If
    End Sub
    '
    Public Sub MensajeBarra_TeclasAccesoDirecto_Carpeta(ByRef Control As StatusStrip)
        Control.Items(5).Text = "Cerrar:ESC / GrabarCerrar:F2 /AbrirCarpeta:F3 /EditarMensaje:F4"
    End Sub
    Public Sub MensajeBarra_TeclasAccesoDirecto_Archivo(ByRef Control As StatusStrip)
        Control.Items(5).Text = "Cerrar:ESC / GrabarCerrar:F2 /AbrirArchivo:F3 /EditarMensaje:F4"
    End Sub
    '
    Public Sub MensajeBarra_Valores(ByRef Control As StatusStrip)
        Control.Items(6).Text = "UF: " & P_Datos_UF_HOY() & " | "
        Control.Items(7).Text = "UTM: " & P_Datos_UTM_HOY() & " | "
        Control.Items(8).Text = "Dolar: " & P_Datos_DOLAR_HOY() & " | "
    End Sub
    Public Sub MensajeBarra_Hora(ByRef Control As StatusStrip)
        Control.Items(9).Text = Format(Now(), "yyyy/MM/dd") & ", " & Format(Now(), "hh:mm") & "hrs"
    End Sub

    '
    '
    '
End Module
'
'
'
'