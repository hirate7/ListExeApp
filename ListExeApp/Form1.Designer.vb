<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCListExeApp
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdShow = New System.Windows.Forms.Button()
        Me.List1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cmdShow
        '
        Me.cmdShow.Location = New System.Drawing.Point(27, 23)
        Me.cmdShow.Name = "cmdShow"
        Me.cmdShow.Size = New System.Drawing.Size(77, 33)
        Me.cmdShow.TabIndex = 0
        Me.cmdShow.Text = "表示"
        Me.cmdShow.UseVisualStyleBackColor = True
        '
        'List1
        '
        Me.List1.FormattingEnabled = True
        Me.List1.ItemHeight = 12
        Me.List1.Location = New System.Drawing.Point(124, 23)
        Me.List1.Name = "List1"
        Me.List1.Size = New System.Drawing.Size(1100, 304)
        Me.List1.TabIndex = 1
        '
        'frmCListExeApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 343)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.cmdShow)
        Me.Name = "frmCListExeApp"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdShow As Button
    Friend WithEvents List1 As ListBox
End Class
