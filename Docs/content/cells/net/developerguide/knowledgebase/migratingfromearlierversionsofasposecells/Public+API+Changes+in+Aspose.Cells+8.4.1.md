+++
title = "Public API Changes in Aspose.Cells 8.4.1" 
description = "" 
weight = 16761 
+++

Aspose.Cells for .NET : Public API Changes in Aspose.Cells 8.4.1  

# Aspose.Cells for .NET : Public API Changes in Aspose.Cells 8.4.1


This document describes the changes to the Aspose.Cells API from version 8.4.0 to 8.4.1 that may be of interest to module/application developers. It includes not only new and updated public methods, [added classes etc.](http://localhost:1313/cellsnet/developerguide/knowledgebase/migratingfromearlierversionsofasposecells/public+api+changes+in+aspose.cells+8.4.1) and [removed classes etc.](http://localhost:1313/cellsnet/developerguide/knowledgebase/migratingfromearlierversionsofasposecells/public+api+changes+in+aspose.cells+8.4.1), but also a description of any changes in the behavior behind the scenes in Aspose.Cells.

## Added APIs

### Mechanism to Modify Database Connection

The `Aspose.Cells.ExternalConnections.ExternalConnection` class already contained the method & properties that could be used to inspect the database connection details stored in a spreadsheet. Most of the properties associated with `Aspose.Cells.ExternalConnections.ExternalConnection` class were read only until the release of Aspose.Cells for .NET 8.4.1. With this release, the API has provided the support to manipulate the database connection settings as well.

The following code snippet shows how to dynamically modify database connection settings.

**C#**

//Create workbook objectAspose.Cells.Workbook workbook = new Aspose.Cells.Workbook(input);//Access first data connectionAspose.Cells.ExternalConnections.ExternalConnection conn = workbook.DataConnections\[0\];//Change a few propertiesconn.Name = "MyConnectionName";conn.OdcFile = "MyDefaulConnection.odc";conn.ConnectionDescription = "Test Connection";conn.Credentials = Aspose.Cells.ExternalConnections.CredentialsMethodType.Prompt;//Save the workbookworkbook.Save(output);

Here are a few most important properties exposed by the {Aspose.Cells.ExternalConnections.ExternalConnection}} class.

Property Name

Description

BackgroundRefresh

Indicates whether the connection can be refreshed in the background (asynchronously).  
true if preferred usage of the connection is to refresh asynchronously in the background;  
false if preferred usage of the connection is to refresh synchronously in the foreground.

ConnectionDescription

Specifies the user description for this connection

ConnectionId

Specifies The unique identifier of this connection.

Credentials

Specifies the authentication method to be used when establishing (or re-establishing) the connection.

IsDeleted

Indicates whether the associated workbook connection has been deleted. true if the  
connection has been deleted; otherwise, false.

IsNew

True if the connection has not been refreshed for the first time; otherwise, false. This  
state can happen when the user saves the file before a query has finished returning.

KeepAlive

True when the spreadsheet application should make efforts to keep the connection  
open. When false, the application should close the connection after retrieving the  
information.

Name

Specifies the name of the connection. Each connection must have a unique name.

OdcFile

Specifies the full path to external connection file from which this connection was  
created. If a connection fails during an attempt to refresh data, and reconnectionMethod=1,  
then the spreadsheet application will try again using information from the external connection file  
instead of the connection object embedded within the workbook.

OnlyUseConnectionFile

Indicates whether the spreadsheet application should always and only use the  
connection information in the external connection file indicated by the odcFile attribute  
when the connection is refreshed. If false, then the spreadsheet application  
should follow the procedure indicated by the reconnectionMethod attribute

Parameters

Gets ConnectionParameterCollection for an ODBC or web query.

ReConnectionMethod

Specify reconnectionMethod type

RefreshInternal

Specifies the number of minutes between automatic refreshes of the connection.

RefreshOnLoad

True if this connection should be refreshed when opening the file; otherwise, false.

SaveData

True if the external data fetched over the connection to populate a table is to be saved  
with the workbook; otherwise, false.

SavePassword

True if the password is to be saved as part of the connection string; otherwise, False.

SourceFile

Used when the external data source is file-based. When a connection to such a data  
source fails, the spreadsheet application attempts to connect directly to this file. May be  
expressed in URI or system-specific file path notation.

SSOId

Identifier for Single Sign On (SSO) used for authentication between an intermediate  
spreadsheetML server and the external data source.

Type

Specifies the data source type.

### Ability to Format Sub-String of DataLabels' Text

Aspose.Cells for .NET 8.4.1 has exposed the `DataLabels.Characters` method to retrieve an instance of `FontSetting` class that corresponds to the sub-string of a `ChartPoints.DataLabels`. In turn, the instance of `FontSetting` class can be used to format the sub-string of the DataLabels with different font settings & color.

The following code snippet shows how to use the `DataLabels.Characters` method.

**C#**

//Create a workbook from source Excel fileAspose.Cells.Workbook workbook = new Aspose.Cells.Workbook(input);//Access first worksheetAspose.Cells.Worksheet worksheet = workbook.Worksheets\[0\];//Access the first chart inside the sheetAspose.Cells.Charts.Chart chart = worksheet.Charts\[0\];//Access the data label of first series first pointAspose.Cells.Charts.DataLabels labels = chart.NSeries\[0\].Points\[0\].DataLabels;//Set data label textlabels.Text = "Rich Text Label";//Set the font setting of the first 10 charactersAspose.Cells.FontSetting settings = labels.Characters(0, 10);settings.Font.Color = System.Drawing.Color.Red;settings.Font.IsBold = true;//Save the workbookworkbook.Save(output);

### Ability to Set Desired Image Dimensions for Spreadsheet & Chart Export

Aspose.Cells for .NET 8.4.1 has exposed the `ImageOrPrintOptions.SetDesiredSize` method to set the dimensions of the resultant image while exporting spreadsheets & charts to images. The `ImageOrPrintOptions.SetDesiredSize` method accepts two integer type parameters, where first is the desired width and second is desired height.

The following code snippet shows how to set the desired dimensions while exporting worksheet to PNG.

**C#**

//Create workbook object from source fileAspose.Cells.Workbook workbook = new Aspose.Cells.Workbook(input);//Access first worksheetAspose.Cells.Worksheet worksheet = workbook.Worksheets\[0\];//Create an instance of ImageOrPrintOptionsAspose.Cells.Rendering.ImageOrPrintOptions options = new Aspose.Cells.Rendering.ImageOrPrintOptions();//Set resultant image formatoptions.ImageFormat = System.Drawing.Imaging.ImageFormat.Png;//Set desired dimensions as 400x400options.SetDesiredSize(400, 400);//Render sheet to imageAspose.Cells.Rendering.SheetRender renderer = new Aspose.Cells.Rendering.SheetRender(worksheet, options);renderer.ToImage(0, "output.png"); 

Same property can also be used for converting charts to images.

### Rendering Comments to PDF

With the release of v8.4.1, the Aspose.Cells API has provided the `PageSetup.PrintComments` property & `PrintCommentsType` enumeration in order to facilitate the rendering of comments while converting spreadsheets to PDF format. The `PrintCommentsType` enumeration has the following constants.

*   `PrintCommentsType.PrintNoComments`: Comments are not to be rendered.
*   `PrintCommentsType.PrintInPlace`: Comments are to be rendered where they are placed.
*   `PrintCommentsType.PrintSheetEnd`: Comments are to be rendered at the end of worksheet.

The following sample code demonstrates the use of `PageSetup.PrintComments` property to render the comments using all possible `PrintCommentsType` enumeration values.

**C#**

//Create an instance of workbookAspose.Cells.Workbook workbook = new Aspose.Cells.Workbook(input);//Access first worksheetAspose.Cells.Worksheet worksheet = workbook.Worksheets\[0\];//Print no commentsworksheet.PageSetup.PrintComments = Aspose.Cells.PrintCommentsType.PrintNoComments;//Save workbook in PDF format without commentsworkbook.Save("nocomments.pdf");//Print the comments as displayed on sheetworksheet.PageSetup.PrintComments = Aspose.Cells.PrintCommentsType.PrintInPlace;//Save workbook in PDF format while rendering comments in placeworkbook.Save("printinplace.pdf");//Print the comments at the end of sheetworksheet.PageSetup.PrintComments = Aspose.Cells.PrintCommentsType.PrintSheetEnd;//Save workbook in PDF format while rendering comments at the end of worksheetworkbook.Save("printsheetend.pdf");

### Move Worksheets in Aspose.Cells.GridDesktop

`Aspose.Cells.GridDesktop` provides the `WorksheetCollection.MoveTo` method, that can used to move a worksheet to the specified index. The aforesaid method takes the indexes (zero-based) of the source worksheet and destination worksheet as parameters.

The following sample code demonstrates the usage of `WorksheetCollection.MoveTo` property.

**C#**

//Move the second worksheet to 4th position.GridDesktop1.Worksheets.MoveTo(1, 3);

### Added Workbook.IsLicensed Property

Aspose.Cells for .NET 8.4.1 has exposed the `Workbook.IsLicensed` which could be of great help in determining if the license has been successfully loaded or not. If you access this property before setting the license, it will return false and vise versa, however, the license should be valid.

The following sample code demonstrates the usage of `Workbook.IsLicensed` property.

**C#**

//Create workbook object before setting a licenseAspose.Cells.Workbook workbook = new Aspose.Cells.Workbook();//Check if the license is loaded or notif (!workbook.IsLicensed){    //Set license    Aspose.Cells.License license = new Aspose.Cells.License();    lic.SetLicense(licPath);}else{    //do process}

### Added ImageOrPrintOptions.SVGFitToViewPort Property

Aspose.Cells for .NET 8.4.1 has exposed the `SVGFitToViewPort` property for the `ImageOrPrintOptions` class that can be used to turn on the viewBox attribute for the SVG file format while exporting spreadsheets or charts to SVG format. The default value of this property is false therefore the base XML for SVG file generated without setting the aforesaid property will not include the viewBox attribute.

The following sample code demonstrates the usage of `ImageOrPrintOptions.SVGFitToViewPort` property.

**C#**

//Create workbook object from source fileAspose.Cells.Workbook workbook = new Aspose.Cells.Workbook(input);//Access first worksheetAspose.Cells.Worksheet worksheet = workbook.Worksheets\[0\];//Create an instance of ImageOrPrintOptionsAspose.Cells.Rendering.ImageOrPrintOptions options = new Aspose.Cells.Rendering.ImageOrPrintOptions();//Set image format to SVGoptions.SaveFormat = Aspose.Cells.SaveFormat.SVG;//Set the SVGFitToViewPort to trueoptions.SVGFitToViewPort = true;//Create an instance of SheetRender and initialize it with worksheet instance as well as object of ImageOrPrintOptionsAspose.Cells.Rendering.SheetRender renderer = new Aspose.Cells.Rendering.SheetRender(worksheet, options);renderer.ToImage(0, "output.svg");

## Obseleted APIs

### Method Workbook.ValidateFormula Obsoleted

Use the `Cell.Formula` method to validate the formula.
