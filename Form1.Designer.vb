<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.lbltext1 = New System.Windows.Forms.Label()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.lbltext2 = New System.Windows.Forms.Label()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.lbltext3 = New System.Windows.Forms.Label()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.lbltext4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(275, 28)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(94, 29)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "click"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'lbltext1
        '
        Me.lbltext1.AutoSize = True
        Me.lbltext1.Location = New System.Drawing.Point(437, 31)
        Me.lbltext1.Name = "lbltext1"
        Me.lbltext1.Size = New System.Drawing.Size(53, 20)
        Me.lbltext1.TabIndex = 1
        Me.lbltext1.Text = "Label1"
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(275, 105)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(94, 29)
        Me.btn2.TabIndex = 2
        Me.btn2.Text = "click"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'lbltext2
        '
        Me.lbltext2.AutoSize = True
        Me.lbltext2.Location = New System.Drawing.Point(437, 108)
        Me.lbltext2.Name = "lbltext2"
        Me.lbltext2.Size = New System.Drawing.Size(53, 20)
        Me.lbltext2.TabIndex = 3
        Me.lbltext2.Text = "Label2"
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(90, 108)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(125, 27)
        Me.tb1.TabIndex = 4
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(275, 196)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(94, 29)
        Me.btn3.TabIndex = 5
        Me.btn3.Text = "click"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'lbltext3
        '
        Me.lbltext3.AutoSize = True
        Me.lbltext3.Location = New System.Drawing.Point(437, 199)
        Me.lbltext3.Name = "lbltext3"
        Me.lbltext3.Size = New System.Drawing.Size(53, 20)
        Me.lbltext3.TabIndex = 6
        Me.lbltext3.Text = "Label3"
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(90, 273)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(125, 27)
        Me.tb2.TabIndex = 7
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(275, 271)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(94, 29)
        Me.btn4.TabIndex = 8
        Me.btn4.Text = "click"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'lbltext4
        '
        Me.lbltext4.AutoSize = True
        Me.lbltext4.Location = New System.Drawing.Point(437, 280)
        Me.lbltext4.Name = "lbltext4"
        Me.lbltext4.Size = New System.Drawing.Size(53, 20)
        Me.lbltext4.TabIndex = 9
        Me.lbltext4.Text = "Label4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbltext4)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.lbltext3)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.lbltext2)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.lbltext1)
        Me.Controls.Add(Me.btn1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents lbltext1 As Label
    Friend WithEvents btn2 As Button
    Friend WithEvents lbltext2 As Label
    Friend WithEvents tb1 As TextBox
    Friend WithEvents btn3 As Button
    Friend WithEvents lbltext3 As Label
    Friend WithEvents tb2 As TextBox
    Friend WithEvents btn4 As Button
    Friend WithEvents lbltext4 As Label
End Class
