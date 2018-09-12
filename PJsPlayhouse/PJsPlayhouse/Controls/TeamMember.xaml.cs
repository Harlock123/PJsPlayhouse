using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PJsPlayhouse.Controls
{
    public partial class TeamMember : Xamarin.Forms.Grid
    {
        public TeamMember()
        {
            InitializeComponent();
        }

        public TeamMember(string PT, string TT, string TD)
        {
            InitializeComponent();
            PicText = PT;
            TeamMemberTitleText = TT;
            TeamMemberDescriptionText = TD;
        }

        public string PicText
        {
            //get;
            set { PicButton.Text = value; 
                switch (value.ToUpper())
                {
                    case "DOC":
                        PicButton.BackgroundColor = Color.Green;
                        break;
                    case "FAM":
                        PicButton.BackgroundColor = Color.Blue;
                        break;
                    case "COW":
                        PicButton.BackgroundColor = Color.DarkOrange;
                        break;
                    default:
                        PicButton.BackgroundColor = Color.Yellow;
                        break;
                }

            
            }
        } 

        public string TeamMemberTitleText
        {
            //get;
            set { TeamMemberTitle.Text = value; }
        } 

        public string TeamMemberDescriptionText
        {
            //get;
            set { TeamMemberDescription.Text = value; }
        } 

    }
}
