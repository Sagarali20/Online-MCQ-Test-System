<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registeration.aspx.cs" Inherits="mcq.Registeration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 45%;
		}
		.auto-style6 {
			height: 23px;
			width: 191px;
		}
		.auto-style7 {
			width: 122px;
		}
		.auto-style8 {
			height: 23px;
			width: 122px;
		}
		.auto-style10 {
			height: 23px;
			width: 47px;
		}
		.auto-style11 {
			width: 47px;
		}
		.auto-style12 {
			width: 191px;
		}
	</style>
</head>
<body>
	<center>
    <form id="form1" runat="server">
		
        <table class="auto-style1">
			<tr>
				<td class="auto-style7">&nbsp;</td>
				<td class="auto-style12">Registeration</td>
				<td class="auto-style10" style="text-align:left">
					<asp:Button ID="Button2" runat="server" Text="Login" OnClick="Button2_Click1" CausesValidation="False" />
				</td>
			</tr>
			<tr>
				<td class="auto-style7" style="text-align:center">Name</td>
				<td class="auto-style12">
					<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter your name"></asp:RequiredFieldValidator>
				</td>
				<td class="auto-style11">&nbsp;</td>
			</tr>
			<tr>
				<td class="auto-style7" style="text-align:center">Address</td>
				<td class="auto-style12">
					<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter your address"></asp:RequiredFieldValidator>
				</td>
				<td class="auto-style11">&nbsp;</td>
			</tr>
			<tr>
				<td class="auto-style7" style="text-align:center">Phone</td>
				<td class="auto-style12">
					<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter your phone"></asp:RequiredFieldValidator>
				</td>
				<td class="auto-style11">&nbsp;</td>
			</tr>
			<tr>
				<td class="auto-style7" style="text-align:center">Email</td>
				<td class="auto-style12">
					<asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged" TextMode="Email"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Enter your Email"></asp:RequiredFieldValidator>
				</td>
				<td class="auto-style11">&nbsp;</td>
			</tr>
			<tr>
				<td class="auto-style7" style="text-align:center">Gender</td>
				<td class="auto-style12" id="gen" aria-grabbed="undefined">
					<asp:RadioButtonList ID="RadioButtonList1" runat="server">
						<asp:ListItem>Male</asp:ListItem>
						<asp:ListItem>Female</asp:ListItem>
					</asp:RadioButtonList>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="Enter your Gender"></asp:RequiredFieldValidator>
				</td>
				<td class="auto-style11">&nbsp;</td>
			</tr>
			<tr>
				<td class="auto-style7" style="text-align:center">Age</td>
				<td class="auto-style12">
					<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6" ErrorMessage="Enter your Age"></asp:RequiredFieldValidator>
				</td>
				<td class="auto-style11">&nbsp;</td>
			</tr>
			<tr>
				<td class="auto-style8" style="text-align:center">Department</td>
				<td class="auto-style6">
					<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox7" ErrorMessage="Enter your Department"></asp:RequiredFieldValidator>
				</td>
				<td class="auto-style10"></td>
			</tr>
			<tr>
				<td class="auto-style7" style="text-align:center">User name</td>
				<td class="auto-style12">
					<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox8" ErrorMessage="Enter your user name"></asp:RequiredFieldValidator>
				</td>
				<td class="auto-style11">&nbsp;</td>
			</tr>
			<tr>
				<td class="auto-style7" style="text-align:center">Password</td>
				<td class="auto-style12">
					<asp:TextBox ID="password1" runat="server" TextMode="Password"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="password1" ErrorMessage="Enter your password"></asp:RequiredFieldValidator>
				</td>
				<td class="auto-style11">&nbsp;</td>
			</tr>
			<tr>
				<td class="auto-style7" style="text-align:center">Confirm Password</td>
				<td class="auto-style12">
					<asp:TextBox ID="password2" runat="server" TextMode="Password"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="password2" ErrorMessage="Enter your confirm password"></asp:RequiredFieldValidator>
				</td>
				<td class="auto-style11">&nbsp;</td>
			</tr>
			<tr>
				<td class="auto-style7">&nbsp;</td>
				<td class="auto-style12" style="text-align:left">
					<asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
					<asp:Label ID="Label1" runat="server"></asp:Label>
				</td>
				<td class="auto-style11">&nbsp;</td>
			</tr>
		</table>
        <div>
        </div>
    </form>
		</center>
</body>
</html>
