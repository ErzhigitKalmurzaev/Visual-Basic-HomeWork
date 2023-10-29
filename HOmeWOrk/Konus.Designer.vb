<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Konus
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_R = New System.Windows.Forms.TextBox()
        Me.TextBox_H = New System.Windows.Forms.TextBox()
        Me.Result = New System.Windows.Forms.Button()
        Me.Label_SW = New System.Windows.Forms.Label()
        Me.Label_S = New System.Windows.Forms.Label()
        Me.Label_V = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Конустун радиусу "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Конустун бийиктиги"
        '
        'TextBox_R
        '
        Me.TextBox_R.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox_R.Location = New System.Drawing.Point(347, 53)
        Me.TextBox_R.Name = "TextBox_R"
        Me.TextBox_R.Size = New System.Drawing.Size(169, 28)
        Me.TextBox_R.TabIndex = 2
        '
        'TextBox_H
        '
        Me.TextBox_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox_H.Location = New System.Drawing.Point(347, 116)
        Me.TextBox_H.Name = "TextBox_H"
        Me.TextBox_H.Size = New System.Drawing.Size(169, 28)
        Me.TextBox_H.TabIndex = 3
        '
        'Result
        '
        Me.Result.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Result.Location = New System.Drawing.Point(293, 173)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(250, 58)
        Me.Result.TabIndex = 7
        Me.Result.Text = "Эсепте"
        Me.Result.UseVisualStyleBackColor = True
        '
        'Label_SW
        '
        Me.Label_SW.AutoSize = True
        Me.Label_SW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_SW.Location = New System.Drawing.Point(63, 310)
        Me.Label_SW.Name = "Label_SW"
        Me.Label_SW.Size = New System.Drawing.Size(348, 25)
        Me.Label_SW.TabIndex = 8
        Me.Label_SW.Text = "Конустун сырткы бетинин аянты"
        Me.Label_SW.Visible = False
        '
        'Label_S
        '
        Me.Label_S.AutoSize = True
        Me.Label_S.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_S.Location = New System.Drawing.Point(63, 358)
        Me.Label_S.Name = "Label_S"
        Me.Label_S.Size = New System.Drawing.Size(239, 25)
        Me.Label_S.TabIndex = 9
        Me.Label_S.Text = "Конустун толук аянты"
        Me.Label_S.Visible = False
        '
        'Label_V
        '
        Me.Label_V.AutoSize = True
        Me.Label_V.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_V.Location = New System.Drawing.Point(63, 266)
        Me.Label_V.Name = "Label_V"
        Me.Label_V.Size = New System.Drawing.Size(188, 25)
        Me.Label_V.TabIndex = 10
        Me.Label_V.Text = "Конустун көлөмү"
        Me.Label_V.Visible = False
        '
        'Konus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label_V)
        Me.Controls.Add(Me.Label_S)
        Me.Controls.Add(Me.Label_SW)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.TextBox_H)
        Me.Controls.Add(Me.TextBox_R)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Konus"
        Me.Text = "Конус"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_R As TextBox
    Friend WithEvents TextBox_H As TextBox
    Friend WithEvents Result As Button
    Friend WithEvents Label_SW As Label
    Friend WithEvents Label_S As Label
    Friend WithEvents Label_V As Label
End Class
