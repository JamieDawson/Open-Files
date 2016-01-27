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
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(16, 51)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(149, 23)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(13, 13)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(88, 13)
        Me.lblFile.TabIndex = 1
        Me.lblFile.Text = "No File Selected "
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(192, 86)
        Me.Controls.Add(Me.lblFile)
        Me.Controls.Add(Me.btnOpen)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpen As Button
    Friend WithEvents lblFile As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
