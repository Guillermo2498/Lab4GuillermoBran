<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridSimpleLab.aspx.cs" EnableEventValidation="false"  Inherits="Lab4.GridSimpleLab" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="gridFarmacia" runat="server" 
             AutoGenerateColumns="false"  
                DataKeyNames="codMedicina" 
            BackColor="LightGoldenrodYellow"
            BorderColor="Tan" 
            BorderWidth="1px"
            CellPadding="2" 
            ForeColor="Black"
            GridLines="None"
            OnRowDataBound="gridFarmacia_RowDataBound" OnSelectedIndexChanged="gridFarmacia_SelectedIndexChanged">
            
             <Columns>
                  <asp:BoundField DataField="idMedicina" HeaderText="ID" />
                 <asp:BoundField DataField="numMedicina" HeaderText="NumeroFila" />
                 <asp:BoundField DataField="codMedicina" HeaderText="Codigo" />
                 <asp:BoundField DataField="detMedicina" HeaderText="Detalle" />
                 <asp:BoundField DataField="cantProducto" HeaderText="Cantidad" />
                 <asp:BoundField DataField="costUnit" HeaderText="CostoUnitario" />
                 <asp:BoundField DataField="Total" HeaderText="Total" />

                </Columns>
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
          <br />
            <br />
            <table>
                <tr>
                    <td>Id</td>
                    <td><asp:TextBox ID="TxtId" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Numero</td>
                    <td><asp:TextBox ID="txtNumero" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Codigo</td>
                    <td><asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Detalle</td>
                    <td><asp:TextBox ID="txtdetalle" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Cantidad</td>
                    <td><asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>CostoUnit</td>
                    <td><asp:TextBox ID="txtCosto" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Total</td>
                    <td><asp:TextBox ID="txtTotal" runat="server"></asp:TextBox></td>
                </tr>
            </table>
    </form>
</body>
</html>
