using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Soft262Coursework
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Revision : ContentPage
    {
        public Revision()
        {
            InitializeComponent();
            //listView.ItemTemplate = new DataTemplate(typeof());
            listView.ItemTapped += async (sender, e) => {
                await DisplayAlert("Tapped", e.Item + " row was tapped", "OK");
                ((ListView)sender).SelectedItem = null; 
            };
        }
    }
}