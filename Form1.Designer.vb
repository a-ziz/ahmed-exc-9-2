<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.btnParseName = New System.Windows.Forms.Button()
        Me.btnEditPhoneNumber = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter full name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter  phone number:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(212, 27)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(217, 22)
        Me.txtName.TabIndex = 2
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(212, 66)
        Me.txtPhoneNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(135, 22)
        Me.txtPhoneNumber.TabIndex = 3
        '
        'btnParseName
        '
        Me.btnParseName.Location = New System.Drawing.Point(459, 25)
        Me.btnParseName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnParseName.Name = "btnParseName"
        Me.btnParseName.Size = New System.Drawing.Size(167, 28)
        Me.btnParseName.TabIndex = 4
        Me.btnParseName.Text = "Parse Name"
        Me.btnParseName.UseVisualStyleBackColor = True
        '
        'btnEditPhoneNumber
        '
        Me.btnEditPhoneNumber.Location = New System.Drawing.Point(459, 64)
        Me.btnEditPhoneNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEditPhoneNumber.Name = "btnEditPhoneNumber"
        Me.btnEditPhoneNumber.Size = New System.Drawing.Size(167, 28)
        Me.btnEditPhoneNumber.TabIndex = 5
        Me.btnEditPhoneNumber.Text = "Edit Phone Number"
        Me.btnEditPhoneNumber.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(459, 139)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(167, 28)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(683, 193)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEditPhoneNumber)
        Me.Controls.Add(Me.btnParseName)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "String Handling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnParseName As System.Windows.Forms.Button
    Friend WithEvents btnEditPhoneNumber As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
