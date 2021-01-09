Imports System.Data.SqlClient

Public Class Form1
    Dim cnnstr As String = "Initial Catalog=test_db;Data Source=DESKTOP-0TQBVUG\SQLEXPRESS;Integrated Security=True;"
    Dim cnn As New SqlConnection(cnnstr)
    Dim Adapter As SqlDataAdapter
    Dim dtable As New DataTable
    Dim dt As New DataSet
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        TextBoxC.Text = ((Integer.Parse(TextBoxA.Text()) + Integer.Parse(TextBoxB.Text())).ToString())


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO:  这行代码将数据加载到表“Test_dbDataSet.test_table”中。您可以根据需要移动或删除它。
        Me.Test_tableTableAdapter.Fill(Me.Test_dbDataSet.test_table)
        'TODO:  这行代码将数据加载到表“TestDataSet.test”中。您可以根据需要移动或删除它。
        'Me.TestTableAdapter.Fill(Me.TestDataSet.test)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlstr As String
        sqlstr = "select * from test_table where s_name like '%" & TextBoxName.Text & "%'"
        Me.Adapter = New SqlDataAdapter(sqlstr, cnn)
        dtable.Clear()
        Me.Adapter.Fill(dtable)
        DataGridView1.DataSource = New DataView(dtable)
    End Sub
End Class
