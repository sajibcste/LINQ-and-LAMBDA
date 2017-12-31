<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeEntryUI.aspx.cs" Inherits="Link_Prac.EmployeeEntryUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-sm-12">
            <div class="col-sm-12">
                <div class="col-sm-2">
                    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                </div>
                <div class="col-sm-6">
                    <asp:TextBox ID="employeeNameTextBox" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col-sm-12">
                <div class="col-sm-2">
                    <asp:Label ID="Label2" runat="server" Text="Gender"></asp:Label>
                </div>
                <div class="col-sm-6">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="Male">Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-sm-12">
                <div class="col-sm-2">
                    <asp:Label ID="Label3" runat="server" Text="DepartmentId"></asp:Label>
                </div>
                <div class="col-sm-6">
                    <asp:DropDownList ID="DeptDropDownList" runat="server"></asp:DropDownList>
                </div>
            </div>
            <div class="col-sm-12">
                <div class="col-sm-2">
                    <asp:Label ID="Label4" runat="server" Text="gradeId"></asp:Label>
                </div>
                <div class="col-sm-6">
                    <asp:DropDownList ID="gradeDropDownList" runat="server"></asp:DropDownList>
                </div>
            </div>
            <div class="col-sm-12">
                <div class="col-sm-2">
                    <asp:Label ID="Label5" runat="server" Text="address"></asp:Label>
                </div>
                <div class="col-sm-6">
                    <textarea runat="server" id="addressTextBox"></textarea>
                </div>
            </div>
            <div class="col-sm-12">
                <div class="col-sm-2">
                    <asp:Button ID="EmployeesaveButton" runat="server" Text="Save" OnClick="EmployeesaveButton_Click" />
                </div>
                <div class="col-sm-6">
                    <asp:Label ID="msgLabel" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
    </form>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>
</body>
</html>
