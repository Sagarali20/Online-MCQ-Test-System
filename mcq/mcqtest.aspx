<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mcqtest.aspx.cs" Inherits="mcq.mcqtest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 640px;
			height: 168px;
		}
		</style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #66FFCC">
    <div style="width:100%;text-align:center; background-color: #66FFCC;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="Test Your Skill" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button5" runat="server" BackColor="#FF3399" Height="41px" OnClick="Button5_Click" Text="Log out" />
    </div>
		<br />
    <div style="width:100%;text-align:center; background-color: #66FFCC;">
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <img alt="" class="auto-style1" src="Images/download%20(1).jpg" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
		<br />
		<div>
			<asp:Label ID="Label7" runat="server" Text="Now,You are attempting"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" BackColor="#FFCCCC" BorderColor="#0099FF" Height="20px" Width="92px"></asp:TextBox>
			\<asp:TextBox ID="TextBox2" runat="server" BackColor="#FFCCCC" BorderColor="#0099FF" Height="20px" Width="92px"></asp:TextBox>
		</div>
		<br />
&nbsp;<br />
		<asp:Label ID="Label6" runat="server" Text="Choose Your Subject :"></asp:Label>
		<asp:DropDownList ID="DropDownList2" runat="server" Height="30px" Width="159px" DataSourceID="SqlDataSource1" DataTextField="title" DataValueField="title" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" BackColor="#FFCCCC" Enabled="False" AutoPostBack="True">
		</asp:DropDownList>
		<br />
		<br />
		<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT [title] FROM [subject]"></asp:SqlDataSource>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Start Exam" OnClick="Button1_Click" BackColor="#FFCCCC" BorderColor="#0099FF" Height="30px" Enabled="False" />
		<br />
		<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Question will Display Here ?"></asp:Label>
		<br />
		<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="Answer: "></asp:Label>
		<asp:DropDownList ID="DropDownList1" runat="server" Height="25px" ToolTip="Find Your Answer Here" Width="159px" BackColor="#FFCCCC">
		</asp:DropDownList>
		<br />
		<br />
		<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Text="Submit Answer" OnClick="Button4_Click" Enabled="False" BackColor="#FFCCCC" BorderColor="#0099FF" Height="30px" />
		<asp:Button ID="Button2" runat="server" Text="Next Question" Enabled="False" OnClick="Button2_Click" BackColor="#FFCCCC" BorderColor="#0099FF" Height="30px" />
		<asp:Button ID="Button3" runat="server" Text="Close Exam" Enabled="False" OnClick="Button3_Click" BackColor="#FFCCCC" BorderColor="#0099FF" Height="30px" />
		<asp:Button ID="Button6" runat="server" Text="Test again" Enabled="False" OnClick="Button3_Click" BackColor="#FFCCCC" BorderColor="#0099FF" Height="30px" />
		<br />
		<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:Label ID="final" runat="server" Text="Label" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
		<br />
		<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        	<br />
		<br />
		<br />
		<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
    </form>
</body>
</html>
