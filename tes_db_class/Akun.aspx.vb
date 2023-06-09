﻿Imports MySql.Data.MySqlClient

Public Class Akun
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim conn As MySqlConnection = New MySqlConnection("server=localhost;user=root;pwd=;database=dbkeluhan")
        Dim dt As New DataTable
        Dim mydata As MySqlDataAdapter
        Dim query = "SELECT akun.idakun AS 'ID Akun', akun.username as 'USERNAME', akun.password as 'PASSWORD', level.namalevel AS 'Nama Level' FROM akun INNER JOIN level ON akun.idlevel = level.idlevel"

        Try
            conn.Open()
            mydata = New MySqlDataAdapter(query, conn)
            mydata.Fill(dt)
            conn.Close()

            GV.DataSource = dt
            GV.DataBind()
        Catch ex As Exception
            If conn.State = ConnectionState.Open Then
                MsgBox("Koneksi Database Gagal")
                conn.Close()
            End If
        End Try
    End Sub

    Protected Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Response.Redirect("WebForm1.aspx")
    End Sub
    Protected Sub btnAkunDosen_Click(sender As Object, e As EventArgs) Handles btnAkunDosen.Click
        Response.Redirect("AkunDosen.aspx")
    End Sub
    Protected Sub btnAkunMahasiswa_Click(sender As Object, e As EventArgs) Handles btnAkunMahasiswa.Click
        Response.Redirect("AkunMahasiswa.aspx")
    End Sub
    Protected Sub btnAkunStaff_Click(sender As Object, e As EventArgs) Handles btnAkunStaff.Click
        Response.Redirect("AkunStaff.aspx")
    End Sub
End Class