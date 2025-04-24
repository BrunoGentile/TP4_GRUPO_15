<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP4_GRUPO_15.Ejercicio1" %>

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
            width: 80px;
        }
        .auto-style3 {
            width: 80px;
            height: 40px;
        }
        .auto-style4 {
            height: 40px;
        }
        .auto-style5 {
            width: 140px;
        }
        .auto-style6 {
            height: 40px;
            width: 140px;
        }
        .auto-style7 {
            width: 150px;
        }
        .auto-style8 {
            height: 40px;
            width: 150px;
        }
        .auto-style17 {
            width: 80px;
            height: 25px;
        }
        .auto-style18 {
            width: 140px;
            height: 25px;
        }
        .auto-style19 {
            width: 150px;
            height: 25px;
        }
        .auto-style20 {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style6">
                        <asp:Label ID="LBL_DestinoInicio" runat="server" Font-Underline="True" Text="DESTINO INICIO"></asp:Label>
                    </td>
                    <td class="auto-style8"></td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style17"></td>
                    <td class="auto-style18">
                        <asp:Label ID="LBL_Provincia1" runat="server" Font-Bold="True" Text="PROVINCIA:"></asp:Label>
                    </td>
                    <td class="auto-style19">
                        <asp:DropDownList ID="DDL_Provincia1" runat="server" Height="16px" Width="130px">
                            <asp:ListItem>--Seleccionar--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style20"></td>
                </tr>
                <tr>
                    <td class="auto-style17"></td>
                    <td class="auto-style18">
                        <asp:Label ID="LBL_Localidad1" runat="server" Font-Bold="True" Text="LOCALIDAD:"></asp:Label>
                    </td>
                    <td class="auto-style19">
                        <asp:DropDownList ID="DDL_Localidad1" runat="server" Height="16px" Width="130px">
                            <asp:ListItem>--Seleccionar--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style20"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
