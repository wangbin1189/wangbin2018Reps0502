<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="PowerKSI.Student" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/>
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
                        <asp:Label runat="server" AssociatedControlID="tbxStudentId" CssClass="col-md-3 control-label">Student ID</asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox runat="server" ID="tbxStudentId" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="tbxStudentId"
                                CssClass="text-danger" ErrorMessage="The student ID field is required." />
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
                        <asp:Label runat="server" AssociatedControlID="ddlStatus" CssClass="col-md-3 control-label">Status</asp:Label>
                        <div class="col-md-9">
                            <asp:DropDownList runat="server" ID="ddlStatus" CssClass="form-control" Width="280px">
                                <Items>
                                    <asp:ListItem Value="Active"></asp:ListItem>
                                    <asp:ListItem Value="Withdrawn"></asp:ListItem>
                                    <asp:ListItem Value="Graduated"></asp:ListItem>
                                </Items>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="ddlStatus"
                                CssClass="text-danger" ErrorMessage="The status field is required." />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="cbxIsOnline" CssClass="col-md-3 control-label">Is Online</asp:Label>
                        <div class="col-md-9">
                            <asp:CheckBox runat="server" ID="cbxIsOnline"/>
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
            <h2>Students</h2>
            <section id="gridFrom">
                <div style="text-align: right">
                    <asp:LinkButton runat="server" ViewStateMode="Disabled" ID="lbtnAddNew" OnClick="lbtnAddNew_OnClick">add new Student</asp:LinkButton>
                    <br />
                </div>
                <telerik:RadGrid ID="rgStudent" runat="server" AutoGenerateColumns="False" GridLines="None" AllowSorting="true"
                    OnDeleteCommand="rgStudent_DeleteCommand" AllowPaging="True" PageSize="25" OnNeedDataSource="rgStudent_NeedDataSource" CellSpacing="0" OnSelectedIndexChanged="rgStudent_OnSelectedIndexChanged">
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
                            <telerik:GridBoundColumn DataField="Status" AutoPostBackOnFilter="True"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="Status" ShowFilterIcon="False">
                                <ItemStyle Wrap="False" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="IsOnline" AutoPostBackOnFilter="True"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="IsOnline" ShowFilterIcon="False">
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
