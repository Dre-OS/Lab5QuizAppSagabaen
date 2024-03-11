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
        Me.pbx_Banana = New System.Windows.Forms.PictureBox()
        Me.pbx_Orange = New System.Windows.Forms.PictureBox()
        Me.pbx_DragonFruit = New System.Windows.Forms.PictureBox()
        Me.btn_Check = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbx_AnswerOrange = New System.Windows.Forms.PictureBox()
        Me.pbx_AnswerBanana = New System.Windows.Forms.PictureBox()
        Me.pbx_AnswerDragonFruit = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_Orange = New System.Windows.Forms.Label()
        Me.lbl_DragonFruit = New System.Windows.Forms.Label()
        Me.lbl_Banana = New System.Windows.Forms.Label()
        CType(Me.pbx_Banana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_Orange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_DragonFruit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_AnswerOrange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_AnswerBanana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_AnswerDragonFruit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbx_Banana
        '
        Me.pbx_Banana.Image = CType(resources.GetObject("pbx_Banana.Image"), System.Drawing.Image)
        Me.pbx_Banana.InitialImage = CType(resources.GetObject("pbx_Banana.InitialImage"), System.Drawing.Image)
        Me.pbx_Banana.Location = New System.Drawing.Point(139, 401)
        Me.pbx_Banana.Name = "pbx_Banana"
        Me.pbx_Banana.Size = New System.Drawing.Size(110, 110)
        Me.pbx_Banana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx_Banana.TabIndex = 0
        Me.pbx_Banana.TabStop = False
        '
        'pbx_Orange
        '
        Me.pbx_Orange.Image = Global.Lab5QuizAppSagabaen.My.Resources.Resources.Orange
        Me.pbx_Orange.InitialImage = CType(resources.GetObject("pbx_Orange.InitialImage"), System.Drawing.Image)
        Me.pbx_Orange.Location = New System.Drawing.Point(23, 401)
        Me.pbx_Orange.Name = "pbx_Orange"
        Me.pbx_Orange.Size = New System.Drawing.Size(110, 110)
        Me.pbx_Orange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_Orange.TabIndex = 1
        Me.pbx_Orange.TabStop = False
        '
        'pbx_DragonFruit
        '
        Me.pbx_DragonFruit.Image = CType(resources.GetObject("pbx_DragonFruit.Image"), System.Drawing.Image)
        Me.pbx_DragonFruit.InitialImage = CType(resources.GetObject("pbx_DragonFruit.InitialImage"), System.Drawing.Image)
        Me.pbx_DragonFruit.Location = New System.Drawing.Point(255, 401)
        Me.pbx_DragonFruit.Name = "pbx_DragonFruit"
        Me.pbx_DragonFruit.Size = New System.Drawing.Size(110, 110)
        Me.pbx_DragonFruit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_DragonFruit.TabIndex = 2
        Me.pbx_DragonFruit.TabStop = False
        '
        'btn_Check
        '
        Me.btn_Check.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Check.Location = New System.Drawing.Point(390, 402)
        Me.btn_Check.Name = "btn_Check"
        Me.btn_Check.Size = New System.Drawing.Size(101, 42)
        Me.btn_Check.TabIndex = 3
        Me.btn_Check.Text = "Check"
        Me.btn_Check.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(398, 466)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Score:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(529, 424)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 73)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "0"
        '
        'pbx_AnswerOrange
        '
        Me.pbx_AnswerOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbx_AnswerOrange.Location = New System.Drawing.Point(408, 24)
        Me.pbx_AnswerOrange.Name = "pbx_AnswerOrange"
        Me.pbx_AnswerOrange.Size = New System.Drawing.Size(110, 110)
        Me.pbx_AnswerOrange.TabIndex = 8
        Me.pbx_AnswerOrange.TabStop = False
        '
        'pbx_AnswerBanana
        '
        Me.pbx_AnswerBanana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbx_AnswerBanana.Location = New System.Drawing.Point(117, 24)
        Me.pbx_AnswerBanana.Name = "pbx_AnswerBanana"
        Me.pbx_AnswerBanana.Size = New System.Drawing.Size(110, 110)
        Me.pbx_AnswerBanana.TabIndex = 7
        Me.pbx_AnswerBanana.TabStop = False
        '
        'pbx_AnswerDragonFruit
        '
        Me.pbx_AnswerDragonFruit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbx_AnswerDragonFruit.Location = New System.Drawing.Point(255, 218)
        Me.pbx_AnswerDragonFruit.Name = "pbx_AnswerDragonFruit"
        Me.pbx_AnswerDragonFruit.Size = New System.Drawing.Size(110, 110)
        Me.pbx_AnswerDragonFruit.TabIndex = 6
        Me.pbx_AnswerDragonFruit.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_Orange)
        Me.Panel1.Controls.Add(Me.lbl_DragonFruit)
        Me.Panel1.Controls.Add(Me.lbl_Banana)
        Me.Panel1.Controls.Add(Me.pbx_AnswerOrange)
        Me.Panel1.Controls.Add(Me.pbx_AnswerBanana)
        Me.Panel1.Controls.Add(Me.pbx_AnswerDragonFruit)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 387)
        Me.Panel1.TabIndex = 9
        '
        'lbl_Orange
        '
        Me.lbl_Orange.AutoSize = True
        Me.lbl_Orange.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_Orange.Location = New System.Drawing.Point(420, 137)
        Me.lbl_Orange.Name = "lbl_Orange"
        Me.lbl_Orange.Size = New System.Drawing.Size(86, 31)
        Me.lbl_Orange.TabIndex = 12
        Me.lbl_Orange.Text = "Name"
        '
        'lbl_DragonFruit
        '
        Me.lbl_DragonFruit.AutoSize = True
        Me.lbl_DragonFruit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_DragonFruit.Location = New System.Drawing.Point(224, 331)
        Me.lbl_DragonFruit.Name = "lbl_DragonFruit"
        Me.lbl_DragonFruit.Size = New System.Drawing.Size(86, 31)
        Me.lbl_DragonFruit.TabIndex = 11
        Me.lbl_DragonFruit.Text = "Name"
        '
        'lbl_Banana
        '
        Me.lbl_Banana.AutoSize = True
        Me.lbl_Banana.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_Banana.Location = New System.Drawing.Point(129, 137)
        Me.lbl_Banana.Name = "lbl_Banana"
        Me.lbl_Banana.Size = New System.Drawing.Size(86, 31)
        Me.lbl_Banana.TabIndex = 10
        Me.lbl_Banana.Text = "Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(639, 523)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Check)
        Me.Controls.Add(Me.pbx_DragonFruit)
        Me.Controls.Add(Me.pbx_Orange)
        Me.Controls.Add(Me.pbx_Banana)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbx_Banana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_Orange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_DragonFruit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_AnswerOrange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_AnswerBanana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_AnswerDragonFruit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbx_Banana As PictureBox
    Friend WithEvents pbx_Orange As PictureBox
    Friend WithEvents pbx_DragonFruit As PictureBox
    Friend WithEvents btn_Check As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pbx_AnswerOrange As PictureBox
    Friend WithEvents pbx_AnswerBanana As PictureBox
    Friend WithEvents pbx_AnswerDragonFruit As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_Orange As Label
    Friend WithEvents lbl_DragonFruit As Label
    Friend WithEvents lbl_Banana As Label
End Class
