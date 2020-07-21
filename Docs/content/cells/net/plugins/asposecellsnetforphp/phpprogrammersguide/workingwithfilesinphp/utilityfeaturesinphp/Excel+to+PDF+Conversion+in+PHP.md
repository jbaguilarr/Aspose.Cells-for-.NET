+++
title = "Excel to PDF Conversion in PHP" 
description = "" 
weight = 24901 
+++

Aspose.Cells for .NET : Excel to PDF Conversion in PHP  

# Aspose.Cells for .NET : Excel to PDF Conversion in PHP


## Aspose.Cells - Excel to PDF Conversion

Convert Microsoft Excel File to PDF

**PHP Code**

        $dataDir = '';        // Create Aspose.Cells Helper Object        $ptr = new \\COM('Aspose.Cells.Interop.InteropHelper');        // Opening through Path        // Creating a Workbook object and opening an Excel file using its file path        $workbook = $ptr->New("Aspose.Cells.Workbook",array($dataDir . '/Book1.xls'));        $ptr->Call($workbook,"Save",array($dataDir."/outBook1.pdf"));        print "Conversion Completed" . PHP\_EOL;

## Download Running Code

Download **Excel to PDF Conversion (Aspose.Cells)** from any of the below mentioned social coding sites:

*   [GitHub](https://github.com/aspose-cells/Aspose.Cells-for-.NET/blob/master/Plugins/Aspose_Cells_NET_for_PHP/src/aspose/cells/WorkingWithFiles/UtilityFeatures/Excel2PDFConversion.php)
