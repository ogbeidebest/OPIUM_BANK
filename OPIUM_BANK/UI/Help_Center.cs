using OPIUM_BANK.Core.MODELS;
using OPIUM_BANK.Core.UTILITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPIUM_BANK.UI
{
    public class Help_Center
    {
        public static void Helper()
        {
            Console.Clear();
            Background_Color.colorMagenta("WELCOME TO OPNIUM BANK");
            Background_Color.colourBlue("THANKS FOR TRUSTING US!! WE WON'T LET YOU DOWN");

            Console.WriteLine();

            Error_Handling.HelpBack();

        }
    }
}
