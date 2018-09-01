<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/Admin.Master" AutoEventWireup="true" CodeBehind="InsertBlocks.aspx.cs" Inherits="IdealResidencia.AdminPanel.InsertBlocks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                <div class="row" style="padding-top: 5%; padding-left: 8%">
                    <div class="col-lg-2 col-md-2 col-sm-12 col-xs-12">
                    </div>
                    <div class="col-lg-8 col-md-8 col-sm-12 col-xs-12">
                        <div class="row">
                            <div class="col-lg-8 col-md-8 col-sm-12 col-xs-12">
                                <div class="card-panel" style="box-shadow: 0 2px 5px 0 #00bcd4 , 0 2px 10px 0 rgba(0, 0, 0, 0.12) !important">
                                    <h4 class="header2"><b>Insert Blocks</b></h4>
                                    <div class="row">
                                        <div class="row">
                                            <div class="input-field col s12">
                                                <asp:TextBox ID="BlockNameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                                <label>Block Name</label>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="input-field col s12">
                                                <asp:TextBox ID="MarketName" runat="server" CssClass="form-control"></asp:TextBox>
                                                <label>Market Name</label>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="input-field col s12">
                                                <asp:TextBox ID="ParkNameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                                <label>Park Name</label>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="input-field col s12">
                                                <asp:TextBox ID="HospitalNameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                                <label>Hospital Name</label>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="input-field col s12">
                                                <asp:TextBox ID="SchoolNameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                                <label>School Name</label>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="input-field col s12">
                                                <asp:TextBox ID="MasjidNameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                                <label>Masjid Name</label>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="input-field col s12">
                                                <asp:LinkButton ID="SubmitBtn" runat="server" class="btn cyan waves-effect waves-light right">
                                                        Submit  
                                                        <i class="mdi-content-send right"></i>
                                                </asp:LinkButton>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>


                    </div>
                    <div class="col-lg-2 col-md-2 col-sm-12 col-xs-12">
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
