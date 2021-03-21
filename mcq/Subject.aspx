<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Subject.aspx.cs" Inherits="mcq.Subject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 106px;
		}
		.auto-style2 {
			width: 209px;
			height: 199px;
		}
	</style>
</head>
<body>
	<br /><br /><br />
    <form id="form1" runat="server">
        <div>
			<center>
			<table class="auto-style2">
				<tr>
					<td class="auto-style1">Subject</td><td class="auto-style1">
					<asp:TextBox ID="TextBox1" runat="server" Height="25px"></asp:TextBox>
					</td>

				</tr>
				<tr>
					<td class="auto-style1">Title</td><td class="auto-style1">
					<asp:TextBox ID="TextBox2" runat="server" Height="25px"></asp:TextBox>
					</td>

				</tr>
				<tr>
					<td class="auto-style1">Department</td><td class="auto-style1">
					<asp:TextBox ID="TextBox3" runat="server" Height="25px"></asp:TextBox>
					</td>

				</tr>
				<tr>
					<td colspan="2" style="text-align:center">
						<asp:Button ID="Button1" runat="server" Text="Insert" Height="30px" Width="71px" />
					</td>

				</tr>
			</table>
				</center>
        </div>
    </form>
</body>
</html>
