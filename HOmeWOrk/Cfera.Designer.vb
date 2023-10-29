<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cfera
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label_R = New System.Windows.Forms.Label()
        Me.TextBox_R = New System.Windows.Forms.TextBox()
        Me.Label_V = New System.Windows.Forms.Label()
        Me.Label_S = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label_R
        '
        Me.Label_R.AutoSize = True
        Me.Label_R.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_R.Location = New System.Drawing.Point(48, 75)
        Me.Label_R.Name = "Label_R"
        Me.Label_R.Size = New System.Drawing.Size(187, 20)
        Me.Label_R.TabIndex = 0
        Me.Label_R.Text = "Сферанын радиусу"
        '
        'TextBox_R
        '
        Me.TextBox_R.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox_R.Location = New System.Drawing.Point(296, 72)
        Me.TextBox_R.Multiline = True
        Me.TextBox_R.Name = "TextBox_R"
        Me.TextBox_R.Size = New System.Drawing.Size(224, 31)
        Me.TextBox_R.TabIndex = 1
        '
        'Label_V
        '
        Me.Label_V.AutoSize = True
        Me.Label_V.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_V.Location = New System.Drawing.Point(48, 286)
        Me.Label_V.Name = "Label_V"
        Me.Label_V.Size = New System.Drawing.Size(182, 20)
        Me.Label_V.TabIndex = 2
        Me.Label_V.Text = "Сферанын  көлөмү"
        Me.Label_V.Visible = False
        '
        'Label_S
        '
        Me.Label_S.AutoSize = True
        Me.Label_S.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_S.Location = New System.Drawing.Point(48, 246)
        Me.Label_S.Name = "Label_S"
        Me.Label_S.Size = New System.Drawing.Size(170, 20)
        Me.Label_S.TabIndex = 3
        Me.Label_S.Text = "Cферанын аянты"
        Me.Label_S.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(296, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(224, 42)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Эсепте"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cfera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label_S)
        Me.Controls.Add(Me.Label_V)
        Me.Controls.Add(Me.TextBox_R)
        Me.Controls.Add(Me.Label_R)
        Me.Name = "Cfera"
        Me.Text = "Сфера"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_R As Label
    Friend WithEvents TextBox_R As TextBox
    Friend WithEvents Label_V As Label
    Friend WithEvents Label_S As Label
    Friend WithEvents Button1 As Button
End Class
