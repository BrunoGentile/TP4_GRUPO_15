<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3b.aspx.cs" Inherits="TP4_GRUPO_15.Ejercicio3b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 144px;
        }
        .auto-style3 {
            height: 35px;
        }
        .auto-style4 {
            height: 35px;
        }
        .auto-style5 {
            width: 144px;
            height: 150px;
        }
        .auto-style6 {
            height: 150px;
        }
        .auto-style7 {
            width: 144px;
            height: 23px;
        }
        .auto-style8 {
            height: 23px;
        }
        .auto-style12 {
            height: 150px;
            width: 60px;
        }
        .auto-style13 {
            width: 60px;
        }
        .auto-style14 {
            height: 23px;
            width: 60px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3" colspan="5">
                        <asp:Label ID="lblListado" runat="server" Text="Listado de libros:" Font-Bold="False"></asp:Label>
                    </td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:GridView ID="gvLibros" runat="server">
                        </asp:GridView>
                    </td>
                    <td class="auto-style12"></td>
                    <td class="auto-style12"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:LinkButton ID="lbConsultaTema" runat="server" OnClick="lbConsultaTema_Click">Consultar otro tema</asp:LinkButton>
                    </td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
