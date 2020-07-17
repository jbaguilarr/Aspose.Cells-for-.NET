+++
title = "Implement Cell.FormulaLocal similar to Excel VBA Range.FormulaLocal" 
description = "" 
weight = 12134 
+++

Aspose.Cells for .NET : Implement Cell.FormulaLocal similar to Excel VBA Range.FormulaLocal  

# Aspose.Cells for .NET : Implement Cell.FormulaLocal similar to Excel VBA Range.FormulaLocal


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738034171 {padding: 0px;}div.rbtoc1590738034171 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738034171 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Possible Usage Scenarios](#ImplementCell.FormulaLocalsimilartoExcelVBARange.FormulaLocal-PossibleUsageScenarios)
*   2 [Implement Cell.FormulaLocal similar to Excel VBA Range.FormulaLocal](#ImplementCell.FormulaLocalsimilartoExcelVBARange.FormulaLocal-ImplementCell.FormulaLocalsimilartoExcelVBARange.FormulaLocal)
*   3 [Sample Code](#ImplementCell.FormulaLocalsimilartoExcelVBARange.FormulaLocal-SampleCode)
*   4 [Console Output](#ImplementCell.FormulaLocalsimilartoExcelVBARange.FormulaLocal-ConsoleOutput)

 

## Possible Usage Scenarios

Microsoft Excel Formulas may have different names in different locales or regions or languages. For example, **SUM **function is called **SUMME **in German. Aspose.Cells cannot work with non-English function names. In Microsoft Excel VBA, there is **Range.FormulaLocal** property that returns the name of the function as per its language or region. Aspose.Cells also provides [Cell.FormulaLocal](https://apireference.aspose.com/net/cells/aspose.cells/cell/properties/formulalocal) property for this purpose. However, this property will only work when you will implement [GlobalizationSettings.GetLocalFunctionName(string standardName)](https://apireference.aspose.com/net/cells/aspose.cells/globalizationsettings/methods/getlocalfunctionname) method. 

## Implement Cell.FormulaLocal similar to Excel VBA Range.FormulaLocal

The following sample code explains how to implement [GlobalizationSettings.GetLocalFunctionName(string standardName)](https://apireference.aspose.com/net/cells/aspose.cells/globalizationsettings/methods/getlocalfunctionname) method. The method returns the local name of the standard function. If the standard function name is **SUM**, it returns **UserFormulaLocal\_SUM**. You can change the code as per your needs and return the correct local function names e.g. **SUM **is **SUMME **in German and **TEXT** is **ТЕКСТ **in Russian. Please also see the console output of the sample code given below for a reference.

## Sample Code

## Console Output

Formula Local: =UserFormulaLocal\_SUM(A1:A2)Formula Local: =UserFormulaLocal\_AVERAGE(B1:B2,B5)
