+++
title = "Display String in Worksheet Cell" 
description = "" 
weight = 16799 
+++

Aspose.Cells for .NET : Display String in Worksheet Cell  

# Aspose.Cells for .NET : Display String in Worksheet Cell


#### VSTO

 Excel.Workbook myWorkbook = this.Application.Workbooks.Open(fileName); Excel.Worksheet mySheet = myWorkbook.ActiveSheet; Excel.Range cells = mySheet.Cells; cells.set\_Item(1, 1, "Some Text");

#### Aspose.Cells

 Workbook myWorkbook = new Workbook(fileName); Worksheet mySheet = myWorkbook.Worksheets\[myWorkbook.Worksheets.ActiveSheetIndex\]; Cells cells = mySheet.Cells; cells\[0, 0\].PutValue("Some Text"); myWorkbook.Save(fileName);

#### Download

*   [CodePlex](https://asposevsto.codeplex.com/downloads/get/1459769)
*   [GitHub](https://github.com/asposemarketplace/Aspose_for_VSTO/releases/download/Aspose.Cells1.1/DisplayStringInCell.Aspose.Cells.zip)
