<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picUk = New System.Windows.Forms.PictureBox()
        Me.picAustralia = New System.Windows.Forms.PictureBox()
        Me.picUsa = New System.Windows.Forms.PictureBox()
        Me.picGermany = New System.Windows.Forms.PictureBox()
        Me.picGreece = New System.Windows.Forms.PictureBox()
        Me.picCanada = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.TextBox()
        CType(Me.picUk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAustralia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUsa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGermany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGreece, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCanada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click a Flag to Learn Its Country"
        '
        'picUk
        '
        Me.picUk.Image = Global.Flags.My.Resources.Resources.uk1
        Me.picUk.Location = New System.Drawing.Point(174, 158)
        Me.picUk.Name = "picUk"
        Me.picUk.Size = New System.Drawing.Size(72, 46)
        Me.picUk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUk.TabIndex = 6
        Me.picUk.TabStop = False
        '
        'picAustralia
        '
        Me.picAustralia.Image = Global.Flags.My.Resources.Resources.australia
        Me.picAustralia.Location = New System.Drawing.Point(174, 38)
        Me.picAustralia.Name = "picAustralia"
        Me.picAustralia.Size = New System.Drawing.Size(72, 41)
        Me.picAustralia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAustralia.TabIndex = 5
        Me.picAustralia.TabStop = False
        '
        'picUsa
        '
        Me.picUsa.Image = Global.Flags.My.Resources.Resources.usa
        Me.picUsa.Location = New System.Drawing.Point(31, 102)
        Me.picUsa.Name = "picUsa"
        Me.picUsa.Size = New System.Drawing.Size(72, 42)
        Me.picUsa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUsa.TabIndex = 4
        Me.picUsa.TabStop = False
        '
        'picGermany
        '
        Me.picGermany.Image = Global.Flags.My.Resources.Resources.germany
        Me.picGermany.Location = New System.Drawing.Point(174, 102)
        Me.picGermany.Name = "picGermany"
        Me.picGermany.Size = New System.Drawing.Size(72, 42)
        Me.picGermany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGermany.TabIndex = 3
        Me.picGermany.TabStop = False
        '
        'picGreece
        '
        Me.picGreece.Image = Global.Flags.My.Resources.Resources.greece
        Me.picGreece.Location = New System.Drawing.Point(31, 158)
        Me.picGreece.Name = "picGreece"
        Me.picGreece.Size = New System.Drawing.Size(72, 46)
        Me.picGreece.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGreece.TabIndex = 2
        Me.picGreece.TabStop = False
        '
        'picCanada
        '
        Me.picCanada.Image = Global.Flags.My.Resources.Resources.canada
        Me.picCanada.Location = New System.Drawing.Point(31, 38)
        Me.picCanada.Name = "picCanada"
        Me.picCanada.Size = New System.Drawing.Size(72, 41)
        Me.picCanada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCanada.TabIndex = 1
        Me.picCanada.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(103, 261)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(54, 229)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(166, 20)
        Me.lblMessage.TabIndex = 7
        Me.lblMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 296)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.picUk)
        Me.Controls.Add(Me.picAustralia)
        Me.Controls.Add(Me.picUsa)
        Me.Controls.Add(Me.picGermany)
        Me.Controls.Add(Me.picGreece)
        Me.Controls.Add(Me.picCanada)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Flags"
        CType(Me.picUk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAustralia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUsa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGermany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGreece, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCanada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents picCanada As PictureBox
    Friend WithEvents picGreece As PictureBox
    Friend WithEvents picGermany As PictureBox
    Friend WithEvents picUsa As PictureBox
    Friend WithEvents picAustralia As PictureBox
    Friend WithEvents picUk As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents lblMessage As TextBox
End Class
