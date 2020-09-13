using DecToBinX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DecToBinX
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        BinToDec binToDec = new BinToDec();
        public Page1()
        {
            InitializeComponent();
            binButton.Clicked += BinButton_Clicked;
        }

        private void BinButton_Clicked(object sender, EventArgs e)
        {
            if (long.TryParse(binEntry.Text, out long binTemp))
            {
                binResult.Text = binToDec.BinInput(binTemp).ToString();
                binProcess.Text = binToDec.BinProcess;
            }
        }

        /*private void BinEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue.Length > 15)
            {
                binEntry.Text = binEntry.Text.Remove(15);
            }
        }*/
    }
}