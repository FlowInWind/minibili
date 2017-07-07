﻿<%@ Page Title="查看用户信息" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Admin_UserManage_Search" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p style="font-size: x-large">
        <strong>输入要搜索的用户信息：</strong></p>
    <p style="font-size: x-large">
        <table style="width:100%;">
            <tr>
                <td class="text-center">
                    <asp:TextBox ID="TextBox1" runat="server" style="font-size: small" Width="221px"></asp:TextBox>
                    <asp:DropDownList ID="DropDownList1" runat="server" style="font-size: small">
                        <asp:ListItem Selected="True">ID</asp:ListItem>
                        <asp:ListItem>用户名</asp:ListItem>
                        <asp:ListItem>昵称</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="SearchUser" runat="server" style="font-size: small" Text="搜索" OnClick="SearchUser_Click" />
                </td>
            </tr>
        </table>
    </p>
    <p style="font-size: x-large">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateDeleteButton="True" Width="737px" OnRowDeleting="GridView1_RowDeleting" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT [Id], [UserName], [Passwd] FROM [AspNetUser]"  DeleteCommand="delete from [AspNetUser] where Id = [Id]"></asp:SqlDataSource>
    <p style="font-size: x-large">
        &nbsp;
</asp:Content>