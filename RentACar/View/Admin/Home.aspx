<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="RentACar.View.Admin.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mybody" runat="server">
    <div class="div container-fluid mt-5 ms-5">
        <div class="row">
            <div class ="jumbotron jumbotron-fluid ">
                <div class ="container">
                    <h1 class="display-4"> Welcome in the admin panel</h1>
                    <p class="lead">The admin can manage Cars, Customers, Rentals and Returns</p>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-3"><div><img src="../../Assets/Images/bmwM5cs.jpeg" alt="Picture of BMW M5 CS" width =" 250px" height ="200px"></div><div><h6>BMW M5 cs</h6></div></div>
            <div class="col-lg-3"><div><img src="../../Assets/Images/c63AMG.jpg" alt="Picture of Mercedes C63 AMG" width =" 250px" height ="200px"></div><div><h6>Mercedes C63 AMG</h6></div></div>
            <div class="col-lg-3"><div><img src="../../Assets/Images/HondaCivic.jpg" alt="Picture of Honda Civic" width =" 250px" height ="200px"></div><div><h6>Honda Civic</h6></div></div>
            <div class="col-lg-3"><div><img src="../../Assets/Images/ChevroletMalibu.jpg" alt="Picture of Chevrolet Malibu" width =" 250px" height ="200px"></div><div><h6>Chevrolet Malibu</h6></div></div>
        </div>
        <div class="row">
            <div class="col-lg-3"><div><img src="../../Assets/Images/SubaruWRX.png" alt="Picture of Subaru WRX" width =" 250px" height ="200px"></div><div><h6>Subaru WRX</h6></div></div>
            <div class="col-lg-3"><div><img src="../../Assets/Images/ToyotaCorolla.jpeg" alt="Picture of Toyota Corolla" width =" 250px" height ="200px"></div><div><h6>Toyota Corolla</h6></div></div>
            <div class="col-lg-3"><div><img src="../../Assets/Images/MitsubishiEvo.jpg" alt="Picture of Mitsubishi Evo" width =" 250px" height ="200px"></div><div><h6>Mitsubishi Evo</h6></div></div>
            <div class="col-lg-3"><div><img src="../../Assets/Images/MazdaCX-5.jpg" alt="Picture of Mazda CX-5" width =" 250px" height ="200px"></div><div><h6>Mazda CX-5</h6></div></div>
        </div>
    </div>
</asp:Content>

