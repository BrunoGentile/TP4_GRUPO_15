﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP4_GRUPO_15.Ejercicio2" %>

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
        }
        .auto-style4 {
            width: 233px;
        }
        .auto-style5 {
            width: 94px;
        }
        .auto-style6 {
            width: 85px;
            height: 28px;
        }
        .auto-style7 {
            width: 101px;
            height: 28px;
        }
        .auto-style8 {
            height: 23px;
        }
        .auto-style9 {
            width: 95px;
            height: 23px;
        }
        .auto-style10 {
            width: 94px;
            height: 23px;
        }
        .auto-style11 {
            width: 233px;
            height: 23px;
        }
        .auto-style16 {
            height: 28px;
        }
        .auto-style17 {
            width: 94px;
            height: 28px;
        }
        .auto-style18 {
            height: 40px;
        }
        .auto-style19 {
            width: 95px;
            height: 40px;
        }
        .auto-style20 {
            width: 94px;
            height: 40px;
        }
        .auto-style21 {
            width: 233px;
            height: 40px;
        }
        .auto-style22 {
            height: 10px;
        }
        .auto-style23 {
            width: 94px;
            height: 10px;
        }
        .auto-style24 {
            width: 233px;
            height: 10px;
        }
        .auto-style25 {
            height: 36px;
        }
        .auto-style26 {
            width: 95px;
            height: 36px;
        }
        .auto-style27 {
            width: 94px;
            height: 36px;
        }
        .auto-style28 {
            width: 233px;
            height: 36px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4" colspan="2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25"></td>
                <td class="auto-style26">
                    <asp:Label ID="lblProducto" runat="server" Text="Id Producto: "></asp:Label>
                </td>
                <td class="auto-style27">
                    <asp:DropDownList ID="ddlProducto" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style28" colspan="2">
                    <asp:TextBox ID="txtProducto" runat="server" Width="214px"></asp:TextBox>
                </td>
                <td class="auto-style25">
                    <asp:CompareValidator ID="cvProducto" runat="server" ControlToValidate="txtProducto" Operator="GreaterThan" Type="Integer" ValueToCompare="0" ErrorMessage="No ingresó el código de producto correctamente" ValidationGroup="ValSum">Ingrese una cantidad valida</asp:CompareValidator>
                    <br />
                    <asp:Label ID="lblIdProducto" runat="server"></asp:Label>
                </td>
                <td class="auto-style25"></td>
                <td class="auto-style25"></td>
            </tr>
            <tr>
                <td class="auto-style8"></td>
                <td class="auto-style9"></td>
                <td class="auto-style10"></td>
                <td class="auto-style11" colspan="2"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="lblCategoria" runat="server" Text="IdCategoria: "></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:DropDownList ID="ddlCategoria" runat="server" OnSelectedIndexChanged="ddlCategoria_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style4" colspan="2">
                    <asp:TextBox ID="txtCategoria" runat="server" Width="211px"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="cvCategoria" runat="server" ControlToValidate="txtCategoria" Operator="GreaterThan" Type="Integer" ValueToCompare="0" ErrorMessage="No ingresó el código de categoría correcto" ValidationGroup="ValSum">Ingrese una cantidad valida</asp:CompareValidator>
                    <br />
                    <asp:Label ID="lblIdCategoria" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style16"></td>
                <td class="auto-style16"></td>
                <td class="auto-style17"></td>
                <td class="auto-style7">
                    <asp:Button ID="btnFiltrar" runat="server" style="margin-left: 24px" Text="Filtrar" OnClick="btnFiltrar_Click" ValidationGroup="ValSum" />
                </td>
                <td class="auto-style6">
                    <asp:Button ID="btnQuitarFiltro" runat="server" style="margin-left: 0px" Text="Quitar filtro" Width="78px" OnClick="btnQuitarFiltro_Click" ValidationGroup="group1" CausesValidation="False" />
                </td>
                <td class="auto-style16">
                    <asp:Button ID="btnInicio" runat="server" OnClick="btnInicio_Click" Text="Inicio" CausesValidation="False" />
                </td>
                <td class="auto-style16"></td>
                <td class="auto-style16"></td>
            </tr>
            <tr>
                <td class="auto-style18"></td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style20"></td>
                <td class="auto-style21" colspan="2">
                    <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                </td>
                <td class="auto-style18">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="ValSum" />
                </td>
                <td class="auto-style18"></td>
                <td class="auto-style18"></td>
            </tr>
            <tr>
                <td class="auto-style22"></td>
                <td class="auto-style22"></td>
                <td class="auto-style23"></td>
                <td class="auto-style24" colspan="2">
                    </td>
                <td class="auto-style22"></td>
                <td class="auto-style22"></td>
                <td class="auto-style22"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2" colspan="5">
                    <asp:GridView ID="gvProductos" runat="server"  style="margin-left: 0px" Width="280px">
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4" colspan="2">
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
