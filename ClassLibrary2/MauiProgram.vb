Imports Microsoft.Maui.Controls.Hosting
Imports Microsoft.Maui.Hosting
Public Module MauiProgram
    Function CreateMauiApp() As MauiApp
        Dim builder = MauiApp.CreateBuilder()
        builder.UseMauiApp(Of App)().
            ConfigureFonts(Sub(fonts)
                               fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular")
                               fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold")
                           End Sub)
        Return builder.Build()
    End Function

End Module

