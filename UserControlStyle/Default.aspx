<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UserControlStyle.Default" %>
<%@ Register src="UserControl/TodoItemView.ascx" tagname="TodoItemView" tagprefix="bt" %>
<%@ Register src="UserControl/TodoItemEditor.ascx" tagname="TodoItemEditor" tagprefix="bt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <h1>Demo with Single item</h1>    
    <div class="form-group">
        <h2>Item Without Reading Data</h2>
        <bt:TodoItemView ID="TodoItemView" runat="server" Data="<%# Item1 %>" />
    </div>
    <div class="form-group">
        <h2>Item With Reading Data Back</h2>
        <bt:TodoItemEditor ID="SecondItemView" runat="server" Data="<%# Item2 %>" />
        <div class="form-group">
            <asp:Button ID="SaveButton" runat="server" 
                CssClass="btn but-default btn-primary" 
                Text="Check Back"
                OnClick="SaveButton_Click" />
        </div>
        <div class="form-group">
            <asp:Label ID="MessageLabel" runat="server" />
        </div>
    </div>
</asp:Content>
