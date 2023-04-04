<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuccessfulLoginForm
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
        dgvLog = New DataGridView()
        CType(dgvLog, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvLog
        ' 
        dgvLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLog.Location = New Point(41, 26)
        dgvLog.Name = "dgvLog"
        dgvLog.RowTemplate.Height = 25
        dgvLog.Size = New Size(516, 351)
        dgvLog.TabIndex = 0
        ' 
        ' SuccessfulLoginForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(572, 385)
        Controls.Add(dgvLog)
        Name = "SuccessfulLoginForm"
        Text = "SuccessfulLoginForm"
        CType(dgvLog, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvLog As DataGridView
End Class
