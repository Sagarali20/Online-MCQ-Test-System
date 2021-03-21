<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="mcq.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 50%;
		}
	</style>
</head>
<body>
	<br /><br /><br /><br />
	<center>
    <form id="form1" runat="server">
        <div>
        	<table class="auto-style1">
				<tr>
					<td>&nbsp;</td>
					<td >Login page</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td style="text-align:center">User Name</td>
					<td>
						<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
						<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter your user name"></asp:RequiredFieldValidator>
					</td>
					<td>
						&nbsp;</td>
				</tr>
				<tr>
					<td style="text-align:center">Password</td>
					<td>
						<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
						<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter your password"></asp:RequiredFieldValidator>
					</td>
					<td>
						&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>
						<asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
					</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>
						<asp:Label ID="Label1" runat="server"></asp:Label>
					</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>
						<asp:HyperLink ID="HyperLink1" runat="server" Visible="False" NavigateUrl="~/Registeration.aspx">Sing up here=&gt;</asp:HyperLink>
					</td>
					<td>&nbsp;</td>
				</tr>
			</table>
        </div>
    </form>
		</center>
</body>
</html>
