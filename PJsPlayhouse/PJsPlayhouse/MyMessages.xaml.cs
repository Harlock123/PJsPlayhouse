using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PJsPlayhouse
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyMessages : ContentPage
	{
		public MyMessages ()
		{
			InitializeComponent ();

            TheMessageList.Children.Add(new Controls.MemberMessage(DateTime.Now,
                "Dr King", "Your annual checkup appointment needs to be made. Call our office at 111-222-3333 and make that appointment, see you soon."));
            TheMessageList.Children.Add(new Controls.MemberMessage(DateTime.Now,
                "Sally Watson", "The doctors office called and left a message about your annual checkup. You need to call and make an appointment"));
            TheMessageList.Children.Add(new Controls.MemberMessage(DateTime.Now,
                            "Todd Watson", "I wanted to ask you what you Doctors name was. The one you go to that helped you get your sugar undercontrol"));
            TheMessageList.Children.Add(new Controls.MemberMessage(DateTime.Now,
                            "Dr Carey", "We need to get you into the office for a  screening that may have you eligible for a new sugar medication that may be less expensive for you in the long run. Please call and make an appointment..."));
             

        }
    }
}