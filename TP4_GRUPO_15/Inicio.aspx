<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="TP4_GRUPO_15.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style5 {
            width: 145px;
        }
        .auto-style6 {
            text-align: center;
            width: 145px;
        }
        .auto-style7 {
        }
        .auto-style8 {
            text-align: center;
            width: 160px;
        }
        .auto-style9 {
            width: 146px;
        }
        .auto-style10 {
            text-align: center;
            width: 146px;
        }
        .auto-style11 {
            height: 28px;
        }
        .auto-style12 {
            width: 145px;
            height: 28px;
        }
        .auto-style13 {
            width: 160px;
            height: 28px;
        }
        .auto-style14 {
            width: 146px;
            height: 28px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td colspan="3" style="text-align: center">
                        <asp:Label ID="LBL_Title" runat="server" Font-Bold="True" Font-Size="16pt" Text="Menú Inicio"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style6">
                        <asp:Button ID="BTN_EJ1" runat="server" Text="Ejercicio 1" OnClick="BTN_EJ1_Click" />
                    </td>
                    <td class="auto-style8">
                        <asp:Button ID="BTN_EJ2" runat="server" Text="Ejercicio 2" OnClick="BTN_EJ2_Click" />
                    </td>
                    <td class="auto-style10">
                        <asp:Button ID="BTN_EJ3" runat="server" Text="Ejercicio 3" OnClick="BTN_EJ3_Click" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style11"></td>
                    <td class="auto-style12">
                        <asp:Label ID="LBL_Integrantes" runat="server" Font-Bold="True" Text="Integrantes:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style13"><span style="color: rgb(33, 37, 41); font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; font-size: 11px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgba(0, 0, 0, 0.075); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">
                        <br />
                        <br />
                        </span></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style11"></td>
                    <td class="auto-style11"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style7">Blanarik, Francisco</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style7">Castro, Jonathan</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style7" colspan="2">Mareco, Ezequiel Alejandro</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style7">Pericles, Emilse Narela</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style7">Piccioni, Nicolás Gabriel</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style7">Gentile, Bruno</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
