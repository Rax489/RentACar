<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="RentACar.View.Admin.Customers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mybody" runat="server">
<div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <div class="row">
                    <div class="col"></div>
                    <div class="col">
                           <h3 class ="text-secondary p-lg-4">Manage Customers</h3>
                        <img src="../../Assets/Images/person.png" alt="Customer image" width ="150px"/></div>
                    <div class="col"></div>
                </div>
                <div class="row">
                    <div class="col">
                        <form>
                            <div class="mb-3">
                                <label for="CNameTb" class="form-label">Customer Name</label>
                                <input type="text" class="form-control" id="CNameTb" placeholder="Enter Customer's Name" runat="server">
                            </div>
                            <div class="mb-3">
                                <label for="CAdressTb" class="form-label">Customer Address</label>
                                <input type="text" class="form-control" id="CAdressTb" placeholder="Enter Customer's Adress" runat="server">
                            </div>
                            <div class="mb-3">
                                <label for="CPhoneTb" class="form-label">Customer Phone</label>
                                <input type="text" class="form-control" id="CPhoneTb" placeholder="Enter Customer's Phone" runat="server">
                            </div>
                            <div class="mb-3">
                                <label for="CPasswordTb" class="form-label">Customer Password</label>
                                <input type="text" class="form-control" id="CPasswordTb" placeholder="Enter Customer's Password" runat="server">
                            </div>
                            <br />
                            <asp:Label Text="" id ="errMessage" runat ="server" class="text-danger"/>
                            <br />
                            <asp:Button type="submit" id="EditBtn" class="btn btn-secondary" Text="Edit" runat="server" OnClick="EditBtn_Click"/>
                            <asp:Button type="submit" id="SaveBtn" class="btn btn-secondary" Text="Save" runat="server" OnClick="SaveBtn_Click"/>
                            <asp:Button type="submit" id="DeleteBtn" class="btn btn-secondary" Text="Delete" runat="server" OnClick="DeleteBtn_Click1"/>
                            
                            </form>
                    </div>
                </div>
            </div>
            <div class="col-md-8">
                <h1>Customers List</h1>
                <asp:GridView runat="server" ID ="CustomersList" Class="table table-secondary table-hover" AutoGenerateSelectButton="True" OnSelectedIndexChanged="CarList_SelectedIndexChanged">
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
