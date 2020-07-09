+++
title = "Public API Changes in Aspose.Cells 8.1.0" 
description = "" 
weight = 16751 
+++

Aspose.Cells for .NET : Public API Changes in Aspose.Cells 8.1.0  

# Aspose.Cells for .NET : Public API Changes in Aspose.Cells 8.1.0


This document describes changes to the Aspose.Cells API from version 8.0.2 to 8.1.0, that may be of interest to module/application developers. It includes not only new and updated public methods, but also a description of any changes in the behavior behind the scenes in Aspose.Cells.

### Added HtmlSaveOptions.ExportHiddenWorksheet Property

The `HtmlSaveOptions` class has exposed `ExportHiddenWorksheet` property which can be used to specify if hidden worksheets are exported to HTML format. The default value is true. whereas if set to false, the Aspose.Cells will not export hidden worksheet contents.

Please check the detailed article on [Prevent Exporting Hidden Worksheet](http://localhost:1313/cellsnet/developerguide/technicalarticles/asposecellsgeneral/renderingandprinting/prevent+exporting+hidden+worksheet+contents+on+saving+to+html)

### Added Cell.StringValueWithoutFormat Property

`StringValueWithoutFormat` property has been added to the `Cell` Class, in order to facilitate the developers to retrieve the cell value without any formatting applied.

Below provided code snippet demonstrate the usage of `Cell.StringValueWithoutFormat` property as compared to the `cell.DisplayStringValue` by creating a spreadsheet from scratch and applying the number format to one of the cells.

**C#**

//Create an instance of WorkbookWorkbook book = new Workbook();//Access first worksheetWorksheet sheet = book.Worksheets\[0\];//Access A1 cellCell cell = sheet.Cells\["A1"\];//Put a value cell and convert it to numbercell.PutValue("123456", true);//Create a new Style object and add it to Workbook's Style CollectionStyle style = book.Styles\[book.Styles.Add()\];//Set Number format for Style objectstyle.Number = 3;//Set the style of A1 cellcell.SetStyle(style, new StyleFlag() { NumberFormat = true });//Get formatted string value string formatted = cell.DisplayStringValue;Console.WriteLine(formatted);//Get un-formatted string valuestring unformatted = cell.StringValueWithoutFormat;Console.WriteLine(unformatted);

Output of above code is as follow

123,456

123456

### Obsoleted Bytes, Characters, CharactersWithSpaces, Lines, Paragraphs Properties

Many properties from `BuiltInDocumentPropertyCollection` class have been marked obsolete starting from Aspose.Cells for .NET 8.1.0. These properties include `Bytes`, `Characters`, `CharactersWithSpaces`, `Lines` & `Paragraphs`. Reason being, the aforesaid properties are of no use in preservative of Excel spreadsheets because Excel omits them. Where as these properties were originally written for Word documents & PowerPoint presentations.

