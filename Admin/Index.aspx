<%@ Page Title="查看用户信息" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Admin_UserManage_Search" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p style="font-size: x-large">
        <strong>选择您的操作：</strong></p>
<p style="font-size: x-large">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/UserManage/Index.aspx" style="font-size: medium">用户信息管理</asp:HyperLink>
</p>
<p style="font-size: x-large" class="text-left">
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Admin/VideoManage/Index.aspx" style="font-size: medium">视频信息管理</asp:HyperLink>
</p>
<p style="font-size: x-large" class="text-right">
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click1" style="font-size: medium">注销</asp:LinkButton>
</p>
</asp:Content>
