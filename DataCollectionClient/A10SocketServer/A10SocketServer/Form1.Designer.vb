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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.btnShowLog = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.lblSent = New System.Windows.Forms.Label()
        Me.lblErr = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(12, 42)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(515, 439)
        Me.txtLog.TabIndex = 0
        Me.txtLog.Visible = False
        '
        'btnShowLog
        '
        Me.btnShowLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowLog.Location = New System.Drawing.Point(208, 12)
        Me.btnShowLog.Name = "btnShowLog"
        Me.btnShowLog.Size = New System.Drawing.Size(75, 23)
        Me.btnShowLog.TabIndex = 2
        Me.btnShowLog.Text = "Show Log"
        Me.btnShowLog.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.CadetBlue
        Me.lblMsg.Location = New System.Drawing.Point(0, 4)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(45, 13)
        Me.lblMsg.TabIndex = 3
        Me.lblMsg.Text = "Label1"
        '
        'lblSent
        '
        Me.lblSent.AutoSize = True
        Me.lblSent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSent.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblSent.Location = New System.Drawing.Point(0, 22)
        Me.lblSent.Name = "lblSent"
        Me.lblSent.Size = New System.Drawing.Size(45, 13)
        Me.lblSent.TabIndex = 4
        Me.lblSent.Text = "Label2"
        '
        'lblErr
        '
        Me.lblErr.AutoSize = True
        Me.lblErr.ForeColor = System.Drawing.Color.Red
        Me.lblErr.Location = New System.Drawing.Point(83, 2)
        Me.lblErr.Name = "lblErr"
        Me.lblErr.Size = New System.Drawing.Size(39, 13)
        Me.lblErr.TabIndex = 5
        Me.lblErr.Text = "Label3"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(127, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Import"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(295, 40)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblErr)
        Me.Controls.Add(Me.lblSent)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btnShowLog)
        Me.Controls.Add(Me.txtLog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Data Collector of DOOM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents btnShowLog As System.Windows.Forms.Button
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents lblSent As System.Windows.Forms.Label
    Friend WithEvents lblErr As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
