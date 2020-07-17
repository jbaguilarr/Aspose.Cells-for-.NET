+++
title = "Update references in other worksheets while deleting blank columns and rows in a worksheet" 
description = "" 
weight = 20495 
+++

Aspose.Cells for .NET : Update references in other worksheets while deleting blank columns and rows in a worksheet  

# Aspose.Cells for .NET : Update references in other worksheets while deleting blank columns and rows in a worksheet


When you delete blank columns and rows in a worksheet, then its references in other worksheets become invalid. If you want to avoid this behavior and want those references of the current worksheet in other worksheets are also updated, then please use the [DeleteOptions.UpdateReference](https://apireference.aspose.com/net/cells/aspose.cells/deleteoptions/properties/updatereference) property and set it to **true**.

**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738116863 {padding: 0px;}div.rbtoc1590738116863 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738116863 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Update references in other worksheets while deleting blank columns and rows in a worksheet](#Updatereferencesinotherworksheetswhiledeletingblankcolumnsandrowsinaworksheet-Updatereferencesinotherworksheetswhiledeletingblankcolumnsandrowsinaworksheet)
    *   1.1 [Programming Sample](#Updatereferencesinotherworksheetswhiledeletingblankcolumnsandrowsinaworksheet-ProgrammingSample)
    *   1.2 [Console Output](#Updatereferencesinotherworksheetswhiledeletingblankcolumnsandrowsinaworksheet-ConsoleOutput)

 

 

## Update references in other worksheets while deleting blank columns and rows in a worksheet

Please see the following sample code and its console output. The cell E3 in the second worksheet has a formula `=Sheet1!C3` which is referring to cell C3 in the first worksheet. If you will set [DeleteOptions.UpdateReference](https://apireference.aspose.com/net/cells/aspose.cells/deleteoptions/properties/updatereference) property as **true**, this formula will be updated and become `=Sheet1!A1` on deleting blank columns and rows in the first worksheet. However, if you will set [DeleteOptions.UpdateReference](https://apireference.aspose.com/net/cells/aspose.cells/deleteoptions/properties/updatereference) property as **false**, the formula in cell E3 of the second worksheet will remain `=Sheet1!C3` and become invalid.

### Programming Sample

### Console Output

This is the console output of the above sample code when [DeleteOptions.UpdateReference](https://apireference.aspose.com/net/cells/aspose.cells/deleteoptions/properties/updatereference) property has been set as **true**.

Cell E3 before deleting blank columns and rows in Sheet1.--------------------------------------------------------Cell Formula: =Sheet1!C1Cell Value: 4Cell E3 after deleting blank columns and rows in Sheet1.--------------------------------------------------------Cell Formula: =Sheet1!A1Cell Value: 4

This is the console output of the above sample code when [DeleteOptions.UpdateReference](https://apireference.aspose.com/net/cells/aspose.cells/deleteoptions/properties/updatereference) property has been set as **false**. As you can see, the formula in cell E3 of the second worksheet is not updated and its cell value is now 0 instead of 4 which is invalid.

Cell E3 before deleting blank columns and rows in Sheet1.--------------------------------------------------------Cell Formula: =Sheet1!C1Cell Value: 4Cell E3 after deleting blank columns and rows in Sheet1.--------------------------------------------------------Cell Formula: =Sheet1!C1Cell Value: 0
