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
                    int row_count = 0;
                    int index = cmbobx_tariff_name.SelectedIndex;

                    string region = "-" + cmbobx_regions.Text;
                    string code = myProductDeserializeData.results[index].code;
                    string myType = "";
                    // string tariff = chckbx_use_gas.Checked ? "/gas-tariffs" : "/electricity-tariffs";

                    string type = "/standing-charges/"; //changes to unit charge later

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
                    //RichTextBox myRichTextBox = rchtxbx_import_electric;
                    DataGridView myDataGridView = dGV_import_electric;

                    if (rdobtn_import_gas.Checked)
                    {
                        fuel = "/G";
                        tariff = "/gas-tariffs";
                        //myRichTextBox = rchtxbx_import_gas;
                        myDataGridView = dGV_import_gas;
                        rdobtn_single_rate.Checked = true; //need to make sure it is on single rate as gas has no night/day rate
                    }
                    else if (rdobtn_import_electric.Checked)
                    {
                        fuel = "/E";
                        tariff = "/electricity-tariffs";
                        //myRichTextBox = rchtxbx_import_electric;
                        myDataGridView = dGV_import_electric;
                    }
                    else if (rdobtn_export_electric.Checked)
                    {
                        fuel = "/E";
                        tariff = "/electricity-tariffs";
                        //myRichTextBox = rchtxbx_export_electric;
                        myDataGridView = dGV_export_electric;
                        type = "/standard-unit-rates/";
                        paymentType = null;
                        count = 1;
                        rdobtn_single_rate.Checked = true; //need to make sure it is on single rate as export electric has no night/day rate
                    }
                    
                    string rate = rdobtn_single_rate.Checked ? "-1R-" : "-2R-";
                    if (rate == "-2R-") count = 3;
                    
                   // myRichTextBox.Clear();
                   myDataGridView.Rows.Clear();
                   myDataGridView.Refresh();
                    
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
                                    myType = "Standing Charge";

                                    if (type != "/standing-charges/")
                                   {
                                        myType = "Unit Rates";

                                        if ((rate == "-2R-") && (j == 1))
                                        {
                                            myType = "Day Unit Rates";
                                        }
                                        else if ((rate == "-2R-") && (j == 2))
                                        {
                                            myType = "Night Unit Rates";
                                        }
                                    }

                                    
                                    string ValidTo = myStandingChargeDeserializedData.results[i].valid_to;

                                    if (ValidTo != null)
                                    {
                                        myDataGridView.Rows.Add(myType,
                                            myStandingChargeDeserializedData.results[i].valid_from.Substring(0, 10),
                                            ValidTo.Substring(0, 10),
                                            myStandingChargeDeserializedData.results[i].value_exc_vat + ((char)0x2009) + "p",
                                            myStandingChargeDeserializedData.results[i].value_inc_vat + ((char)0x2009) + "p");
                                    }
                                    else
                                    {
                                        myDataGridView.Rows.Add(myType,
                                            myStandingChargeDeserializedData.results[i].valid_from.Substring(0, 10),
                                            "",
                                            myStandingChargeDeserializedData.results[i].value_exc_vat + ((char)0x2009) + "p",
                                            myStandingChargeDeserializedData.results[i].value_inc_vat + ((char)0x2009) + "p");
                                    }




                                    //myRichTextBox.AppendText(myType + "\r");

                                    //if (paymentType!=null) myRichTextBox.AppendText("Payment Method = " + paymentType + "\r");
                                   
                                    //myRichTextBox.AppendText("Valid From = " +
                                    //                         myStandingChargeDeserializedData.results[i]
                                    //                             .valid_from +
                                    //                         "\r");
                                    //myRichTextBox.AppendText("Valid To = " +
                                    //                         myStandingChargeDeserializedData.results[i]
                                    //                             .valid_to +
                                    //                         "\r");
                                    //myRichTextBox.AppendText("Price Ex VAT = " +
                                    //                         myStandingChargeDeserializedData.results[i]
                                    //                             .value_exc_vat +
                                    //                         "p\r");
                                    //myRichTextBox.AppendText("Price inc VAT = " +
                                    //                         myStandingChargeDeserializedData.results[i]
                                    //                             .value_inc_vat +
                                    //                         "p\r\r");
                                }
                            }
                        }
                        else
                        {
                            MsgBox.Show("Tariff does not have " + rate, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        type = "/standard-unit-rates/";

                        if ((rate == "-2R-") && (j == 0))
                        {
                            type = "/day-unit-rates/";
                        }
                        else if ((rate == "-2R-") && (j == 1))
                        {
                            type = "/night-unit-rates/";
                        }
                        
                                    
                        
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
