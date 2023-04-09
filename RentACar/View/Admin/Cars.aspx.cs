using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACar.View.Admin
{
    public partial class Cars : System.Web.UI.Page
    {
        Functions conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new Functions();
            ShowCars();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (LNumberTb.Value == "" || BrandTb.Value == "" || ModelTb.Value == "" || PriceTb.Value == "" || ColorTb.Value == "")
                {
                    errMessage.Text = "Missing information about the car!";
                }
                else
                {
                    string plateNum = LNumberTb.Value;
                    string brand = BrandTb.Value;
                    string model = ModelTb.Value;
                    int price = int.Parse(PriceTb.Value);
                    string color = ColorTb.Value;
                    string status = AvailableCb.SelectedValue;

                    string query = $"INSERT INTO CarTbl VALUES ('{plateNum}', '{brand}', '{model}', {price}, '{color}', '{status}')";
                    conn.SetData(query);

                    ShowCars();
                    Clear();
                    errMessage.Text = "Car Added!";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ShowCars() 
        {
            string query = "SELECT * FROM CarTbl";
            CarList.DataSource = this.conn.GetData(query);
            CarList.DataBind();
        }
        private void Clear() 
        {
            LNumberTb.Value = " ";
            BrandTb.Value = " ";
            ModelTb.Value = " ";
            PriceTb.Value = " ";
            ColorTb.Value = " ";
        }
        protected void CarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LNumberTb.Value = CarList.SelectedRow.Cells[1].Text;
            BrandTb.Value = CarList.SelectedRow.Cells[2].Text;
            ModelTb.Value = CarList.SelectedRow.Cells[3].Text;
            PriceTb.Value = CarList.SelectedRow.Cells[4].Text;
            ColorTb.Value = CarList.SelectedRow.Cells[5].Text;
            AvailableCb.SelectedValue = CarList.SelectedRow.Cells[6].Text;
        }


        protected void DeleteBtn_Click1(object sender, EventArgs e)
        {
            try
            {
                if (LNumberTb.Value == "")
                {
                    errMessage.Text = "Missing information about the car!";
                }
                else
                {
                    string plateNum = LNumberTb.Value;

                    string query = $"DELETE FROM CarTbl WHERE CPlateNum = '{plateNum}'";
                    conn.SetData(query);

                    ShowCars();
                    Clear();
                    errMessage.Text = "Car Deleted!";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (LNumberTb.Value == "" || BrandTb.Value == "" || ModelTb.Value == "" || PriceTb.Value == "" || ColorTb.Value == "")
                {
                    errMessage.Text = "Missing information about the car!";
                }
                else
                {
                    string plateNum = LNumberTb.Value;
                    string brand = BrandTb.Value;
                    string model = ModelTb.Value;
                    int price = int.Parse(PriceTb.Value);
                    string color = ColorTb.Value;
                    string status = AvailableCb.SelectedValue;

                    string query = $"UPDATE CarTbl SET Brand = '{brand}', Model = '{model}', Price = {price}, Color = '{color}',Status = '{status}' WHERE CPlateNum = '{plateNum}' ";
                    conn.SetData(query);

                    ShowCars();
                    Clear();
                    errMessage.Text = "Car Edited!";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}