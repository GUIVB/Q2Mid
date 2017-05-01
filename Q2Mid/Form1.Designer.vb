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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.factTB = New System.Windows.Forms.TextBox()
        Me.YTb = New System.Windows.Forms.TextBox()
        Me.XTb = New System.Windows.Forms.TextBox()
        Me.FactBtn = New System.Windows.Forms.Button()
        Me.PowBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PowerR = New System.Windows.Forms.Label()
        Me.FacR = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N! ="
        '
        'factTB
        '
        Me.factTB.Location = New System.Drawing.Point(94, 101)
        Me.factTB.Name = "factTB"
        Me.factTB.Size = New System.Drawing.Size(179, 20)
        Me.factTB.TabIndex = 1
        '
        'YTb
        '
        Me.YTb.Location = New System.Drawing.Point(218, 173)
        Me.YTb.Name = "YTb"
        Me.YTb.Size = New System.Drawing.Size(55, 20)
        Me.YTb.TabIndex = 2
        '
        'XTb
        '
        Me.XTb.Location = New System.Drawing.Point(94, 173)
        Me.XTb.Name = "XTb"
        Me.XTb.Size = New System.Drawing.Size(60, 20)
        Me.XTb.TabIndex = 3
        '
        'FactBtn
        '
        Me.FactBtn.Location = New System.Drawing.Point(307, 98)
        Me.FactBtn.Name = "FactBtn"
        Me.FactBtn.Size = New System.Drawing.Size(75, 23)
        Me.FactBtn.TabIndex = 4
        Me.FactBtn.Text = "Factorial"
        Me.FactBtn.UseVisualStyleBackColor = True
        '
        'PowBtn
        '
        Me.PowBtn.Location = New System.Drawing.Point(307, 170)
        Me.PowBtn.Name = "PowBtn"
        Me.PowBtn.Size = New System.Drawing.Size(75, 23)
        Me.PowBtn.TabIndex = 5
        Me.PowBtn.Text = "Power"
        Me.PowBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "X ="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(174, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Y ="
        '
        'PowerR
        '
        Me.PowerR.AutoSize = True
        Me.PowerR.Location = New System.Drawing.Point(405, 175)
        Me.PowerR.Name = "PowerR"
        Me.PowerR.Size = New System.Drawing.Size(47, 13)
        Me.PowerR.TabIndex = 8
        Me.PowerR.Text = "Result : "
        '
        'FacR
        '
        Me.FacR.AutoSize = True
        Me.FacR.Location = New System.Drawing.Point(405, 104)
        Me.FacR.Name = "FacR"
        Me.FacR.Size = New System.Drawing.Size(47, 13)
        Me.FacR.TabIndex = 9
        Me.FacR.Text = "Result : "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 293)
        Me.Controls.Add(Me.FacR)
        Me.Controls.Add(Me.PowerR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PowBtn)
        Me.Controls.Add(Me.FactBtn)
        Me.Controls.Add(Me.XTb)
        Me.Controls.Add(Me.YTb)
        Me.Controls.Add(Me.factTB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents factTB As TextBox
    Friend WithEvents YTb As TextBox
    Friend WithEvents XTb As TextBox
    Friend WithEvents FactBtn As Button
    Friend WithEvents PowBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PowerR As Label
    Friend WithEvents FacR As Label
End Class
