Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sql7DataSet.dados' table. You can move, or remove it, as needed.
        Me.DadosTableAdapter.Fill(Me.Sql7DataSet.dados)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class