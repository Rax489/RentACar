using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACar.View.Admin
{
    public partial class Rents : System.Web.UI.Page
    {
        Functions conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new Functions();
            ShowRentals();
        }
        public void ShowRentals() 
        {
            string query = "SELECT * FROM RentTbl";
            RentalsList.DataSource = this.conn.GetData(query);
            RentalsList.DataBind();
        }
    }
}