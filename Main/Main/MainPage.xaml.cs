using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Main
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AboutClick(object sender, EventArgs e)
        {
            TitleBlock.Text = "This app aims to recognize mahjong hands from taking an image of your winning hand and calculate the appropiate points allotted";
        }

        private void AccessCamera(object sender, EventArgs e)
        {

        }
    }
}
