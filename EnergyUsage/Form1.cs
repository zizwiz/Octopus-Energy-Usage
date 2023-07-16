using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using EnergyUsage.Properties;
using help_about;
using Newtonsoft.Json;


namespace EnergyUsage
{
    public partial class Form1 : Form
    {
        private Settings settings = Settings.Default;
        private ProductRootobject myProductDeserializeData = new ProductRootobject();
        private StandingChargeRootobject myStandingChargeDeserializedData = new StandingChargeRootobject();

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
            rdobtn_electricity_import.Checked = settings.Electricity;
            rdobtn_gas.Checked = settings.Gas;

            dtPicker_date_from.Value = settings.Date_from;
            cmbobx_hour_from.Text = settings.Hour_from;
            cmbobx_minute_from.Text = settings.Minutes_from;

            dtPicker_date_to.Value = settings.Date_to;
            cmbobx_hour_to.Text = settings.Hour_to;
            cmbobx_minute_to.Text = settings.Minutes_to;

            rdobtn_single_rate.Checked = settings.single_rate;
            rdobtn_dual_rate.Checked = settings.dual_rate;
            chckbx_export_electric.Checked = settings.export_electric;
            chckbx_use_gas.Checked = settings.use_gas;
            

            //remove all chart legends
            chart_electric_import.Legends.Clear();
            chart_electric_export.Legends.Clear();
            chart_gas_import.Legends.Clear();

            //make some items invisible 
            picbx_regions.Visible = false;
            lbl_choose_tariff.Visible = false;
            cmbobx_tariff_name.Visible = false;
            rchtxtbx_tariff_info.Visible = false;
            grpbx_tariff.Visible = false;
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
                PopulateTariffInformation();
            }
        }


        private void PopulateTariffInformation()
        {
            myProductDeserializeData =
                Utilities.GetProducts(new Uri("https://api.octopus.energy/v1/products/"));

            cmbobx_tariff_name.Items.Clear();

            for (int i = 0; i < myProductDeserializeData.count; i++)
            {
                cmbobx_tariff_name.Items.Add(myProductDeserializeData.results[i].full_name);
            }

            //Set to last used items
            cmbobx_tariff_name.SelectedIndex = settings.tariff_name;
            cmbobx_regions.SelectedIndex = settings.region;

            //show all items on UI
            picbx_regions.Visible = true;
            lbl_choose_tariff.Visible = true;
            cmbobx_tariff_name.Visible = true;
            rchtxtbx_tariff_info.Visible = true;
            grpbx_tariff.Visible = true;
        }

        private void cmbobx_tariff_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetTariffs();
            settings.tariff_name = cmbobx_tariff_name.SelectedIndex;
        }


        private void cmbobx_regions_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetTariffs();
            settings.region = cmbobx_regions.SelectedIndex;
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

            settings.Electricity = rdobtn_electricity_import.Checked;
            settings.Gas = rdobtn_gas.Checked;

            settings.Date_from = dtPicker_date_from.Value;
            settings.Hour_from = cmbobx_hour_from.Text;
            settings.Minutes_from = cmbobx_minute_from.Text;

            settings.Date_to = dtPicker_date_to.Value;
            settings.Hour_to = cmbobx_hour_to.Text;
            settings.Minutes_to = cmbobx_minute_to.Text;

            settings.single_rate = rdobtn_single_rate.Checked;
            settings.dual_rate = rdobtn_dual_rate.Checked;
            settings.export_electric = chckbx_export_electric.Checked;
            settings.use_gas = chckbx_use_gas.Checked;
            

            settings.Save();
        }

        private void btn_fill_data_Click(object sender, EventArgs e)
        {
            //Add your info here and remove FillData()
            //txtbx_api_key.Text = "";
            //txtbx_electric_serial_num.Text = "";
            //txtbx_electric_import_mpan.Text = "";
            //txtbx_electric_export_mpan.Text = "";
            //txtbx_gas_serial_num.Text = "";
            //txtbx_gas_mprn.Text = "";

            FillData();
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

            if (TabControl1.SelectedTab.Name == "tab_energy_usage_data_input")
            {
                btn_getinfo.Visible = true;
                btn_fill_data.Visible = true;
            }
            else if (TabControl1.SelectedTab.Name == "tab_tariff_info")
            {
                btn_getinfo.Visible = true;
                btn_fill_data.Visible = false;
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