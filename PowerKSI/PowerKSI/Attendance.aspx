<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Attendance.aspx.cs" Inherits="PowerKSI.Attendance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h2>Attendance</h2>

    <div style="padding: 10px 5px;" class="ui-state-highlight ">
        <div class="yui3-g">
            <div class="yui3-u-3-5">
                Date : 
			   <telerik:RadDatePicker ID="rdpDate" runat="server" Width="100px" ShowPopupOnFocus="True" AutoPostBack="True" OnSelectedDateChanged="rdpDate_textChanged">
                   <Calendar ShowRowHeaders="false" runat="server">
                       <SpecialDays>
                           <telerik:RadCalendarDay Repeatable="Today" ItemStyle-Font-Bold="True">
                           </telerik:RadCalendarDay>
                       </SpecialDays>
                   </Calendar>
               </telerik:RadDatePicker>
                Class : 
			<asp:DropDownList runat="server" ID="ddlOffering" AppendDataBoundItems="True" AutoPostBack="True"
                OnSelectedIndexChanged="ddlOffering_SelectedIndexChanged">
                <Items>
                    <asp:ListItem Value="CIS510"></asp:ListItem>
                </Items>
            </asp:DropDownList>
            </div>
        </div>
    </div>

    <telerik:RadGrid ID="rg1" runat="server" GridLines="None" AutoGenerateColumns="False" AllowSorting="True"
        AllowPaging="True" PageSize="33" OnNeedDataSource="rg1_NeedDataSource" OnItemDataBound="rg1_ItemDataBound"
        AllowFilteringByColumn="True" CellSpacing="0">
        <ClientSettings AllowColumnsReorder="True" EnableRowHoverStyle="True" ColumnsReorderMethod="Reorder" />
        <GroupingSettings CaseSensitive="False" />
        <MasterTableView DataKeyNames="">
            <Columns>
                <telerik:GridBoundColumn AutoPostBackOnFilter="True" CurrentFilterFunction="Contains"
                    DataField="FirstName" FilterControlWidth="99px" HeaderText="Student" ShowFilterIcon="False"
                    UniqueName="Student">
                    <ItemStyle Wrap="False" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn CurrentFilterFunction="Contains" DataField="AbsentCount"
                    FilterControlWidth="33px" HeaderText="Abs." ShowFilterIcon="True" UniqueName="AbsentCount">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn CurrentFilterFunction="Contains" DataField="TardyCount"
                    FilterControlWidth="33px" HeaderText="Trd." ShowFilterIcon="True" UniqueName="TardyCount">
                </telerik:GridBoundColumn>
                <telerik:GridTemplateColumn AllowFiltering="False" DataField="AttendanceCodeId" UniqueName="AttendanceCodeId">
                    <ItemTemplate>
                        <asp:DropDownList runat="server" ID="ddlAttendanceCode" />
                    </ItemTemplate>
                </telerik:GridTemplateColumn>
                <telerik:GridTemplateColumn AutoPostBackOnFilter="True" HeaderText="Notes" CurrentFilterFunction="Contains"
                    DataField="Notes" FilterControlWidth="133px" ShowFilterIcon="False" UniqueName="Notes">
                    <ItemTemplate>
                        <asp:TextBox ID="tbxNotes" runat="server" MaxLength="100" Width="96%" />
                    </ItemTemplate>
                </telerik:GridTemplateColumn>
            </Columns>
        </MasterTableView>
    </telerik:RadGrid>
    <br/>
    <div class="form-group">
        <div class="col-md-offset-3 col-md-9">
            <asp:Button runat="server" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_OnClick" CssClass="btn btn-default" />
            or 
                            <asp:LinkButton runat="server" ViewStateMode="Disabled" ID="lbtnCancel" OnClick="lbtnCancel_OnClick" CausesValidation="False">Cancel</asp:LinkButton>
        </div>
    </div>
</asp:Content>
