+++
title = "Using Format Painter" 
description = "" 
weight = 16644 
+++

Aspose.Cells for .NET : Using Format Painter  

# Aspose.Cells for .NET : Using Format Painter


Format painter is the feature of MS Excel that has been adapted in Aspose.Cells.GridDesktop. It's a very nice feature. For those people who have not yet used this feature, format painter allows users to apply the formatting settings of any focused cell to another cell. The implementation of this feature is very simple. In this topic, we will cover that too.

**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738148599 {padding: 0px;}div.rbtoc1590738148599 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738148599 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Using Format Painter](#UsingFormatPainter-UsingFormatPainter)
    *   1.1 [Using Format Painter Once](#UsingFormatPainter-UsingFormatPainterOnce)
    *   1.2 [Using Format Painter Always](#UsingFormatPainter-UsingFormatPainterAlways)

 

 

## Using Format Painter

The feature of **Format Painter** requires users to select a cell whose formatting settings you want to apply on other cells and then call **StartFormatPainter** method **GridDesktop**. There are two modes of format painter as follows:

*   **Using Format Painter Once**
*   **Using Format Painter Always**

### Using Format Painter Once

If developers want to use the feature of format painter for just one time only to apply the formatting settings of a focused cell to a single cell then they can do it by calling **StartFormatPainter** method and passing a **false** value to it. This **false** value will prohibit format painter from painting forever.

### Using Format Painter Always

To use format painter always is a useful feature when we need to apply the formatting settings on more than ons cells. Developers can achieve this feature by simply calling **StartFormatPainter** method and passing a **true** value to it.

  
This kind of format painter keeps painting forever unless we stop it. So, to stop format painter from painting always, we can simply call **EndFormatPainter** method of **GridDesktop**.
