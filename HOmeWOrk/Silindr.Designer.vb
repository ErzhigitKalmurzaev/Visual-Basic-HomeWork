<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Silindr
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
        Me.Label_S = New System.Windows.Forms.Label()
        Me.R_V = New System.Windows.Forms.TextBox()
        Me.H_V = New System.Windows.Forms.TextBox()
        Me.Result = New System.Windows.Forms.Button()
        Me.Label_SW = New System.Windows.Forms.Label()
        Me.Label_V = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Цлиндирдин бийиктини"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Цилиндрдин радиусу"
        '
        'Label_S
        '
        Me.Label_S.AutoSize = True
        Me.Label_S.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_S.Location = New System.Drawing.Point(30, 292)
        Me.Label_S.Name = "Label_S"
        Me.Label_S.Size = New System.Drawing.Size(312, 20)
        Me.Label_S.TabIndex = 3
        Me.Label_S.Text = "цилиндрдин сырткы бетинин аянты"
        Me.Label_S.Visible = False
        '
        'R_V
        '
        Me.R_V.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.R_V.Location = New System.Drawing.Point(315, 27)
        Me.R_V.Multiline = True
        Me.R_V.Name = "R_V"
        Me.R_V.Size = New System.Drawing.Size(250, 36)
        Me.R_V.TabIndex = 4
        '
        'H_V
        '
        Me.H_V.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.H_V.Location = New System.Drawing.Point(315, 90)
        Me.H_V.Multiline = True
        Me.H_V.Name = "H_V"
        Me.H_V.Size = New System.Drawing.Size(250, 37)
        Me.H_V.TabIndex = 5
        '
        'Result
        '
        Me.Result.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Result.Location = New System.Drawing.Point(315, 178)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(250, 58)
        Me.Result.TabIndex = 6
        Me.Result.Text = "Эсепте"
        Me.Result.UseVisualStyleBackColor = True
        '
        'Label_SW
        '
        Me.Label_SW.AutoSize = True
        Me.Label_SW.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_SW.Location = New System.Drawing.Point(31, 377)
        Me.Label_SW.Name = "Label_SW"
        Me.Label_SW.Size = New System.Drawing.Size(222, 20)
        Me.Label_SW.TabIndex = 7
        Me.Label_SW.Text = "цилиндрдин толук аянты"
        Me.Label_SW.Visible = False
        '
        'Label_V
        '
        Me.Label_V.AutoSize = True
        Me.Label_V.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_V.Location = New System.Drawing.Point(30, 335)
        Me.Label_V.Name = "Label_V"
        Me.Label_V.Size = New System.Drawing.Size(175, 20)
        Me.Label_V.TabIndex = 8
        Me.Label_V.Text = "цилиндрдин көлөмү"
        Me.Label_V.Visible = False
        '
        'Silindr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label_V)
        Me.Controls.Add(Me.Label_SW)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.H_V)
        Me.Controls.Add(Me.R_V)
        Me.Controls.Add(Me.Label_S)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Silindr"
        Me.Text = "Силиндр"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_S As Label
    Friend WithEvents R_V As TextBox
    Friend WithEvents H_V As TextBox
    Friend WithEvents Result As Button
    Friend WithEvents Label_SW As Label
    Friend WithEvents Label_V As Label
End Class
