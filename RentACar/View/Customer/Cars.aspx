<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="RentACar.View.Customer.Cars" %>

<asp:Content ID="Content2" ContentPlaceHolderID="mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-8"></div>
            <div class="col-md-4">
                <label id="CustName" runat="server">xxxxx</label>
            </div>
            <div class="col-2"></div>
            <div class="col">
                <form runat="server">
                    <div class="col-md-8">
                        <h1>Available Cars</h1>
                        <asp:GridView runat="server" ID="CarList" Class="table table-secondary table-hover" AutoGenerateSelectButton="True" PageSize="6" OnSelectedIndexChanged="CarList_SelectedIndexChanged">
                        </asp:GridView>

                    </div>

                    <div class="row">
                        <div class="col-4">
                            <div class="mb-3">
                            <input type="date" class="form-control" id="UserBookDatetb" placeholder="Chose Date" required="required" runat="server">
                          </div>
                        </div>
                        <div class="col-4">
                            <div class="d-grid">
                                <asp:Button type="submit" ID="BookBtn" class="btn btn-secondary" Text="Book" runat="server" OnClick="BookBtn_Click"/>
                            </div>
                        </div>
                    </div>
                    <asp:Label Text="" id ="errMessage" runat ="server" class="text-danger"/>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
