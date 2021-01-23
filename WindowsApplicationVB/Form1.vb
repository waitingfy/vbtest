Imports System.Data.SqlClient

Public Class Form1
    Dim cnnstr As String = "Initial Catalog=test_db;Data Source=DESKTOP-0TQBVUG\SQLEXPRESS;Integrated Security=True;"
    Dim cnn As New SqlConnection(cnnstr)
    'Dim Adapter As SqlDataAdapter
    'Dim dtable As New DataTable
    'Dim dt As New DataSet
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        TextBoxC.Text = ((Integer.Parse(TextBoxA.Text()) + Integer.Parse(TextBoxB.Text())).ToString())


    End Sub

    Private Function FillCombo() As Integer
        Dim sqlstr As String
        Dim Adapter As SqlDataAdapter
        Dim dtable As New DataTable
        sqlstr = "select CITY from facilit where FACILITY_NAME like '%" & facilityTextBox.Text & "%' group by CITY"
        Adapter = New SqlDataAdapter(sqlstr, cnn)
        dtable.Clear()
        Adapter.Fill(dtable)
        cityComboBox.DataSource = New DataView(dtable)
        cityComboBox.DisplayMember = "CITY"
        Return 1
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim sqlstr As String
        Dim dtable As New DataTable
        sqlstr = "select FACILITY_NAME, ADDRESS_1+' '+ADDRESS_2 as 'ADDRESS', DESCRIPTION_1 as 'SERVICE TYPE' from facilit where FACILITY_NAME like '%" & facilityTextBox.Text & "%' and CITY ='" & cityComboBox.Text & "'"
        Dim Adapter As SqlDataAdapter
        Adapter = New SqlDataAdapter(sqlstr, cnn)
        dtable.Clear()
        Adapter.Fill(dtable)
        resultGridView.DataSource = New DataView(dtable)

    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles resultGridView.MouseClick

    End Sub

    Private Sub facilityTextBox_TextChanged(sender As Object, e As EventArgs) Handles facilityTextBox.TextChanged
        FillCombo()
    End Sub
End Class
