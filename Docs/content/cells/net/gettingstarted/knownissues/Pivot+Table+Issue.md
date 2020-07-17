+++
title = "Pivot Table Issue" 
description = "" 
weight = 12027 
+++

Aspose.Cells for .NET : Pivot Table Issue  

# Aspose.Cells for .NET : Pivot Table Issue


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738020717 {padding: 0px;}div.rbtoc1590738020717 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738020717 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Symptom](#PivotTableIssue-Symptom)
    *   1.1 [Solution](#PivotTableIssue-Solution)

 

 

## Symptom

"I tried to open the generated excel file from the "Open" button of the IE. The excel has been generated by reading an excel template. While I am clicking the Open button it is opening and at the same time it is popping up an error message saying "Cannot open Pivot Table Source file.....".

But when I am saving the generated excel file using the "Save" button and opening it from the file from the saved path it is opening properly without any error. "

### Solution

Aspose.Cells sets the pivot data format and forces MS Excel to create pivot table report and other calculation tasks based on the data source when the workbook opens into MS Excel. So one should use **SaveType.OpenInBrowser** rather than using **SaveType.OpenInExcel**. One of the many reason is when you use OpenInExcel option while saving the output generated file into MS Excel at runtime using "Open" button of the download dialog box, MS Excel could not parse the Workbook data to generate pivot table report. This is caused by the filename problem, It is the routine of IE as it appends something like "\[1\]" to make it as "fileName"+ "\[1\]"+ ".xls" to the original name and thus nothing to do with Aspose.Cells.  (i.e.... it always adds "\[1\]" to make "fileName"+ "\[1\]"+ ".xls" and not like fileName.xls). In short, if a file contains pivot table, it cannot be opened using OpenInExcel SaveType option and this will apply for both i.e., if you create the file from scrach or using any template file for source data to create pivot table report. So, you should use OpenInBrowser SaveType option if the file has pivot table data in it to create pivot table report.

You should change your code and update to SaveType.OpenInBrowser if you are using Workbook.Save() method

Or edit your code to use "inline" if you are using "attachment" option in your code. i.e.
