﻿Imports MySql.Data.MySqlClient

Public Class AkunStaff
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim conn As MySqlConnection = New MySqlConnection("server=localhost;user=root;pwd=;database=dbkeluhan")
        Dim dt As New DataTable
        Dim mydata As MySqlDataAdapter
        Dim query = "SELECT 
                        staff_bidang.idstaff AS 'ID Staff',
                        staff_bidang.idakun as 'ID Akun', 
                        staff_bidang.nama as 'Nama',
                        bidang.namabidang as 'Nama Bidang', 
                        staff_bidang.jeniskelamin AS 'Jenis Kelamin', 
                        staff_bidang.alamat as 'Alamat', 
                        staff_bidang.nohp as 'NO HP',  
                        staff_bidang.foto as 'Foto',
                        staff_bidang.email as 'Email'
                    FROM 
                        staff_bidang 
                        INNER JOIN bidang ON staff_bidang.idbidang = bidang.idbidang"
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
        Response.Redirect("Akun.aspx")
    End Sub
End Class