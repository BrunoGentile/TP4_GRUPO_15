<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP4_GRUPO_15.Ejercicio2" %>

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
            width: 95px;
        }
        .auto-style4 {
            width: 233px;
        }
        .auto-style5 {
            width: 94px;
        }
        .auto-style6 {
            width: 85px;
        }
        .auto-style7 {
            width: 101px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
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
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="lblProducto" runat="server" Text="Id Producto: "></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:DropDownList ID="ddlProducto" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style4" colspan="2">
                    <asp:TextBox ID="txtProducto" runat="server" Width="214px"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="cvProducto" runat="server" ControlToValidate="txtProducto" Operator="GreaterThan" Type="Integer" ValueToCompare="0">Ingrese una cantidad valida</asp:CompareValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td></td>
                <td class="auto-style2"></td>
                <td class="auto-style5"></td>
                <td class="auto-style4" colspan="2"></td>
                <td></td>
                <td></td>
                <td></td>
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
                    <asp:CompareValidator ID="cvCategoria" runat="server" ControlToValidate="txtCategoria" Operator="GreaterThan" Type="Integer" ValueToCompare="0">Ingrese una cantidad valida</asp:CompareValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Button ID="btnFiltrar" runat="server" style="margin-left: 24px" Text="Filtrar" />
                </td>
                <td class="auto-style6">
                    <asp:Button ID="btnQuitarFiltro" runat="server" style="margin-left: 0px" Text="Quitar filtro" Width="78px" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
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
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4" colspan="2">
                    <asp:GridView ID="gvProductos" runat="server" style="margin-left: 0px" Width="280px">
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
