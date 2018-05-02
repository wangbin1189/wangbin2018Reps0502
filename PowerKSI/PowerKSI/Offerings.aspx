<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Offerings.aspx.cs" Inherits="PowerKSI.Offerings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="row">
        <div runat="server" id="divForm" visible="False" class="col-md-8">
            <section id="textForm">
                <div class="form-horizontal">

                    <div class="form-group">
                        <div class="col-md-offset-3 col-md-9">
                            <asp:Label runat="server" ID="lblTitle" Font-Size="XX-Large" Text="" />
                        </div>
                    </div>

                    <hr />
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="ddlSemester" CssClass="col-md-3 control-label">Semester</asp:Label>
                        <div class="col-md-9">
                            <asp:DropDownList runat="server" ID="ddlSemester" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="ddlSemester"
                                CssClass="text-danger" ErrorMessage="Semester is required." />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="ddlCourse" CssClass="col-md-3 control-label">Course</asp:Label>
                        <div class="col-md-9">
                            <asp:DropDownList runat="server" ID="ddlCourse" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="ddlCourse"
                                CssClass="text-danger" ErrorMessage="Course is required." />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="ddlPrimaryInstructor" CssClass="col-md-3 control-label"> Primary Instructor</asp:Label>
                        <div class="col-md-9">
                            <asp:DropDownList runat="server" ID="ddlPrimaryInstructor" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="ddlPrimaryInstructor"
                                CssClass="text-danger" ErrorMessage="Primary Intructor is required." />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="ddlSecondaryInstructor" CssClass="col-md-3 control-label">Secondary Instructor</asp:Label>
                        <div class="col-md-9">
                            <asp:DropDownList runat="server" ID="ddlSecondaryInstructor" CssClass="form-control" />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="tbxCapacity" CssClass="col-md-3 control-label">Capacity</asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox runat="server" ID="tbxCapacity" TextMode="Number" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="tbxCapacity"
                                CssClass="text-danger" ErrorMessage="Capacity is required." />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="tbxRoom" CssClass="col-md-3 control-label">Room Number</asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox runat="server" ID="tbxRoom" CssClass="form-control"></asp:TextBox>
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
            <h2>Offerings</h2>
            <section id="gridFrom">
                <div style="text-align: right">
                    <asp:LinkButton runat="server" ViewStateMode="Disabled" ID="lbtnAddNew" OnClick="lbtnAddNew_OnClick">Create new Offering</asp:LinkButton>
                    <br />
                </div>
                <telerik:RadGrid ID="rgOfferings" runat="server" AutoGenerateColumns="False" GridLines="None" AllowSorting="true"
                    OnDeleteCommand="rgOfferings_DeleteCommand" AllowPaging="True" PageSize="25" OnNeedDataSource="rgOfferings_NeedDataSource" CellSpacing="0">
                    <SortingSettings EnableSkinSortStyles="false" />
                    <GroupingSettings CaseSensitive="False" />
                    <ClientSettings EnableRowHoverStyle="True" />
                    <FilterMenu EnableImageSprites="False" />

                    <MasterTableView DataKeyNames="" AllowFilteringByColumn="True" TableLayout="Auto">
                        <CommandItemSettings ShowExportToExcelButton="true" ShowAddNewRecordButton="false" ShowRefreshButton="false" />
                        <HeaderStyle HorizontalAlign="Left" Font-Bold="True" Wrap="False" />
                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column"
                            Visible="True">
                        </RowIndicatorColumn>
                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column"
                            Visible="True">
                        </ExpandCollapseColumn>
                        <Columns>
                            <telerik:GridBoundColumn DataField="SemesterId" AutoPostBackOnFilter="True"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="Semester" ShowFilterIcon="False">
                                <ItemStyle Wrap="False" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="CourseId" AutoPostBackOnFilter="True"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="Course" ShowFilterIcon="False">
                                <ItemStyle Wrap="False" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="InstructorId" AutoPostBackOnFilter="True"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="Instructor" ShowFilterIcon="False">
                                <ItemStyle Wrap="False" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Instructor2Id" AutoPostBackOnFilter="True"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="Instructor 2" ShowFilterIcon="False">
                                <ItemStyle Wrap="False" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Capacity" AutoPostBackOnFilter="True"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="Capacity" ShowFilterIcon="False">
                                <ItemStyle Wrap="False" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="RoomNumber" AutoPostBackOnFilter="True"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="Room" ShowFilterIcon="False">
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
