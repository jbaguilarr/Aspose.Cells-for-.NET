+++
title = "Delete Worksheets from Workbooks" 
description = "" 
weight = 16798 
+++

Aspose.Cells for .NET : Delete Worksheets from Workbooks  

# Aspose.Cells for .NET : Delete Worksheets from Workbooks


You can delete any worksheet in a workbook. To delete a worksheet, use the worksheet host item or access the worksheet by using the sheets collection of the workbook.

#### VSTO

 Excel.Workbook myWorkbook= this.Application.Workbooks.Open(fileName); myWorkbook.Sheets\[2\].Delete();

#### Aspose.Cells

 Workbook myWorkbook = new Workbook(fileName); myWorkbook.Worksheets.RemoveAt(1); myWorkbook.Save(fileName);

#### Download

*   [CodePlex](https://asposevsto.codeplex.com/downloads/get/1459766)
*   [GitHub](https://github.com/asposemarketplace/Aspose_for_VSTO/releases/download/Aspose.Cells1.1/DeleteWorksheetsFromWorkbooks.zip)

