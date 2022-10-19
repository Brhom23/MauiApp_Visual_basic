'مرجع برمجه هذه الصفحة
'https://stackoverflow.com/questions/31137807/how-to-dynamically-add-resourcedictionary-to-mergeddictionaries-in-wpf-app
Imports System.ComponentModel
Imports Microsoft.Maui.Controls
Imports Microsoft.Maui.Graphics
Imports Microsoft.UI.Xaml.Markup
Imports Microsoft.Maui.ui
Imports Windows.UI.Xaml.Markup
Imports System.Xml.XPath

Partial Public Class App : Inherits Application

    <Obsolete>
    Public Sub New()

        'With New ResourceDictionary
        '    With .MergedDictionaries
        '        '.Add(New ResourceDictionary With {.Source = New Uri(String.Concat("Resources/Styles/Colors.xaml"), UriKind.Relative)})
        '        '.Add(New ResourceDictionary With {.Source = New Uri(String.Concat("Resources/Styles/Styles.xaml"), UriKind.Relative)})
        '        '<ResourceDictionary Source = "Resources/Styles/Colors.xaml" />
        '        '<ResourceDictionary Source="Resources/Styles/Styles.xaml"/>
        '    End With
        '    Me.Resources = .Slf
        'End With
        'Dim _prefix As String = String.Concat(GetType(App).Namespace, ";component\")

        'With Me.Resources.MergedDictionaries
        '    .Clear()
        '    '.Add(New ResourceDictionary With {.Source = New Uri(_prefix & "Resources\Styles\Colors.xaml", UriKind.Relative)})
        '    Dim d = <ResourceDictionary
        '                xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
        '                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml">
        '                <Color x:Key="Primary">#512BD4</Color>
        '                <Color x:Key="Secondary">#DFD8F7</Color>
        '                <Color x:Key="Tertiary">#2B0B98</Color>
        '                <Color x:Key="White">White</Color>
        '                <Color x:Key="Black">Black</Color>
        '                <Color x:Key="Gray100">#E1E1E1</Color>
        '                <Color x:Key="Gray200">#C8C8C8</Color>
        '                <Color x:Key="Gray300">#ACACAC</Color>
        '                <Color x:Key="Gray400">#919191</Color>
        '                <Color x:Key="Gray500">#6E6E6E</Color>
        '                <Color x:Key="Gray600">#404040</Color>
        '                <Color x:Key="Gray900">#212121</Color>
        '                <Color x:Key="Gray950">#141414</Color>
        '                <SolidColorBrush x:Key="PrimaryBrush" Color="{StaticResource Primary}"/>
        '                <SolidColorBrush x:Key="SecondaryBrush" Color="{StaticResource Secondary}"/>
        '                <SolidColorBrush x:Key="TertiaryBrush" Color="{StaticResource Tertiary}"/>
        '                <SolidColorBrush x:Key="WhiteBrush" Color="{StaticResource White}"/>
        '                <SolidColorBrush x:Key="BlackBrush" Color="{StaticResource Black}"/>
        '                <SolidColorBrush x:Key="Gray100Brush" Color="{StaticResource Gray100}"/>
        '                <SolidColorBrush x:Key="Gray200Brush" Color="{StaticResource Gray200}"/>
        '                <SolidColorBrush x:Key="Gray300Brush" Color="{StaticResource Gray300}"/>
        '                <SolidColorBrush x:Key="Gray400Brush" Color="{StaticResource Gray400}"/>
        '                <SolidColorBrush x:Key="Gray500Brush" Color="{StaticResource Gray500}"/>
        '                <SolidColorBrush x:Key="Gray600Brush" Color="{StaticResource Gray600}"/>
        '                <SolidColorBrush x:Key="Gray900Brush" Color="{StaticResource Gray900}"/>
        '                <SolidColorBrush x:Key="Gray950Brush" Color="{StaticResource Gray950}"/>
        '                <Color x:Key="Yellow100Accent">#F7B548</Color>
        '                <Color x:Key="Yellow200Accent">#FFD590</Color>
        '                <Color x:Key="Yellow300Accent">#FFE5B9</Color>
        '                <Color x:Key="Cyan100Accent">#28C2D1</Color>
        '                <Color x:Key="Cyan200Accent">#7BDDEF</Color>
        '                <Color x:Key="Cyan300Accent">#C3F2F4</Color>
        '                <Color x:Key="Blue100Accent">#3E8EED</Color>
        '                <Color x:Key="Blue200Accent">#72ACF1</Color>
        '                <Color x:Key="Blue300Accent">#A7CBF6</Color>
        '            </ResourceDictionary>
        '    'Dim dd = XamlReader.Load(d)
        '    '.Add(CType(dd, ResourceDictionary))
        'End With


        Me.Resources.MergedDictionaries.Clear()
        With New ResourceDictionary
            .Add("Primary", Color.FromHex("512B00"))
            .Add("Secondary", Color.FromHex("DFD800"))
            .Add("Tertiary", Color.FromHex("2B0B00"))
            .Add("White", Colors.White)
            .Add("Black", Colors.Black)
            .Add("Gray100", Color.FromHex("E1E1E1"))
            .Add("Gray200", Color.FromHex("C8C8C8"))
            .Add("Gray300", Color.FromHex("ACACAC"))
            .Add("Gray400", Color.FromHex("919191"))
            .Add("Gray500", Color.FromHex("6E6E6E"))
            .Add("Gray600", Color.FromHex("404040"))
            .Add("Gray900", Color.FromHex("212121"))
            .Add("Gray950", Color.FromHex("141414"))
            .Add("PrimaryBrush", New SolidColorBrush(.Slf("Primary")))
            .Add("SecondaryBrush", New SolidColorBrush(.Slf("Secondary")))
            .Add("TertiaryBrush", New SolidColorBrush(.Slf("Tertiary")))
            .Add("WhiteBrush", New SolidColorBrush(.Slf("White")))
            .Add("BlackBrush", New SolidColorBrush(.Slf("Black")))
            .Add("Gray100Brush", New SolidColorBrush(.Slf("Gray100")))
            .Add("Gray200Brush", New SolidColorBrush(.Slf("Gray200")))
            .Add("Gray300Brush", New SolidColorBrush(.Slf("Gray300")))
            .Add("Gray400Brush", New SolidColorBrush(.Slf("Gray400")))
            .Add("Gray500Brush", New SolidColorBrush(.Slf("Gray500")))
            .Add("Gray600Brush", New SolidColorBrush(.Slf("Gray600")))
            .Add("Gray900Brush", New SolidColorBrush(.Slf("Gray900")))
            .Add("Gray950Brush", New SolidColorBrush(.Slf("Gray950")))
            '<SolidColorBrush x : Key = "Gray950Brush" Color="{StaticResource Gray950}"/>
            .Add("Yellow100Accent", Color.FromHex("F7B548"))
            .Add("Yellow200Accent", Color.FromHex("FFD590"))
            .Add("Yellow300Accent", Color.FromHex("FFE5B9"))
            .Add("Cyan100Accent", Color.FromHex("28C2D1"))
            .Add("Cyan200Accent", Color.FromHex("7BDDEF"))
            .Add("Cyan300Accent", Color.FromHex("C3F2F4"))
            .Add("Blue100Accent", Color.FromHex("3E8EED"))
            .Add("Blue200Accent", Color.FromHex("72ACF1"))
            .Add("Blue300Accent", Color.FromHex("A7CBF6"))
            Me.Resources.MergedDictionaries.Add(.Slf)
        End With
        With New ResourceDictionary
            .Add("Primary", Color.FromHex("512B00"))
            Me.Resources.MergedDictionaries.Add(.Slf)
        End With



        MainPage = New AppShell()
    End Sub
End Class
