using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACar.View.Customer
{
    public partial class Cars : System.Web.UI.Page
    {
        Functions conn; 
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new Functions();
            ShowCars();
            CustName.InnerText = Login.CName;
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        private void ShowCars()
        {
            string query = "SELECT * FROM CarTbl WHERE Status = 'Available'";
            CarList.DataSource = this.conn.GetData(query);
            CarList.DataBind();
        }
        private void Updatecar() 
        {
            string status = "Booked";
            try
            {
                string query = $"UPDATE CarTbl SET Status = '{status}' WHERE CPlateNum = '{CarList.SelectedRow.Cells[1].Text}'";
                conn.SetData(query);

                ShowCars();
            }
            catch (Exception)
            {

                throw;
            }
        }
        protected void BookBtn_Click(object sender, EventArgs e)
        {
            TimeSpan dDays = Convert.ToDateTime(UserBookDatetb.Value) - Convert.ToDateTime(DateTime.Today.Date.ToString());
            int days = int.Parse(dDays.Days.ToString());
            int DPrice;
            DPrice= Convert.ToInt32(CarList.SelectedRow.Cells[4].Text);
            int fees = days * DPrice;
            try
            {
                if (fees==0)
                {
                    errMessage.Text = "Select return date!";
                }
                else
                {
                    string query = $"INSERT INTO RentTbl VALUES('{CarList.SelectedRow.Cells[1].Text}', {Login.Id}, '{DateTime.Today.Date.ToString()}', '{UserBookDatetb.Value.ToString()}', {fees})";
                    conn.SetData(query);

                    ShowCars();
                    Updatecar();
                    errMessage.Text = "Car Rented!";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        protected void CarList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}