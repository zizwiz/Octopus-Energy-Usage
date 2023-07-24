using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EnergyUsage
{
    public partial class Form1
    {

        private void UpdateEnergyCost()
        {
            DateTime startDate = dtPicker_date_from.Value;
            DateTime endDate = dtPicker_date_to.Value;
            double numberOfDays = (endDate - startDate).TotalDays;

            if (rdobtn_electricity_import.Checked)
            {
                double electricityImportedCosts = ((double.Parse(lbl_electricity_imported.Text) *
                                                    double.Parse(txtbx_electricity_unit_cost.Text)) / 100);
                double electricityStandingCharge = (numberOfDays * double.Parse(txtbx_electricity_standing_charge.Text)) / 100;

                lbl_electricity_cost.Text = "£" + Math.Round(electricityImportedCosts,2, MidpointRounding.AwayFromZero).ToString("##0.00") + ((char)0x2009) + "p";
                lbl_electricity_standing_charge.Text = "£" + Math.Round(electricityStandingCharge, 2, MidpointRounding.AwayFromZero).ToString("##0.00") + ((char)0x2009) + "p";
            }
            else if (rdobtn_electricity_export.Checked)
            {
                double electricityExportIncome = ((double.Parse(lbl_electricity_exported.Text) *
                                                   double.Parse(txtbx_electricity_unit_income.Text)) / 100);

                lbl_electricity_export_income.Text = "£" + Math.Round(electricityExportIncome, 2).ToString("##0.00") + ((char) 0x2009) + "p";
            }
            else if (rdobtn_gas.Checked)
            {
                double gasImportedCosts = ((double.Parse(lbl_gas_usage.Text) *
                                            double.Parse(txtbx_gas_unit_cost.Text)) / 100);
                double gasStandingCharge = (numberOfDays * double.Parse(txtbx_gas_standing_charge.Text)) / 100;
                
                lbl_gas_cost.Text = "£" + Math.Round(gasImportedCosts, 2).ToString("##0.00") + ((char) 0x2009) + "p";
                lbl_gas_standing_charge.Text =
                    "£" + Math.Round(gasStandingCharge, 2).ToString("##0.00") + ((char) 0x2009) + "p";
                lbl_total_gas_cost.Text = "£" + Math.Round((gasImportedCosts + gasStandingCharge), 2).ToString("##0.00") + ((char) 0x2009) + "p";
            }

            double totalElectricity = double.Parse(lbl_electricity_cost.Text.Substring(1, lbl_electricity_cost.Text.Length - 3)) +
                                      +double.Parse(lbl_electricity_standing_charge.Text.Substring(1, lbl_electricity_standing_charge.Text.Length - 3)) +
                                      -double.Parse(lbl_electricity_export_income.Text.Substring(1, lbl_electricity_export_income.Text.Length - 3)); 
            lbl_total_electricity_cost.Text = "£" + Math.Round(totalElectricity, 2).ToString("##0.00") + ((char)0x2009) + "p";

            double grandTotal = double.Parse(lbl_total_electricity_cost.Text.Substring(1,lbl_total_electricity_cost.Text.Length-3)) +
                                double.Parse(lbl_total_gas_cost.Text.Substring(1, lbl_total_gas_cost.Text.Length - 3));
            lbl_total_energy_cost.ForeColor = (grandTotal < 0) ? Color.Green : Color.Red;
            lbl_total_energy_cost.Text = "£" + Math.Round((grandTotal), 2).ToString("##0.00") + ((char)0x2009) + "p";
            lbl_grand_total.ForeColor = lbl_total_energy_cost.ForeColor;

        }
    }
}
