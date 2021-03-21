<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="mcq.Admin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style8 {
			margin-right: 0px;
		}
		.auto-style9 {
			width: 172px;
		}
		.auto-style10 {
			height: 28px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<center>
			<table border="1">
				<tr>
					<td style="text-align:center">
						<asp:Label ID="Label1" runat="server" Text="Chose Your Subject From Here:"></asp:Label>
					</td><td style="text-align:center" class="auto-style9">
						<asp:DropDownList ID="DropDownList1" runat="server" Height="18px" Width="121px" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="title" DataValueField="title" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
						</asp:DropDownList>
						<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString5 %>" ProviderName="<%$ ConnectionStrings:ConnectionString5.ProviderName %>" SelectCommand="SELECT [title] FROM [subject]"></asp:SqlDataSource>
					</td>

				</tr>
				<tr>
					<td style="text-align:center">&nbsp</td><td style="text-align:center" class="auto-style9">&nbsp;</td>
				</tr>
				<tr>
					<td style="text-align:center">Question No:</td><td style="text-align:center" class="auto-style9">
					<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
					</td>
				</tr>
					
				<tr>
					<td style="text-align:center">Title</td><td style="text-align:center" class="auto-style9">
					<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td style="text-align:left; font-size: medium; font-weight: bold; font-style: italic; color: #0033CC;">Answer Option:</td><td style="text-align:center" class="auto-style9"></td>
				</tr>
				<tr>
					<td style="text-align:right">1:</td><td style="text-align:center" class="auto-style9">
					<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td style="text-align:right">2:</td><td style="text-align:center" class="auto-style9">
					<asp:TextBox ID="text2" runat="server"></asp:TextBox>
					</td>
				</tr><tr>
					<td style="text-align:right">3:</td><td style="text-align:center" class="auto-style9">
					<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td style="text-align:right">4:</td><td style="text-align:center" class="auto-style9">
					<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td style="text-align:center; font-size: large; font-weight: bold; font-style: normal; color: #00FF00;">Correct Answer:</td><td style="text-align:center" class="auto-style9">
					<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td colspan="2"style="text-align:center" class="auto-style10" >
						<asp:Button ID="Button8" runat="server" Height="28px" OnClick="Button8_Click" Text="AddNew" />
						<asp:Button ID="Button1" runat="server" Text="Insert" Height="28px" Width="48px" CssClass="auto-style8" OnClick="Button1_Click" Enabled="False" />
						<asp:Button ID="Button2" runat="server" Text="Next Question" Height="28px" Width="99px" OnClick="Button2_Click" Enabled="False" />
						<asp:Button ID="Button5" runat="server" Height="28px" Text="Search" OnClick="Button5_Click" />
					</td>
				</tr>
				<tr>
					<td colspan="2" style="text-align:center">
						<asp:Button ID="Button3" runat="server" Text="Update" Height="28px" OnClick="Button3_Click" Enabled="False" />
						<asp:Button ID="Button4" runat="server" Text="Delete" Height="28px" OnClick="Button4_Click" Enabled="False" />
						<asp:Button ID="Button9" runat="server" Enabled="False" Height="28px" OnClick="Button9_Click" Text="Cancel" />
						<asp:Button ID="Button6" runat="server" Text="Start" OnClick="Button6_Click" BackColor="#009900" ForeColor="White" Height="28px" />
						<asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Stop" BackColor="Red" Enabled="False" ForeColor="#FFFFCC" Height="28px" />
					</td>
				</tr>
				<tr>
					<td colspan="2" style="text-align:center">&nbsp
						<asp:Label ID="Label2" runat="server"></asp:Label>
					</td>
				</tr>
			</table>
				</center>
        </div>
    </form>
</body>
</html>
