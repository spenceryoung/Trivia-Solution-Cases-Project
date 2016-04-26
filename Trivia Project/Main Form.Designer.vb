<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.aRadioButton = New System.Windows.Forms.RadioButton()
        Me.bRadioButton = New System.Windows.Forms.RadioButton()
        Me.cRadioButton = New System.Windows.Forms.RadioButton()
        Me.dRadioButton = New System.Windows.Forms.RadioButton()
        Me.questionTextBox = New System.Windows.Forms.TextBox()
        Me.TblGameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TriviaDataSet = New Trivia_Project.TriviaDataSet()
        Me.aTextBox = New System.Windows.Forms.TextBox()
        Me.bTextBox = New System.Windows.Forms.TextBox()
        Me.cTextBox = New System.Windows.Forms.TextBox()
        Me.dTextBox = New System.Windows.Forms.TextBox()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.TblGameTableAdapter = New Trivia_Project.TriviaDataSetTableAdapters.tblGameTableAdapter()
        Me.TableAdapterManager = New Trivia_Project.TriviaDataSetTableAdapters.TableAdapterManager()
        Me.previousButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.changeButton = New System.Windows.Forms.Button()
        Me.incorrectButton = New System.Windows.Forms.Button()
        CType(Me.TblGameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TriviaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Question:"
        '
        'aRadioButton
        '
        Me.aRadioButton.AutoSize = True
        Me.aRadioButton.Checked = True
        Me.aRadioButton.Location = New System.Drawing.Point(17, 114)
        Me.aRadioButton.Name = "aRadioButton"
        Me.aRadioButton.Size = New System.Drawing.Size(34, 21)
        Me.aRadioButton.TabIndex = 8
        Me.aRadioButton.TabStop = True
        Me.aRadioButton.Text = "&A"
        Me.aRadioButton.UseVisualStyleBackColor = True
        '
        'bRadioButton
        '
        Me.bRadioButton.AutoSize = True
        Me.bRadioButton.Location = New System.Drawing.Point(17, 160)
        Me.bRadioButton.Name = "bRadioButton"
        Me.bRadioButton.Size = New System.Drawing.Size(33, 21)
        Me.bRadioButton.TabIndex = 9
        Me.bRadioButton.Text = "&B"
        Me.bRadioButton.UseVisualStyleBackColor = True
        '
        'cRadioButton
        '
        Me.cRadioButton.AutoSize = True
        Me.cRadioButton.Location = New System.Drawing.Point(17, 206)
        Me.cRadioButton.Name = "cRadioButton"
        Me.cRadioButton.Size = New System.Drawing.Size(34, 21)
        Me.cRadioButton.TabIndex = 10
        Me.cRadioButton.Text = "&C"
        Me.cRadioButton.UseVisualStyleBackColor = True
        '
        'dRadioButton
        '
        Me.dRadioButton.AutoSize = True
        Me.dRadioButton.Location = New System.Drawing.Point(17, 252)
        Me.dRadioButton.Name = "dRadioButton"
        Me.dRadioButton.Size = New System.Drawing.Size(35, 21)
        Me.dRadioButton.TabIndex = 11
        Me.dRadioButton.Text = "&D"
        Me.dRadioButton.UseVisualStyleBackColor = True
        '
        'questionTextBox
        '
        Me.questionTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.questionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGameBindingSource, "Question", True))
        Me.questionTextBox.Location = New System.Drawing.Point(16, 33)
        Me.questionTextBox.Multiline = True
        Me.questionTextBox.Name = "questionTextBox"
        Me.questionTextBox.ReadOnly = True
        Me.questionTextBox.Size = New System.Drawing.Size(461, 51)
        Me.questionTextBox.TabIndex = 7
        '
        'TblGameBindingSource
        '
        Me.TblGameBindingSource.DataMember = "tblGame"
        Me.TblGameBindingSource.DataSource = Me.TriviaDataSet
        '
        'TriviaDataSet
        '
        Me.TriviaDataSet.DataSetName = "TriviaDataSet"
        Me.TriviaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'aTextBox
        '
        Me.aTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGameBindingSource, "AnswerA", True))
        Me.aTextBox.Location = New System.Drawing.Point(56, 113)
        Me.aTextBox.Multiline = True
        Me.aTextBox.Name = "aTextBox"
        Me.aTextBox.ReadOnly = True
        Me.aTextBox.Size = New System.Drawing.Size(421, 31)
        Me.aTextBox.TabIndex = 12
        '
        'bTextBox
        '
        Me.bTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGameBindingSource, "AnswerB", True))
        Me.bTextBox.Location = New System.Drawing.Point(56, 159)
        Me.bTextBox.Multiline = True
        Me.bTextBox.Name = "bTextBox"
        Me.bTextBox.ReadOnly = True
        Me.bTextBox.Size = New System.Drawing.Size(421, 31)
        Me.bTextBox.TabIndex = 13
        '
        'cTextBox
        '
        Me.cTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGameBindingSource, "AnswerC", True))
        Me.cTextBox.Location = New System.Drawing.Point(56, 205)
        Me.cTextBox.Multiline = True
        Me.cTextBox.Name = "cTextBox"
        Me.cTextBox.ReadOnly = True
        Me.cTextBox.Size = New System.Drawing.Size(421, 31)
        Me.cTextBox.TabIndex = 14
        '
        'dTextBox
        '
        Me.dTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGameBindingSource, "AnswerD", True))
        Me.dTextBox.Location = New System.Drawing.Point(57, 251)
        Me.dTextBox.Multiline = True
        Me.dTextBox.Name = "dTextBox"
        Me.dTextBox.ReadOnly = True
        Me.dTextBox.Size = New System.Drawing.Size(421, 31)
        Me.dTextBox.TabIndex = 15
        '
        'submitButton
        '
        Me.submitButton.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.submitButton.Location = New System.Drawing.Point(516, 128)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(122, 32)
        Me.submitButton.TabIndex = 2
        Me.submitButton.Text = "&Submit Answer"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(516, 242)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(122, 32)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'TblGameTableAdapter
        '
        Me.TblGameTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblGameTableAdapter = Me.TblGameTableAdapter
        Me.TableAdapterManager.UpdateOrder = Trivia_Project.TriviaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'previousButton
        '
        Me.previousButton.Location = New System.Drawing.Point(516, 52)
        Me.previousButton.Name = "previousButton"
        Me.previousButton.Size = New System.Drawing.Size(122, 32)
        Me.previousButton.TabIndex = 0
        Me.previousButton.Text = "Previous Question"
        Me.previousButton.UseVisualStyleBackColor = True
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(516, 90)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(122, 32)
        Me.nextButton.TabIndex = 1
        Me.nextButton.Text = "Next Question"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'changeButton
        '
        Me.changeButton.Location = New System.Drawing.Point(516, 166)
        Me.changeButton.Name = "changeButton"
        Me.changeButton.Size = New System.Drawing.Size(122, 32)
        Me.changeButton.TabIndex = 3
        Me.changeButton.Text = "Change Answer"
        Me.changeButton.UseVisualStyleBackColor = True
        '
        'incorrectButton
        '
        Me.incorrectButton.Location = New System.Drawing.Point(516, 204)
        Me.incorrectButton.Name = "incorrectButton"
        Me.incorrectButton.Size = New System.Drawing.Size(122, 32)
        Me.incorrectButton.TabIndex = 4
        Me.incorrectButton.Text = "Number Incorrect"
        Me.incorrectButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 312)
        Me.Controls.Add(Me.incorrectButton)
        Me.Controls.Add(Me.changeButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.previousButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.dTextBox)
        Me.Controls.Add(Me.cTextBox)
        Me.Controls.Add(Me.bTextBox)
        Me.Controls.Add(Me.aTextBox)
        Me.Controls.Add(Me.questionTextBox)
        Me.Controls.Add(Me.dRadioButton)
        Me.Controls.Add(Me.cRadioButton)
        Me.Controls.Add(Me.bRadioButton)
        Me.Controls.Add(Me.aRadioButton)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trivia Game"
        CType(Me.TblGameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TriviaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents aRadioButton As RadioButton
    Friend WithEvents bRadioButton As RadioButton
    Friend WithEvents cRadioButton As RadioButton
    Friend WithEvents dRadioButton As RadioButton
    Friend WithEvents questionTextBox As TextBox
    Friend WithEvents aTextBox As TextBox
    Friend WithEvents bTextBox As TextBox
    Friend WithEvents cTextBox As TextBox
    Friend WithEvents dTextBox As TextBox
    Friend WithEvents submitButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents TriviaDataSet As TriviaDataSet
    Friend WithEvents TblGameBindingSource As BindingSource
    Friend WithEvents TblGameTableAdapter As TriviaDataSetTableAdapters.tblGameTableAdapter
    Friend WithEvents TableAdapterManager As TriviaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents previousButton As Button
    Friend WithEvents nextButton As Button
    Friend WithEvents changeButton As Button
    Friend WithEvents incorrectButton As Button
End Class
