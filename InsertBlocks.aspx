<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="InsertBlocks.aspx.cs" Inherits="IdealResidencia.InsertBlocks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
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
                                    <li class="active"><a data-toggle="tab" href="#Insert">Insert Blocks</a></li>
                                    <li><a data-toggle="tab" href="#Update">Update Blocks</a></li>
                                </ul>
                                <br />
                                <div class="tab-content">
                                    <div id="Insert" class="tab-pane fade in active">
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
                                                                <asp:TextBox ID="MarketNameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
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
                                                                <asp:LinkButton ID="SubmitBtn" runat="server" OnClick="SubmitBtn_Click" class="btn cyan waves-effect waves-light right">
                                                                    Submit<i class="mdi-content-send right"></i>
                                                                </asp:LinkButton>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div id="Update" class="table-responsive fade">
                                        <div id="table-datatables">
                                            <h4 class="header">Block Details</h4>
                                            <div class="row">
                                                <div class="col s12 m8 l9">
                                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnRowEditing="GridView1_RowEditing" 
                                                        OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" >
                                                        <Columns>
                                                            <asp:TemplateField>
                                                                <ItemTemplate>
                                                                    <asp:Button ID="EditButton" runat="server" Text="Edit" CommandName="Edit" />  
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:Button ID="UpdateButton" runat="server" Text="Update" CommandName="Update"/>  
                                                                    <asp:Button ID="CancelButton" runat="server" Text="Cancel" CommandName="Cancel"/>
                                                                </EditItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="BlockID">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="BlockIDLabel" runat="server" Text='<%#Eval("BlockID") %>'></asp:Label>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>  
                                                            <asp:TemplateField HeaderText="BlockName">  
                                                            <ItemTemplate>  
                                                                <asp:Label ID="BlockNameLabel" runat="server" Text='<%#Eval("BlockName") %>'></asp:Label>  
                                                            </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="BlockNameTextBox" runat="server" Text='<%#Eval("BlockName") %>'></asp:TextBox>  
                                                                </EditItemTemplate>  
                                                            </asp:TemplateField>  
                                                            <asp:TemplateField HeaderText="BlockMarketName">  
                                                                <ItemTemplate>  
                                                                    <asp:Label ID="MarketNameLabel" runat="server" Text='<%#Eval("BlockMarketName") %>'></asp:Label>  
                                                                </ItemTemplate>
                                                                <EditItemTemplate>  
                                                                    <asp:TextBox ID="MarketNameTextBox" runat="server" Text='<%#Eval("BlockMarketName") %>'></asp:TextBox>
                                                                </EditItemTemplate>  
                                                            </asp:TemplateField>  

                                                            <asp:TemplateField HeaderText="BlockParkName">  
                                                                <ItemTemplate>  
                                                                    <asp:Label ID="ParkNameLabel" runat="server" Text='<%#Eval("BlockParkName") %>'></asp:Label>  
                                                                </ItemTemplate>
                                                                <EditItemTemplate>  
                                                                    <asp:TextBox ID="ParkNameTextBox" runat="server" Text='<%#Eval("BlockParkName") %>'></asp:TextBox>
                                                                </EditItemTemplate>  
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="BlockHospitalName">  
                                                                <ItemTemplate>  
                                                                    <asp:Label ID="HospitalNameLabel" runat="server" Text='<%#Eval("BlockHospitalName") %>'></asp:Label>  
                                                                </ItemTemplate>
                                                                <EditItemTemplate>  
                                                                    <asp:TextBox ID="HospitalNameTextBox" runat="server" Text='<%#Eval("BlockHospitalName") %>'></asp:TextBox>
                                                                </EditItemTemplate>  
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="BlockMasjidName">  
                                                                <ItemTemplate>  
                                                                    <asp:Label ID="MasjidNameLabel" runat="server" Text='<%#Eval("BlockMasjidName") %>'></asp:Label>  
                                                                </ItemTemplate>
                                                                <EditItemTemplate>  
                                                                    <asp:TextBox ID="MasjidNameTextBox" runat="server" Text='<%#Eval("BlockMasjidName") %>'></asp:TextBox>
                                                                </EditItemTemplate>  
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="BlockSchoolName">  
                                                                <ItemTemplate>  
                                                                    <asp:Label ID="SchoolNameLabel" runat="server" Text='<%#Eval("BlockSchoolName") %>'></asp:Label>  
                                                                </ItemTemplate>
                                                                <EditItemTemplate>  
                                                                    <asp:TextBox ID="SchoolNameTextBox" runat="server" Text='<%#Eval("BlockSchoolName") %>'></asp:TextBox>
                                                                </EditItemTemplate>  
                                                            </asp:TemplateField>
                                                        </Columns>
                                                    </asp:GridView>
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
