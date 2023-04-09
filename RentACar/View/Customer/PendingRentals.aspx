<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="PendingRentals.aspx.cs" Inherits="RentACar.View.Customer.PendingRentals" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col"></div>
            <div class="col">
                <h2>See Rentals</h2>
            </div>
            <div class="col"></div>
        </div>
        <div class="row ">
            <div class="">
                <form runat="server">
                    <div class="col-md-8">
                        <asp:GridView runat="server" ID="RentalsList" Class="table table-secondary table-hover">
                        </asp:GridView>
                    </div>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
