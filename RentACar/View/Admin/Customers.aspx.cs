using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACar.View.Admin
{
    public partial class Customers : System.Web.UI.Page
    {
        Functions conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new Functions();
            ShowCustomers();
        }

        private void ShowCustomers()
        {
            string query = "SELECT * FROM CustomerTbl";
            CustomersList.DataSource = this.conn.GetData(query);
            CustomersList.DataBind();
        }
        private void Clear() 
        {
            CNameTb.Value = "";
            CAdressTb.Value = "";
            CPhoneTb.Value = "";
            CPasswordTb.Value = "";
        }
        protected void CarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CNameTb.Value = CustomersList.SelectedRow.Cells[2].Text;
            CAdressTb.Value = CustomersList.SelectedRow.Cells[3].Text;
            CPhoneTb.Value = CustomersList.SelectedRow.Cells[4].Text;
            CPasswordTb.Value = CustomersList.SelectedRow.Cells[5].Text;
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CNameTb.Value == "" || CAdressTb.Value == "" || CPhoneTb.Value == "" || CPasswordTb.Value == "")
                {
                    errMessage.Text = "Missing information about the customer!";
                }
                else
                {
                    int ID = Convert.ToInt32(CustomersList.SelectedRow.Cells[1].Text);
                    string name = CNameTb.Value;
                    string adress = CAdressTb.Value;
                    string phone = CPhoneTb.Value;
                    string password = CPasswordTb.Value;

                    string query = $"UPDATE CustomerTbl SET Custname = '{name}', CustAdd = '{adress}', CustPhone = '{phone}', CustPassword = '{password}' WHERE CustId = {ID}";
                    conn.SetData(query);

                    ShowCustomers();
                    Clear();
                    errMessage.Text = "Customer Edited!";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CNameTb.Value == "" || CAdressTb.Value == "" || CPhoneTb.Value == "" || CPasswordTb.Value == "")
                {
                    errMessage.Text = "Missing information about the customer!";
                }
                else
                {
                    string name = CNameTb.Value;
                    string adress = CAdressTb.Value;
                    string phone = CPhoneTb.Value;
                    string password = CPasswordTb.Value;

                    string query = $"INSERT INTO CustomerTbl VALUES ('{name}', '{adress}', '{phone}', '{password}')";
                    conn.SetData(query);

                    ShowCustomers();
                    Clear();
                    errMessage.Text = "Customer Added!";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void DeleteBtn_Click1(object sender, EventArgs e)
        {
            try
            {
                if (CNameTb.Value == "")
                {
                    errMessage.Text = "Missing information about the customer!";
                }
                else
                {
                    int ID = Convert.ToInt32(CustomersList.SelectedRow.Cells[1].Text);
                    string query = $"DELETE FROM CustomerTbl WHERE CustId = {ID}";
                    conn.SetData(query);

                    ShowCustomers();
                    Clear();
                    errMessage.Text = "Customer Deleted!";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}