<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .uyari{
            color:red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>Ürün Adı</td>
                <td>
                    <asp:TextBox runat="server" ID="txtUrunAdi" />
                </td>
            </tr>
            <tr>
                <td>SupplierID</td>
                <td><asp:TextBox runat="server"  ID="txtSupplierID"/></td>
            </tr>
            <tr>
                <td>CategoryID</td>
                <td><asp:TextBox runat="server"  ID="txtCategoryID"/>
                    <asp:RegularExpressionValidator ErrorMessage="Boş Geçilemez" ControlToValidate="txtCategoryID" CssClass="uyari" runat="server" />
                </td>

            </tr>
            <tr>
                <td>UnitInStock</td>
                <td><asp:TextBox runat="server"  ID="txtUnitInStock"/></td>
            </tr>
            <tr>
                <td>UnitInPrice</td>
                <td><asp:TextBox runat="server"  ID="txtUnitPrice"/></td>
            </tr>
            <tr>
                <td>
                    <asp:Button Text="text" runat="server" ID="btnKaydet" OnClick="btnKaydet_Click"/>
                </td>
            </tr>
        </table>

        
       <table>
            <tr>
                <td>ProductID</td>
                <td>ProductName</td>
                <td>UnitPrice</td>
            </tr>
            <%--döngüye almak için kullanılır--%>
            <asp:Repeater runat="server" ID="rptUrunler">
                <ItemTemplate>
                    <tr>                
                        <td><%#Eval("ProductID")%></td>
                        <td><%#Eval("ProductName")%></td>
                        <td><%#Eval("UnitPrice")%></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            
        </table>

        <table>
            <tr>
                <td>ProductID</td>
                <td>ProductName</td>
                <td>UnitPrice</td>
            </tr>
            <%--döngüye almak için kullanılır--%>
            <asp:Repeater runat="server" ID="Repeater1">
                <ItemTemplate>
                    <tr>                
                        <td><%#Eval("EmployeeID")%></td>
                        <td><%#Eval("LastName")%></td>
                        <td><%#Eval("FirstName")%></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>

    </form>
</body>
</html>
