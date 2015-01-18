<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TodoItemView.ascx.cs" Inherits="UserControlStyle.UserControl.TodoItemView" %>

<div class="form-group">
    <asp:CheckBox ID="IsFinishedCheckBox" runat="server" CssClass="checkbox" Checked="<%# Data.IsFinished %>" />
    <asp:Label ID="NameLabel" runat="server" Text="<%# Data.Name %>" />
</div>