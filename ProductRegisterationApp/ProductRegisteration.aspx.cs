using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductRegisterationApp
{
    public partial class ProductRegisteration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblMsg.Visible = false;
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

        protected void BtnReg_Click(object sender, EventArgs e)
        {
            LblMsg.Visible = true;
            LblMsg.Text="Product Name: "+TxtName.Text;
            LblMsg.Text += "<br/> category: " + DdlCategory.Text;
            LblMsg.Text += "<br/> Price: " + TxtPrice.Text;
            LblMsg.Text += "<br/> Description: " +TextArea1 .InnerText;
            LblMsg.Text += "<br/> Release date: " + ReleaseDate.SelectedDate.ToShortDateString();
        }
    }
}