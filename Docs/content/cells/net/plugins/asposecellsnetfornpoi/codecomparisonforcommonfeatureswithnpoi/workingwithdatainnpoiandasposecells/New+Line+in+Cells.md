+++
title = "New Line in Cells" 
description = "" 
weight = 20918 
+++

Aspose.Cells for .NET : New Line in Cells  

# Aspose.Cells for .NET : New Line in Cells


## Aspose.Cells - New Line in Cells

To ensure that text in a cell can be read, explicit line breaks and text wrapping can be applied. Text wrapping turns one line into several in a cell, which explicit line breaks put in breaks exactly where you want them.

To wrap text in a cell, use the `Aspose.Cells.Style.IsTextWrapped` property.

**C#**

Workbook workbook = new Workbook(); // Creating a Workbook objectWorksheet sheet = workbook.Worksheets\[0\];sheet.Cells\[2,2\].Value = "Use \\n with word wrap on to create a new line";//Get Cell's StyleStyle style = sheet.Cells\[2, 2\].GetStyle();//Set Text Wrap property to truestyle.IsTextWrapped = true;//Set Cell's Stylesheet.Cells\[2, 2\].SetStyle(style);workbook.Save("test.xlsx");

## NPOI - HSSF XSSF - New Line in Cells

`CellStyle.setWrapText` should be true for wrapped text.

**C#**

IWorkbook workbook = new XSSFWorkbook();ISheet sheet = workbook.CreateSheet("Sheet1");IRow row = sheet.CreateRow(2);ICell cell = row.CreateCell(2);cell.SetCellValue("Use \\n with word wrap on to create a new line");//to enable newlines you need set a cell styles with wrap=trueICellStyle cs = workbook.CreateCellStyle();cs.WrapText = true;cell.CellStyle = cs;FileStream sw = File.Create("test.xlsx");workbook.Write(sw);sw.Close();

## Download Running Code

Download **New Line in Cells** form any of the below mentioned social coding sites:

*   [CodePlex](https://asposenpoi.codeplex.com/downloads/get/1479035)
*   [GitHub](https://github.com/aspose-cells/Aspose.Cells-for-.NET/releases/download/Aspose.Cells_vs_NPOI_1.0/New.Line.In.Cells.Aspose.Cells.zip)

For more details, visit [Line Breaks and Text Wrapping](http://www.aspose.com/docs/display/cellsnet/Line+Breaks+and+Text+Wrapping).
