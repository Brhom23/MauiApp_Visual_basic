Imports Microsoft.Maui.Controls
Imports Microsoft.Maui
Partial Public Class AppShell : Inherits Shell

    Public Sub New()
        FlyoutBehavior = FlyoutBehavior.Disabled
        With New ShellContent
            .Title = "Home"
            '.ContentTemplate = "{DataTemplate local:MainPage}"
            .ContentTemplate = New DataTemplate(GetType(MainPage))
            .Route = "MainPage"
            Me.Items.Add(.Slf)
        End With

    End Sub
End Class
