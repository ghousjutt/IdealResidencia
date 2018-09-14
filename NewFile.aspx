<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="NewFile.aspx.cs" Inherits="IdealResidencia.NewFile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="padding: 20px; margin-left: 15px">
        <div class="row">
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                <asp:Wizard ID="Wizard1" runat="server" CssClass="col-md-8" DisplayCancelButton="true" ActiveStepIndex="0">
                    <StartNextButtonStyle CssClass="btn btn-info" />
                    <StepNextButtonStyle CssClass="btn btn-info" />
                    <StepPreviousButtonStyle CssClass="btn btn-info" />
                    <SideBarButtonStyle CssClass="btn btn-success btn-block" />
                    <CancelButtonStyle CssClass="btn btn-info" />
                    <FinishPreviousButtonStyle CssClass="btn btn-info" />
                    <FinishCompleteButtonStyle CssClass="btn btn-info" />
                    <WizardSteps>

                        <%--Wizard Booking Form--%>
                        <asp:WizardStep ID="WizardStep1" runat="server" Title="Booking Form">
                            <div class="col-md-12">
                                <div class="panel panel-primary">
                                    <div class="panel-heading">
                                        Booking Form
                                    </div>
                                    <div class="panel-body">
                                    </div>
                                </div>
                            </div>
                        </asp:WizardStep>

                        <%--Wizard Sale Detail--%>

                        <asp:WizardStep ID="WizardStep2" runat="server" Title="Sale Detail">
                            <div class="col-md-12">
                                <div class="panel panel-info">
                                    <div class="panel-heading">
                                        Payment Schedules
                                    </div>
                                    <div class="panel-body">
                                    </div>
                                </div>
                            </div>
                        </asp:WizardStep>
                    </WizardSteps>
                </asp:Wizard>
            </div>
        </div>
    </div>
</asp:Content>
