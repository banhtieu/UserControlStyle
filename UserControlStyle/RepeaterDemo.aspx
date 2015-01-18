<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="RepeaterDemo.aspx.cs" Inherits="UserControlStyle.RepeaterDemo" %>

<%@ Register src="UserControl/TodoItemView.ascx" tagname="TodoItemView" tagprefix="bt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <h1>Demo a List With Repeater</h1>    
    <div class="form-group">
        <asp:Repeater ID="TodoList" runat="server">
            <ItemTemplate>
                <bt:TodoItemView ID="Item" runat="server" Data="<%# Container.DataItem %>" />
            </ItemTemplate>
        </asp:Repeater>
        
    </div>
    <div class="form-group">
        <asp:Button ID="SaveButton" runat="server" 
            CssClass="btn but-default btn-primary" 
            Text="Check Back"
            OnClick="SaveButton_Click" />
    </div>
    <div class="form-group">
        <asp:Label ID="MessageLabel" runat="server" />
    </div>
</asp:Content>
