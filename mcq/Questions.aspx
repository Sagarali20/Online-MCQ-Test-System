<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Questions.aspx.cs" Inherits="mcq.Questions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 185px;
			height: 135px;
		}
		.auto-style2 {
			width: 58px;
		}
	</style>
</head>
<body>
	<center>
    <form id="form1" runat="server">
        <div>
			
			<table class="auto-style1">
				<tr>
					<td class="auto-style2">Q.No:</td><td class="auto-style2">
					<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td class="auto-style2">Qtitle</td><td class="auto-style2">
					<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td class="auto-style2">Subject</td><td class="auto-style2">
					<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td colspan="2" style="text-align:center">
						<asp:Button ID="Button1" runat="server" Text="Insert" Width="71px" />
					</td>
				</tr>
			</table>
        </div>
    </form>
		</cente>

</body>
</html>
