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

            TheList.Children.Add(new Controls.TeamMember("Doc", "Dr Drew Carey", "Endrocrynologist (Sugar Doc)"));
            TheList.Children.Add(new Controls.TeamMember("Doc", "Dr Gary King", "Primary Care Physician"));
            TheList.Children.Add(new Controls.TeamMember("Doc", "Dr Joseph Wyllie", "Cardiologyst"));
            TheList.Children.Add(new Controls.TeamMember("Fam", "Sally Watson", "Wife"));
            TheList.Children.Add(new Controls.TeamMember("Fam", "Kathleen Sherman", "Mother In Law"));
            TheList.Children.Add(new Controls.TeamMember("Fam", "Todd Watson", "Brother"));
            TheList.Children.Add(new Controls.TeamMember("Fam", "Kimberly Hearn", "Sister"));
            TheList.Children.Add(new Controls.TeamMember("Fam", "Robert Lonnie Watson", "Son"));
            TheList.Children.Add(new Controls.TeamMember("Fam", "Michael Mitchell Watson", "Son"));
            TheList.Children.Add(new Controls.TeamMember("Cow", "Jennifer Feeney", ""));
            TheList.Children.Add(new Controls.TeamMember("Cow", "Cheryl Bellucci", ""));
            TheList.Children.Add(new Controls.TeamMember("Cow", "Keith Inman", ""));
            TheList.Children.Add(new Controls.TeamMember("Cow", "Lawrence Reedy", ""));
          
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
