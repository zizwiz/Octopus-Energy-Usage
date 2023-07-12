using System;
using System.Drawing;
using System.IO;
using System.Reflection;
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

            cmbobx_regions.SelectedIndex = 0;
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
            if (TabControl1.SelectedTab.Name == "tab_energy_usage_data_input")
            {
                GetEnergyUsed();
            }
            else if (TabControl1.SelectedTab.Name == "tab_tariff_info")
            {
                GetTariffInformation();
            }
        }


        private void GetTariffInformation()
        {
            ProductRootobject myProductDeserializeData =
                Utilities.GetTariffInfo(new Uri("https://api.octopus.energy/v1/products/"));

            cmbobx_tariff_name.Items.Clear();

            for (int i = 0; i < myProductDeserializeData.count; i++)
            {
                cmbobx_tariff_name.Items.Add(myProductDeserializeData.results[i].full_name);
            }

            cmbobx_tariff_name.SelectedIndex = 0;
        }

        private void cmbobx_tariff_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductRootobject myProductDeserializeData =
                Utilities.GetTariffInfo(new Uri("https://api.octopus.energy/v1/products/"));

            int index = cmbobx_tariff_name.SelectedIndex;
            rchtxtbx_tariff_info.Clear();
            rchtxtbx_tariff_info.AppendText("Code = " + myProductDeserializeData.results[index].code +"\r");
            rchtxtbx_tariff_info.AppendText("Direction = " + myProductDeserializeData.results[index].direction + "\r");
            rchtxtbx_tariff_info.AppendText("Full Name = " + myProductDeserializeData.results[index].full_name + "\r");
            rchtxtbx_tariff_info.AppendText("Display Name = " + myProductDeserializeData.results[index].display_name + "\r");
            rchtxtbx_tariff_info.AppendText("Description = " + myProductDeserializeData.results[index].description + "\r");
            rchtxtbx_tariff_info.AppendText("Is Tariff Variable? = " + myProductDeserializeData.results[index].is_variable + "\r");
            rchtxtbx_tariff_info.AppendText("Is Tariff Green? = " + myProductDeserializeData.results[index].is_green + "\r");
            rchtxtbx_tariff_info.AppendText("Is Tariff Tracker? = " + myProductDeserializeData.results[index].is_tracker + "\r");
            rchtxtbx_tariff_info.AppendText("Is Tariff Prepay? = " + myProductDeserializeData.results[index].is_prepay + "\r");
            rchtxtbx_tariff_info.AppendText("Can Tariff be used for Business? = " + myProductDeserializeData.results[index].is_business + "\r");
            rchtxtbx_tariff_info.AppendText("Is Tariff Restricted = " + myProductDeserializeData.results[index].is_restricted + "\r");
            rchtxtbx_tariff_info.AppendText("Term = " + myProductDeserializeData.results[index].term + "\r");
            rchtxtbx_tariff_info.AppendText("Available From = " + myProductDeserializeData.results[index].available_from + "\r");
            rchtxtbx_tariff_info.AppendText("Available To = " + myProductDeserializeData.results[index].available_to + "\r");
            rchtxtbx_tariff_info.AppendText("Company Selling Tariff = " + myProductDeserializeData.results[index].brand + "\r");



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
            txtbx_api_key.Text = "sk_live_Be2iCvLvPpt2FBhzxwrVjh8J";
            txtbx_electric_serial_num.Text = "22E5055634";
            txtbx_electric_import_mpan.Text = "1012799766349";
            txtbx_electric_export_mpan.Text = "1050002706893";
            txtbx_gas_serial_num.Text = "E6E05522812221";
            txtbx_gas_mprn.Text = "3083198305";
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
            btn_getinfo.Visible = false;
            btn_fill_data.Visible = false;

            if ((TabControl1.SelectedTab.Name == "tab_electric_import" && File.Exists("ElectricityImported.json")) ||
                   (TabControl1.SelectedTab.Name == "tab_electric_export" && File.Exists("ElectricityExported.json")) ||
                      (TabControl1.SelectedTab.Name == "tab_gas_import" && File.Exists("GasImported.json")))
            {
                btn_save_chart.Visible = true;
                btn_save_data.Visible = true;
            }
            else if (TabControl1.SelectedTab.Name == "tab_combined_electricity"
                     &&
                     (File.Exists("ElectricityImported.json") &&
                      File.Exists("ElectricityExported.json")))

            {
                btn_save_chart.Visible = true;
            }

            if (TabControl1.SelectedTab.Name == "tab_data_input")
            {
                btn_getinfo.Visible = true;
                btn_fill_data.Visible = true;
            }
            else if (TabControl1.SelectedTab.Name == "tab_tariff_info")
            {
                btn_getinfo.Visible = true;
            }
        }


        private void btn_save_info_Click(object sender, EventArgs e)
        {
            string dataFile = "";
            EnergyUsageRootobject myOctopusDeserializeData = new EnergyUsageRootobject(); //Just Initialise

            if (TabControl1.SelectedTab.Name == "tab_electric_import") { dataFile = "ElectricityImported.json"; }
            else if (TabControl1.SelectedTab.Name == "tab_electric_export") { dataFile = "ElectricityExported.json"; }
            else if (TabControl1.SelectedTab.Name == "tab_gas_import") { dataFile = "GasImported.json"; }

            // deserialize json data
            myOctopusDeserializeData =
                JsonConvert.DeserializeObject<EnergyUsageRootobject>(Utilities.LoadJson(dataFile));

            Utilities.SaveData(TabControl1, myOctopusDeserializeData);
        }

        
    }
}