<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="RentACar.View.Admin.Cars" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <div class="row">
                    <div class="col"></div>
                    <div class="col">
                           <h3 class ="text-secondary p-lg-4">Manage Cars</h3>
                        <img src="../../Assets/Images/carCrud.jpg" alt="Car image"  width="450px"/></div>
                    <div class="col"></div>
                </div>
                <div class="row">
                    <div class="col">
                        <form>
                            <div class="mb-3">
                                <label for="LNumberTb" class="form-label" runat="server">License Number</label>
                                <input type="text" class="form-control" id="LNumberTb" placeholder="Enter Plate Number" runat = "server">
                            </div>
                            <div class="mb-3">
                                <label for="BrandTb" class="form-label">Brand name</label>
                                <input type="text" class="form-control" id="BrandTb" placeholder="Enter Brand Name" runat = "server">
                            </div>
                            <div class="mb-3">
                                <label for="ModelTb" class="form-label">Model</label>
                                <input type="text" class="form-control" id="ModelTb" placeholder="Enter Model" runat = "server">
                            </div>
                            <div class="mb-3">
                                <label for="PriceTb" class="form-label">Price</label>
                                <input type="text" class="form-control" id="PriceTb" placeholder="Enter Price" runat = "server">
                            </div>
                            <div class="mb-3">
                                <label for="ColorTb" class="form-label">Color</label>
                                <input type="text" class="form-control" id="ColorTb" placeholder="Enter Color" runat = "server">
                            </div>
                            <div class="mb-3">
                                <label for="AvailableCb" class="form-label">Available</label>
                                <asp:DropDownList runat="server" ID ="AvailableCb" class="form-control" runat="server">
                                    <asp:ListItem Text="Available" />
                                    <asp:ListItem Text="Booked" />
                                </asp:DropDownList>
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
                <h1>Car List</h1>
                <asp:GridView runat="server" ID ="CarList" Class="table table-secondary table-hover" AutoGenerateSelectButton="True" OnSelectedIndexChanged="CarList_SelectedIndexChanged">
                </asp:GridView>

            </div>
        </div>
    </div>
</asp:Content>
