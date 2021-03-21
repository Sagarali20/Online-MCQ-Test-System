<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admins.aspx.cs" Inherits="mcq.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style3 {
			width: 253px;
		}
		.auto-style4 {
			width: 27px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<center>
			<table border="1">
				<tr>
					<td class="auto-style3">Choose&nbsp; your subject from hear</td> <td class="auto-style4">
					<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="title" DataValueField="title" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
					</asp:DropDownList>
					<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>" ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>" SelectCommand="SELECT [title] FROM [subject]"></asp:SqlDataSource>
					</td>
				</tr>
				<tr>
					<td class="auto-style3"></td> <td class="auto-style4"></td>
				</tr>
				<tr>
					<td class="auto-style3">Question no:</td> <td class="auto-style4">
					<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td class="auto-style3">Title</td> <td class="auto-style4">
					<asp:TextBox ID="TextBox2" runat="server" Height="22px"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td class="auto-style3">Answer option</td> <td class="auto-style4"></td>
				</tr>
				<tr>
					<td class="auto-style3">1:</td> <td class="auto-style4"></td>
				</tr>
				<tr>
					<td class="auto-style3">2:</td> <td class="auto-style4"></td>
				</tr>
				<tr>
					<td class="auto-style3">3:</td> <td class="auto-style4"></td>
				</tr>
				<tr>
					<td class="auto-style3">4:</td> <td class="auto-style4"></td>
				</tr>
				<tr>
					<td class="auto-style3">Correct Answer</td> <td class="auto-style4">
					<asp:TextBox ID="TextBox3" runat="server" Height="22px"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td colspan="2">
						<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 26px" Text="Insert" />
						<asp:Button ID="Button2" runat="server" Text="Next Question" />
					</td> 
				</tr>
			
			</table>
				</center>
        </div>
    </form>
</body>
</html>
