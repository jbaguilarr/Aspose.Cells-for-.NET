+++
title = "Manipulate Position Size and Designer Chart" 
description = "" 
weight = 12265 
+++

Aspose.Cells for .NET : Manipulate Position Size and Designer Chart  

# Aspose.Cells for .NET : Manipulate Position Size and Designer Chart


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738054066 {padding: 0px;}div.rbtoc1590738054066 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738054066 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Chart Position and Size](#ManipulatePositionSizeandDesignerChart-ChartPositionandSize)
    *   1.1 [Controlling Chart Position and Size](#ManipulatePositionSizeandDesignerChart-ControllingChartPositionandSize)
*   2 [Manipulating Designer Charts](#ManipulatePositionSizeandDesignerChart-ManipulatingDesignerCharts)
    *   2.1 [Manipulating Designer Charts in Template Files](#ManipulatePositionSizeandDesignerChart-ManipulatingDesignerChartsinTemplateFiles)
        *   2.1.1 [Creating a Chart](#ManipulatePositionSizeandDesignerChart-CreatingaChart)
        *   2.1.2 [Manipulating the Chart](#ManipulatePositionSizeandDesignerChart-ManipulatingtheChart)
        *   2.1.3 [Manipulating a Line Chart in the Designer Template](#ManipulatePositionSizeandDesignerChart-ManipulatingaLineChartintheDesignerTemplate)

 

## Chart Position and Size

Sometimes, you want to change the position or size of the new or existing chart inside the worksheet. Aspose.Cells provides the [Chart.ChartObject](https://apireference.aspose.com/cells/net/aspose.cells.charts/chart/properties/chartobject) property to achieve this. You can use its sub-properties to re-size the chart with new **height** and **width** or re-position it with new **X** and **Y** coordinates.

### Controlling Chart Position and Size

To change the chart's position (X, Y coordinates) or size (height, width), use these properties:

1.  [Chart.ChartObject.X](https://apireference.aspose.com/cells/net/aspose.cells.drawing/shape/properties/x)
2.  [Chart.ChartObject.Y](https://apireference.aspose.com/cells/net/aspose.cells.drawing/shape/properties/y)
3.  [Chart.ChartObject.Height](https://apireference.aspose.com/cells/net/aspose.cells.drawing/shape/properties/height)
4.  [Chart.ChartObject.Width](https://apireference.aspose.com/cells/net/aspose.cells.drawing/shape/properties/width)

The following example explains the usage of the above APIs, it loads the existing workbook which contains a chart in its first worksheet. Then it re-sizes and re-positions the chart using Aspose.Cells.

## Manipulating Designer Charts

There are times when you need to manipulate or modify charts in designer template files. Aspose.Cells fully supports manipulating designer chart contents and elements. The data, chart contents, background image, and formattings can be preserved with accuracy.

### Manipulating Designer Charts in Template Files

To manipulate designer charts in template files, use the chart related API. For example, you may use the `Worksheet.Charts` property to get the existing charts collection in the template file.

#### Creating a Chart

The following example shows how to create a pie chart. We will manipulate this chart later on.

#### Manipulating the Chart

The following example shows how to manipulate the existing chart. In this example, we modify the chart created above. In the generated output, note that the color of the chart title has changed from blue to black, and 'England 30000' has been changed to 'United Kingdom, 30K'.

#### Manipulating a Line Chart in the Designer Template

In this example, we will manipulate a line chart. We will add some data series to the existing chart and change their line colors.
