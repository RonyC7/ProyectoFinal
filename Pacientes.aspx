<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pacientes.aspx.cs" Inherits="ProyectoFinal.Pacientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body> 
    <form id="form1" runat="server">
    <h1>Paciente</h1>
        <asp:Label ID="Label1" runat="server" Text="Nombre Del Paciente:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBoxNopaciente" runat="server" BackColor="Blue"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Apellido Del  Paciente:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBoxApaciente" runat="server" BackColor="Blue"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nit:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxNit" runat="server" BackColor="Blue"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Direccion:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxDireccion" runat="server" BackColor="Blue"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Telefono:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxTelefono" runat="server" BackColor="Blue"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Fecha Nacimiento:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxFnaciemiento" runat="server" BackColor="Blue"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Calendar ID="Calendar1" runat="server" BackColor="#0080C0"></asp:Calendar>
        <br />
        <asp:GridView ID="GridView1" runat="server" BackColor="Lime">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="ButtonApaciente" runat="server" BackColor="#00FFCC" Text="Agregar Paciente" Width="130px" OnClick="ButtonApaciente_Click" />
&nbsp;<asp:Button ID="ButtonElpaciente" runat="server" BackColor="#FF3300" Text="Eliminar Paciente" Width="124px" />
&nbsp;<asp:Button ID="ButtonEpaciente" runat="server" BackColor="#6666FF" Text="Editar Paciente" Width="110px" OnClick="ButtonEpaciente_Click" />
&nbsp;<asp:Button ID="ButtonGuardar" runat="server" BackColor="#66FFFF" Text="Guardar Datos" Width="130px" />
        <br />
    </form>
    </body>
</html>
