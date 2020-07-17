+++
title = "Upgrade Aspose.Grid.Web to Aspose.Cells.GridWeb" 
description = "" 
weight = 16658 
+++

Aspose.Cells for .NET : Upgrade Aspose.Grid.Web to Aspose.Cells.GridWeb  

# Aspose.Cells for .NET : Upgrade Aspose.Grid.Web to Aspose.Cells.GridWeb


To make it easier to upgrade, we maintain a document describing information critical to existing users, especially ones who have used the older Aspose.Grid.Web and need to upgrade to the merged Aspose.Cells.GridWeb.

These are intended to be brief notes, and you should be able to find more information by looking at the sections of the [Developer Guide](http://localhost:1313/cellsnet/developerguide/) and [Aspose.Cells.GridWeb API Reference](/pages/createpage.action?spaceKey=cellsnet&title=Aspose.Cells.GridWeb+namespace&linkCreation=true&fromPageId=5013732).

## Upgrading to Aspose.Cells.GridWeb

Aspose.Grid.Web users might come across issues using the new Aspose.Cells.GridWeb when they upgrade to it. It is to be noted that Aspose.Grid.Web has been renamed and become a part of Aspose.Cells so we will not continue or make amendments to older versions of the control.

It is not hard to upgrade to the latest Aspose.Cells.GridWeb component.

There are a few changes in the API as the classes with the members, structs, enumerations etc. remain the same. Most of the changes have been made to the control’s namespaces and other tags or attributes.

The following is the namespaces list and other attributes/tags that are changed now:

1.  The Aspose.Grid.Web namespace has renamed to Aspose.Cells.GridWeb.
2.  The Aspose.Grid.Web.Data namespace has renamed Aspose.Cells.GridWeb.Data.
3.  The Aspose.Grid.Web.Design namespace has renamed Aspose.Cells.GridWeb.Design.
4.  The Aspose.Grid.Formula namespace was renamed to Aspose.Cells.GridFormula, and with recent releases of the component, the said namespace was completely removed from the public API.
5.  The tag `agw:GridWeb` has changed to `acw:GridWeb` in the aspx form.
6.  The older Aspose.Grid.Web client path, agw\_client, has changed to acw\_client for Aspose.Cells.GridWeb .
7.  The client path setting in the web.config file, for example:
    
    <appSettings>     <add key="aspose.grid.web.agw\_client\_path" value="/agw\_client/" />    <add key="aspose.grid.web.force\_script\_path" value="true" /></appSettings> 
    
    has changed to
    
    <appSettings>    <add key="aspose.cells.gridweb.acw\_client\_path" value="/acw\_client/" />    <add key="aspose.cells.gridweb.force\_script\_path" value="true" /></appSettings> 
    
