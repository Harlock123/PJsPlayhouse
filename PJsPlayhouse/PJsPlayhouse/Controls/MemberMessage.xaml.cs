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

        public MemberMessage(long id, DateTime SD, string MF, string MB, string MTYPE)
        {
            InitializeComponent();

            MessageID = id;
            MessageFromText = MF;
            MessageSentDateText = SD.ToShortDateString();
            MessageBodyText = MB;

            MessageType = MTYPE;

            switch (MTYPE.ToUpper())
            {
                case "TEXT":
                    this.BackgroundColor = Color.LightCoral;
                    break;
                case "EMAIL":
                    this.BackgroundColor = Color.LightGreen;
                    break;
                case "SYSTEM":
                    this.BackgroundColor = Color.LightSeaGreen;
                    break;
                default:
                    this.BackgroundColor = Color.Cornsilk;
                    break;
            }

        }

        public string MessageType { get; set; }

        public long MessageID { get; set; }


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

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            MessageSentDateText = DateTime.Now.ToShortTimeString();
        }

        private void ClickGestureRecognizer_Clicked(object sender, EventArgs e)
        {

        }
    }
}