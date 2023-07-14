using System;

namespace EnergyUsage
{
    public partial class Form1
    {
        private void GetTariffs()
        {

            int index = cmbobx_tariff_name.SelectedIndex;

            string region = cmbobx_regions.Text;
            string code = myProductDeserializeData.results[index].code;

            rchtxtbx_tariff_info.Clear();
            rchtxtbx_tariff_info.AppendText("Code = " + code + "\r");
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

            rchtxtbx_tariff_info.AppendText("\r" + region);
            rchtxtbx_tariff_info.AppendText("\r" + code);

            // "https://api.octopus.energy/v1/products/" + code + "/gas-tariffs/G-1R-VAR-22-11-01-A/standing-charges/"
            // "https://api.octopus.energy/v1/products/" + code + /gas-tariffs/G-1R-VAR-22-11-01-A/standard-unit-rates/"


            //"https://api.octopus.energy/v1/products/" + code + "/"

            //myTariffDeserializedData =
            //    Utilities.GetTariffInfo(new Uri("https://api.octopus.energy/v1/products/" + code + "/"));

            //rchtxtbx_tariff_info.AppendText(myTariffDeserializedData.code + "\r");
            //rchtxtbx_tariff_info.AppendText(myTariffDeserializedData.brand + "\r");
            //rchtxtbx_tariff_info.AppendText(myTariffDeserializedData.description + "\r");

            //rchtxtbx_tariff_info.AppendText(myTariffDeserializedData.single_register_electricity_tariffs._A.direct_debit_monthly.standing_charge_inc_vat + "\r");




        }
    }
}
