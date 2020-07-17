+++
title = "Merging and Unmerging Cells" 
description = "" 
weight = 16645 
+++

Aspose.Cells for .NET : Merging and Unmerging Cells  

# Aspose.Cells for .NET : Merging and Unmerging Cells


In this topic, we will discuss a utility feature of merging and unmerging cells of a worksheet. This feature is useful in those cases when we need to span some rows or columns to enhance the readability of data.

**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738148654 {padding: 0px;}div.rbtoc1590738148654 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738148654 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Merging Cells](#MergingandUnmergingCells-MergingCells)
*   2 [Unmerging Cells](#MergingandUnmergingCells-UnmergingCells)

 

 

## Merging Cells

To merge cells into a single large cell, please follow the steps below:

*   Access any desired **Worksheet**
*   Create a **Range of Cells** to be merged
*   **Merge** the range of cells into a large cell

You can use **Merge** method of **Worksheet** to merge cells. However, a range of cells can be defined using **CellRange** object.

## Unmerging Cells

To unmerge a large cell into many cells, please follow the steps below:

*   Access any desired **Worksheet**
*   Access the merged cell that needs to be unmerged
*   **Unmerge** the large cell into many cells using the location of merged cell

You can use **Unmerge** method of **Worksheet** to unmerge a cell using its location.

When you merge cells into a single cell then the formatting settings of top left cell (in the range of cells) are applied on the merged cell but when the cell is unmerged, all unmerged cells maintain their formatting settings.

## Attachments:

