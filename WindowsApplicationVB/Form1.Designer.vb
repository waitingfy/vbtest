<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxA = New System.Windows.Forms.TextBox()
        Me.TextBoxB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.resultGridView = New System.Windows.Forms.DataGridView()
        Me.TestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestDataSet = New WindowsApplicationVB.testDataSet()
        Me.TestTableAdapter = New WindowsApplicationVB.testDataSetTableAdapters.testTableAdapter()
        Me.facilityTextBox = New System.Windows.Forms.TextBox()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.Test_dbDataSet = New WindowsApplicationVB.test_dbDataSet()
        Me.TesttableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Test_tableTableAdapter = New WindowsApplicationVB.test_dbDataSetTableAdapters.test_tableTableAdapter()
        Me.cityComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.resultGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Test_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TesttableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(444, 114)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(180, 33)
        Me.ButtonAdd.TabIndex = 0
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "A"
        '
        'TextBoxA
        '
        Me.TextBoxA.Location = New System.Drawing.Point(180, 63)
        Me.TextBoxA.Name = "TextBoxA"
        Me.TextBoxA.Size = New System.Drawing.Size(227, 28)
        Me.TextBoxA.TabIndex = 2
        '
        'TextBoxB
        '
        Me.TextBoxB.Location = New System.Drawing.Point(180, 118)
        Me.TextBoxB.Name = "TextBoxB"
        Me.TextBoxB.Size = New System.Drawing.Size(227, 28)
        Me.TextBoxB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "B"
        '
        'TextBoxC
        '
        Me.TextBoxC.Location = New System.Drawing.Point(180, 191)
        Me.TextBoxC.Name = "TextBoxC"
        Me.TextBoxC.Size = New System.Drawing.Size(100, 28)
        Me.TextBoxC.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "C"
        '
        'resultGridView
        '
        Me.resultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.resultGridView.Location = New System.Drawing.Point(141, 406)
        Me.resultGridView.Name = "resultGridView"
        Me.resultGridView.RowTemplate.Height = 30
        Me.resultGridView.Size = New System.Drawing.Size(722, 150)
        Me.resultGridView.TabIndex = 7
        '
        'TestBindingSource
        '
        Me.TestBindingSource.DataMember = "test"
        Me.TestBindingSource.DataSource = Me.TestDataSet
        '
        'TestDataSet
        '
        Me.TestDataSet.DataSetName = "testDataSet"
        Me.TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TestTableAdapter
        '
        Me.TestTableAdapter.ClearBeforeFill = True
        '
        'facilityTextBox
        '
        Me.facilityTextBox.Location = New System.Drawing.Point(141, 300)
        Me.facilityTextBox.Name = "facilityTextBox"
        Me.facilityTextBox.Size = New System.Drawing.Size(184, 28)
        Me.facilityTextBox.TabIndex = 8
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(141, 353)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(180, 33)
        Me.searchButton.TabIndex = 9
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'Test_dbDataSet
        '
        Me.Test_dbDataSet.DataSetName = "test_dbDataSet"
        Me.Test_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TesttableBindingSource
        '
        Me.TesttableBindingSource.DataMember = "test_table"
        Me.TesttableBindingSource.DataSource = Me.Test_dbDataSet
        '
        'Test_tableTableAdapter
        '
        Me.Test_tableTableAdapter.ClearBeforeFill = True
        '
        'cityComboBox
        '
        Me.cityComboBox.FormattingEnabled = True
        Me.cityComboBox.Location = New System.Drawing.Point(332, 300)
        Me.cityComboBox.Name = "cityComboBox"
        Me.cityComboBox.Size = New System.Drawing.Size(195, 26)
        Me.cityComboBox.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 568)
        Me.Controls.Add(Me.cityComboBox)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.facilityTextBox)
        Me.Controls.Add(Me.resultGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxB)
        Me.Controls.Add(Me.TextBoxA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.resultGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Test_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TesttableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxA As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxB As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxC As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents resultGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TestDataSet As WindowsApplicationVB.testDataSet
    Friend WithEvents TestBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TestTableAdapter As WindowsApplicationVB.testDataSetTableAdapters.testTableAdapter
    Friend WithEvents facilityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents Test_dbDataSet As WindowsApplicationVB.test_dbDataSet
    Friend WithEvents TesttableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Test_tableTableAdapter As WindowsApplicationVB.test_dbDataSetTableAdapters.test_tableTableAdapter
    Friend WithEvents cityComboBox As System.Windows.Forms.ComboBox

End Class
