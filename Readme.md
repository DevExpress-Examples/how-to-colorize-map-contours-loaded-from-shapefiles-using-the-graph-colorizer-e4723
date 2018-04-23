# How to colorize map contours loaded from Shapefiles using the graph colorizer 


<p>This example demonstrates how to paint map contours loaded from Shapefile  (<strong>Countries.shp</strong>) using the graph colorizer. </p><br />



<h3>Description</h3>

<p>To accomplish this task, create a graph colorizer (the <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapGraphColorizertopic">GraphColorizer</a> object) and assign it to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapVectorFileLayer_Colorizertopic">VectorFileLayer.Colorizer</a> property.</p>
<p>And finally, specify the desired set of colors in the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapGenericColorizerItemCollection~T~topic">GenericColorizerItemCollection&lt;ColorizerColorItem&gt;</a> object that is accessed via the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapChoroplethColorizer_ColorItemstopic">MapColorizer.ColorItems</a> property.</p>

<br/>


