+++
title = "Create Pivot Tables and Pivot Charts" 
description = "" 
weight = 20414 
+++

Aspose.Cells for .NET : Create Pivot Tables and Pivot Charts  

# Aspose.Cells for .NET : Create Pivot Tables and Pivot Charts


A pivot table is an interactive summary of records. For example, you may have hundreds of invoice entries in a list in a worksheet. A pivot table can total the invoices by customer, product or date. With Microsoft Excel it is possible to quickly re-arrange the information in the pivot table by dragging buttons to a new position.

A pivot chart is an interactive graphical representation of the data in a pivot table. Pivot charts were introduced in Excel 2000. Using a pivot chart makes it even easier to understand the data since the pivot table creates subtotals and totals automatically.

Aspose.Cells supports [pivot tables](http://localhost:1313/cellsnet/developerguide/technicalarticles/asposecellsgeneral/managingpivottablesandpivotcharts/create+pivot+tables+and+pivot+charts) and [pivot charts](http://localhost:1313/cellsnet/developerguide/technicalarticles/asposecellsgeneral/managingpivottablesandpivotcharts/create+pivot+tables+and+pivot+charts).

**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738104595 {padding: 0px;}div.rbtoc1590738104595 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738104595 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Adding Pivot Tables and Charts](#CreatePivotTablesandPivotCharts-AddingPivotTablesandCharts)
    *   1.1 [Preparing to use Aspose.Cells](#CreatePivotTablesandPivotCharts-PreparingtouseAspose.Cells)
    *   1.2 [Adding a Pivot Table](#CreatePivotTablesandPivotCharts-AddingaPivotTable)
    *   1.3 [Adding a Pivot Chart](#CreatePivotTablesandPivotCharts-AddingaPivotChart)

 

 

## Adding Pivot Tables and Charts

Aspose.Cells provides a special set of classes used to create pivot tables. These classes are used to create and set `PivotTable` objects, which act as a `PivotTable` object's basic building blocks:

*   `PivotField`, a field in a pivot table report.
*   `PivotFields`, a collection of all the `PivotField` objects in a pivot table.
*   `PivotTable`, a `PivotTable` report on a worksheet.
*   `PivotTables`, a collection of all the `PivotTable` objects on the worksheet.

### Preparing to use Aspose.Cells

1.  Download and install Aspose.Cells:
    1.  [Download Aspose.Cells](http://www.aspose.com/community/files/51/.net-components/aspose.cells-for-.net/default.aspx).
    2.  Install it on your development computer.  
        All [Aspose](http://www.aspose.com/) components, when installed, work in evaluation mode. The evaluation mode has no time limit and it only injects watermarks into produced documents. To work with the component in its full capacity you do need to have a valid license.
2.  Create a project:
    1.  Start Visual Studio.Net.
    2.  Create a new console application.
3.  Add references:  
    Add reference to the Aspose.Cells component into your project, for example ...\\Program Files\\Aspose\\Aspose.Cells\\Bin\\Net1.0\\Aspose.Cells.dll

### Adding a Pivot Table

To create a pivot table using Aspose.Cells:

1.  Add some data to a worksheet cells using a `Cell` object's `PutValue`/`setValue` method. You also use a template file already filled with data. The data will be used as the pivot table's data source.
2.  Add a pivot table to the worksheet by calling the `PivotTables` collection's `add` method (encapsulated in the `Worksheet` object).
3.  Access the new `PivotTable` object from the `PivotTables` collection by passing its index. # Use any of the pivot table objects encapsulated in the `PivotTable` object to manage the table.

Code examples are given below.

### Adding a Pivot Chart

To create a PivotChart using Aspose.Cells:

1.  Add a chart.
2.  Set the `PivotSource` of the chart to refer to an existing pivot table in the spreadsheet.
3.  Set other attributes.

## Attachments:

