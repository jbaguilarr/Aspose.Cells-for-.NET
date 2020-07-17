+++
title = "Direct calculation of custom function without writing it in a worksheet" 
description = "" 
weight = 20547 
+++

Aspose.Cells for .NET : Direct calculation of custom function without writing it in a worksheet  

# Aspose.Cells for .NET : Direct calculation of custom function without writing it in a worksheet


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738128953 {padding: 0px;}div.rbtoc1590738128953 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738128953 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Direct calculation of custom function without writing it in a worksheet](#Directcalculationofcustomfunctionwithoutwritingitinaworksheet-Directcalculationofcustomfunctionwithoutwritingitinaworksheet)
    *   1.1 [Programming Sample](#Directcalculationofcustomfunctionwithoutwritingitinaworksheet-ProgrammingSample)
    *   1.2 [Console Output](#Directcalculationofcustomfunctionwithoutwritingitinaworksheet-ConsoleOutput)
    *   1.3 [Related Article](#Directcalculationofcustomfunctionwithoutwritingitinaworksheet-RelatedArticle)

 

 

## Direct calculation of custom function without writing it in a worksheet

This topic explains how you can directly calculate your custom functions without first writing them in a worksheet. Please use the [Worksheet.CalculateFormula(string formula, CalculationOptions opts)](https://apireference.aspose.com/net/cells/aspose.cells.worksheet/calculateformula/methods/3) method for this purpose.

Please see the following sample code that illustrates the usage of this method. We have used a custom function named `MyCompany.CustomFunction()` and we calculate its value as `"Aspose.Cells."` by ourselves and then this value is automatically concatenated with the value of cell A1 which is `"Welcome to "` by the calculation engine and the final calculated value returns as `"Welcome to Aspose.Cells."`". As you can see in a code that we have not written our custom function anywhere in a worksheet and it is calculated directly by our own custom logic.

### Programming Sample

### Console Output

Below is the console output of the above sample code.

Calculated Value: Welcome to Aspose.Cells.

### Related Article

[Implement Custom Calculation Engine to extend the Default Calculation Engine of Aspose.Cells](http://localhost:1313/cellsnet/developerguide/technicalarticles/asposecellsgeneral/workingwithcalculationengine/implement+custom+calculation+engine+to+extend+the+default+calculation+engine+of+aspose.cells)
