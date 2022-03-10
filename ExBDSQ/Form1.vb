Imports System.Data.SqlClient
Public Class Form1
    Dim con As SqlConnection = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Database=sql7; Integrated Security=True;")

    Public Sub executarQuery(query As String)

        Dim command As New SqlCommand(query, con)

        con.Open()

        command.ExecuteNonQuery()

        con.Close()


    End Sub


    Private Sub BtnInserir_Click(sender As Object, e As EventArgs) Handles BtnInserir.Click

        Dim inserirQuery As String = "INSERT INTO dados (Nome, Utente,Localidade, Telemovel,Data) VALUES ('" & TxtNome.Text & "', '" & TxtUtente.Text & "','" & Txtlocalidade.Text & "', '" & Txttlm.Text & "', '" & DateTimePicker1.Value & "')"


        executarQuery(inserirQuery)

        MessageBox.Show("Dados Inseridos com sucesso")

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        Dim actualizarQuery As String = "UPDATE dados Set Nome='" & TxtNome.Text & "',Utente ='" & TxtUtente.Text & "',Localidade ='" & Txtlocalidade.Text & "' Telemovel ='" & Txttlm.Text & "', Data ='" & DateTimePicker1.Value & "', WHERE Id =" & TxtID.Text & ""

        executarQuery(actualizarQuery)

        MessageBox.Show("Dados Actualizados com sucesso")
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        Dim eliminaQuery As String = "Delete from dados Where Id=" & TxtID.Text

        executarQuery(eliminaQuery)

        MessageBox.Show("Utilizador Eliminado")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TxtID.Clear()
        Txtlocalidade.Clear()
        Txttlm.Clear()
        TxtNome.Clear()
        TxtUtente.Clear()




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class
