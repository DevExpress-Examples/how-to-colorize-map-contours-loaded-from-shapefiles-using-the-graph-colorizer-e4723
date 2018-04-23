using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace MapGraphColorizer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            // Create a map control and specify its dock style.
            MapControl map = new MapControl();
            map.Dock = DockStyle.Fill;

            // Specify the map's initial view.  
            map.ZoomLevel = 2;
            map.CenterPoint = new GeoPoint(38, -100);

            // Create a file layer and assign a shape loader to it.
            VectorFileLayer fileLayer = new VectorFileLayer();
            map.Layers.Add(fileLayer);
            fileLayer.FileLoader = CreateShapefileLoader();

            // Create a colorizer.
            fileLayer.Colorizer = CreateGraphColorizer();

            // Add the map control to the window. 
            this.Controls.Add(map);
        }

        private ShapefileLoader CreateShapefileLoader() {
            // Create an object to load data from a shapefile.
            ShapefileLoader loader = new ShapefileLoader();

            // Determine the path to the Shapefile.
            Uri baseUri = new Uri(System.Reflection.Assembly.GetEntryAssembly().Location);
            string shapefilePath = "../../Data/Countries.shp";
            loader.FileUri = new Uri(baseUri, shapefilePath);

            return loader;
        }

        private GraphColorizer CreateGraphColorizer() {
            // Create a graph colorizer.
            GraphColorizer colorizer = new GraphColorizer();

            // Specify colors for the colorizer.
            colorizer.ColorItems.AddRange(new List<ColorizerColorItem> { 
                new ColorizerColorItem(Color.FromArgb(0xF1, 0xC1, 0x49)), 
                new ColorizerColorItem(Color.FromArgb(0xE5, 0xA8, 0x4D)),
                new ColorizerColorItem(Color.FromArgb(0xC5, 0x64, 0x50)),
                new ColorizerColorItem(Color.FromArgb(0xD6, 0x86, 0x4E)),
                new ColorizerColorItem(Color.FromArgb(0x79, 0x96, 0x89)), 
                new ColorizerColorItem(Color.FromArgb(0xA2, 0xA8, 0x75))
            });
            return colorizer;
        }
    }
}
