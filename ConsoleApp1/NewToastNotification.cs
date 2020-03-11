using Microsoft.QueryStringDotNET;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace ConsoleApp1
{
    public class NewToastNotification
    {
        public NewToastNotification(string input, int type)
        {
            string NotificationTextThing = input;
            string Toast = "";
            switch (type)
            {
                case 1:
                    {
                        //Basic Toast
                        Toast = "<toast><visual><binding template=\"ToastImageAndText01\"><text id = \"1\" >";
                        Toast += NotificationTextThing;
                        Toast += "</text></binding></visual></toast>";
                        break;
                    }
                default:
                    {
                        Toast = "<toast><visual><binding template=\"ToastImageAndText01\"><text id = \"1\" >";
                        Toast += "Default Text String";
                        Toast += "</text></binding></visual></toast>";
                        break;
                    }
            }
            XmlDocument tileXml = new XmlDocument();
            tileXml.LoadXml(Toast);
            var toast = new ToastNotification(tileXml);
            ToastNotificationManager.CreateToastNotifier("New Toast Notification").Show(toast);
        }

    }
}
