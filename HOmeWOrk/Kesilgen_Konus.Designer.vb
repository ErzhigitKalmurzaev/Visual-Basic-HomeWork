<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kesilgen_Konus
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
        Me.TextBox_H = New System.Windows.Forms.TextBox()
        Me.TextBox_R = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.TextBox_rr = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label_V = New System.Windows.Forms.Label()
        Me.Label_S = New System.Windows.Forms.Label()
        Me.Label_SW = New System.Windows.Forms.Label()
        Me.Result = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox_H
        '
        Me.TextBox_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox_H.Location = New System.Drawing.Point(495, 128)
        Me.TextBox_H.Name = "TextBox_H"
        Me.TextBox_H.Size = New System.Drawing.Size(169, 28)
        Me.TextBox_H.TabIndex = 7
        '
        'TextBox_R
        '
        Me.TextBox_R.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox_R.Location = New System.Drawing.Point(495, 23)
        Me.TextBox_R.Name = "TextBox_R"
        Me.TextBox_R.Size = New System.Drawing.Size(169, 28)
        Me.TextBox_R.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(314, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Кесилген конустун бийиктиги"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label.Location = New System.Drawing.Point(56, 23)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(342, 25)
        Me.Label.TabIndex = 4
        Me.Label.Text = "Кесилген конустун  чон радиусу "
        '
        'TextBox_rr
        '
        Me.TextBox_rr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox_rr.Location = New System.Drawing.Point(495, 72)
        Me.TextBox_rr.Name = "TextBox_rr"
        Me.TextBox_rr.Size = New System.Drawing.Size(169, 28)
        Me.TextBox_rr.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(353, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Кесилген конустун  кичи радиусу "
        '
        'Label_V
        '
        Me.Label_V.AutoSize = True
        Me.Label_V.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_V.Location = New System.Drawing.Point(56, 282)
        Me.Label_V.Name = "Label_V"
        Me.Label_V.Size = New System.Drawing.Size(286, 25)
        Me.Label_V.TabIndex = 14
        Me.Label_V.Text = "Кесилген конустун көлөмү"
        Me.Label_V.Visible = False
        '
        'Label_S
        '
        Me.Label_S.AutoSize = True
        Me.Label_S.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_S.Location = New System.Drawing.Point(56, 374)
        Me.Label_S.Name = "Label_S"
        Me.Label_S.Size = New System.Drawing.Size(343, 25)
        Me.Label_S.TabIndex = 13
        Me.Label_S.Text = "Кесилген конустун  толук аянты"
        Me.Label_S.Visible = False
        '
        'Label_SW
        '
        Me.Label_SW.AutoSize = True
        Me.Label_SW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_SW.Location = New System.Drawing.Point(56, 326)
        Me.Label_SW.Name = "Label_SW"
        Me.Label_SW.Size = New System.Drawing.Size(452, 25)
        Me.Label_SW.TabIndex = 12
        Me.Label_SW.Text = "Кесилген конустун  сырткы бетинин аянты"
        Me.Label_SW.Visible = False
        '
        'Result
        '
        Me.Result.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Result.Location = New System.Drawing.Point(286, 189)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(250, 58)
        Me.Result.TabIndex = 11
        Me.Result.Text = "Эсепте"
        Me.Result.UseVisualStyleBackColor = True
        '
        'Kesilgen_Konus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label_V)
        Me.Controls.Add(Me.Label_S)
        Me.Controls.Add(Me.Label_SW)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.TextBox_rr)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_H)
        Me.Controls.Add(Me.TextBox_R)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label)
        Me.Name = "Kesilgen_Konus"
        Me.Text = "Кесилген конус"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_H As TextBox
    Friend WithEvents TextBox_R As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label As Label
    Friend WithEvents TextBox_rr As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label_V As Label
    Friend WithEvents Label_S As Label
    Friend WithEvents Label_SW As Label
    Friend WithEvents Result As Button
End Class
