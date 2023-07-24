using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using CenteredMessagebox;

namespace EnergyUsage.utils
{
    class CheckForConnection
    {


        public static bool is_My_Connection_OK()
        {
            try
            {
                bool Connection = false;
                using (var ping = new Ping())
                {
                    var reply = ping.Send("octopusenergy.com");
                    if (reply != null && reply.Status == IPStatus.Success)
                    {
                        Connection = true;
                    }
                }

                return Connection;
            }
            catch (Exception e)
            {
                MsgBox.Show("Check Internet Connection and try again", "No Internet Connection", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false; //leave function and correct internet connection
            }
        }


    }
}
