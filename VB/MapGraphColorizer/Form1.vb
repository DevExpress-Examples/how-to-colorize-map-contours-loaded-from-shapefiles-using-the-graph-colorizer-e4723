Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.XtraMap

Namespace MapGraphColorizer
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

			' Create a map control and specify its dock style.
			Dim map As New MapControl()
			map.Dock = DockStyle.Fill

			' Specify the map's initial view.  
			map.ZoomLevel = 2
			map.CenterPoint = New GeoPoint(38, -100)

			' Create a file layer and assign a shape loader to it.
			Dim fileLayer As New VectorFileLayer()
			map.Layers.Add(fileLayer)
			fileLayer.FileLoader = CreateShapefileLoader()

			' Create a colorizer.
			fileLayer.Colorizer = CreateGraphColorizer()

			' Add the map control to the window. 
			Me.Controls.Add(map)
		End Sub

		Private Function CreateShapefileLoader() As ShapefileLoader
			' Create an object to load data from a shapefile.
			Dim loader As New ShapefileLoader()

			' Determine the path to the Shapefile.
			Dim baseUri As New Uri(System.Reflection.Assembly.GetEntryAssembly().Location)
			Dim shapefilePath As String = "../../Data/Countries.shp"
			loader.FileUri = New Uri(baseUri, shapefilePath)

			Return loader
		End Function

		Private Function CreateGraphColorizer() As GraphColorizer
			' Create a graph colorizer.
			Dim colorizer As New GraphColorizer()

			' Specify colors for the colorizer.
			colorizer.Colors.AddRange(New List(Of Color) (New Color() {Color.FromArgb(&HF1, &HC1, &H49), Color.FromArgb(&HE5, &HA8, &H4D), Color.FromArgb(&HC5, &H64, &H50), Color.FromArgb(&HD6, &H86, &H4E), Color.FromArgb(&H79, &H96, &H89), Color.FromArgb(&HA2, &HA8, &H75)}))
			Return colorizer
		End Function
	End Class
End Namespace
