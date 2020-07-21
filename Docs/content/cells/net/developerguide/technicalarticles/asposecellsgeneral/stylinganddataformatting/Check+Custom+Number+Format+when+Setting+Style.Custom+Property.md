+++
title = "Check Custom Number Format when Setting Style.Custom Property" 
description = "" 
weight = 20410 
+++

Aspose.Cells for .NET : Check Custom Number Format when Setting Style.Custom Property  

# Aspose.Cells for .NET : Check Custom Number Format when Setting Style.Custom Property


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738103436 {padding: 0px;}div.rbtoc1590738103436 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738103436 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Possible Usage Scenarios](#CheckCustomNumberFormatwhenSettingStyle.CustomProperty-PossibleUsageScenarios)
*   2 [Check Custom Number Format when setting Style.Custom property](#CheckCustomNumberFormatwhenSettingStyle.CustomProperty-CheckCustomNumberFormatwhensettingStyle.Customproperty)
*   3 [Sample Code](#CheckCustomNumberFormatwhenSettingStyle.CustomProperty-SampleCode)

 

 

## Possible Usage Scenarios

If you assign invalid custom number format to `Style.Custom` property, then Aspose.Cells will not throw any exception. But if you want that Aspose.Cells should check if the assigned custom number format is valid or not, then please set the `Workbook.Settings.CheckCustomNumberFormat` property to true.

## Check Custom Number Format when setting Style.Custom property

The following sample code assigns an invalid custom number format to `Style.Custom` property. Since, we have already set `Workbook.Settings.CheckCustomNumberFormat` property to true, therefore it throws exception e.g. `Invalid number format`. Please read the comments inside the code for more help.

## Sample Code
