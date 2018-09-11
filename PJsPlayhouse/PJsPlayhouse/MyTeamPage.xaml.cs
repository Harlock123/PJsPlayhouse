using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PJsPlayhouse
{
    public partial class MyTeamPage : ContentPage
    {
        public MyTeamPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
