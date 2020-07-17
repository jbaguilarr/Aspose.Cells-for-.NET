+++
title = "Set DefaultFont property of PdfSaveOptions and ImageOrPrintOptions to have priority" 
description = "" 
weight = 12085 
+++

Aspose.Cells for .NET : Set DefaultFont property of PdfSaveOptions and ImageOrPrintOptions to have priority  

# Aspose.Cells for .NET : Set DefaultFont property of PdfSaveOptions and ImageOrPrintOptions to have priority


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738027352 {padding: 0px;}div.rbtoc1590738027352 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738027352 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Possible Usage Scenarios](#SetDefaultFontpropertyofPdfSaveOptionsandImageOrPrintOptionstohavepriority-PossibleUsageScenarios)
*   2 [Set DefaultFont property of PdfSaveOptions/ImageOrPrintOptions](#SetDefaultFontpropertyofPdfSaveOptionsandImageOrPrintOptionstohavepriority-SetDefaultFontpropertyofPdfSaveOptions/ImageOrPrintOptions)
*   3 [Sample Code](#SetDefaultFontpropertyofPdfSaveOptionsandImageOrPrintOptionstohavepriority-SampleCode)

 

## Possible Usage Scenarios

While setting the **DefaultFont** property of [PdfSaveOptions](https://apireference.aspose.com/net/cells/aspose.cells/pdfsaveoptions) and [ImageOrPrintOptions](https://apireference.aspose.com/net/cells/aspose.cells.rendering/imageorprintoptions), you might expect that saving to PDF or image would set that DefaultFont to all the text in a workbook that has a missing (not installed) font.

Generally, when saving to PDF or image, Aspose.Cells will first try to set Workbook's default font (i.e., Workbook.DefaultStyle.Font). If workbook's default font still cannot show/render text properly, then Aspose.Cells will try to render with font mentioned against DefaultFont attribute in [PdfSaveOptions](https://apireference.aspose.com/net/cells/aspose.cells/pdfsaveoptions)/[ImageOrPrintOptions](https://apireference.aspose.com/net/cells/aspose.cells.rendering/imageorprintoptions).

To cope with your expectation, we have a Boolean property named "**CheckWorkbookDefaultFont**" in [PdfSaveOptions](https://apireference.aspose.com/net/cells/aspose.cells/pdfsaveoptions)/[ImageOrPrintOptions](https://apireference.aspose.com/net/cells/aspose.cells.rendering/imageorprintoptions). You can set it to false to disable trying workbook's default font or let the **DefaultFont** setting in [PdfSaveOptions](https://apireference.aspose.com/net/cells/aspose.cells/pdfsaveoptions)/[ImageOrPrintOptions](https://apireference.aspose.com/net/cells/aspose.cells.rendering/imageorprintoptions) to have priority.

## Set DefaultFont property of PdfSaveOptions/ImageOrPrintOptions

The following sample code opens an Excel file. The A1 cell (in the first worksheet) has a text set to "Christmas Time Font text". The font name is "Christmas Time Personal Use" that is not installed on the machine. We set ***DefaultFont*** attribute of [PdfSaveOptions](https://apireference.aspose.com/net/cells/aspose.cells/pdfsaveoptions)/*[ImageOrPrintOptions](https://apireference.aspose.com/net/cells/aspose.cells.rendering/imageorprintoptions)* to "Times New Roman". We also set **CheckWorkbookDefaultFont** Boolean property to "false" which ensures that the text of A1 cell is rendered with "Times New Roman" font and should not use the default font of the workbook ("Calibri" in this case). The code renders the first worksheet to PNG and TIFF image formats. It finally renders to a PDF file format. 

The default value of ***CheckWorkbookDefaultFont*** attribute is **true**.



This is the output PNG image after setting the [ImageOrPrintOptions.DefaultFont](https://apireference.aspose.com/net/cells/aspose.cells.rendering/imageorprintoptions/properties/imageformat) property to "`Times New Roman"`.




## Sample Code

## Attachments:

