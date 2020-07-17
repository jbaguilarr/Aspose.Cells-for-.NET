+++
title = "Names and Indices" 
description = "" 
weight = 12299 
+++

Aspose.Cells for .NET : Names and Indices  

# Aspose.Cells for .NET : Names and Indices


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738058797 {padding: 0px;}div.rbtoc1590738058797 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738058797 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Get Cell Name from Row and Column Indices](#NamesandIndices-GetCellNamefromRowandColumnIndices)
*   2 [Get Row and Column Indices from Cell Name](#NamesandIndices-GetRowandColumnIndicesfromCellName)
*   3 [Create safe sheet names](#NamesandIndices-Createsafesheetnames)

 

## Get Cell Name from Row and Column Indices

It is possible to find a cell's name given the row and column index. This article explains how.  
Aspose.Cells provides the `CellsHelper.CellIndexToName` method which allows developers to get a cell's name if they provide the row and column index.

Unlike Microsoft Excel, where row and column indices start from 1, Aspose.Cells starts counting row and column indices from 0.

The following sample code illustrates how to use `CellsHelper.CellIndexToName` to access the a cell's name given a known row and column index. The code generates the following output.

## Get Row and Column Indices from Cell Name

It is possible to find a row and column index of the cell from its name. This article explains how.  
Aspose.Cells provides the `CellsHelper.CellNameToIndex` method which allows developers to get a row and column index from the cell's name.

Unlike Microsoft Excel, where row and column indices start from 1, Aspose.Cells starts counting row and column indices from 0.

The following sample code illustrates how to use `CellsHelper.CellNameToIndex` to get the row and column index from the cell's name. The code generates the following output.

## Create safe sheet names

Sometimes there is a need of assigning the sheet name at runtime. In this scenario, there may be sheet names which may contain some additional characters like <>+(?”. There is a need to replace any such character, which is not allowed as a sheet name with some preset character provided by user. Similarly the length may increase to more than 31 characters which needs to be truncated. Apache POI provides certain features of creating safe names, hence similar feature is provided by Aspose.Cells to handle all these issues. Following sample code demonstrates this feature:

Output:

this is first name which is cre

 <> + (adj.Private \_ " Private"
