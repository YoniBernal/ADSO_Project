<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="Empleados.Vista.Ventas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
      <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .container {
            margin-top: 50px;
        }

        .gridview-container {
            margin-top: 30px;
        }

        table {
            border-collapse: collapse;
            width: 100%;
        }

        th, td {
            border: 1px solid black;
            padding: 8px;
        }
    </style>
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div class="container">
            <h1>Formulario con GridView</h1>

            <div class="row">
                <div class="col-md-3">
                    <div class="form-group">
                        <label for="txtProducto">Producto</label>
                        <asp:TextBox ID="txtProducto" runat="server" CssClass="form-control" placeholder="Producto"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="form-group">
                        <label for="txtCantidad">Cantidad</label>
                        <asp:TextBox ID="txtCantidad" runat="server" CssClass="form-control" placeholder="Cantidad"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="form-group">
                        <label for="txtFecha">Fecha</label>
                        <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" placeholder="Fecha"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="form-group">
                        <label for="txtUsuario">Usuario</label>
                        <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="Usuario"></asp:TextBox>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-md-6">
                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-primary" OnClick="btnAgregar_Click1" />
                </div>
                <br />   
            </div>
        </div>
         <br />
         <br />

             <div class="col-md-3">
                    <div class="form-group">
                        <label for="txtUsuario">Eliminar Registro</label>
                        <asp:TextBox ID="txtProd" runat="server" CssClass="form-control" placeholder=""></asp:TextBox>
                        <br />
                             <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click" />
                    </div>
                </div>


        <div class="gridview-container">


            <div class="container">
                <asp:GridView ID="gvVentas" runat="server" AutoGenerateColumns="False">
                    <Columns>
                       <asp:BoundField DataField="Producto" HeaderText="Producto" />
                <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                <asp:BoundField DataField="FechaVenta" HeaderText="Fecha de Venta" />
                <asp:BoundField DataField="Usuario" HeaderText="Usuario" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
       
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    </form>
</body>
</html>
