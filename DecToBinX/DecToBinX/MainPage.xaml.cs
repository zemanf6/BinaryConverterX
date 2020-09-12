using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DecToBinX
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        readonly Calculator calculator = new Calculator();

        
        public MainPage()
        {
            InitializeComponent();
            button.Clicked += Button_Clicked;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(entry.Text, out double temp))
            {
                if (temp < 1)
                {
                    result.Text = temp.ToString();
                    process.Text = "...";
                }
                else
                {
                    result.Text = calculator.Input(temp);
                    process.Text = calculator.Process;
                }
            }

        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue.Length > 30)
            {
                entry.Text = entry.Text.Remove(30);
            }
        }
    }
}
