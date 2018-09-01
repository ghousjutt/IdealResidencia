<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/Admin.Master" AutoEventWireup="true" CodeBehind="AddPlots.aspx.cs" Inherits="IdealResidencia.AdminPanel.AddPlots" %>

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
                                    <h4 class="header2"><b>Add Plots</b></h4>
                                    <div class="row">
                                        <div class="row">
                                            <div class="input-field col s12">
                                                <asp:DropDownList ID="TextBox1" runat="server">
                                                    <asp:ListItem>--Select Blocks--</asp:ListItem>
                                                    <asp:ListItem>A</asp:ListItem>
                                                    <asp:ListItem>B</asp:ListItem>
                                                    <asp:ListItem>C</asp:ListItem>
                                                    <asp:ListItem>D</asp:ListItem>
                                                    <asp:ListItem>H</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="input-field col s12">
                                                <asp:TextBox ID="SizeMarlaTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                                <label>Plot Size Marla</label>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="input-field col s12">
                                                <asp:TextBox ID="SizeSquareInchTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                                <label>Plot Size Square Inch</label>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="input-field col s12">
                                                <asp:TextBox ID="StreetNo1TextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                                <label>Plot Street No 1</label>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="input-field col s12">
                                                <asp:TextBox ID="StreetNo2TextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                                 <label>Plot Street No 2</label>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="input-field col s12">
                                                <asp:TextBox ID="StreetNo3TextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                                 <label>Plot Street No 3</label>
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
