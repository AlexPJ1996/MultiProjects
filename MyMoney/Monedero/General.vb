Module General
    Public FondoF
    Public AppTit, AppDes, AppDev, EMess, OInva As String

    Sub MisVaris()
        FondoF = SystemColors.ActiveCaption
        AppInfo()
        EMess = "Datos no válidos para su ingreso"
        OInva = "Operación no válida"
    End Sub

    Sub AppInfo()
        AppTit = My.Application.Info.Title
        AppDes = My.Application.Info.Description
        AppDev = My.Application.Info.CompanyName
    End Sub

    Sub OnlyNumbers(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
End Module
