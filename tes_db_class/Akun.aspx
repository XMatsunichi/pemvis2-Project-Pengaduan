﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Akun.aspx.vb" Inherits="tes_db_class.Akun" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <h1 class="auto-style1">APLIKASI PENGADUAN KELUHAN POLITALA</h1>
            <p class="auto-style1">
                <strong>Data Akun:</strong></p>
            <p>
                <asp:GridView ID="GV" runat="server" HorizontalAlign="Center" CellPadding="5">
                </asp:GridView>
            </p>
            <p class="auto-style1">
                <asp:Button ID="btnAkunDosen" runat="server" Text="Akun Dosen" style="height: 26px" />
            &nbsp;<asp:Button ID="btnAkunMahasiswa" runat="server" Text="Akun Mahasiswa" style="height: 26px" />
            &nbsp;<asp:Button ID="btnAkunStaff" runat="server" Text="Akun Staff" style="height: 26px" />
            </p>
            <p class="auto-style1">
                <asp:Button ID="btnBack" runat="server" Text="Back" style="height: 26px" />
            </p>
        </div>
    </form>
</body>
</html>
