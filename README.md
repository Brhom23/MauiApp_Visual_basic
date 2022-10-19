To convert the Maui app into a Visul basic
1 Create MauiApp2
2 In the Maui project, created the ClassLibrary2 project for the visual Basic Library
3 Double-click on the Visual Basic project to open the ClassLibrary2.vbproj configuration file
4 Replace the following lines
<PropertyGroup>
    <RootNamespace>ClassLibrary2</RootNamespace>
    <TargetFramework>net6.0</TargetFramework>
    <UseMaui>true</UseMaui>
  </PropertyGroup>
  
  with the following lines
  
  <PropertyGroup>
    <RootNamespace>ClassLibrary2</RootNamespace>
    <TargetFramework>net6.0</TargetFramework>
    <UseMaui>true</UseMaui>
    <SingleProject>true</SingleProject>
    <ImplicitUsings>enable</ImplicitUsings>
    <SupportedOSPlatformVersion Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'ios'">14.2</SupportedOSPlatformVersion>
    <SupportedOSPlatformVersion Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'maccatalyst'">14.0</SupportedOSPlatformVersion>
    <SupportedOSPlatformVersion Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'android'">21.0</SupportedOSPlatformVersion>
    <SupportedOSPlatformVersion Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'windows'">10.0.17763.0</SupportedOSPlatformVersion>
    <TargetPlatformMinVersion Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'windows'">10.0.17763.0</TargetPlatformMinVersion>
    <SupportedOSPlatformVersion Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'tizen'">6.5</SupportedOSPlatformVersion>
  </PropertyGroup>
  واهم ما في هذه الاسطر  <UseMaui>true</UseMaui>

5 Clean the following libraries in nuget
        Microsoft.Maui.Dependencies
        Microsoft.Maui.Extensions
        Microsoft.Windows.SDK.BuildTools
        System.Runtime.InteropServices.NFloat.Internal
6 Convert the codes from c# to Visual Basic
     MauiProgram is converted to a Module and given type Public
7 Adding the BASIC project to the Maui project for reference
         * Click the can button on the Maui project
         * Choose add -> Project refrance
         * Choose the Visual Basic project from the ClassLibrary2 menu
