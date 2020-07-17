+++
title = "Merge Files" 
description = "" 
weight = 12300 
+++

Aspose.Cells for .NET : Merge Files  

# Aspose.Cells for .NET : Merge Files


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738058828 {padding: 0px;}div.rbtoc1590738058828 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738058828 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Introduction](#MergeFiles-Introduction)
*   2 [Merge Files Using Aspose.Cells](#MergeFiles-MergeFilesUsingAspose.Cells)

 

## Introduction

Aspose.Cells provides different ways for merging files. For simple files with data, formatting, and formulas, the [Workbook.Combine()](https://apireference.aspose.com/net/cells/aspose.cells/workbook/methods/combine) method can be used to combine several workbooks, and the [Worksheet.Copy()](https://apireference.aspose.com/net/cells/aspose.cells/worksheet/methods/copy/index) method can be used to copy worksheets into a new workbook. These methods are easy to use and effective, but if you have a lot of files to merge, you might find that they take a lot of system resources. To avoid this, use the [CellsHelper.MergeFiles](https://apireference.aspose.com/net/cells/aspose.cells/cellshelper/methods/mergefiles) static method, a more efficient way to merge several files.

## Merge Files Using Aspose.Cells

The following sample code illustrates how to merge large files using the [CellsHelper.MergeFiles](https://apireference.aspose.com/net/cells/aspose.cells/cellshelper/methods/mergefiles) method. It takes two simple but large files, Book1.xls and Book2.xls. The files contain formatted data and formulas only.

The [CellsHelper.MergeFiles](https://apireference.aspose.com/net/cells/aspose.cells/cellshelper/methods/mergefiles) method only supports merging data, styles, formatting, and formulas. Objects like charts, pictures, comments or other objects might not be merged using this method. Moreover, a cached file is used to store temporary data for the process.
