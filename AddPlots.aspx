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
                                                                <asp:DropDownList ID="ddlBlocks" runat="server">
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
                                                                <asp:TextBox ID="AreaTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                                                <label>Plot Area</label>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="input-field col s12">
                                                                <asp:TextBox ID="StatusTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                                                <label>Plot Status</label>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="input-field col s12">
                                                                <asp:TextBox ID="TypeTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                                                <label>Plot Type</label>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="input-field col s12">
                                                                <asp:TextBox ID="CategoryTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                                                <label>Plot Category</label>
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
                                    <div id="Update" class="tab-pane fade table-responsive">
                                        <div id="table-datatables">
                                            <h4 class="header">Plots Details</h4>
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
                                                            <asp:TemplateField HeaderText="PlotID">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="PlotIDLabel" runat="server" Text='<%#Eval("PlotID") %>'></asp:Label>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>  
                                                            <asp:TemplateField HeaderText="PlotSizeMarla">  
                                                            <ItemTemplate>  
                                                                <asp:Label ID="PlotSizeMarlaLabel" runat="server" Text='<%#Eval("PlotSizeMarla") %>'></asp:Label>  
                                                            </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <asp:TextBox ID="PlotSizeMarlaTextBox" runat="server" Text='<%#Eval("PlotSizeMarla") %>'></asp:TextBox>  
                                                                </EditItemTemplate>  
                                                            </asp:TemplateField>  
                                                            <asp:TemplateField HeaderText="PlotArea">  
                                                                <ItemTemplate>  
                                                                    <asp:Label ID="PlotAreaLabel" runat="server" Text='<%#Eval("PlotArea") %>'></asp:Label>  
                                                                </ItemTemplate>
                                                                <EditItemTemplate>  
                                                                    <asp:TextBox ID="PlotAreaTextBox" runat="server" Text='<%#Eval("PlotArea") %>'></asp:TextBox>
                                                                </EditItemTemplate>  
                                                            </asp:TemplateField>  
                                                            <asp:TemplateField HeaderText="PlotStatus">  
                                                                <ItemTemplate>  
                                                                    <asp:Label ID="PlotStatusLabel" runat="server" Text='<%#Eval("PlotStatus") %>'></asp:Label>  
                                                                </ItemTemplate>
                                                                <EditItemTemplate>  
                                                                    <asp:TextBox ID="PlotStatusTextBox" runat="server" Text='<%#Eval("PlotStatus") %>'></asp:TextBox>
                                                                </EditItemTemplate>  
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="PlotType">  
                                                                <ItemTemplate>  
                                                                    <asp:Label ID="PlotTypeLabel" runat="server" Text='<%#Eval("PlotType") %>'></asp:Label>  
                                                                </ItemTemplate>
                                                                <EditItemTemplate>  
                                                                    <asp:TextBox ID="PlotTypeTextBox" runat="server" Text='<%#Eval("PlotType") %>'></asp:TextBox>
                                                                </EditItemTemplate>  
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="PlotCategory">  
                                                                <ItemTemplate>  
                                                                    <asp:Label ID="PlotCategoryLabel" runat="server" Text='<%#Eval("PlotCategory") %>'></asp:Label>  
                                                                </ItemTemplate>
                                                                <EditItemTemplate>  
                                                                    <asp:TextBox ID="PlotCategoryTextBox" runat="server" Text='<%#Eval("PlotCategory") %>'></asp:TextBox>
                                                                </EditItemTemplate>  
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="PlotStreetNo1">  
                                                                <ItemTemplate>  
                                                                    <asp:Label ID="PlotStreetNo1Label" runat="server" Text='<%#Eval("PlotStreetNo1") %>'></asp:Label>  
                                                                </ItemTemplate>
                                                                <EditItemTemplate>  
                                                                    <asp:TextBox ID="PlotStreetNo1TextBox" runat="server" Text='<%#Eval("PlotStreetNo1") %>'></asp:TextBox>
                                                                </EditItemTemplate>  
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="PlotStreetNo2">  
                                                                <ItemTemplate>  
                                                                    <asp:Label ID="PlotStreetNo2Label" runat="server" Text='<%#Eval("PlotStreetNo2") %>'></asp:Label>  
                                                                </ItemTemplate>
                                                                <EditItemTemplate>  
                                                                    <asp:TextBox ID="PlotStreetNo2Textbox" runat="server" Text='<%#Eval("PlotStreetNo2") %>'></asp:TextBox>
                                                                </EditItemTemplate>  
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="PlotStreetNo3">  
                                                                <ItemTemplate>  
                                                                    <asp:Label ID="PlotStreetNo3Label" runat="server" Text='<%#Eval("PlotStreetNo3") %>'></asp:Label>  
                                                                </ItemTemplate>
                                                                <EditItemTemplate>  
                                                                    <asp:TextBox ID="PlotStreetNo3TextBox" runat="server" Text='<%#Eval("PlotStreetNo3") %>'></asp:TextBox>
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
