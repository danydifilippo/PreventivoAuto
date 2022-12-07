<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PreventivoAuto.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Default.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Configura la tua Auto:</h1>
            <div class="row d-flex">
            <div class="col-6">
            <asp:DropDownList ID="DropDownAuto" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownAuto_SelectedIndexChanged"
                 CssClass="FormControl">
                <asp:ListItem Value="0" Text=""></asp:ListItem>
                <asp:ListItem Value="25450" Text="Fiat 500 ELETTRICA 70 KW (95CV)"></asp:ListItem>
                <asp:ListItem Value="22980" Text="Jeep Renegade 1.0 GSE T3 120CV FWD"></asp:ListItem>
                <asp:ListItem Value="23600" Text="Fiat 500X 1.3 MULTIJET 95 CV"></asp:ListItem>
                <asp:ListItem Value="51600" Text="Alfa Romeo Tonale Ed. Speciale PLUG-IN HYBRID Q4"></asp:ListItem>
                <asp:ListItem Value="16900" Text="Fiat Panda Garmin 1.0 HYBRID 70 CV"></asp:ListItem>
                <asp:ListItem Value="28500" Text=""></asp:ListItem>
            </asp:DropDownList>
            </div>
             <div class="col-6">
                <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image1" runat="server" />
                 <div class="card-body">
                     <asp:Label ID="lblDescrAuto" runat="server" Text=""></asp:Label>
                     <hr />
                     <asp:Label ID="PrezzoBase" Font-Bold="true" runat="server" Text=""></asp:Label>
                 </div>
                </div>
            </div>
            </div>
        </div>
        <hr />
        <div class="container">
            <h3>Optional:</h3>
            <div class="row text-center">
                <asp:CheckBoxList ID="cblOptional" CssClass="form-control" RepeatColumns="3" runat="server">
                    <asp:ListItem Text="Vernice metallizzata (+ 500,00 €)" Value="500"></asp:ListItem>
                    <asp:ListItem Text="Cerchi in lega (+ 1.200,00 €)" Value="1200"></asp:ListItem>
                    <asp:ListItem Text="Pack winter (+ 1.700,00 €)" Value="1700"></asp:ListItem>
                    <asp:ListItem Text="Fari xeno (+ 200,00 €)" Value="200"></asp:ListItem>
                    <asp:ListItem Text="Ruota di scorta (+ 160,00 €)" Value="160"></asp:ListItem>
                    <asp:ListItem Text="Sedili in pelle (+ 650,00 €)" Value="650"></asp:ListItem>
                </asp:CheckBoxList>
            </div>
        </div>
        <hr />
         <div class="container">
            <h1>Scegli il periodo di garanzia:</h1>
            <div class="row">
            <div class="col-4">
            <asp:DropDownList ID="ddlGaranzia" runat="server"
                 CssClass="FormControl">
                <asp:ListItem Value="1" Text="1 anno"></asp:ListItem>
                <asp:ListItem Value="2" Text="2 anni"></asp:ListItem>
                <asp:ListItem Value="3" Text="3 anni"></asp:ListItem>
                <asp:ListItem Value="4" Text="4 anni"></asp:ListItem>
            </asp:DropDownList>
            </div>
            </div>
        </div>
        <hr />
             <asp:Button ID="Calcola" runat="server" Text="Calcola Preventivo" CssClass="btn btn-info" OnClick="Calcola_Click" />
        
        <div id="Configurazione" class="alert alert-info" runat="server">
            <asp:Label ID="ListaConfig" runat="server" Text=""></asp:Label>
            <asp:Label ID="TotConfig" Font-Bold="true" ForeColor="CadetBlue" Font-Size="28px" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
