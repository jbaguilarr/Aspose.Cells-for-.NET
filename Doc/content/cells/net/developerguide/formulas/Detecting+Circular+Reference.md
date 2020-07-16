+++
title = "Detecting Circular Reference" 
description = "" 
weight = 12227 
+++

Aspose.Cells for .NET : Detecting Circular Reference  

# Aspose.Cells for .NET : Detecting Circular Reference


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738047591 {padding: 0px;}div.rbtoc1590738047591 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738047591 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Introduction](#DetectingCircularReference-Introduction)
*   2 [Concept behind detecting the circular reference](#DetectingCircularReference-Conceptbehinddetectingthecircularreference)

 

## Introduction

Workbooks can have circular references and sometimes there is a need to detect if circular references are there or not.

## Concept behind detecting the circular reference

Circular references can only be detected when the formula is calculated because the references of one formula commonly depend on the calculated result of other parts or other formulas. So we provide new APIs for this requirement(to gather cells with circular references) in the process of formula calculation:

[CalculationCell](https://apireference.aspose.com/net/cells/aspose.cells/calculationcell): Represents the calculation of relevant data about one cell being calculated

[AbstractCalculationMonitor.OnCircular(IEnumerator circularCellsData)](https://apireference.aspose.com/net/cells/aspose.cells/abstractcalculationmonitor/methods/oncircular): will be invoked by formula calculation engine when encounter circular references, the element in the enumerator is [CalculationCell](https://apireference.aspose.com/net/cells/aspose.cells/calculationcell) objects which represent all cells in one circle. The returned value denotes whether the formula engine needs to calculate those cells in circular after this call.

User may gather those circular references in the implementation of [AbstractCalculationMonitor.OnCircular()](https://apireference.aspose.com/net/cells/aspose.cells/abstractcalculationmonitor/methods/oncircular) method.

The source sample file can be downloaded from the following link:


Definition of *CircularMonitor* class which is derived from [AbstractCalculationMonitor](https://apireference.aspose.com/net/cells/aspose.cells/abstractcalculationmonitor) class is as follows:

## Attachments:


