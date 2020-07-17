+++
title = "Evaluating Cell.GetStyle and SetStyle Methods against Cell.Style Property" 
description = "" 
weight = 20398 
+++

Aspose.Cells for .NET : Evaluating Cell.GetStyle and SetStyle Methods against Cell.Style Property  

# Aspose.Cells for .NET : Evaluating Cell.GetStyle and SetStyle Methods against Cell.Style Property


Aspose.Cells for .NET 4.4.2 introduced two new methods for formatting cells: `Cell.GetStyle` and `Cell.SetStyle`. This article examines the `Cell.GetStyle`/`SetStyle` approach Vs the `Cell.Style` approach to help you judge which technique best suits you.

**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738102136 {padding: 0px;}div.rbtoc1590738102136 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738102136 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Formatting Cells](#EvaluatingCell.GetStyleandSetStyleMethodsagainstCell.StyleProperty-FormattingCells)
    *   1.1 [Using GetStyle()](#EvaluatingCell.GetStyleandSetStyleMethodsagainstCell.StyleProperty-UsingGetStyle())
    *   1.2 [Using SetStyle()](#EvaluatingCell.GetStyleandSetStyleMethodsagainstCell.StyleProperty-UsingSetStyle())
*   2 [Conclusion](#EvaluatingCell.GetStyleandSetStyleMethodsagainstCell.StyleProperty-Conclusion)

 

 

## Formatting Cells

There are two ways to format a cell, illustrated below.

### Using GetStyle()

With following piece of code, a `Style` object is initiated for each cell when formatting it. If ta lot of cells are being formatted, a large amount of memory is consumed because the `Style` object is a large object. These `Style` objects won't be freed until the `Workbook.Save` method is called.

**C#**

cell.GetStyle().Font.IsBold = true; 

### Using SetStyle()

The first approach is easy and straight-forward so why did we add the second approach?

We added the second approach to optimize memory usage. After using the `Cell.GetStyle` method to retrieve a `Style` object, modify it and use the `Cell.SetStyle` method to set the it back to this cell. This `Style` object won't be preserved and .NET GC collect it when it's not referenced.

When calling the `Cell.SetStyle` method, the `Style` object isn't saved for each cell. Instead, we compare this `Style` object to an internal `Style` object pool to see if it can be reused. Only `Style` objects that differ from the existing ones are kept for each `Workbook` object. This means that there are only several hundred `Style` objects for each Excel file instead of thousands. For each cell, only an index to the `Style` object pool is preserved.

**C#**

Style style = cell.GetStyle();style.Font.IsBold = true;cell.SetStyle(style); 

Since the `Cell.GetStyle`/`SetStyle` approach uses much less memory and is performance efficient we have eliminated the older `Cell.Style` property that consumed a lot of unnecessary memory with the release of Aspose.Cells 7.1.x.

## Conclusion

The new approach saves a large amount of memory when processing very large Excel files.
