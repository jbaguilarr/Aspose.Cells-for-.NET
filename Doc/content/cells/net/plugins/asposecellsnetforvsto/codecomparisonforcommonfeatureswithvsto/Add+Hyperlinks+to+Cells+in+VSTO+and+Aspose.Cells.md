+++
title = "Add Hyperlinks to Cells in VSTO and Aspose.Cells" 
description = "" 
weight = 16790 
+++

Aspose.Cells for .NET : Add Hyperlinks to Cells in VSTO and Aspose.Cells  

# Aspose.Cells for .NET : Add Hyperlinks to Cells in VSTO and Aspose.Cells


To add hyperlinks to cells in a spreadsheet, take the following steps:

1.  Set up the worksheet:
    *   Instantiate an Application object.(VSTO only.)
    *   Add a Workbook.
    *   Get the first sheet.
    *   Add text to the cells that you'll add a hyperlink to.
2.  Add hyperlink.
3.  Save the document.

These steps are shown in the code examples below. The first examples shows how to use VSTO with either C# to add a hyperlink to a cell. The examples that follow show how to do the same thing using Aspose.Cells for .NET, again using C#.

The code samples generate an Excel file that has a hyperlink in cell A1 on the first worksheet.

![](download/thumbnails/5020859/1119347197)

A hyperlink is added to cell A1.

### VSTO

//Instantiate the Application object.Excel.Application ExcelApp = Application;//Add a Workbook.Excel.Workbook objBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);//Get the First sheet.Excel.Worksheet objSheet = (Excel.Worksheet)objBook.Sheets\["Sheet1"\];//Define a range object(A1).Excel.Range \_range;\_range = objSheet.get\_Range("A1", "A1");//Add a hyperlink to it.objSheet.Hyperlinks.Add(\_range, "http://www.aspose.com/", Type.Missing, "Click to go to Aspose site", "Aspose Site!");//Save the excel file.objBook.SaveCopyAs("Hyperlink\_test.xls");//Quit the Application.ExcelApp.Quit();

### Aspose.Cells

//Instantiate a new Workbook object.Workbook workbook = new Workbook();//Get the First sheet.Worksheet worksheet = workbook.Worksheets\[0\];//Define A1 Cell.Aspose.Cells.Cell cell = worksheet.Cells\["A1"\];//Add a hyperlink to it.int index = worksheet.Hyperlinks.Add("A1", 1, 1, "http://www.aspose.com/");worksheet.Hyperlinks\[index\].TextToDisplay = "Aspose Site!";worksheet.Hyperlinks\[index\].ScreenTip = "Click to go to Aspose site";//Save the excel file.workbook.Save("Hyperlink\_test.xls");

## Download Sample Code

*   [Codeplex](https://asposevsto.codeplex.com/downloads/get/1459771)
*   [Github](https://github.com/asposemarketplace/Aspose_for_VSTO/releases/download/Aspose.Cells1.1/Add.Hyperlinks.to.Cells.Aspose.Cells.zip)
*   [Sourceforge](https://sourceforge.net/projects/asposevsto/files/Aspose.Cells%20Vs%20VSTO%20Excel/Add%20Hyperlinks%20to%20Cells%20(Aspose.Cells).zip/download)
*   [Bitbucket](https://bitbucket.org/asposemarketplace/aspose-for-vsto/downloads/Add%20Hyperlinks%20to%20Cells%20(Aspose.Cells).zip)

## Attachments:


