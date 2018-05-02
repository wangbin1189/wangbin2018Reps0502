<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GradeBookItem.aspx.cs" Inherits="PowerKSI.GradeBookItem" %>
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
                        <asp:Label runat="server" AssociatedControlID="tbxName" CssClass="col-md-3 control-label">Name</asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox runat="server" ID="tbxName" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="tbxName"
                                CssClass="text-danger" ErrorMessage="The name field is required." />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="tbxWeight" CssClass="col-md-3 control-label">Weight</asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox runat="server" ID="tbxWeight" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="tbxWeight"
                                CssClass="text-danger" ErrorMessage="The weight field is required." />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="tbxScore" CssClass="col-md-3 control-label">Full Score</asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox runat="server" ID="tbxScore" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="tbxScore"
                                CssClass="text-danger" ErrorMessage="The score field is required." />
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="ddlType" CssClass="col-md-3 control-label">Type</asp:Label>
                        <div class="col-md-9">
                            <asp:DropDownList runat="server" ID="ddlType" CssClass="form-control" Width="280px">
                                <Items>
                                    <asp:ListItem Value="Score"></asp:ListItem>
                                    <asp:ListItem Value="Letter"></asp:ListItem>
                                </Items>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="ddlType"
                                CssClass="text-danger" ErrorMessage="The type field is required." />
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
            <h2>Grade Items</h2>
            <section id="gridFrom">
                <div style="text-align: right">
                    <asp:LinkButton runat="server" ViewStateMode="Disabled" ID="lbtnAddNew" OnClick="lbtnAddNew_OnClick">add new item</asp:LinkButton>
                    <br />
                </div>
                <telerik:RadGrid ID="rgGradeItem" runat="server" AutoGenerateColumns="False" GridLines="None" AllowSorting="true"
                    OnDeleteCommand="rgGradeItem_DeleteCommand" AllowPaging="True" PageSize="25" OnNeedDataSource="rgGradeItem_NeedDataSource" CellSpacing="0">
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
                                HeaderText="Name" ShowFilterIcon="False">
                                <ItemStyle Wrap="False" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Type" AutoPostBackOnFilter="True"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="Type" ShowFilterIcon="False">
                                <ItemStyle Wrap="False" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="FullScore" AutoPostBackOnFilter="True"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="Full Score" ShowFilterIcon="False">
                                <ItemStyle Wrap="False" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Weight" AutoPostBackOnFilter="True"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="Weight" ShowFilterIcon="False">
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
