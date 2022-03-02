<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SiparisGir.aspx.cs" Inherits="WebApplication1.SiparisGir" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:DropDownList runat="server" ID="drop1" AutoPostBack="true">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList runat="server" ID="drop2" AutoPostBack="true">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox runat="server" ID="txt1"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox runat="server" ID="txt2"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox runat="server" ID="txt3"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox runat="server" ID="txt4"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox runat="server" ID="txt5"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox runat="server" ID="txt6"/>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:TextBox runat="server" ID="txt7"/>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:TextBox runat="server" ID="txt8"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button Text="Kaydet" runat="server" ID="btnKaydet" OnClick="btnKaydet_Click"/>
                    </td>
                </tr>
                
                <asp:Button Text="Kaydet" runat="server" ID="Button1" />
            </table>
            
        </div>
    </form>
</body>
</html>
