<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Instructors.aspx.cs" Inherits="PowerKSI.Instructors" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/>
    <div class="row">
        <div runat="server" id="divForm" Visible="False" class="col-md-8">
            <section id="textForm">
                <div class="form-horizontal">

                    <div class="form-group">
                        <div class="col-md-offset-3 col-md-9">
                            <asp:Label runat="server" ID="lblTitle" Font-Size="XX-Large" Text=""/>
                        </div>
                    </div>

                    <hr />
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="tbxFirstName" CssClass="col-md-3 control-label">First Name</asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox runat="server" ID="tbxFirstName" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="tbxFirstName"
                                CssClass="text-danger" ErrorMessage="The first name field is required." />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="tbxLastName" CssClass="col-md-3 control-label">Last Name</asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox runat="server" ID="tbxLastName" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="tbxLastName"
                                CssClass="text-danger" ErrorMessage="The last name field is required." />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="tbxUsername" CssClass="col-md-3 control-label">Username</asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox runat="server" ID="tbxUsername" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="tbxUsername"
                                CssClass="text-danger" ErrorMessage="The username field is required." />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="tbxEmail" CssClass="col-md-3 control-label">Email</asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox runat="server" ID="tbxEmail" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="tbxEmail"
                                CssClass="text-danger" ErrorMessage="The email field is required." />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="cbxIsAdmin" CssClass="col-md-3 control-label">Is Admin</asp:Label>
                        <div class="col-md-9">
                            <asp:CheckBox runat="server" ID="cbxIsAdmin"/>
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="cbxIsInstructor" CssClass="col-md-3 control-label">Is Instructor</asp:Label>
                        <div class="col-md-9">
                            <asp:CheckBox runat="server" ID="cbxIsInstructor"/>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-md-offset-3 col-md-9">
                            <asp:Button runat="server" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_OnClick" CssClass="btn btn-default" />
                            or 
                            <asp:LinkButton runat="server" ViewStateMode="Disabled" ID="lbtnCancel" OnClick="lbtnCancel_OnClick" CausesValidation="False">Cancel</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    </div>
    
    <hr />

    <div class="row">
        <div runat="server" id="divRadGrid" visible="True" class="col-md-12">
            <h2>Instructors</h2>
            <section id="gridFrom">
                <div style="text-align: right">
                    <asp:LinkButton runat="server" ViewStateMode="Disabled" ID="lbtnAddNew" OnClick="lbtnAddNew_OnClick">add new Instructor</asp:LinkButton>
                    <br />
                </div>
                <telerik:RadGrid ID="rgInstructors" runat="server" AutoGenerateColumns="False" GridLines="None" AllowSorting="true"
                    OnDeleteCommand="rgInstructors_DeleteCommand" OnSelectedCellChanged="rgInstructor_OnSelectedIndexChanged" AllowPaging="True" PageSize="25" OnNeedDataSource="rgInstructors_NeedDataSource" CellSpacing="0">
                    <SortingSettings EnableSkinSortStyles="false" />
                    <GroupingSettings CaseSensitive="False" />
                    <ClientSettings EnableRowHoverStyle="True" />
                    <FilterMenu EnableImageSprites="False" />

                    <MasterTableView DataKeyNames="Id" AllowFilteringByColumn="True" TableLayout="Auto">
                        <CommandItemSettings ShowExportToExcelButton="true" ShowAddNewRecordButton="false" ShowRefreshButton="false" />
                        <HeaderStyle HorizontalAlign="Left" Font-Bold="True" Wrap="False" />
                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column"
                            Visible="True">
                        </RowIndicatorColumn>
                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column"
                            Visible="True">
                        </ExpandCollapseColumn>
                        <Columns>
                            <telerik:GridBoundColumn DataField="FirstName" AutoPostBackOnFilter="True"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="First Name" ShowFilterIcon="False">
                                <ItemStyle Wrap="False" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="LastName" AutoPostBackOnFilter="True"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="Last Name" ShowFilterIcon="False">
                                <ItemStyle Wrap="False" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Email" AutoPostBackOnFilter="True"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="Email" ShowFilterIcon="False">
                                <ItemStyle Wrap="False" />
                            </telerik:GridBoundColumn>
                            <telerik:GridButtonColumn Text="edit" UniqueName="Edit" CommandName="Select">
                                <HeaderStyle Width="20px" />
                            </telerik:GridButtonColumn>
                            <telerik:GridButtonColumn UniqueName="Delete" CommandName="Delete" ConfirmText="Are you sure you want to delete the selected item?"
                                ButtonType="ImageButton">
                                <HeaderStyle Width="20px" />
                            </telerik:GridButtonColumn>
                        </Columns>
                        <EditFormSettings>
                            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                            </EditColumn>
                        </EditFormSettings>
                    </MasterTableView>
                </telerik:RadGrid><br />
            </section>
        </div>
    </div>

</asp:Content>
