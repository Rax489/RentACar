<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RentACar.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Assets/Libraries/css/bootstrap.min.css" rel="stylesheet" />

</head>
<body>
    <div class="container-fluid">
        <div class="row">
            <div class ="col-md-3"></div>
            <div class ="col-md-6">
                 <form id="form1" runat="server">
                     <div class ="row">
                         <div class ="col"></div>
                         <div class ="col"><h1>Login Page</h1></div>
                         <div class ="col"></div>
                     </div>
                    <div>   
                          <div class="mb-3">
                            <label for="UserNameTb" class="form-label">Username</label>
                            <input type="text" class="form-control" id="UserNameTb" aria-describedby="emailHelp" placeholder="Enter username" required="required" runat="server">
                          </div>
                          <div class="mb-3">
                            <label for="UserPasswordTb" class="form-label">Password</label>
                            <input type="password" class="form-control" id="UserPasswordTb" placeholder="Enter password" required="required" runat="server">
                          </div>
                        <div class="mb-3 form-check">
                            <input type="checkbox" class="form-check-input" id="AdminRadio" name="Role" runat="server">
                            <label class="form-check-label" for="AdminRadio">Admin</label>
                        </div>
                        <div class="d-grid">
                          <asp:Button type="submit" id="LoginBtn" class="btn btn-secondary" Text="Login" runat="server" OnClick="LoginBtn_Click" />
                         </div>

                        <asp:Label Text="" id ="errMessage" runat ="server" class="text-danger"/>
                    </div>
                </form>
            </div>
            <div class ="col-md-3"></div>
        </div>
    </div>
</body>
</html>
