<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Rents.aspx.cs" Inherits="RentACar.View.Admin.Rents" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <div class="row">
                    <div class="col-2"></div>
                    <div class="col-8">
                        <h3>See Rentals</h3>
                    </div>
                    <div class="col"></div>
                </div>
                <div class="row">
                    <div class="col">
                        <div class="col-md-4">
                            <asp:GridView runat="server" ID="RentalsList" Class="table table-secondary table-hover">
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
