<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="mcq.Result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
	<center>
    <form id="form1" runat="server">
        <div>
        	<asp:Label ID="Label1" runat="server" BorderColor="Black" Font-Bold="True" Font-Size="XX-Large" ForeColor="#00CC00" Text="Results"></asp:Label>
			
			<asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="16px" Width="459px">
				
				<AlternatingRowStyle BackColor="White" />
				<EditRowStyle BackColor="#2461BF" />
				<FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
				<HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
				<PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
				<RowStyle BackColor="#EFF3FB" />
				<SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
				<SortedAscendingCellStyle BackColor="#F5F7FB" />
				<SortedAscendingHeaderStyle BackColor="#6D95E1" />
				<SortedDescendingCellStyle BackColor="#E9EBEF" />
				<SortedDescendingHeaderStyle BackColor="#4870BE" />
			</asp:GridView>
				
        </div>
    </form>
		</center>
</body>
</html>
