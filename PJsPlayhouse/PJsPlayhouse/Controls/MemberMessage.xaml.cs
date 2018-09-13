using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PJsPlayhouse.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MemberMessage : Xamarin.Forms.Grid
	{
		public MemberMessage ()
		{
			InitializeComponent ();

            MessageFromText = "Lonnie Watson";
            MessageSentDateText = DateTime.Now.ToShortDateString();
            MessageBodyText = "This is an example of a fairly long message it goes on and on and on for some time and should wordwrap appropriately given the constraints of the display in which its being viewed";

		}

        public MemberMessage(DateTime SD, string MF, string MB)
        {
            InitializeComponent();

            MessageFromText = MF;
            MessageSentDateText = SD.ToShortDateString();
            MessageBodyText = MB;

        }

        public string MessageFromText
        {
            //get;
            set { MessageFrom.Text = value; }
        }

        public string MessageBodyText
        {
            //get;
            set { MessageBody.Text = value; }
        }

        public string MessageSentDateText
        {
            //get;
            set { MessageSentDate.Text = value; }
        }
    }
}