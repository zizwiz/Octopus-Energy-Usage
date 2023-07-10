using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json;

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
            myChartArea.AxisX.Enabled = AxisEnabled.True;
            myChartArea.AxisX.LabelStyle.Enabled = true;


            // As we use date and time on the x axis we need to do more work to make scrollable.
            myChartArea.CursorX.Interval = 0.001D;
            myChartArea.AxisX.ScaleView.SmallScrollSizeType = DateTimeIntervalType.Minutes;
            myChartArea.AxisX.LabelStyle.Format = "dd/MM@HH:mm";
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


        public static void SaveFileStream(String path, Stream stream)
        {
            var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
            stream.CopyTo(fileStream);
            fileStream.Dispose();
        }


        public static string LoadJson(string myFile)
        {
            using (StreamReader r = new StreamReader(myFile))
            {
                //Reads file into a long string
                return r.ReadToEnd();
            }
        }

        public static Rootobject GetData(Uri myURI, string myApiKey)
        {
            Rootobject myOctopusDeserializeData = new Rootobject();
            var request = WebRequest.Create(myURI);

            request.Headers["Authorization"] =
                "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes(myApiKey + ":"));


            return myOctopusDeserializeData =
                 JsonConvert.DeserializeObject<Rootobject>(
                     new StreamReader(request.GetResponse().GetResponseStream()).ReadToEnd());
        }



        public static void SaveData()
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                InitialDirectory = Application.StartupPath, 
                Title = "Save Text Files",
                CheckPathExists = true,
                DefaultExt = "CSV",
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, "your data here...");
            }

        }

        public static void CopyFile(string myFile, string myPath)
        {
            if (File.Exists(myFile)) File.Delete(myFile);
            File.Copy(myPath, myFile);
        }

        /*
         * Invoke(new Action(() =>
          {


          }));
         */
        }
}
