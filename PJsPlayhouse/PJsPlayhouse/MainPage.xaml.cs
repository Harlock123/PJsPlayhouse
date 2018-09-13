using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PJsPlayhouse
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //Application.Current.MainPage.Navigation.PushAsync(MainPage);
        }


        async void Handle_MyTeamClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MyTeamPage());

            //Application.Current.MainPage = new MyTeamPage();
        }

        async void Handle_MyAssessmentsClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new UnderConstructionPage());
        }

        async void Handle_MyServicesClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new UnderConstructionPage());
        }

        async void Handle_MyAuthsClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new UnderConstructionPage());
        }

        async void Handle_MyMessagesClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new UnderConstructionPage());
        }
    }
}
