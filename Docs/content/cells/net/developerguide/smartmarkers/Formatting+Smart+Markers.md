+++
title = "Formatting Smart Markers" 
description = "" 
weight = 12306 
+++

Aspose.Cells for .NET : Formatting Smart Markers  

# Aspose.Cells for .NET : Formatting Smart Markers


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738059625 {padding: 0px;}div.rbtoc1590738059625 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738059625 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Copy Style Attribute](#FormattingSmartMarkers-CopyStyleAttribute)
    *   1.1 [Copying Styles from Cells with Smart Markers](#FormattingSmartMarkers-CopyingStylesfromCellswithSmartMarkers)
*   2 [Adding Custom Labels](#FormattingSmartMarkers-AddingCustomLabels)
    *   2.1 [Introduction](#FormattingSmartMarkers-Introduction)
    *   2.2 [Adding custom Labels to concatenate with the Subtotal rows in Smart Markers](#FormattingSmartMarkers-AddingcustomLabelstoconcatenatewiththeSubtotalrowsinSmartMarkers)

 

## Copy Style Attribute

Sometimes, when using smart markers, you want to copy the style of the cell that contains the smart marker tags. You can use the `CopyStyle` attribute of the smart marker's tags for this purpose.

### Copying Styles from Cells with Smart Markers

This example uses a simple template Microsoft Excel file with two markers in the A2 and B2 cells. The marker pasted in cell B2 uses the `CopyStyle` attribute, whereas the marker in cell A2 does not. Apply simple formatting (for example, set the font color to **red** and set the cell fill color to **yellow**).

When executing the code, Aspose.Cells copies the formatting to all the records in column B but does not keep the formatting in column A.

## Adding Custom Labels

### Introduction

While working with Smart Markers' grouping data feature, sometimes you need to add your own custom labels to the summary row. You also want to concatenate the Column's name with that Label, e.g "Sub Total of Orders". Aspose.Cells provides you `Label` and `LabelPosition` attributes, so you may place your custom labels in the Smart Markers while concatenating with the Subtotal rows in grouping data.

### Adding custom Labels to concatenate with the Subtotal rows in Smart Markers


## Attachments:

