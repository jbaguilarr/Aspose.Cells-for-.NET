+++
title = "Implement Custom Calculation Engine to extend the Default Calculation Engine of Aspose.Cells" 
description = "" 
weight = 20546 
+++

Aspose.Cells for .NET : Implement Custom Calculation Engine to extend the Default Calculation Engine of Aspose.Cells  

# Aspose.Cells for .NET : Implement Custom Calculation Engine to extend the Default Calculation Engine of Aspose.Cells


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738128892 {padding: 0px;}div.rbtoc1590738128892 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738128892 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Implement Custom Calculation Engine](#ImplementCustomCalculationEnginetoextendtheDefaultCalculationEngineofAspose.Cells-ImplementCustomCalculationEngine)
    *   1.1 [Programming Sample](#ImplementCustomCalculationEnginetoextendtheDefaultCalculationEngineofAspose.Cells-ProgrammingSample)
    *   1.2 [Console Output](#ImplementCustomCalculationEnginetoextendtheDefaultCalculationEngineofAspose.Cells-ConsoleOutput)
    *   1.3 [Related Article](#ImplementCustomCalculationEnginetoextendtheDefaultCalculationEngineofAspose.Cells-RelatedArticle)

 

 

## Implement Custom Calculation Engine

Aspose.Cells has a powerful calculation engine that can calculate almost all of the Microsoft Excel formulas. Despite this, it also allows you to extend the default calculation engine which provides you greater power and flexibility.

The following property and classes are used in implementing this feature.

*   [CalculationOptions.CustomEngine](https://apireference.aspose.com/net/cells/aspose.cells/calculationoptions/properties/customengine)
*   [AbstractCalculationEngine](https://apireference.aspose.com/net/cells/aspose.cells/abstractcalculationengine)
*   [CalculationData](https://apireference.aspose.com/net/cells/aspose.cells/calculationdata)

The following code implements the Custom Calculation Engine. It implements the interface [AbstractCalculationEngine](https://apireference.aspose.com/net/cells/aspose.cells/abstractcalculationengine) which has a [Calculate(CalculationData data)](https://apireference.aspose.com/net/cells/aspose.cells/abstractcalculationengine/methods/calculate) method. This method is called against all of your formulas. Inside this method, we capture the **Sum** formula and increases its value by 30. So if the Aspose.Cells calculated value is 20, then our custom engine will make it 50 by adding 30.

### Programming Sample

### Console Output

Here is the console output of the above sample code.

Without Custom Engine Value of A1: 20With Custom Engine Value of A1: 50

### Related Article

[Direct calculation of custom function without writing it in a worksheet](http://localhost:1313/cellsnet/developerguide/technicalarticles/asposecellsgeneral/workingwithcalculationengine/direct+calculation+of+custom+function+without+writing+it+in+a+worksheet)
