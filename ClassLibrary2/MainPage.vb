Imports Microsoft.Maui.Accessibility
Imports Microsoft.Maui.Controls
Imports Microsoft.Maui
Partial Public Class MainPage : Inherits ContentPage
    Private WithEvents CounterBtn As Button
    Private count As Integer = 0

    Public Sub New()
        'Xaml.Extensions.LoadFromXaml(Me, GetType(MainPage))
        'CounterBtn = NameScopeExtensions.FindByName(Of Button)(Me, "CounterBtn")

        Dim lScrollView = New ScrollView
        With lScrollView
            Dim lVerticalStackLayout As New VerticalStackLayout
            With lVerticalStackLayout
                .Spacing = 25
                .Padding = New Thickness(30, 0)
                .VerticalOptions = LayoutOptions.Center

                With New Image
                    .Source = "dotnet_bot.png"
                    SemanticProperties.SetDescription(.Slf, "Cute dot net bot waving hi to you!")
                    .HeightRequest = 200
                    .HorizontalOptions = LayoutOptions.Center
                    lVerticalStackLayout.Children.Add(.Slf)
                End With

                With New Label
                    .Text = "Hello, World!"
                    SemanticProperties.SetHeadingLevel(.Slf, SemanticHeadingLevel.Level1)
                    .FontSize = 32
                    .HorizontalOptions = LayoutOptions.Center
                    lVerticalStackLayout.Children.Add(.Slf)
                End With

                With New Label
                    .Text = "Welcome to .NET Multi-platform App UI"
                    SemanticProperties.SetHeadingLevel(.Slf, SemanticHeadingLevel.Level2)
                    SemanticProperties.SetDescription(.Slf, "Welcome to dot net Multi platform App U I")
                    .FontSize = 18
                    .HorizontalOptions = LayoutOptions.Center
                    lVerticalStackLayout.Children.Add(.Slf)
                End With

                CounterBtn = New Button
                With CounterBtn
                    .Text = "Click me"
                    SemanticProperties.SetHint(.Slf, "Counts the number of times you click")
                    .HorizontalOptions = LayoutOptions.Center
                    lVerticalStackLayout.Children.Add(.Slf)
                End With

            End With
            .Content = lVerticalStackLayout
        End With
        Content = lScrollView




        'InitializeComponent()
    End Sub

    Private Sub CounterBtn_Clicked(sender As Object, e As EventArgs) Handles CounterBtn.Clicked
        count += 2
        If count = 1 Then
            CounterBtn.Text = $"Clicked {count} time"
        Else
            CounterBtn.Text = $"Clicked {count} times"
        End If
        SemanticScreenReader.Announce(CounterBtn.Text)
    End Sub
End Class




'<Assembly: [global].Microsoft.Maui.Controls.Xaml.XamlResourceId("MauiApp2.MainPage.xaml", "MainPage.xaml", GetType([global].MauiApp2.MainPage))>
'Namespace MauiApp2
'    <[global].Microsoft.Maui.Controls.Xaml.XamlFilePath("MainPage.xaml")>
'    Partial Public Class MainPage
'        Inherits [global].Microsoft.Maui.Controls.ContentPage

'        <[global].System.CodeDom.Compiler.GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")>
'        Private CounterBtn As [global].Microsoft.Maui.Controls.Button

'        <[global].System.CodeDom.Compiler.GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")>
'        Private Sub InitializeComponent()
'            [global].Microsoft.Maui.Controls.Xaml.Extensions.LoadFromXaml(Me, GetType(MainPage))
'            CounterBtn = [global].Microsoft.Maui.Controls.NameScopeExtensions.FindByName(Of [global].Microsoft.Maui.Controls.Button)(Me, "CounterBtn")
'        End Sub
'    End Class
'End Namespace
