<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="task_22_jan.delete1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"> 
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
       <div class="form-group">
    <label for="exampleLabel">Name</label>
           <asp:Label id="name" class="form-control" runat="server" />
  </div>
  <div class="form-group">
    <label for="exampleLabel">Email</label>
      <asp:Label id="email" class="form-control" runat="server" />
  </div>
  <div class="form-group">
    <label for="exampleLabel">Phone Number</label>
      <asp:Label id="phone" class="form-control" runat="server" />
  </div>
 
            <asp:Button Text="Delete" ID="delete" runat="server" OnClick="delete_Click" class="btn-primary form-group"/>
     
        </div>
    </form>
</body>
</html>
