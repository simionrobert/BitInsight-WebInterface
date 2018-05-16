﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watcher.Controllers
{
    public static class Utils
    {
        public static bool ValidateIPv4(ref string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }
            
            ipString = ipString.Trim();
            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }

        public static String FormatBytes(long bytes)
        {
            if (bytes > 1000000000)
                return (bytes / 1000000000.00).ToString("f2") + " GB";
            else if (bytes > 1000000)
                return (bytes / 1000000.00).ToString("f2") + " MB";
            else
                return (bytes / 1000.00).ToString("f2") + " KB";
        }

        public static String FormatTags(IEnumerable<string> Categories)
        {
            String desc = "";

            if (Categories != null && Categories.Count() != 0)
            {

                foreach (var cat in Categories)
                {
                    desc += cat + ", ";
                }
                desc = desc.Substring(0, desc.Length - 2);
            }

            return desc;
        }

        public static String FormatDate(string epoch)
        {
            DateTime time = new DateTime(1970, 1, 1).AddMilliseconds(Double.Parse(epoch));

            return time.ToString("g"); ;
        }
    }


}
