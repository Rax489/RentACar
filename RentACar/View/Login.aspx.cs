using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACar.View
{
    public partial class Login : System.Web.UI.Page
    {
        Functions conn;
        public static string CName = "";
        public static int Id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new Functions();
        }
        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            if (AdminRadio.Checked)
            {
                if (UserNameTb.Value == "Admin" && UserPasswordTb.Value == "Admin")
                {
                    Response.Redirect("Admin/Home.aspx");
                }
                else
                {
                    errMessage.Text = "Invalid admin";
                }
            }
            else
            {
                string username = UserNameTb.Value;
                string password = UserPasswordTb.Value;
                string cmd = $"SELECT Custname, CustPassword, CustId FROM CustomerTbl WHERE CustName = '{username}' AND CustPassword = '{password}'";

                DataTable dt = conn.GetData(cmd);

                if (dt.Rows.Count == 0)
                {
                    errMessage.Text = "Invalid username or password!";
                }
                else
                {
                    Id= int.Parse(dt.Rows[0][2].ToString());
                    CName = dt.Rows[0][0].ToString();
                    Response.Redirect("Customer/Cars.aspx");
                }
            }
        }
    }
}