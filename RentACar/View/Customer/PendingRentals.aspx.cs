using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACar.View.Customer
{
    public partial class PendingRentals : System.Web.UI.Page
    {
        Functions conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new Functions();
            ShowRents();
        }
        public void ShowRents() 
        {
            string query = $"SELECT * FROM RentTbl WHERE Customer = {Login.Id}";
            RentalsList.DataSource = this.conn.GetData(query);
            RentalsList.DataBind();
        }
    }
}