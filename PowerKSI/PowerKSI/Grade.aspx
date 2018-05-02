<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Grade.aspx.cs" Inherits="PowerKSI.Grade" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <br />
    <h2>Gradebook</h2>

    <div style="padding: 10px 5px;" class="ui-state-highlight ">
        <div class="yui3-g">
            
                Class : 
			<asp:DropDownList runat="server" ID="ddlOffering" AppendDataBoundItems="True" AutoPostBack="True"
                OnSelectedIndexChanged="ddlOffering_SelectedIndexChanged">
                <Items>
                    <asp:ListItem Value="CIS510"></asp:ListItem>
                </Items>
            </asp:DropDownList>
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
                <telerik:GridTemplateColumn AllowFiltering="False" HeaderText="Midterm" DataField="AttendanceCodeId" UniqueName="Midterm"
                    CurrentFilterFunction="Contains" FilterControlWidth="99px">
                    <ItemTemplate>
                        <asp:TextBox runat="server" ID="tbxAssignment1"></asp:TextBox>
                    </ItemTemplate>
                </telerik:GridTemplateColumn>
                <telerik:GridTemplateColumn AllowFiltering="False" HeaderText="Final" DataField="AttendanceCodeId" UniqueName="Final">
                    <ItemTemplate>
                        <asp:TextBox runat="server" ID="tbxAssignment2"></asp:TextBox>
                    </ItemTemplate>
                </telerik:GridTemplateColumn>
                <telerik:GridTemplateColumn AllowFiltering="False" HeaderText="Assignment 1" DataField="AttendanceCodeId" UniqueName="Assignment1">
                    <ItemTemplate>
                        <asp:TextBox runat="server" ID="tbxAssignment3"></asp:TextBox>
                    </ItemTemplate>
                </telerik:GridTemplateColumn>
                <telerik:GridTemplateColumn AllowFiltering="False" HeaderText="Assignment 2" DataField="AttendanceCodeId" UniqueName="Assignment2">
                    <ItemTemplate>
                        <asp:TextBox runat="server" ID="tbxAssignment4"></asp:TextBox>
                    </ItemTemplate>
                </telerik:GridTemplateColumn>
                <telerik:GridBoundColumn AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" AllowFiltering="False"
                    DataField="FinalGrade" FilterControlWidth="99px" HeaderText="Computer Grade" ShowFilterIcon="False"
                    UniqueName="FinalGrade">
                    <ItemStyle Wrap="False" />
                </telerik:GridBoundColumn>
                <telerik:GridTemplateColumn AllowFiltering="False" HeaderText="Final Grade" DataField="AttendanceCodeId" UniqueName="Assignment2">
                    <ItemTemplate>
                        <asp:TextBox runat="server" ID="FinalGrade"></asp:TextBox>
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
