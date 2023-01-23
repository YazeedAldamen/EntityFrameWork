﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="task_22_jan.delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"> 
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
                  <div class="container">
        <div>
              <div class="form-group row">
    <label for="name" class="col-4 col-form-label">Name</label> 
    <div class="col-8">
        <asp:TextBox runat="server" id="name" name="name" placeholder="Name" type="text" class="form-control"  />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="g1" ErrorMessage="RequiredFieldValidator" ControlToValidate="name"></asp:RequiredFieldValidator>
    </div>
  </div>
  <div class="form-group row">
    <label for="city" class="col-4 col-form-label">City</label> 
    <div class="col-8">
        <asp:DropDownList ID="city" runat="server" class="form-control"></asp:DropDownList>
    </div>
  </div>
  <div class="form-group row">
    <label for="age" class="col-4 col-form-label">Age</label> 
    <div class="col-8">
        <asp:TextBox runat="server" id="age" name="age" placeholder="Age" type="text" class="form-control"  />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="age" ValidationGroup="g1"></asp:RequiredFieldValidator>
    </div>
  </div>
  <div class="form-group row">
    <label for="phone" class="col-4 col-form-label">Phone</label> 
    <div class="col-8">
        <asp:TextBox runat="server" id="phone" name="phone" placeholder="Phone" type="text" class="form-control"  ValidationGroup="g1"/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="phone" ValidationGroup="g1"></asp:RequiredFieldValidator>
    </div>
  </div>
  <div class="form-group row">
    <label for="email" class="col-4 col-form-label">Email</label> 
    <div class="col-8">
        <asp:TextBox runat="server" id="email" name="email" placeholder="Email" type="text" class="form-control"  ValidationGroup="g1"/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="email" ValidationGroup="g1"></asp:RequiredFieldValidator>
    </div>
  </div>
  <div class="form-group row">
    <label for="photo" class="col-4 col-form-label">Photo</label> 
    <div class="col-8">
        <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
        <asp:Label ID="Label1"  runat="server" />
    </div>
  </div> 
  <div class="form-group row">
    <div class="offset-4 col-8">
        <asp:Button Text="Edit" runat="server" class="btn btn-success" OnClick="Unnamed1_Click" ValidationGroup="g1"/>
    </div>
  </div>
  </div>
 
        </div>
    </form>
</body>
</html>
