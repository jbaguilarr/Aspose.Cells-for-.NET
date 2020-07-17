+++
title = "Insert Hyperlinks in Worksheet" 
description = "" 
weight = 20917 
+++

Aspose.Cells for .NET : Insert Hyperlinks in Worksheet  

# Aspose.Cells for .NET : Insert Hyperlinks in Worksheet


## Aspose.Cells - Insert Hyperlinks in Worksheet

**Adding a Link to a Cell in the Same File**

It is possible to add hyperlinks to cells in the same Excel file by calling the Hyperlink collection's Add method. The Add method works for both internal and external hyperlinks.

**C#**

Workbook workbook = new Workbook(); // Creating a Workbook objectWorksheet sheet = workbook.Worksheets.Add("Hyperlinks");HyperlinkCollection hyperlinks = sheet.Hyperlinks;Style style = new Style();style.Font.Underline = FontUnderlineType.Single;style.Font.Color = System.Drawing.Color.Blue;sheet.Cells\[0, 0\].Value = "URL Link";hyperlinks.Add(0, 0, 1, 1, "http://www.aspose.com");sheet.Cells\[0, 0\].SetStyle(style);//link to a file in the current directorysheet.Cells\[1, 0\].Value = "File Link";hyperlinks.Add(1, 0, 1, 1, "book1.xls");sheet.Cells\[1, 0\].SetStyle(style);//e-mail linksheet.Cells\[2, 0\].Value = "Email Link";hyperlinks.Add(2, 0, 1, 1, "mailto:marketplace@aspose.com?subject=Hyperlinks");sheet.Cells\[2, 0\].SetStyle(style);//link to a place in this workbookWorksheet sheet2 = workbook.Worksheets.Add("Target ISheet");HyperlinkCollection hyperlinks2 = sheet2.Hyperlinks;sheet2.Cells\[3, 0\].Value = "Worksheet Link";hyperlinks2.Add(3, 0, 1, 1, "Target ISheet!A4");sheet2.Cells\[3, 0\].SetStyle(style);workbook.Save("test.xlsx");

**Adding a Link to an External File**

It is possible to add hyperlinks to cells in the same Excel file by calling the `Hyperlink` collection's `Add` method. The `Add` method works for both internal and external hyperlinks. One version of the overloaded method takes the following parameters:

*   Cell name,the name of the cell the hyperlink will be added to.
*   Number of rows, the number of rows in this hyperlink range.
*   Number of columns, the number of columns in this hyperlink range.
*   URL, the address of the target cell.

**C#**

//Instantiating a Workbook objectWorkbook workbook = new Workbook();//Obtaining the reference of the first (default) worksheetWorksheet worksheet = workbook.Worksheets\[0\];//Adding an internal hyperlink to the "B9" cell of the other worksheet "Sheet2" in//the same Excel fileworksheet.Hyperlinks.Add("B3", 1, 1, "Sheet2!B9");//Saving the Excel fileworkbook.Save("C:\\\\book1.xls");

## NPOI - HSSF XSSF - Insert Hyperlinks in Worksheet

**C#**

IWorkbook workbook = new XSSFWorkbook();////cell style for hyperlinks////by default hyperlinks are blue and underlinedICellStyle hlink\_style = workbook.CreateCellStyle();IFont hlink\_font = workbook.CreateFont();hlink\_font.Underline = FontUnderlineType.Single;hlink\_font.Color = HSSFColor.Blue.Index;hlink\_style.SetFont(hlink\_font);ICell cell;ISheet sheet = workbook.CreateSheet("Hyperlinks");//URLcell = sheet.CreateRow(0).CreateCell(0);cell.SetCellValue("URL Link");XSSFHyperlink link = new XSSFHyperlink(HyperlinkType.Url);link.Address = ("http://poi.apache.org/");cell.Hyperlink = (link);cell.CellStyle = (hlink\_style);//link to a file in the current directorycell = sheet.CreateRow(1).CreateCell(0);cell.SetCellValue("File Link");link = new XSSFHyperlink(HyperlinkType.File);link.Address = ("link1.xls");cell.Hyperlink = (link);cell.CellStyle = (hlink\_style);//e-mail linkcell = sheet.CreateRow(2).CreateCell(0);cell.SetCellValue("Email Link");link = new XSSFHyperlink(HyperlinkType.Email);//note, if subject contains white spaces, make sure they are url-encodedlink.Address = ("mailto:poi@apache.org?subject=Hyperlinks");cell.Hyperlink = (link);cell.CellStyle = (hlink\_style);//link to a place in this workbook//Create a target sheet and cellISheet sheet2 = workbook.CreateSheet("Target ISheet");sheet2.CreateRow(0).CreateCell(0).SetCellValue("Target ICell");cell = sheet.CreateRow(3).CreateCell(0);cell.SetCellValue("Worksheet Link");link = new XSSFHyperlink(HyperlinkType.Document);link.Address = ("'Target ISheet'!A1");cell.Hyperlink = (link);cell.CellStyle = (hlink\_style);FileStream sw = File.Create("test.xlsx");workbook.Write(sw);sw.Close();

## Download Running Code

Download **Insert Hyperlinks in Worksheet** form any of the below mentioned social coding sites:

*   [CodePlex](https://asposenpoi.codeplex.com/downloads/get/1479036)
*   [GitHub](https://github.com/aspose-cells/Aspose.Cells-for-.NET/releases/download/Aspose.Cells_vs_NPOI_1.0/Insert.Hyperlinks.In.Worksheet.Aspose.Cells.zip)

For more details, visit [Adding Hyperlinks to Link Data](http://www.aspose.com/docs/display/cellsnet/Adding+Hyperlinks+to+Link+Data).
