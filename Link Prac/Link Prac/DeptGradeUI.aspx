<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeptGradeUI.aspx.cs" Inherits="Link_Prac.DeptGradeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="col-sm-12">
            <div class="col-sm-6">
                <div class="col-sm-12">
                    <div class="col-sm-3">
                        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                    </div>
                    <div class="col-sm-6">
                        <asp:TextBox ID="DeptnameTextBox" runat="server"></asp:TextBox>         
                    </div>
                </div>
                <div class="col-sm-12">
                    <div class="col-sm-3">
                        <asp:Label ID="Label2" runat="server" Text="Salary"></asp:Label>
                    </div>
                    <div class="col-sm-6">
                        <asp:TextBox ID="salaryTextBox" runat="server"></asp:TextBox>         
                    </div>
                </div>
                <div class="col-sm-12">
                   <div class="col-sm-4">
                    <asp:Button ID="DeptsaveButton" runat="server" Text="Save" OnClick="DeptsaveButton_Click" />   
                       <div class="col-sm-8">
                           <asp:Label ID="deptMsgLabel" runat="server" Text=""></asp:Label>  
                       </div> 
                </div> 
                </div> 
            </div>
            <div class="col-sm-6">
                
               <div class="col-sm-12">
                    <div class="col-sm-3">
                        <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
                    </div>
                    <div class="col-sm-6">
                        <asp:TextBox ID="gradenameTextBox" runat="server"></asp:TextBox>         
                    </div>
                </div>
                <div class="col-sm-12">
                    <div class="col-sm-3">
                        <asp:Label ID="Label4" runat="server" Text="Bonus"></asp:Label>
                    </div>
                    <div class="col-sm-6">
                        <asp:TextBox ID="BonusTextBox" runat="server"></asp:TextBox>         
                    </div>
                </div>
                <div class="col-sm-12">
                   <div class="col-sm-4">
                    <asp:Button ID="GradeButton" runat="server" Text="Save" OnClick="GradeButton_Click" />   
                       <div class="col-sm-8">
                           <asp:Label ID="gradeMsgLabel" runat="server" Text=""></asp:Label>  
                       </div> 
                </div> 
                </div>
            </div>
        </div>
    </form>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>
</body>
</html>
