<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AddPlots.aspx.cs" Inherits="IdealResidencia.AddPlots" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                <div class="row" style="padding-top: 5%; padding-left: 8%">
                    <div class="col-lg-2 col-md-2 col-sm-12 col-xs-12">
                    </div>
                    <div class="col-lg-8 col-md-8 col-sm-12 col-xs-12">
                        <div class="panel panel-danger">
                            <div class="panel-heading">
                                Plots Availibility
                            </div>
                            <div class="panel-body">
                                <ul class="nav nav-tabs">
                                    <li class="active"><a data-toggle="tab" href="#Insert">Insert Plots</a></li>
                                    <li><a data-toggle="tab" href="#Update">Update Plots</a></li>
                                </ul>
                                <br />
                                <div class="tab-content">
                                    <div id="Insert" class="tab-pane fade in active">
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
                                    <div id="Update" class="tab-pane fade">
                                        <div id="table-datatables">
                                            <h4 class="header">DataTables example</h4>
                                            <div class="row">
                                                <div class="col s12 m8 l9">
                                                    <table id="data-table-simple" class="table table-hover table-responsive">
                                                        <thead>
                                                            <tr>
                                                                <th>Name</th>
                                                                <th>Position</th>
                                                                <th>Office</th>
                                                                <th>Age</th>
                                                                <th>Start date</th>
                                                                <th>Salary</th>
                                                            </tr>
                                                        </thead>


                                                        <tbody>
                                                            <tr>
                                                                <td>Tiger Nixon</td>
                                                                <td>System Architect</td>
                                                                <td>Edinburgh</td>
                                                                <td>61</td>
                                                                <td>2011/04/25</td>
                                                                <td>$320,800</td>
                                                            </tr>
                                                            <tr>
                                                                <td>Garrett Winters</td>
                                                                <td>Accountant</td>
                                                                <td>Tokyo</td>
                                                                <td>63</td>
                                                                <td>2011/07/25</td>
                                                                <td>$170,750</td>
                                                            </tr>
                                                            <tr>
                                                                <td>Ashton Cox</td>
                                                                <td>Junior Technical Author</td>
                                                                <td>San Francisco</td>
                                                                <td>66</td>
                                                                <td>2009/01/12</td>
                                                                <td>$86,000</td>
                                                            </tr>
                                                            <tr>
                                                                <td>Cedric Kelly</td>
                                                                <td>Senior Javascript Developer</td>
                                                                <td>Edinburgh</td>
                                                                <td>22</td>
                                                                <td>2012/03/29</td>
                                                                <td>$433,060</td>
                                                            </tr>
                                                            <tr>
                                                                <td>Airi Satou</td>
                                                                <td>Accountant</td>
                                                                <td>Tokyo</td>
                                                                <td>33</td>
                                                                <td>2008/11/28</td>
                                                                <td>$162,700</td>
                                                            </tr>
                                                            <tr>
                                                                <td>Brielle Williamson</td>
                                                                <td>Integration Specialist</td>
                                                                <td>New York</td>
                                                                <td>61</td>
                                                                <td>2012/12/02</td>
                                                                <td>$372,000</td>
                                                            </tr>
                                                            <tr>
                                                                <td>Herrod Chandler</td>
                                                                <td>Sales Assistant</td>
                                                                <td>San Francisco</td>
                                                                <td>59</td>
                                                                <td>2012/08/06</td>
                                                                <td>$137,500</td>
                                                            </tr>
                                                            <tr>
                                                                <td>Rhona Davidson</td>
                                                                <td>Integration Specialist</td>
                                                                <td>Tokyo</td>
                                                                <td>55</td>
                                                                <td>2010/10/14</td>
                                                                <td>$327,900</td>
                                                            </tr>
                                                        </tbody>
                                                    </table>
                                                </div>
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
