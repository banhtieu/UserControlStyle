<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TodoItemEditor.ascx.cs" Inherits="UserControlStyle.UserControl.TodoItemEdit" %>

<div class="form-group">
    <asp:HiddenField ID="IdHiddenField" runat="server" Value="<%# Data.Id %>" />
    <asp:CheckBox ID="IsFinishedCheckBox" runat="server" CssClass="checkbox" Checked="<%# Data.IsFinished %>" />
    <asp:TextBox ID="NameTextBox" runat="server" Text="<%# Data.Name %>" />
</div>