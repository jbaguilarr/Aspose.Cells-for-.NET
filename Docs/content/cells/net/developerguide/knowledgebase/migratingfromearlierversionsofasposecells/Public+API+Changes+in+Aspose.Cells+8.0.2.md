+++
title = "Public API Changes in Aspose.Cells 8.0.2" 
description = "" 
weight = 16750 
+++

Aspose.Cells for .NET : Public API Changes in Aspose.Cells 8.0.2  

# Aspose.Cells for .NET : Public API Changes in Aspose.Cells 8.0.2


This document describes changes to the Aspose.Cells API from version 8.0.1 to 8.0.2, that may be of interest to module/application developers. It includes not only new and updated public methods, but also a description of any changes in the behavior behind the scenes in Aspose.Cells.

### Added TextDirection Property to Shape Class

The `Shape` class has exposed `TextDirection` property which can be used get or set the direction of the text flow for the `Shape` object. The `TextDirection` property can also be used to set the desired text direction for the comments in a spreadsheet as demonstrated below.

**C#**

//Instantiate a new Workbookvar book = new Workbook();//Get the first worksheetvar sheet = book.Worksheets\[0\];//Add a comment to A1 cellvar comment = sheet.Comments\[sheet.Comments.Add("A1")\];//Set its vertical alignment setting            comment.CommentShape.TextVerticalAlignment  = TextAlignmentType.Center;//Set its horizontal alignment settingcomment.CommentShape.TextHorizontalAlignment = TextAlignmentType.Right;//Set the Text Direction - Right-to-Leftcomment.CommentShape.TextDirection = TextDirectionType.RightToLeft;//Set the Comment notecomment.Note = "This is my Comment Text. This is test";//Save the Excel filebook.Save(myDir + "output.xlsx");

Please check the detailed article on [Changing Text Direction of the Comment](http://localhost:1313/cellsnet/developerguide/technicalarticles/asposecellsgeneral/stylinganddataformatting/change+text+direction+of+the+comment)

### Added ConvertFormulasData Property to HTMLLoadOptions Class

`ConvertFormulasData` property has been added to the `HTMLLoadOptions` Class, in order to facilitate the developers to load Excel formulas from HTML files. The boolean `ConvertFormulasData` property indicates whether or not to convert the string to a formula when the string value starts with character '='.

**C#**

//Create an instance of HTMLLoadOptionsHTMLLoadOptions loadOptions = new HTMLLoadOptions();//Set ConvertFormulasData to trueloadOptions.ConvertFormulasData = true;//Create an instance of Workbook and load an HTML based spreadsheet //while passing the instance of HTMLLoadOptionsWorkbook workbook = new Workbook(myDir + "spreadsheet.html", loadOptions);

The default value of `ConvertFormulasData` property is false.

### Added ImageOptions Property to HtmlSaveOptions Class

`ImageOptions` property has been added to the `HtmlSaveOptions` Class. Exposing the `ImageOptions` property has enabled the developers to set the preferences for the images embedded in the HTML while exporting spreadsheets.

### Obsoleted HtmlSaveOptions.ExportChartImageFormat Property

`HtmlSaveOptions.ExportChartImageFormat` has been marked obsolete starting from Aspose.Cells for .NET 8.0.2. It is advised to use `HtmlSaveOptions.ImageOptions` instead for image format settings while exporting spreadsheets to HTML format.
