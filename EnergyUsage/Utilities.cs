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

            var results = myChart.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint); // set ChartElementType.PlottingArea for full area, not only DataPoints

            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint) // set ChartElementType.PlottingArea for full area, not only DataPoints
                {
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                    tooltip.Show(((double)yVal).ToString(), myChart, pos.X, pos.Y - 15);
                }
            }
        }


        /*
         * Invoke(new Action(() =>
          {
          
          
          }));
         */




    }
}
