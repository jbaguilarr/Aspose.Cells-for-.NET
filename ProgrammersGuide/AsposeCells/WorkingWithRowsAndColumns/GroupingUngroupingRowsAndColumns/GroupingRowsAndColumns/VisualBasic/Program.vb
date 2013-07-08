'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Cells. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace GroupingRowsAndColumns
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Creating a file stream containing the Excel file to be opened
			Dim fstream As New FileStream(dataDir & "book1.xls", FileMode.Open)

			'Instantiating a Workbook object
			'Opening the Excel file through the file stream
			Dim workbook As New Workbook(fstream)

			'Accessing the first worksheet in the Excel file
			Dim worksheet As Worksheet = workbook.Worksheets(0)

			'Grouping first six rows (from 0 to 5) and making them hidden by passing true
			worksheet.Cells.GroupRows(0, 5, True)

			'Grouping first three columns (from 0 to 2) and making them hidden by passing true
			worksheet.Cells.GroupColumns(0, 2, True)

			'Saving the modified Excel file
			workbook.Save(dataDir & "output.xls")

			'Closing the file stream to free all resources
			fstream.Close()


		End Sub
	End Class
End Namespace