+++
title = "Using Aspose.Cells.GridDesktop in WPF Application" 
description = "" 
weight = 16600 
+++

Aspose.Cells for .NET : Using Aspose.Cells.GridDesktop in WPF Application  

# Aspose.Cells for .NET : Using Aspose.Cells.GridDesktop in WPF Application


This article demonstrates how to use the Windows Presentation Foundation (WPF) Designer for Visual Studio to host a Windows Forms control such as Aspose.Cells.GridDesktop in a WPF application.  
We will be using Visual Studio 2015 to demonstrate the process, however, you can use any version including Visual Studio 2008 or later.

**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738141170 {padding: 0px;}div.rbtoc1590738141170 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738141170 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Create a WPF application using Visual Studio](#UsingAspose.Cells.GridDesktopinWPFApplication-CreateaWPFapplicationusingVisualStudio)
*   2 [Add references to required namespaces](#UsingAspose.Cells.GridDesktopinWPFApplication-Addreferencestorequirednamespaces)
*   3 [Add references to XAML](#UsingAspose.Cells.GridDesktopinWPFApplication-AddreferencestoXAML)
*   4 [Add Aspose.Cells.GridDesktop control to XAML](#UsingAspose.Cells.GridDesktopinWPFApplication-AddAspose.Cells.GridDesktopcontroltoXAML)
*   5 [Use Aspose.Cells.GridDesktop](#UsingAspose.Cells.GridDesktopinWPFApplication-UseAspose.Cells.GridDesktop)
*   6 [Build & Run](#UsingAspose.Cells.GridDesktopinWPFApplication-Build&Run)

 

 

This tutorial will walk you through the process of adding Aspose.Cells.GridDesktop control to a WPF application. You need any version of the Visual Studio IDE that supports WPF development in order to try this on your side.

## Create a WPF application using Visual Studio

First create a WPF application using Visual Studio IDE. Click on **File** >> **New** >> **Project** menu and select **WPF Application** from Templates, name the project and click **OK**. You can target your project to any .NET Framework higher than 2.0, however, you cannot use client profile .NET Frameworks.

## Add references to required namespaces

Add the references to the following assemblies by right clicking the References from Solution Explorer window and select Add Reference menu.

*   WindowsFormsIntegration assembly (WindowsFormsIntegration.dll).
*   Windows Forms assembly (System.Windows.Forms.dll).
*   Aspose.Cells.GridDesktop assembly (Aspose.Cells.GridDesktop.dll).

This action adds the required assemblies to the application, that is; copies the assemblies to the the Bin folder of the application.

## Add references to XAML

Next, go to the XAML file and add the following namespaces and assembly references within the Windows tag.

xmlns:wf="clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms"xmlns:gridDesktop="clr-namespace:Aspose.Cells.GridDesktop;assembly=Aspose.Cells.GridDesktop">

**The final Windows tag will look similar to as shown below.**


## Add Aspose.Cells.GridDesktop control to XAML

Simply add the below code inside the Grid tag in XAML. The **WindowsFormsHost** tag is used to host Windows Forms control and **gridDesktop:GridDesktop** tag represents the Aspose.Cells.GridDesktop control. You can also name the control so that it can be referenced easily in the code.

<WindowsFormsHost Loaded="FrameworkElement\_OnLoaded">    <WindowsFormsHost.Child>        <gridDesktop:GridDesktop x:Name="grid" />    </WindowsFormsHost.Child></WindowsFormsHost>

**The final XAML will look as follow.**  

## Use Aspose.Cells.GridDesktop

We can now access & use Aspose.Cells.GridDesktop control in the .cs file as any other Windows Forms applications. In order to keep the demonstration simple, we are just loading a sample spreadsheet in the Aspose.Cells.GridDesktop control and saving it back. Moreover, we have used the `FrameworkElement_OnLoaded` event to trigger the following statements.

## Build & Run

Now, build and run the application using **F5** or **Start** button on the Visual Studio UI.

## Attachments:

