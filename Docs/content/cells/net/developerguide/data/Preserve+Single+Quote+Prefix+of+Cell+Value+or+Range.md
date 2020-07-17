+++
title = "Preserve Single Quote Prefix of Cell Value or Range" 
description = "" 
weight = 12219 
+++

Aspose.Cells for .NET : Preserve Single Quote Prefix of Cell Value or Range  

# Aspose.Cells for .NET : Preserve Single Quote Prefix of Cell Value or Range


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738046540 {padding: 0px;}div.rbtoc1590738046540 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738046540 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Possible Usage Scenarios](#PreserveSingleQuotePrefixofCellValueorRange-PossibleUsageScenarios)
*   2 [Preserve Single Quote Prefix of Cell Value or Range](#PreserveSingleQuotePrefixofCellValueorRange-PreserveSingleQuotePrefixofCellValueorRange)
*   3 [Sample Code](#PreserveSingleQuotePrefixofCellValueorRange-SampleCode)
*   4 [Console Output](#PreserveSingleQuotePrefixofCellValueorRange-ConsoleOutput)

 

## Possible Usage Scenarios

When you put some value inside the cell that has leading apostrophe or single quote mark, then Microsoft Excel hides it, but when you select the cell, it displays the leading apostrophe or single quote in a formula bar as shown in the following screenshot.


Aspose.Cells also hides the leading apostrophe or single quote like Microsoft Excel but it sets the [Style.QuotePrefix](https://apireference.aspose.com/net/cells/aspose.cells/style/properties/quoteprefix) as **true** for that cell. If you set an empty style of the cell, then [Style.QuotePrefix](https://apireference.aspose.com/net/cells/aspose.cells/style/properties/quoteprefix) becomes **false** again. In order to deal with this issue, Aspose.Cells provides [StyleFlag.QuotePrefix](https://apireference.aspose.com/net/cells/aspose.cells/styleflag/properties/quoteprefix) property, when it is set **false**, then [Style.QuotePrefix](https://apireference.aspose.com/net/cells/aspose.cells/style/properties/quoteprefix) is not updated at all and its old value is preserved. It means if the old value of [Style.QuotePrefix](https://apireference.aspose.com/net/cells/aspose.cells/style/properties/quoteprefix) property was **true**, it will remain **true** and if the old value was **false**, it will remain **false**.

## Preserve Single Quote Prefix of Cell Value or Range

The following sample code explains the usage of [StyleFlag.QuotePrefix](https://apireference.aspose.com/net/cells/aspose.cells/styleflag/properties/quoteprefix) property as described previously. Please read the comments inside the code and see the console output of the code given below for more help.

## Sample Code

## Console Output

Quote Prefix of Cell A1: FalseQuote Prefix of Cell A1: TrueWhen StyleFlag.QuotePrefix is False, it means, do not update the value of Cell.Style.QuotePrefix.Similarly, when StyleFlag.QuotePrefix is True, it means, update the value of Cell.Style.QuotePrefix.Quote Prefix of Cell A1: TrueQuote Prefix of Cell A1: False

## Attachments:


