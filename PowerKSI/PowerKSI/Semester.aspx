<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Semester.aspx.cs" Inherits="PowerKSI.Semester" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style type="text/css">
        .bold {
            font-weight: bold;
        }
    </style>

    <br />
    <div class="row">
        <div runat="server" id="divForm" Visible="False" class="col-md-8">
            <section id="textForm">
                <div class="form-horizontal">

                    <div class="form-group">
                        <div class="col-md-offset-3 col-md-9">
                            <asp:Label runat="server" ID="lbltitle" Font-Size="XX-Large" Text=""/>
                        </div>
                    </div>

                    <hr />
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="tbxSemesterName" CssClass="col-md-3 control-label">Semester Name</asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox runat="server" ID="tbxSemesterName" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="tbxSemesterName"
                                CssClass="text-danger" ErrorMessage="The semester name field is required." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-3 control-label bold">Start Date</asp:Label>
                        <div class="col-md-9">
                            <telerik:RadDatePicker runat="server" ID="rdpStartDate"></telerik:RadDatePicker>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-3 control-label bold">End Date</asp:Label>
                        <div class="col-md-9">
                            <telerik:RadDatePicker runat="server" ID="rdpEndDate"></telerik:RadDatePicker>
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
            <h2>Semesters</h2>
            <section id="gridFrom">
                <div style="text-align: right">
                        <asp:LinkButton runat="server" ViewStateMode="Disabled" ID="lbtnAddNew" OnClick="lbtnAddNew_OnClick">add new semester</asp:LinkButton> <br/>
                </div>
                <telerik:RadGrid ID="rgSemesters" runat="server" AutoGenerateColumns="False" GridLines="None" AllowSorting="true"
                    OnDeleteCommand="rgSemesters_DeleteCommand" AllowPaging="True" PageSize="25" OnNeedDataSource="rgSemesters_NeedDataSource" CellSpacing="0">
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
                            <telerik:GridBoundColumn DataField="Name" AutoPostBackOnFilter="True"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="Semester Name" ShowFilterIcon="False">
                                <ItemStyle Wrap="False" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="StartDate" AutoPostBackOnFilter="True" DataFormatString="{0:MM/dd/yyyy}"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="Start Date" ShowFilterIcon="True">
                                <ItemStyle Wrap="False" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="EndDate" AutoPostBackOnFilter="True" DataFormatString="{0:MM/dd/yyyy}"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="End Date" ShowFilterIcon="True">
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
