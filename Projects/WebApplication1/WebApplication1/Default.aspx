<%@ Page Title="EOSTest" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>
<%@ Import Namespace="System.Data" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content id="form1" runat="server" ContentPlaceHolderID="MainContent">
    <asp:DropDownList id="dropList" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem></asp:ListItem>
            <asp:ListItem></asp:ListItem>
    </asp:DropDownList>
</asp:Content>

<script  runat="server" language="c#">


    /*protected void submit(object sender, EventArgs e)
    {
        this.mess.Text = "You selected: " + dropList.SelectedItem.Text;
        this.mess.Visible = true;
    }*/

     /*
    <asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
        <asp:DropDownList id="dropList" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem></asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <p><asp:label id="selected" runat="server"/></p>
</asp:Content>
    */
</script>