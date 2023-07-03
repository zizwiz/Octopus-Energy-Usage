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
            txtbx_electric_import_mpan.Text = settings.Import_MPAN;
            txtbx_electric_export_mpan.Text = settings.Export_MPAN;
            txtbx_gas_mprn.Text = settings.MPRN;
            rdobtn_electricity_import.Checked = settings.Electrcity;
            rdobtn_gas.Checked = settings.Gas;

            dtPicker_date_from.Value = settings.Date_from;
            cmbobx_hour_from.Text = settings.Hour_from;
            cmbobx_minute_from.Text = settings.Minutes_from;

            dtPicker_date_to.Value = settings.Date_to;
            cmbobx_hour_to.Text = settings.Hour_to;
            cmbobx_minute_to.Text = settings.Minutes_to;

            //remove all chart legends
            chart_electric_import.Legends.Clear();
            chart_electric_export.Legends.Clear();
            chart_gas_import.Legends.Clear();

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


        double totalElectricImported;
        double totalElectricExported;
        double totalGasConsumed;

        private void btn_getinfo_Click(object sender, EventArgs e)
        {

            double totalElectricNet;
            Uri uri = new Uri("https://p.com");                     //Just a placeholder not real URI
            Series seriesGas = new Series();                        //Just Initialise
            Series seriesImportElectric = new Series();             //Just Initialise
            Series seriesCombinedElectric = new Series();           //Just Initialise
            Series seriesExportElectric = new Series();             //Just Initialise
            Rootobject myOctopusDeserializeData = new Rootobject(); //Just Initialise 


            string dt_From = dtPicker_date_from.Text + "T" + cmbobx_hour_from.Text + ":" + cmbobx_minute_from.Text + "Z";
            string dt_To = dtPicker_date_to.Text + "T" + cmbobx_hour_to.Text + ":" + cmbobx_minute_to.Text + "Z";


            if (rdobtn_electricity_import.Checked)
            {
                seriesImportElectric = Utilities.CreateCharts(chart_electric_import, chart_electric_import.Series.Add(""), Color.Red, chkbx_Imported_Electric_lineChart.Checked);
                seriesCombinedElectric = Utilities.CreateCharts(chart_electric_combined, chart_electric_combined.Series.Add(""), Color.Red, chkbx_Combined_Electric_lineChart.Checked);

                uri = new Uri(
                    "https://api.octopus.energy/v1/electricity-meter-points/" + txtbx_electric_import_mpan.Text + "/meters/" + txtbx_electric_serial_num.Text + "/consumption/?page_size=100&period_from=" + dt_From + "&period_to=" + dt_To + "&order_by=period");

            }
            else if (rdobtn_electricity_export.Checked)
            {
                seriesExportElectric = Utilities.CreateCharts(chart_electric_export, chart_electric_export.Series.Add(""), Color.Green, chkbx_Exported_Electric_lineChart.Checked);
                seriesCombinedElectric = Utilities.CreateCharts(chart_electric_combined, chart_electric_combined.Series.Add(""), Color.Green, chkbx_Combined_Electric_lineChart.Checked);

                uri = new Uri(
                    "https://api.octopus.energy/v1/electricity-meter-points/" + txtbx_electric_export_mpan.Text + "/meters/" + txtbx_electric_serial_num.Text + "/consumption/?page_size=100&period_from=" + dt_From + "&period_to=" + dt_To + "&order_by=period");

            }
            else if (rdobtn_gas.Checked)
            {
                seriesGas = Utilities.CreateCharts(chart_gas_import, chart_gas_import.Series.Add(""), Color.Blue, chkbx_Gas_lineChart.Checked);

                uri = new Uri(
                    "https://api.octopus.energy/v1/gas-meter-points/" + txtbx_gas_mprn.Text + "/meters/" + txtbx_gas_serial_num.Text + "/consumption/?page_size=100&period_from=" + dt_From + "&period_to=" + dt_To + "&order_by=period");
            }

            var request = WebRequest.Create(uri);

            request.Headers["Authorization"] =
                "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes(txtbx_api_key.Text + ":"));

            //  StreamReader myStream = new StreamReader(request.GetResponse().GetResponseStream()).ReadToEnd().ToString()); 

            myOctopusDeserializeData =
                JsonConvert.DeserializeObject<Rootobject>(
                    new StreamReader(request.GetResponse().GetResponseStream()).ReadToEnd());

            // Multipages

            //if (myOctopusDeserializeData.count > 100)
            //{
            //    MessageBox.Show("Number = " + myOctopusDeserializeData.count + "\r" + myOctopusDeserializeData.next);
            //    rchtxtbx_data.AppendText(myOctopusDeserializeData.next + "\r");


            //    using (Stream s = File.Create("abc.json"))
            //    {
            //        myStream.CopyTo(s);
            //    }
            //}




            rchtxtbx_data.AppendText(myOctopusDeserializeData.count + "\r");

            for (int i = 0; i < myOctopusDeserializeData.count; i++)
            // for (int i = 0; i < 100; i++)
            {
                rchtxtbx_data.AppendText(myOctopusDeserializeData.results[i].interval_end + " : " +
                                         myOctopusDeserializeData.results[i].consumption + "\r");

                //add data to chart
                if (rdobtn_electricity_import.Checked)
                {
                    totalElectricImported += myOctopusDeserializeData.results[i].consumption;

                    seriesImportElectric.Points.AddXY(myOctopusDeserializeData.results[i].interval_end,
                         myOctopusDeserializeData.results[i].consumption);

                    seriesCombinedElectric.Points.AddXY(myOctopusDeserializeData.results[i].interval_end,
                        myOctopusDeserializeData.results[i].consumption);

                }
                else if (rdobtn_electricity_export.Checked)
                {
                    totalElectricExported += myOctopusDeserializeData.results[i].consumption;

                    seriesExportElectric.Points.AddXY(myOctopusDeserializeData.results[i].interval_end,
                        myOctopusDeserializeData.results[i].consumption);

                    seriesCombinedElectric.Points.AddXY(myOctopusDeserializeData.results[i].interval_end,
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
            if (rdobtn_electricity_import.Checked)
            {
                rchtxtbx_data.AppendText("Total Electric Imported = " + totalElectricImported + " kwh\r");
                lbl_electricity_imported.Text = totalElectricImported.ToString();
                totalElectricImported = 0;
            }
            else if (rdobtn_electricity_export.Checked)
            {
                rchtxtbx_data.AppendText("Total Electric Exported = " + totalElectricExported + " kwh\r");
                lbl_electricity_exported.Text = totalElectricExported.ToString();
                totalElectricExported = 0;
            }
            else if (rdobtn_gas.Checked)
            {
                rchtxtbx_data.AppendText("Total Gas Consumed = " + totalGasConsumed + " kwh\r");
                lbl_gas_usage.Text = "Gas = " + totalGasConsumed + " kwh";
                totalGasConsumed = 0;
            }

            totalElectricNet = double.Parse(lbl_electricity_exported.Text) - double.Parse(lbl_electricity_imported.Text);
            lbl_electricity_net.Text = "Electricity Sold = " + totalElectricNet + "kwh";

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save all the settings so they are used again next time
            settings.API_Key = txtbx_api_key.Text;
            settings.Electric_meter_ser_num = txtbx_electric_serial_num.Text;
            settings.Gas_meter_ser_num = txtbx_gas_serial_num.Text;
            settings.Import_MPAN = txtbx_electric_import_mpan.Text;
            settings.Export_MPAN = txtbx_electric_export_mpan.Text;
            settings.MPRN = txtbx_gas_mprn.Text;

            settings.Electrcity = rdobtn_electricity_import.Checked;
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
            Utilities.ChartDataPoints(sender, e, chart_electric_import);
        }

        private void chart_gas_usage_MouseMove(object sender, MouseEventArgs e)
        {
            Utilities.ChartDataPoints(sender, e, chart_gas_import);
        }


        private void chart_electric_export_MouseMove(object sender, MouseEventArgs e)
        {
            Utilities.ChartDataPoints(sender, e, chart_electric_export);
        }

        private void chart_electric_combined_MouseMove(object sender, MouseEventArgs e)
        {
            Utilities.ChartDataPoints(sender, e, chart_electric_combined);
        }

        private void btn_print_chart_Click(object sender, EventArgs e)
        {
            if (TabControl1.SelectedTab.Name == "tab_electric_import")
            {
                Utilities.PrintChart(chart_electric_import);
            }
            else if (TabControl1.SelectedTab.Name == "tab_electric_export")
            {
                Utilities.PrintChart(chart_electric_export);
            }
            else if (TabControl1.SelectedTab.Name == "tab_combined_electricity")
            {
                Utilities.PrintChart(chart_electric_combined);
            }
            else if (TabControl1.SelectedTab.Name == "tab_gas_import")
            {
                Utilities.PrintChart(chart_gas_import);
            }
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
