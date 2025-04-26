<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP4_GRUPO_15.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio 1</title>
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
            width: 474px;
        }
        .auto-style5 {
            width: 140px;
        }
        .auto-style6 {
            height: 40px;
            width: 140px;
        }
        .auto-style7 {
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
            width: 474px;
        }
        .auto-style21 {
            width: 80px;
            height: 23px;
        }
        .auto-style22 {
            width: 140px;
            height: 23px;
        }
        .auto-style23 {
            width: 150px;
            height: 23px;
        }
        .auto-style24 {
            height: 23px;
            width: 474px;
        }
        .auto-style25 {
            width: 140px;
            font-weight: bold;
        }
        .auto-style26 {
            width: 140px;
            font-weight: bold;
            height: 23px;
        }
        .auto-style27 {
            width: 140px;
            text-decoration: underline;
        }
        .auto-style28 {
            width: 474px;
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
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style28">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style6">
                        <asp:Label ID="LBL_DestinoInicio" runat="server" Font-Underline="True" Text="DESTINO INICIO"></asp:Label>
                    </td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style17"></td>
                    <td class="auto-style18">
                        <asp:Label ID="LBL_Provincia1" runat="server" Font-Bold="True" Text="PROVINCIA:"></asp:Label>
                    </td>
                    <td class="auto-style19">
                        <asp:DropDownList ID="DDL_Provincia1" runat="server" AutoPostBack="true"
                            OnSelectedIndexChanged="DDL_Provincia1_SelectedIndexChanged" Height="16px" Width="130px">
                            <asp:ListItem>--Seleccionar--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style19">
                        <asp:RequiredFieldValidator ID="rfvProvInicio" runat="server" ControlToValidate="DDL_Provincia1" InitialValue="--Seleccionar--">Seleccione una provincia</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td class="auto-style20">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style17"></td>
                    <td class="auto-style18">
                        <asp:Label ID="LBL_Localidad1" runat="server" Font-Bold="True" Text="LOCALIDAD:"></asp:Label>
                    </td>
                    <td class="auto-style19">
                        <asp:DropDownList ID="DDL_Localidad1" runat="server" Height="16px" Width="130px" style="margin-bottom: 0px" AutoPostBack="true" OnSelectedIndexChanged="DDL_Localidad1_SelectedIndexChanged">
                            <asp:ListItem>--Seleccionar--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style19">
                        <asp:RequiredFieldValidator ID="rfvLocInicio" runat="server" ControlToValidate="DDL_Localidad1" InitialValue="--Seleccionar--">Seleccione una localidad</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td class="auto-style20">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style21"></td>
                    <td class="auto-style22"></td>
                    <td class="auto-style23"></td>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style24"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style27">DESTINO FINAL</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style28">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style21"></td>
                    <td class="auto-style22"><strong>PROVINCIA:</strong></td>
                    <td class="auto-style23">
                        <asp:DropDownList ID="ddlProvinciaFinal" runat="server" AutoPostBack="true"
                            OnSelectedIndexChanged="ddlProvinciaFinal_SelectedIndexChanged" Height="21px" Width="130px">
                            <asp:ListItem>--Seleccionar--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style23">
                        &nbsp;</td>
                    <td class="auto-style23">
                        &nbsp;</td>
                    <td class="auto-style24"></td>
                </tr>
                <tr>
                    <td class="auto-style21"></td>
                    <td class="auto-style22"><strong>LOCALIDAD:</strong></td>
                    <td class="auto-style23">
                        <asp:DropDownList ID="ddlLocalidadFinal" runat="server" AutoPostBack="true" Height="18px" Width="130px" OnSelectedIndexChanged="ddlLocalidadFinal_SelectedIndexChanged">
                            <asp:ListItem>--Seleccionar--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style23">
                        &nbsp;</td>
                    <td class="auto-style23">
                        &nbsp;</td>
                    <td class="auto-style24"></td>
                </tr>
                <tr>
                    <td class="auto-style21"></td>
                    <td class="auto-style26"></td>
                    <td class="auto-style23"></td>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style24"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style25">&nbsp;</td>
                    <td class="auto-style7" colspan="4">
                        <asp:Label ID="lblDistancia" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Button ID="btnRestablecerSelecciones" runat="server" OnClick="btnRestablecerSelecciones_Click" Text="Restablecer selecciones" />
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style28">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style28">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style28">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
