<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="usuWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>
        Página de usuarios
    </h2>
    <p> 
        NIF:
        <asp:TextBox ID="NIF" runat="server"></asp:TextBox><br />
        Nombre:
        <asp:TextBox ID="Nombre" runat="server"></asp:TextBox><br />
        Edad:
        <asp:TextBox ID="Edad" runat="server"></asp:TextBox><br />
      
    </p>
    <asp:Button ID="Leer" runat="server" OnClick="Leer_Click" Text="Leer" />
    <asp:Button ID="Leer_Primero" runat="server" Text="Leer Primero" OnClick="Leer_Primero_Click"  />
    <asp:Button ID="Leer_Anterior" runat="server" Text="Leer Anterior" OnClick="Leer_Anterior_Click" />
    <asp:Button ID="Leer_Siguiente" runat="server" OnClick="Leer_Siguiente_Click" Text="Leer Siguiente" />
    <asp:Button ID="Crear" runat="server" Text="Crear" OnClick="Crear_Click"  />
    <asp:Button ID="Actualizar" runat="server" Text="Actualizar" OnClick="Actualizar_Click" />
    <asp:Button ID="Borrar" runat="server" Text="Borrar" OnClick="Borrar_Click" />


</asp:Content>
