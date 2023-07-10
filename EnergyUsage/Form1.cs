﻿using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using EnergyUsage.Properties;
using help_about;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


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

            btn_save_chart.Visible = false;
            btn_save_data.Visible = false;

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
            var f1 = new Help_Form();
            f1.ShowDialog();
            GC.Collect();
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
            Uri uri = new Uri("https://p.com"); //Just a placeholder not real URI
            Series seriesGas = new Series(); //Just Initialise
            Series seriesImportElectric = new Series(); //Just Initialise
            Series seriesCombinedElectric = new Series(); //Just Initialise
            Series seriesExportElectric = new Series(); //Just Initialise
            Rootobject myOctopusDeserializeData = new Rootobject(); //Just Initialise 
            string path = "Data";
            int count = 1;
            int amountData = 0;


            string dt_From = dtPicker_date_from.Text + "T" + cmbobx_hour_from.Text + ":" + cmbobx_minute_from.Text +
                             "Z";
            string dt_To = dtPicker_date_to.Text + "T" + cmbobx_hour_to.Text + ":" + cmbobx_minute_to.Text + "Z";


            if (rdobtn_electricity_import.Checked)
            {
                seriesImportElectric = Utilities.CreateCharts(chart_electric_import,
                    chart_electric_import.Series.Add(""), Color.Red, chkbx_Imported_Electric_lineChart.Checked);
                seriesCombinedElectric = Utilities.CreateCharts(chart_electric_combined,
                    chart_electric_combined.Series.Add(""), Color.Red, chkbx_Combined_Electric_lineChart.Checked);

                uri = new Uri(
                    "https://api.octopus.energy/v1/electricity-meter-points/" + txtbx_electric_import_mpan.Text +
                    "/meters/" + txtbx_electric_serial_num.Text + "/consumption/?page_size=100&period_from=" + dt_From +
                    "&period_to=" + dt_To + "&order_by=period");

            }
            else if (rdobtn_electricity_export.Checked)
            {
                seriesExportElectric = Utilities.CreateCharts(chart_electric_export,
                    chart_electric_export.Series.Add(""), Color.Green, chkbx_Exported_Electric_lineChart.Checked);
                seriesCombinedElectric = Utilities.CreateCharts(chart_electric_combined,
                    chart_electric_combined.Series.Add(""), Color.Green, chkbx_Combined_Electric_lineChart.Checked);

                uri = new Uri(
                    "https://api.octopus.energy/v1/electricity-meter-points/" + txtbx_electric_export_mpan.Text +
                    "/meters/" + txtbx_electric_serial_num.Text + "/consumption/?page_size=100&period_from=" + dt_From +
                    "&period_to=" + dt_To + "&order_by=period");

            }
            else if (rdobtn_gas.Checked)
            {
                seriesGas = Utilities.CreateCharts(chart_gas_import, chart_gas_import.Series.Add(""), Color.Blue,
                    chkbx_Gas_lineChart.Checked);

                uri = new Uri(
                    "https://api.octopus.energy/v1/gas-meter-points/" + txtbx_gas_mprn.Text + "/meters/" +
                    txtbx_gas_serial_num.Text + "/consumption/?page_size=100&period_from=" + dt_From + "&period_to=" +
                    dt_To + "&order_by=period");
            }

            //get the first chunk of data
            myOctopusDeserializeData = Utilities.GetData(uri, txtbx_api_key.Text);

            //if we have multiple pages then we need to use this section. multiple sections will have the count>100
            amountData = myOctopusDeserializeData.count;

            string myPath = "Data_1.json";

            if (amountData > 100)
            {
                File.WriteAllText(myPath, JsonConvert.SerializeObject(myOctopusDeserializeData));

                do
                {
                    count++;
                    myOctopusDeserializeData =
                        Utilities.GetData(new Uri(myOctopusDeserializeData.next), txtbx_api_key.Text);

                    path = path + "_" + count + ".json";

                    // write data to json file so we can merge the files to make one big file
                    File.WriteAllText(path, JsonConvert.SerializeObject(myOctopusDeserializeData));

                    if (count > 1)
                    {

                        JObject o1 = JObject.Parse(Utilities.LoadJson(myPath));
                        JObject o2 = JObject.Parse(Utilities.LoadJson(path));

                        // Add the new results to the original file
                        foreach (JObject o in o2["results"])
                            ((JArray)o1["results"]).Add(o);

                        if (File.Exists(myPath)) File.Delete(myPath); //If it exists delete it
                        File.WriteAllText(myPath, o1.ToString()); //Write the new file
                    }

                    path = path.Substring(0, path.IndexOf("_")); //reset path
                    amountData -= 100; //remove one page worth of data

                } while (amountData > 100);


                // deserialize json data
                myOctopusDeserializeData =
                    JsonConvert.DeserializeObject<Rootobject>(Utilities.LoadJson(myPath));

            }

            rchtxtbx_data.AppendText(myOctopusDeserializeData.count + "\r");

            for (int i = 0; i < myOctopusDeserializeData.count; i++) //Use once merge is working
                                                                     //  for (int i = 0; i < 100; i++)
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

                    //add totals to UI
                    rchtxtbx_data.AppendText("Total Electric Imported = " + totalElectricImported + " kwh\r");
                    lbl_electricity_imported.Text = totalElectricImported.ToString();
                    totalElectricImported = 0;

                    //copy file to name in case we want to save data from it it later
                    Utilities.CopyFile("ElectricityImported.json", myPath);
                }
                else if (rdobtn_electricity_export.Checked)
                {
                    totalElectricExported += myOctopusDeserializeData.results[i].consumption;

                    seriesExportElectric.Points.AddXY(myOctopusDeserializeData.results[i].interval_end,
                        myOctopusDeserializeData.results[i].consumption);

                    seriesCombinedElectric.Points.AddXY(myOctopusDeserializeData.results[i].interval_end,
                        myOctopusDeserializeData.results[i].consumption);

                    //add totals to UI
                    rchtxtbx_data.AppendText("Total Electric Exported = " + totalElectricExported + " kwh\r");
                    lbl_electricity_exported.Text = totalElectricExported.ToString();
                    totalElectricExported = 0;

                    //copy file to name in case we want to save data from it it later
                    Utilities.CopyFile("ElectricityExported.json", myPath);

                }
                else if (rdobtn_gas.Checked)
                {
                    totalGasConsumed += myOctopusDeserializeData.results[i].consumption;

                    seriesGas.Points.AddXY(myOctopusDeserializeData.results[i].interval_end,
                        myOctopusDeserializeData.results[i].consumption);

                    //add totals to UI
                    rchtxtbx_data.AppendText("Total Gas Consumed = " + totalGasConsumed + " kwh\r");
                    lbl_gas_usage.Text = "Gas = " + totalGasConsumed + " kwh";
                    totalGasConsumed = 0;

                    //copy file to name in case we want to save data from it it later
                    Utilities.CopyFile("GasImported.json", myPath);
                }
            }

            totalElectricNet = double.Parse(lbl_electricity_exported.Text) -
                               double.Parse(lbl_electricity_imported.Text);
            lbl_electricity_net.Text = "Electricity Sold = " + totalElectricNet + "kwh";

            //show the button to allow for saving of data
            buttonControl();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Delete files
            if (File.Exists("ElectricityImported.json")) File.Delete("ElectricityImported.json");
            if (File.Exists("ElectricityExported.json")) File.Delete("ElectricityExported.json");
            if (File.Exists("GasImported.json")) File.Delete("GasImported.json");

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

        private void btn_save_chart_Click(object sender, EventArgs e)
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

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonControl();
        }

        private void buttonControl()
        {
            //only becomes true when you have the data and correct tab
            btn_save_chart.Visible = false;
            btn_save_data.Visible = false;

            if ((TabControl1.SelectedTab.Name == "tab_electric_import" && File.Exists("ElectricityImported.json")) ||
                   (TabControl1.SelectedTab.Name == "tab_electric_export" && File.Exists("ElectricityExported.json")) ||
                      (TabControl1.SelectedTab.Name == "tab_gas_import" && File.Exists("GasImported.json")))
            {
                btn_save_chart.Visible = true;
                btn_save_data.Visible = true;
            }
            else if (TabControl1.SelectedTab.Name == "tab_combined_electricity"
                     &&
                     (File.Exists("ElectricityImported.json") ||
                      File.Exists("ElectricityExported.json")))

            {
                btn_save_chart.Visible = true;
            }
        }


        private void btn_save_info_Click(object sender, EventArgs e)
        {
            Utilities.SaveData();
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





