+++
title = "Public API Changes in Aspose.Cells 16.11.0" 
description = "" 
weight = 16782 
+++

Aspose.Cells for .NET : Public API Changes in Aspose.Cells 16.11.0  

# Aspose.Cells for .NET : Public API Changes in Aspose.Cells 16.11.0


This document describes the changes to the Aspose.Cells API from version 16.10.0 to 16.11.0 that may be of interest to module/application developers. It includes not only new and updated public methods, added & removed classes etc., but also a description of any changes in the behavior behind the scenes in Aspose.Cells.

## Added APIs

### Support for Globalization Settings

Aspose.Cells 16.11.0 has exposed the `GlobalizationSettings` class along with `WorkbookSettings.GlobalizationSettings` property in order to enforce the Aspose.Cells APIs to use custom labels for Subtotals. The `GlobalizationSettings` class has the following methods which can be overridden in the custom implementation to give desired names to the labels **Total** & **Grand Total**.

*   `GlobalizationSettings.GetTotalName`: Gets the total name of the function.
*   `GlobalizationSettings.GetGrandTotalName`: Gets the grand total name of the function.

Here is a simple custom class that extends `GlobalizationSettings` class and overrides its aforementioned methods to return custom labels for the consolidation function Average.

**C#**

class CustomSettings : GlobalizationSettings{    public override string GetTotalName(ConsolidationFunction functionType)    {        switch (functionType)        {            case ConsolidationFunction.Average:                return "AVG";            default:                return base.GetTotalName(functionType);        }    }    public override string GetGrandTotalName(ConsolidationFunction functionType)    {        switch (functionType)        {            case ConsolidationFunction.Average:                return "GRD AVG";            default:                return base.GetGrandTotalName(functionType);        }    }}

Following snippet loads an existing spreadsheet and adds the Subtotal of type Average on data already available in the worksheet. The `CustomSettings` class and its `GetTotalName` & `GetGrandTotalName` methods will be called at the time of adding Subtotal to the worksheet.

**C#**

// Loads an existing spreadsheet containing some dataWorkbook book = new Workbook(dir + "sample.xlsx");// Assigns the GlobalizationSettings property of the WorkbookSettings class// to the class created in first stepbook.Settings.GlobalizationSettings = new Cells.CustomSettings();// Accesses the 1st worksheet from the collection which contains data// Data resides in the cell range A2:B9Worksheet sheet = book.Worksheets\[0\];// Adds SubTotal of type Average to the worksheetsheet.Cells.Subtotal(CellArea.CreateCellArea("A2", "B9"), 0, ConsolidationFunction.Average, new int\[\] { 0,1 });// Calculates Formulasbook.CalculateFormula();// Auto fits all columnssheet.AutoFitColumns();// Saves the workbook on discbook.Save(dir + "output.xlsx");

The `GlobalizationSettings` class also offers the `GetOtherName` method which is useful to get the name of "Other" labels for Pie charts. Here is a simple usage scenario of `GlobalizationSettings.GetOtherName` method.

**C#**

class CustomSettings : GlobalizationSettings{    public override string GetOtherName()    {        int lcid = System.Globalization.CultureInfo.CurrentCulture.LCID;        switch (lcid)        {            case 1033:                return "Other";            case 1036:                return "Autre";            case 1031:                return "Andere";            //Do other case            default:                return base.GetOtherName();        }    }}

The following snippet loads an existing spreadsheet containing a Pie chart, and renders the chart to image while utilizing the `CustomSettings` class created above.

**C#**

// Loads an existing spreadsheet containing a pie chartWorkbook book = new Workbook(dir + "sample.xlsx");// Assigns the GlobalizationSettings property of the WorkbookSettings class// to the class created in first stepbook.Settings.GlobalizationSettings = new Cells.CustomSettings();// Accesses the 1st worksheet from the collection which contains pie chartWorksheet sheet = book.Worksheets\[0\];// Accesses the 1st chart from the collectionChart chart = sheet.Charts\[0\];// Refreshes the chartchart.Calculate();// Renders the chart to imagechart.ToImage(dir + "output.png", new ImageOrPrintOptions());

### Added CellsFactory Class

Aspose.Cells 16.11.0 has exposed the `CellsFactory` class which currently has one method, that is; `CreateStyle`. The `CellsFactory.CreateStyle` method can be used to create an instance of `Style` class without adding it to the pool of workbook styles.

Here is simple usage scenario of `CellsFactory.CreateStyle` method.

**C#**

// Initializes the CellsFactory classCellsFactory factory = new CellsFactory();// Creates an instance of StyleStyle style = factory.CreateStyle();

### Added Workbook.AbsolutePath Property

Aspose.Cells 16.11.0 has exposed the `Workbook.AbsolutePath` property allows to get or set the absolute workbook path stored in workbook.xml file. This property is useful while updating the external links only.

### Added GridHyperlinkCollection.GetHyperlink Method

Aspose.Cells.GridWeb 16.11.0 has exposed `GetHyperlink` method to the `GridHyperlinkCollection` class that allows to get the instance of `GridHyperlink` by either passing an instance `GridCell` or a pair of integers corresponding to the row column indices.

In case no hyperlink has been found on the specified cell then the `GetHyperlink` method would return null.

Here is simple usage scenario of `GetHyperlink` method.

**C#**

// Gets the active worksheet from the collectionGridWorksheet sheet = GridWeb1.WorkSheets\[GridWeb1.ActiveSheetIndex\];// Accesses the GridHyperlinkCollectionGridHyperlinkCollection links = sheet.Hyperlinks;// Gets hyperlink from cell A1GridHyperlink link = links.GetHyperlink(sheet.Cells\["A1"\]);// Gets hyperlink from cell D1link = links.GetHyperlink(0, 3);

## Obsoleted APIs

### Obsoleted Style Constructor

Please use `cellsFactory.CreateStyle` method as an alternative.

## Deleted APIs

### Deleted Cell.GetConditionalStyle Method

Please use `Cell.GetConditionalFormattingResult` method instead.

### Deleted Cells.MaxDataRowInColumn(int column) Method

Please use `Cells.GetLastDataRow(int)` method as an alternative.

### Deleted PageSetup.Draft Property

It is advised to use the `PageSetup.PrintDraft` property instead.

### Deleted AutoFilter.FilterColumnCollection Property

Please consider using `AutoFilter.FilterColumns` property to achieve the same goal.

### Deleted TickLabels.Rotation Property

Please use `TickLabels.RotationAngle` property instead.

