<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Course.aspx.cs" Inherits="PowerKSI.Course" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <style type="text/css">
        .bold {
            font-weight: bold;
        }
        .inline {
            display: inline !important;
        }
    </style>

    <br />
    <div class="row">
        <div runat="server" id="divForm" visible="False" class="col-md-8">
            <section id="textForm">
                <div class="form-horizontal">

                    <div class="form-group">
                        <div class="col-md-offset-3 col-md-9">
                            <asp:Label runat="server" ID="lbltitle" Font-Size="XX-Large" Text=""></asp:Label>
                        </div>
                    </div>

                    <hr />
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="tbxCourseNumber" CssClass="col-md-3 control-label">Course Number</asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox runat="server" ID="tbxCourseNumber" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="tbxCourseNumber"
                                CssClass="text-danger" ErrorMessage="The course number field is required." />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="tbxCourseTitle" CssClass="col-md-3 control-label">Title</asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox runat="server" ID="tbxCourseTitle" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="tbxCourseTitle"
                                CssClass="text-danger" ErrorMessage="The course title field is required." />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="tbxDescription" CssClass="col-md-3 control-label">Description</asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox runat="server" ID="tbxDescription" CssClass="form-control" TextMode="MultiLine" Rows="4" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="tbxDescription"
                                CssClass="text-danger" ErrorMessage="The course description field is required." />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="cbxHasPrerequisite" CssClass="col-md-3 control-label">Has Prerequisite</asp:Label>
                        <div class="col-md-9">
                            <asp:CheckBox runat="server" ID="cbxHasPrerequisite" AutoPostBack="True" OnCheckedChanged="cbxHasPrerequisite_OnCheckedChanged"/>
                        </div>
                    </div>
                    
                    <div class="form-group" runat="server" ID="divPrerequisite1" Visible="false">
                        <asp:Label runat="server" AssociatedControlID="ddlPrerequisite1a" CssClass="col-md-3 control-label">Prerequisite 1</asp:Label>
                        <div class="form-group row">
                            <div class="col-md-2">
                                <asp:DropDownList runat="server" ID="ddlPrerequisite1a" CssClass="form-control inline" />
                            </div>
                            <label class="col-md-1 control-label">or</label>
                            <div class="col-md-2">
                                <asp:DropDownList runat="server" ID="ddlPrerequisite1b" CssClass="form-control inline"/>
                            </div>
                            <label class="col-md-1 control-label">or</label>
                            <div class="col-md-2">
                                <asp:DropDownList runat="server" ID="ddlPrerequisite1c" CssClass="form-control" />
                            </div>
                        </div>
                    </div>
                    
                    <div class="form-group" runat="server" ID="divPrerequisite2" Visible="false">
                        <asp:Label runat="server" AssociatedControlID="ddlPrerequisite2a" CssClass="col-md-3 control-label">Prerequisite 2</asp:Label>
                        <div class="form-group row">
                            <div class="col-md-2">
                                <asp:DropDownList runat="server" ID="ddlPrerequisite2a" CssClass="form-control inline" />
                            </div>
                            <label class="col-md-1 control-label">or</label>
                            <div class="col-md-2">
                                <asp:DropDownList runat="server" ID="ddlPrerequisite2b" CssClass="form-control inline"/>
                            </div>
                            <label class="col-md-1 control-label">or</label>
                            <div class="col-md-2">
                                <asp:DropDownList runat="server" ID="ddlPrerequisite2c" CssClass="form-control" />
                            </div>
                        </div>
                    </div>
                    
                    <div class="form-group" runat="server" ID="divPrerequisite3" Visible="false">
                        <asp:Label runat="server" AssociatedControlID="ddlPrerequisite3a" CssClass="col-md-3 control-label">Prerequisite 3</asp:Label>
                        <div class="form-group row">
                            <div class="col-md-2">
                                <asp:DropDownList runat="server" ID="ddlPrerequisite3a" CssClass="form-control inline" />
                            </div>
                            <label class="col-md-1 control-label">or</label>
                            <div class="col-md-2">
                                <asp:DropDownList runat="server" ID="ddlPrerequisite3b" CssClass="form-control inline"/>
                            </div>
                            <label class="col-md-1 control-label">or</label>
                            <div class="col-md-2">
                                <asp:DropDownList runat="server" ID="ddlPrerequisite3c" CssClass="form-control" />
                            </div>
                        </div>
                    </div>
                    
                    <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="rauSyllabus" CssClass="col-md-3 control-label">Syllabus</asp:Label>
                    <div class="col-md-9">
                        <telerik:RadAsyncUpload runat="server" ID="rauSyllabus" MultipleFileSelection="Disabled" MaxFileInputsCount="1"
                            UploadedFilesRendering="BelowFileInput" Localization-Select="Attachments">
                        </telerik:RadAsyncUpload>
                        <asp:Repeater ID="rptSyllabus" runat="server" OnItemDataBound="rptSyllabus_ItemDataBound">
                            <HeaderTemplate>
                                <ul style="margin-top: 0px;">
                            </HeaderTemplate>
                            <ItemTemplate>
                                <li>
                                    <asp:HyperLink runat="server" ID="lnkSyllabus" Target="_blank" ForeColor="Blue"></asp:HyperLink>
                                    -
	                         			<asp:LinkButton runat="server" id="lnkSyllabusDelete" text="delete"
                                             forecolor="Red" font-size="smaller" confirmmessage="Are you sure you want to delete?"
                                             OnClick="lnkSyllabusDelete_OnClick" commandname="Delete"></asp:LinkButton>
                                </li>
                            </ItemTemplate>
                            <FooterTemplate>
                                </ul>
                            </FooterTemplate>
                        </asp:Repeater>
                    </div>
                        </div>

                    <br/>

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
            <h2>Courses</h2>
            <section id="gridFrom">
                <div style="text-align: right">
                    <asp:LinkButton runat="server" ViewStateMode="Disabled" ID="lbtnAddNew" OnClick="lbtnAddNew_OnClick">add new course</asp:LinkButton>
                    <br />
                </div>
                <telerik:RadGrid ID="rgCourses" runat="server" AutoGenerateColumns="False" GridLines="None" AllowSorting="true"
                    OnDeleteCommand="rgCourses_DeleteCommand" AllowPaging="True" PageSize="25" OnNeedDataSource="rgCourses_NeedDataSource" CellSpacing="0">
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
                            <telerik:GridBoundColumn DataField="CourseNumber" AutoPostBackOnFilter="True"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="Course Number" ShowFilterIcon="False">
                                <ItemStyle Wrap="False" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Title" AutoPostBackOnFilter="True"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="Title" ShowFilterIcon="False">
                                <ItemStyle Wrap="False" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Description" AutoPostBackOnFilter="True"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="Description" ShowFilterIcon="False">
                                <ItemStyle Wrap="False" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="HasPrerequisite" AutoPostBackOnFilter="True"
                                FilterControlWidth="100px" ShowSortIcon="False"
                                HeaderText="Has Prereq." ShowFilterIcon="False">
                                <ItemStyle Wrap="False" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Prerequisite1" AutoPostBackOnFilter="True"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="Prerequisite1" ShowFilterIcon="False">
                                <ItemStyle Wrap="False" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Prerequisite2" AutoPostBackOnFilter="True"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="Prerequisite2" ShowFilterIcon="False">
                                <ItemStyle Wrap="False" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Prerequisite3" AutoPostBackOnFilter="True"
                                CurrentFilterFunction="Contains" FilterControlWidth="100px"
                                HeaderText="Prerequisite3" ShowFilterIcon="False">
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
