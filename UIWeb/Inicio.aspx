<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="UIWeb.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        LISTA SOCIOS&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="158px" Width="1059px"></asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnVerSocio" runat="server" Text="VER SOCIO"  Width="226px" OnClick="btnVerSocio_Click" />
        <br />
        <br />
        LISTA ACTIVIDADES<br />
        <asp:ListBox ID="ListBox2" runat="server" Height="159px" Width="1059px"></asp:ListBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnVerAct" runat="server" Text="VER ACTIVIDAD" OnClick="btnVerAct_Click" />
        <br />
&nbsp;<br />
        LISTA PROFESORES<br />
        <asp:ListBox ID="ListBox3" runat="server" Height="162px" Width="1063px"></asp:ListBox>
&nbsp;&nbsp;
        <asp:Button ID="btnVerProf" runat="server" Text="VER PROFESOR" OnClick="btnVerProf_Click" />
    </form>
</body>
</html>
