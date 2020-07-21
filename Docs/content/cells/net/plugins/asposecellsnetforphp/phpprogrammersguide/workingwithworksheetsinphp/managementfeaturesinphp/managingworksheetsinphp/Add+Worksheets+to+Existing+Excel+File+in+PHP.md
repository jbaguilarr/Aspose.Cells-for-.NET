+++
title = "Add Worksheets to Existing Excel File in PHP" 
description = "" 
weight = 28909 
+++

Aspose.Cells for .NET : Add Worksheets to Existing Excel File in PHP  

# Aspose.Cells for .NET : Add Worksheets to Existing Excel File in PHP


Add Worksheets to Existing Excel File

Add Worksheets to Existing Excel File

**PHP Code**

        $dataDir = '';        // Create Aspose.Cells Helper Object        $ptr = new \\COM('Aspose.Cells.Interop.InteropHelper');        // Opening through Path        // Creating a Workbook object and opening an Excel file using its file path        $workbook = $ptr->New("Aspose.Cells.Workbook",array($dataDir . '/book1.xls'));        $worksheets = $ptr->Get($workbook,"Worksheets",array());        $worksheet\_index = $ptr->Call($worksheets,"Add\_2",array());        $worksheet = $ptr->Get($worksheets,"Item",array($worksheet\_index));        $ptr->Set($worksheet,"Name","My Worksheet",array());        $ptr->Call($workbook,"Save",array($dataDir."/output.xls"));        print "Completed." . PHP\_EOL;

## Download Running Code

Download **Add Worksheets to Existing Excel File (Aspose.Cells)** from any of the below mentioned social coding sites:

*   [GitHub](https://github.com/aspose-cells/Aspose.Cells-for-.NET/blob/master/Plugins/Aspose_Cells_NET_for_PHP/src/aspose/cells/WorkingWithWorksheets/ManagementFeatures/ManagingWorksheets/AddWorksheetsToExistingExcelFile.php)
