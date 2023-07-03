using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EnergyUsage
{
    class Utilities
    {
        static Point? prevPosition;
        static ToolTip tooltip = new ToolTip();

        public static void ZoomChart(ChartArea myChartArea)
        {
            myChartArea.AxisX.ScaleView.Zoomable = true;
            myChartArea.CursorX.AutoScroll = true;
            myChartArea.CursorX.IsUserSelectionEnabled = true; //adds reset button on left

            // As we use date and time on the x axis we need to do more work to make scrollable.
            myChartArea.CursorX.Interval = 0.001D;
            myChartArea.AxisX.ScaleView.SmallScrollSizeType = DateTimeIntervalType.Minutes;
            myChartArea.AxisX.LabelStyle.Format = "dd/MM@hh:mm";
        }



        public static void ChartDataPoints(object sender, MouseEventArgs e, Chart myChart)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value) return;

            tooltip.RemoveAll();
            prevPosition = pos;

            var results =
                myChart.HitTest(pos.X, pos.Y, false,
                    ChartElementType.DataPoint); // set ChartElementType.PlottingArea for full area, not only DataPoints

            foreach (var result in results)
            {
                if (result.ChartElementType ==
                    ChartElementType.DataPoint) // set ChartElementType.PlottingArea for full area, not only DataPoints
                {
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                    tooltip.Show(((double)yVal).ToString(), myChart, pos.X, pos.Y - 15);
                }
            }
        }

        public static Series CreateCharts(Chart myChart, Series mySeries, Color myColor, bool LineChart)
        {
            if (myChart.Name != "chart_electric_combined")
                myChart.Series.Clear(); // clear the chart if not combined chart
            myChart.Legends.Clear(); // We do not need a legend
            myChart.ChartAreas[0].AxisX.IsMarginVisible = false;

            mySeries = myChart.Series.Add("");
            if (LineChart) mySeries.ChartType = SeriesChartType.FastLine; //type of chart
            mySeries.Color = myColor;

            ZoomChart(myChart.ChartAreas[mySeries.ChartArea]);

            return mySeries;
        }

        public static void PrintChart(Chart myChart)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter =
            "Image Files|*.png|Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff";
            saveFileDialog.Title = "Save Chart Image As file";
            saveFileDialog.DefaultExt = ".png";
            saveFileDialog.FileName = "Sample.png";

            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && saveFileDialog.FileName != "")
            {
                try
                {
                    var imgFormats = new Dictionary<string, ChartImageFormat>()
                {
                    {".bmp", ChartImageFormat.Bmp},
                    {".gif", ChartImageFormat.Gif},
                    {".jpg", ChartImageFormat.Jpeg},
                    {".jpeg", ChartImageFormat.Jpeg},
                    {".png", ChartImageFormat.Png},
                    {".tiff", ChartImageFormat.Tiff},
                };
                    var fileExt = System.IO.Path.GetExtension(saveFileDialog.FileName).ToString().ToLower();
                    if (imgFormats.ContainsKey(fileExt))
                    {
                        myChart.SaveImage(saveFileDialog.FileName, imgFormats[fileExt]);
                    }
                    else
                    {
                        throw new Exception(String.Format("Only image formats '{0}' supported",
                            string.Join(", ", imgFormats.Keys)));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /*
         * Invoke(new Action(() =>
          {


          }));
         */

        /*
         * JObject o1 = JObject.Parse(file);
           JObject o2 = JObject.Parse(file);
           
           o1.Merge(o2)
         */


    }
}
