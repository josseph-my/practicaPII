<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="practicaPII.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Gestion de envios</title>
    <style>
        body {
            background-color: #e6f0ff;
            font-family: 'Segoe UI', sans-serif;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .container {
            background-color: white;
            padding: 30px;
            border-radius: 20px;
            box-shadow: 0px 0px 15px rgba(0,0,0,0.2);
            width: 100%;
            max-width: 600px;
            text-align: center;
        }

        h1 {
            color: #0059b3;
            margin-bottom: 20px;
        }

              label {
            display: block;
            font-weight: bold;
            margin-top: 15px;
            color: #003366;
            text-align: left;
        }

        input[type="text"],
        input[type="number"],
        select {
            width: 100%;
            padding: 10px;
            margin-top: 5px;
            border: 1px solid #ccc;
            border-radius: 8px;
            font-size: 16px;
        }

        input[type="submit"],
        button {
            background-color: #0059b3;
            color: white;
            border: none;
            padding: 12px 25px;
            border-radius: 8px;
            margin-top: 25px;
            font-size: 16px;
            cursor: pointer;
        }

        .resultado {
            margin-top: 20px;
            padding: 15px;
            background-color: #d0e6ff;
            border: 1px solid #3399ff;
            border-radius: 10px;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Gestión de Envíos</h1>

            <label>Puerto Origen:</label>
            <asp:TextBox ID="txtOrigen" runat="server" />

            <label>Puerto Destino:</label>
            <asp:TextBox ID="txtDestino" runat="server" />

            <label>Peso (toneladas):</label>
            <asp:TextBox ID="txtPeso" runat="server" TextMode="Number" />

            <label>Tipo de Envío:</label>
            <asp:DropDownList ID="ddlTipoEnvio" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlTipoEnvio_SelectedIndexChanged">
                <asp:ListItem Text="Seleccione..." Value="" />
                <asp:ListItem Text="Contenedor" Value="Contenedor" />
                <asp:ListItem Text="Granel" Value="Granel" />
            </asp:DropDownList>
                        <asp:Panel ID="panelContenedor" runat="server" Visible="false">
                <label>Cantidad de Contenedores:</label>
                <asp:TextBox ID="txtContenedores" runat="server" TextMode="Number" />
            </asp:Panel>

           <label>Tipo de granel:</label>
            <asp:DropDownList ID="tipoGranelList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="tipoGranelList_SelectedIndexChanged">
                <asp:ListItem Text="Seleccione..." Value="" />
                <asp:ListItem Text="Granos" Value="Granos" />
                <asp:ListItem Text="Mineral" Value="Mineral" />
            </asp:DropDownList>
            

            <asp:Button ID="btnCalcular" runat="server" Text="Calcular y Guardar" OnClick="btnCalcular_Click" />

            <asp:Label ID="lblEnvio" text =" " runat="server" CssClass="resultado" Visible="false" />
        </div>
    </form>
</body>
</html>
