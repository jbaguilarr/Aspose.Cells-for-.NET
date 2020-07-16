+++
title = "Merge or UnMerge Cells in a Worksheet in VSTO and Aspose.Cells" 
description = "" 
weight = 16805 
+++

Aspose.Cells for .NET : Merge or UnMerge Cells in a Worksheet in VSTO and Aspose.Cells  

# Aspose.Cells for .NET : Merge or UnMerge Cells in a Worksheet in VSTO and Aspose.Cells


Open an existing excel file, Merge some cells in the first worksheet in the workbook and save the excel file.

## Merging Cells

### VSTO

Following are the parallel code snippets for VSTO (C#) and Aspose.Cells for .NET (C#).

//Instantiate the Application object. Excel.Application excelApp = Application;//Specify the template excel file path. string myPath = "Book1.xls";//Open the excel file. excelApp.Workbooks.Open(myPath, Missing.Value, Missing.Value,            Missing.Value, Missing.Value,            Missing.Value, Missing.Value,            Missing.Value, Missing.Value,            Missing.Value, Missing.Value,            Missing.Value, Missing.Value,            Missing.Value, Missing.Value);//Get the range of cells i.e.., A1:C1. Excel.Range rng1 = excelApp.get\_Range("A1", "C1");//Merge the cells. rng1.Merge(Missing.Value); rng1 = excelApp.get\_Range("A1", Missing.Value);//Save the file. excelApp.ActiveWorkbook.Save();//Quit the Application. excelApp.Quit();

### Aspose.Cells

//Instantiate a new Workbook.  Workbook workbook = new Workbook();//Specify the template excel file path. string myPath = "Book1.xls";//Open the excel file. workbook.Open(myPath);//Get the range of cells i.e.., A1:C1. Aspose.Cells.Range rng1 = workbook.Worksheets\[0\].Cells.CreateRange("A1", "C1");//Merge the cells. rng1.Merge();//Save the file.  workbook.Save("Book1.xls");

## UnMerging Cells

To unmerge the cell(s), use the following lines of code for VSTO (C#) and Aspose.Cells for .NET (C#).

### VSTO

//UnMerge the cell.  rng1.UnMerge();

### Aspose.Cells

  Cells rng = workbook.Worksheets\[0\].Cells;//UnMerge the cell.  rng.UnMerge(0, 0, 1, 3);

## Download Sample Code

*   [Codeplex](https://asposevsto.codeplex.com/downloads/get/1459784)
*   [Github](https://github.com/asposemarketplace/Aspose_for_VSTO/releases/download/Aspose.Cells1.1/Merge.or.UnMerge.Cells.in.a.Worksheet.Aspose.Cells.zip)
*   [Sourceforge](https://sourceforge.net/projects/asposevsto/files/Aspose.Cells%20Vs%20VSTO%20Excel/Merge%20or%20UnMerge%20Cells%20in%20a%20Worksheet%20(Aspose.Cells).zip/download)
*   [Bitbucket](https://bitbucket.org/asposemarketplace/aspose-for-vsto/downloads/Merge%20or%20UnMerge%20Cells%20in%20a%20Worksheet%20(Aspose.Cells).zip)

