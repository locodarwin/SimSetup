using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SimSetup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lisStatus.View = View.List;
            //lisStatus.Columns.Add("Status Window", 320, HorizontalAlignment.Left);


            Status("Ready to begin.");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Status("Ready to begin.");
        }
        public struct Permissions
        {

        }

        public static class Globals
        {


            // General Settings - Administration
            public static string SimTitle;
            public static string SimAuthors;
            public static string Captain;
            public static bool AutoRegister;


            // General Settings - Interface
            public static string InvColor;
            public static string PresentColor;
            public static string RegColor;


            // General Settings - Commerce and Terms
            public static string CurrencyName, CurrencyPlural;
            public static string WeightName, WeightPlural;



            // General Settings - Administration
            public static bool FlagInventory, FlagCombat, FlagClasses, FlagDayNight, FlagFarming, FlagSurvival;




        }


        private void button1_Click(object sender, EventArgs e)
        {

        }




        private void Status(string sStatusText)
        {
            lisStatus.Items.Add(sStatusText);
        }

    }
}
