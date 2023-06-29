using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using EnergyUsage.Properties;
using Newtonsoft.Json;


namespace EnergyUsage
{
    public partial class Form1 : Form
    {
        private Settings settings = Settings.Default;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

            //Fill in data from saved settings
            txtbx_api_key.Text = settings.API_Key;
            txtbx_electric_serial_num.Text = settings.Electric_meter_ser_num;
            txtbx_gas_serial_num.Text = settings.Gas_meter_ser_num;
            txtbx_electric_mpan.Text = settings.MPAN;
            txtbx_gas_mprn.Text = settings.MPRN;
            rdobtn_dual_Fuel.Checked = settings.Dual_fuel;
            rdobtn_electricity.Checked = settings.Electrcity;
            rdobtn_gas.Checked = settings.Gas;

            dtPicker_date_from.Value = settings.Date_from;
            cmbobx_hour_from.Text = settings.Hour_from;
            cmbobx_minute_from.Text = settings.Minutes_from;

            dtPicker_date_to.Value = settings.Date_to;
            cmbobx_hour_to.Text = settings.Hour_to;
            cmbobx_minute_to.Text = settings.Minutes_to;

            //remove all chart legends
            chart_electric_usage.Legends.Clear();
            chart_gas_usage.Legends.Clear();

        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            /*
             * var f1 = new Help_Form();
               f1.ShowDialog();
               GC.Collect();
             */
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_getinfo_Click(object sender, EventArgs e)
        {
            double totalElectricConsumed = 0;
            double totalGasConsumed = 0;
            Uri uri = new Uri("https://p.com");                     //Just a placeholder not real URI
            Series seriesGas = new Series();                        //Just Initialise
            Series seriesElectric = new Series();                   //Just Initialise
            Rootobject myOctopusDeserializeData = new Rootobject(); //Just Initialise 


            string dt_From = dtPicker_date_from.Text + "T" + cmbobx_hour_from.Text + ":" + cmbobx_minute_from.Text + "Z";
            string dt_To = dtPicker_date_to.Text + "T" + cmbobx_hour_to.Text + ":" + cmbobx_minute_to.Text + "Z";


            if (rdobtn_dual_Fuel.Checked)
            {
                //Still to do
            }
            else if (rdobtn_electricity.Checked)
            {
                chart_electric_usage.Series.Clear();// clear the chart
                chart_electric_usage.Legends.Clear(); // We do not need a legend
                chart_electric_usage.ChartAreas[0].AxisX.IsMarginVisible = false;

                seriesElectric = chart_electric_usage.Series.Add("");
                if (chkbx_Electric_lineChart.Checked) seriesElectric.ChartType = SeriesChartType.FastLine; //type of chart
                seriesElectric.Color = Color.Red;

               Utilities.ZoomChart(chart_electric_usage.ChartAreas[seriesElectric.ChartArea]);

                uri = new Uri(
                    "https://api.octopus.energy/v1/electricity-meter-points/" + txtbx_electric_mpan.Text + "/meters/" + txtbx_electric_serial_num.Text + "/consumption/?period_from=" + dt_From + "&period_to=" + dt_To + "&order_by=period");
             
            }
            else if (rdobtn_gas.Checked)
            {
                chart_gas_usage.Series.Clear();// clear the chart
                chart_gas_usage.Legends.Clear(); // We do not need a legend
                chart_gas_usage.ChartAreas[0].AxisX.IsMarginVisible = false;

                seriesGas = chart_gas_usage.Series.Add("");
                if (chkbx_Gas_lineChart.Checked) seriesGas.ChartType = SeriesChartType.FastLine; //type of chart
                seriesGas.Color = Color.Blue;

                Utilities.ZoomChart(chart_gas_usage.ChartAreas[seriesGas.ChartArea]);

                uri = new Uri(
                    "https://api.octopus.energy/v1/gas-meter-points/" + txtbx_gas_mprn.Text + "/meters/" + txtbx_gas_serial_num.Text + "/consumption/?period_from=" + dt_From + "&period_to=" + dt_To + "&order_by=period");
            }


            string userName = txtbx_api_key.Text;
            string userPassword = ""; //not required leave blank.

            var request = WebRequest.Create(uri);
            request.Headers["Authorization"] =
                "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes(userName + ":" + userPassword));


            myOctopusDeserializeData =
                JsonConvert.DeserializeObject<Rootobject>(
                    new StreamReader(request.GetResponse().GetResponseStream()).ReadToEnd());


            rchtxtbx_data.AppendText(myOctopusDeserializeData.count + "\r");

            for (int i = 0; i < myOctopusDeserializeData.count; i++)
            {
                rchtxtbx_data.AppendText(myOctopusDeserializeData.results[i].interval_end + " : " +
                                         myOctopusDeserializeData.results[i].consumption + "\r");


                //add data to chart
                if (rdobtn_dual_Fuel.Checked)
                {

                }
                else if (rdobtn_electricity.Checked)
                {
                    totalElectricConsumed += myOctopusDeserializeData.results[i].consumption;

                    seriesElectric.Points.AddXY(myOctopusDeserializeData.results[i].interval_end,
                        myOctopusDeserializeData.results[i].consumption);
                    
                }
                else if (rdobtn_gas.Checked)
                {
                    totalGasConsumed += myOctopusDeserializeData.results[i].consumption;

                    seriesGas.Points.AddXY(myOctopusDeserializeData.results[i].interval_end,
                         myOctopusDeserializeData.results[i].consumption);
                }


            }

            //add totals to UI
            if (rdobtn_dual_Fuel.Checked)
            {

            }
            else if (rdobtn_electricity.Checked)
            {
                rchtxtbx_data.AppendText("Total Electric Consumed = " + totalElectricConsumed + " kwh\r");

                lbl_electricity_usage.Text = "Electricity = " + totalElectricConsumed + " kwh";

            }
            else if (rdobtn_gas.Checked)
            {
                rchtxtbx_data.AppendText("Total Gas Consumed = " + totalGasConsumed + " kwh\r");
                lbl_gas_usage.Text = "Gas = " + totalGasConsumed + " kwh";
            }
        }

        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save all the settings so they are used again next time
            settings.API_Key = txtbx_api_key.Text;
            settings.Electric_meter_ser_num = txtbx_electric_serial_num.Text;
            settings.Gas_meter_ser_num = txtbx_gas_serial_num.Text;
            settings.MPAN = txtbx_electric_mpan.Text;
            settings.MPRN = txtbx_gas_mprn.Text;

            settings.Dual_fuel = rdobtn_dual_Fuel.Checked;
            settings.Electrcity = rdobtn_electricity.Checked;
            settings.Gas = rdobtn_gas.Checked;

            settings.Date_from = dtPicker_date_from.Value;
            settings.Hour_from = cmbobx_hour_from.Text;
            settings.Minutes_from = cmbobx_minute_from.Text;

            settings.Date_to = dtPicker_date_to.Value;
            settings.Hour_to = cmbobx_hour_to.Text;
            settings.Minutes_to = cmbobx_minute_to.Text;

            settings.Save();
        }

        private void btn_fill_data_Click(object sender, EventArgs e)
        {
            //Add your info here
        }

        private void chart_electric_usage_MouseMove(object sender, MouseEventArgs e)
        {
            Utilities.ChartDataPoints(sender, e, chart_electric_usage);
        }

        private void chart_gas_usage_MouseMove(object sender, MouseEventArgs e)
        {
            Utilities.ChartDataPoints(sender, e, chart_gas_usage);
        }
    }

    /// <summary>
    /// Classes made from the json returned by Octopus.
    /// To make them copy the json file to clipboard.
    /// Goto Edit | Paste Special and paste.
    /// </summary>


    public class Rootobject
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public Result[] results { get; set; }
    }

    public class Result
    {
        public double consumption { get; set; }
        public DateTime interval_start { get; set; }
        public DateTime interval_end { get; set; }
    }






}
