<%@ Page Title="管理员登录" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Admin_AdLogin" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4>管理员登录</h4>
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="AdUserName" CssClass="col-md-2 control-label">用户名</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="AdUserName" CssClass="form-control" />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="AdPassword" CssClass="col-md-2 control-label">密码</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="AdPassword" TextMode="Password" CssClass="form-control" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" Text="登录" CssClass="btn btn-default" OnClick="Admin_Click" ID="Button1" />
                        </div>
                    </div>
                </div>
            </section>
        </div>

    </div>
</asp:Content>
