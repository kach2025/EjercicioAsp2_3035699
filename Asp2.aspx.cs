using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioAsp3_3035699
{
    public partial class Asp2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ddlCategory.SelectedValue = Request.QueryString["ddlCategory"];
            ddlSupplier.SelectedValue = Request.QueryString["ddlSupplier"];
            strProduct.Text = Request.QueryString["strProduct"];
            strDescription.Text = Request.QueryString["strDescription"];
            strImage.Text = Request.QueryString["strImage"];
            decimal DecPrice = Convert.ToDecimal(Request.QueryString["decPrice"]);
            decPrice.Text = DecPrice.ToString("c");
            lblNumberInStrock.Text = Request.QueryString["bytNumberInStock"];
            lblNumberOnOrder.Text = Request.QueryString["bytNumberOnOrder"];
            bytReorderLevel.Text = Request.QueryString["bytReorderLevel"];

            Byte byNumberInStock = Convert.ToByte(Request.QueryString["bytNumberInStock"]);
            Byte byNumberOnOrder = Convert.ToByte(Request.QueryString["bytNumberOnOrder"]);
            decimal decValueInStock = DecPrice * byNumberInStock;
            decimal decValueOnOrder = DecPrice * byNumberOnOrder;
            bytNumberInStock.Text = " (Value: " + decValueInStock.ToString("c") + ")";
            bytNumberOnOrder.Text = " (Value: " + decValueOnOrder.ToString("c") + ")";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}