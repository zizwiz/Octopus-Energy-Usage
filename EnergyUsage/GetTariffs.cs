using System;
using System.Windows.Forms;
using CenteredMessagebox;

namespace EnergyUsage
{
    public partial class Form1
    {
        private void GetTariffs()
        {
            try
            {
                if (cmbobx_tariff_name.Items.Count > 0) //only do something here is there is data in combobox.
                {
                    int count = 2;
                    int index = cmbobx_tariff_name.SelectedIndex;

                    string region = "-" + cmbobx_regions.Text;
                    string code = myProductDeserializeData.results[index].code;
                    // string tariff = chckbx_use_gas.Checked ? "/gas-tariffs" : "/electricity-tariffs";

                    string type = "/standing-charges/";

                    string paymentType = "DIRECT_DEBIT";

                    if (rdobtn_nonDirectDebit.Checked)
                    {
                        paymentType = "NON_DIRECT_DEBIT";
                    }
                    else if (rdobtn_otherPayment.Checked)
                    {
                        paymentType = null;
                    }

                    string fuel = "/E";
                    string tariff = "/electricity-tariffs";
                    RichTextBox myRichTextBox = rchtxbx_import_electric;

                    if (rdobtn_import_gas.Checked)
                    {
                        fuel = "/G";
                        tariff = "/gas-tariffs";
                        myRichTextBox = rchtxbx_import_gas;
                    }
                    else if (rdobtn_import_electric.Checked)
                    {
                        fuel = "/E";
                        tariff = "/electricity-tariffs";
                        myRichTextBox = rchtxbx_import_electric;
                    }
                    else if (rdobtn_export_electric.Checked)
                    {
                        fuel = "/E";
                        tariff = "/electricity-tariffs";
                        myRichTextBox = rchtxbx_export_electric;
                        type = "/standard-unit-rates/";
                        paymentType = null;
                        count = 1;
                    }




                    //string fuel = rdobtn_gas.Checked ? "/E" : "/G";
                    //                   // string tariff = rdobtn_gas.Checked ? "/gas-tariffs" : "/electricity-tariffs";
                    //                    string tariff = rdobtn_gas.Checked ? "/electricity-tariffs" : "/gas-tariffs";
                    //                    RichTextBox myRichTextBox = rdobtn_gas.Checked ? rchtxbx_import_electric : rchtxbx_import_gas;


                    

                    string rate = rdobtn_single_rate.Checked ? "-1R-" : "-2R-";

                    myRichTextBox.Clear();
                    //rchtxtbx_tariff_info.AppendText("Code = " + code + "\r");
                    //rchtxtbx_tariff_info.AppendText("Direction = " + myProductDeserializeData.results[index].direction + "\r");
                    //rchtxtbx_tariff_info.AppendText("Full Name = " + myProductDeserializeData.results[index].full_name + "\r");
                    //rchtxtbx_tariff_info.AppendText("Display Name = " + myProductDeserializeData.results[index].display_name + "\r");
                    //rchtxtbx_tariff_info.AppendText("Description = " + myProductDeserializeData.results[index].description + "\r");
                    //rchtxtbx_tariff_info.AppendText("Is Tariff Variable? = " + myProductDeserializeData.results[index].is_variable + "\r");
                    //rchtxtbx_tariff_info.AppendText("Is Tariff Green? = " + myProductDeserializeData.results[index].is_green + "\r");
                    //rchtxtbx_tariff_info.AppendText("Is Tariff Tracker? = " + myProductDeserializeData.results[index].is_tracker + "\r");
                    //rchtxtbx_tariff_info.AppendText("Is Tariff Prepay? = " + myProductDeserializeData.results[index].is_prepay + "\r");
                    //rchtxtbx_tariff_info.AppendText("Can Tariff be used for Business? = " + myProductDeserializeData.results[index].is_business + "\r");
                    //rchtxtbx_tariff_info.AppendText("Is Tariff Restricted = " + myProductDeserializeData.results[index].is_restricted + "\r");
                    //rchtxtbx_tariff_info.AppendText("Term = " + myProductDeserializeData.results[index].term + "\r");
                    //rchtxtbx_tariff_info.AppendText("Available From = " + myProductDeserializeData.results[index].available_from + "\r");
                    //rchtxtbx_tariff_info.AppendText("Available To = " + myProductDeserializeData.results[index].available_to + "\r");
                    //rchtxtbx_tariff_info.AppendText("Company Selling Tariff = " + myProductDeserializeData.results[index].brand + "\r");

                    //rchtxtbx_tariff_info.AppendText("\r" + region);
                    //rchtxtbx_tariff_info.AppendText("\r" + code);

                    // "https://api.octopus.energy/v1/products/" + code + "/gas-tariffs/G-1R-VAR-22-11-01-A/standing-charges/"
                    // "https://api.octopus.energy/v1/products/" + code + /gas-tariffs/G-1R-VAR-22-11-01-A/standard-unit-rates/"

                    // "https://api.octopus.energy/v1/products/" + code + tariff + fuel + rate + code + region + type
                    // "https://api.octopus.energy/v1/products/" + code + /electricity-tariffs/E-1R-" + code + "-A/standard-unit-rates/"


                    for (int j = 0; j < count; j++)
                    {
                        myStandingChargeDeserializedData =
                            Utilities.GetStandingCharge(new Uri("https://api.octopus.energy/v1/products/" + code + tariff +
                                                                fuel + rate + code + region + type));

                        if (myStandingChargeDeserializedData.count != null)
                        {
                            for (int i = 0; i < myStandingChargeDeserializedData.count; i++)
                            {
                                if (myStandingChargeDeserializedData.results[i].payment_method == paymentType)
                                {
                                    myRichTextBox.AppendText("Payment Method = " + paymentType + "\r");
                                    myRichTextBox.AppendText("Valid From = " +
                                                             myStandingChargeDeserializedData.results[i]
                                                                 .valid_from +
                                                             "\r");
                                    myRichTextBox.AppendText("Valid To = " +
                                                             myStandingChargeDeserializedData.results[i]
                                                                 .valid_to +
                                                             "\r");
                                    myRichTextBox.AppendText("Price Ex VAT = " +
                                                             myStandingChargeDeserializedData.results[i]
                                                                 .value_exc_vat +
                                                             "p\r");
                                    myRichTextBox.AppendText("Price inc VAT = " +
                                                             myStandingChargeDeserializedData.results[i]
                                                                 .value_inc_vat +
                                                             "p\r\r");
                                }
                            }
                        }

                        type = "/standard-unit-rates/";
                    }
                }
                //else
                //{
                //    MsgBox.Show("No data in dropdown menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            catch (Exception e)
            {
                //let the user know the error and when they click OK carry on
                MsgBox.Show("Error = " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
