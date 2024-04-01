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
        Me.btn_Check = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_ScoreNum = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_Reset = New System.Windows.Forms.Label()
        Me.pbx_Trash = New System.Windows.Forms.PictureBox()
        Me.lbl_Orange = New System.Windows.Forms.Label()
        Me.lbl_DragonFruit = New System.Windows.Forms.Label()
        Me.lbl_Banana = New System.Windows.Forms.Label()
        Me.pbx_Question3 = New System.Windows.Forms.PictureBox()
        Me.pbx_Question1 = New System.Windows.Forms.PictureBox()
        Me.pbx_Question2 = New System.Windows.Forms.PictureBox()
        Me.pbx_Answer3 = New System.Windows.Forms.PictureBox()
        Me.pbx_Answer1 = New System.Windows.Forms.PictureBox()
        Me.pbx_Answer2 = New System.Windows.Forms.PictureBox()
        Me.lbl_Trash = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pbx_Trash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_Question3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_Question1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_Question2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_Answer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_Answer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_Answer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Check
        '
        Me.btn_Check.BackColor = System.Drawing.Color.Gold
        Me.btn_Check.FlatAppearance.BorderSize = 0
        Me.btn_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Check.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Check.Location = New System.Drawing.Point(390, 402)
        Me.btn_Check.Name = "btn_Check"
        Me.btn_Check.Size = New System.Drawing.Size(101, 42)
        Me.btn_Check.TabIndex = 3
        Me.btn_Check.Text = "Check"
        Me.btn_Check.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(398, 466)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 38)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Score:"
        '
        'lbl_ScoreNum
        '
        Me.lbl_ScoreNum.AutoSize = True
        Me.lbl_ScoreNum.Font = New System.Drawing.Font("Comic Sans MS", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ScoreNum.Location = New System.Drawing.Point(529, 424)
        Me.lbl_ScoreNum.Name = "lbl_ScoreNum"
        Me.lbl_ScoreNum.Size = New System.Drawing.Size(77, 90)
        Me.lbl_ScoreNum.TabIndex = 5
        Me.lbl_ScoreNum.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_Trash)
        Me.Panel1.Controls.Add(Me.lbl_Reset)
        Me.Panel1.Controls.Add(Me.pbx_Trash)
        Me.Panel1.Controls.Add(Me.lbl_Orange)
        Me.Panel1.Controls.Add(Me.lbl_DragonFruit)
        Me.Panel1.Controls.Add(Me.lbl_Banana)
        Me.Panel1.Controls.Add(Me.pbx_Question3)
        Me.Panel1.Controls.Add(Me.pbx_Question1)
        Me.Panel1.Controls.Add(Me.pbx_Question2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 387)
        Me.Panel1.TabIndex = 9
        '
        'lbl_Reset
        '
        Me.lbl_Reset.AutoSize = True
        Me.lbl_Reset.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Reset.Location = New System.Drawing.Point(520, 214)
        Me.lbl_Reset.Name = "lbl_Reset"
        Me.lbl_Reset.Size = New System.Drawing.Size(60, 23)
        Me.lbl_Reset.TabIndex = 14
        Me.lbl_Reset.Text = "Reset?"
        Me.lbl_Reset.Visible = False
        '
        'pbx_Trash
        '
        Me.pbx_Trash.Image = CType(resources.GetObject("pbx_Trash.Image"), System.Drawing.Image)
        Me.pbx_Trash.Location = New System.Drawing.Point(501, 238)
        Me.pbx_Trash.Name = "pbx_Trash"
        Me.pbx_Trash.Size = New System.Drawing.Size(96, 120)
        Me.pbx_Trash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_Trash.TabIndex = 13
        Me.pbx_Trash.TabStop = False
        '
        'lbl_Orange
        '
        Me.lbl_Orange.AutoSize = True
        Me.lbl_Orange.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Orange.Location = New System.Drawing.Point(384, 137)
        Me.lbl_Orange.Name = "lbl_Orange"
        Me.lbl_Orange.Size = New System.Drawing.Size(89, 38)
        Me.lbl_Orange.TabIndex = 12
        Me.lbl_Orange.Text = "Name"
        '
        'lbl_DragonFruit
        '
        Me.lbl_DragonFruit.AutoSize = True
        Me.lbl_DragonFruit.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DragonFruit.Location = New System.Drawing.Point(268, 331)
        Me.lbl_DragonFruit.Name = "lbl_DragonFruit"
        Me.lbl_DragonFruit.Size = New System.Drawing.Size(89, 38)
        Me.lbl_DragonFruit.TabIndex = 11
        Me.lbl_DragonFruit.Text = "Name"
        '
        'lbl_Banana
        '
        Me.lbl_Banana.AutoSize = True
        Me.lbl_Banana.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Banana.Location = New System.Drawing.Point(129, 137)
        Me.lbl_Banana.Name = "lbl_Banana"
        Me.lbl_Banana.Size = New System.Drawing.Size(89, 38)
        Me.lbl_Banana.TabIndex = 10
        Me.lbl_Banana.Text = "Name"
        '
        'pbx_Question3
        '
        Me.pbx_Question3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbx_Question3.Location = New System.Drawing.Point(408, 24)
        Me.pbx_Question3.Name = "pbx_Question3"
        Me.pbx_Question3.Size = New System.Drawing.Size(110, 110)
        Me.pbx_Question3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx_Question3.TabIndex = 8
        Me.pbx_Question3.TabStop = False
        '
        'pbx_Question1
        '
        Me.pbx_Question1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbx_Question1.Location = New System.Drawing.Point(117, 24)
        Me.pbx_Question1.Name = "pbx_Question1"
        Me.pbx_Question1.Size = New System.Drawing.Size(110, 110)
        Me.pbx_Question1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx_Question1.TabIndex = 7
        Me.pbx_Question1.TabStop = False
        '
        'pbx_Question2
        '
        Me.pbx_Question2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbx_Question2.Location = New System.Drawing.Point(255, 218)
        Me.pbx_Question2.Name = "pbx_Question2"
        Me.pbx_Question2.Size = New System.Drawing.Size(110, 110)
        Me.pbx_Question2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx_Question2.TabIndex = 6
        Me.pbx_Question2.TabStop = False
        '
        'pbx_Answer3
        '
        Me.pbx_Answer3.AccessibleName = "dragonfruit"
        Me.pbx_Answer3.InitialImage = Nothing
        Me.pbx_Answer3.Location = New System.Drawing.Point(255, 401)
        Me.pbx_Answer3.Name = "pbx_Answer3"
        Me.pbx_Answer3.Size = New System.Drawing.Size(110, 110)
        Me.pbx_Answer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx_Answer3.TabIndex = 2
        Me.pbx_Answer3.TabStop = False
        Me.pbx_Answer3.Tag = "dragonfruit"
        '
        'pbx_Answer1
        '
        Me.pbx_Answer1.AccessibleName = "banana"
        Me.pbx_Answer1.InitialImage = Nothing
        Me.pbx_Answer1.Location = New System.Drawing.Point(23, 401)
        Me.pbx_Answer1.Name = "pbx_Answer1"
        Me.pbx_Answer1.Size = New System.Drawing.Size(110, 110)
        Me.pbx_Answer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx_Answer1.TabIndex = 1
        Me.pbx_Answer1.TabStop = False
        Me.pbx_Answer1.Tag = "banana"
        '
        'pbx_Answer2
        '
        Me.pbx_Answer2.AccessibleName = "orange"
        Me.pbx_Answer2.InitialImage = Nothing
        Me.pbx_Answer2.Location = New System.Drawing.Point(139, 401)
        Me.pbx_Answer2.Name = "pbx_Answer2"
        Me.pbx_Answer2.Size = New System.Drawing.Size(110, 110)
        Me.pbx_Answer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx_Answer2.TabIndex = 0
        Me.pbx_Answer2.TabStop = False
        Me.pbx_Answer2.Tag = "orange"
        '
        'lbl_Trash
        '
        Me.lbl_Trash.AutoSize = True
        Me.lbl_Trash.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Trash.Location = New System.Drawing.Point(525, 361)
        Me.lbl_Trash.Name = "lbl_Trash"
        Me.lbl_Trash.Size = New System.Drawing.Size(52, 23)
        Me.lbl_Trash.TabIndex = 15
        Me.lbl_Trash.Text = "Trash"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(639, 523)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_ScoreNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Check)
        Me.Controls.Add(Me.pbx_Answer3)
        Me.Controls.Add(Me.pbx_Answer1)
        Me.Controls.Add(Me.pbx_Answer2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbx_Trash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_Question3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_Question1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_Question2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_Answer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_Answer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_Answer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbx_Answer2 As PictureBox
    Friend WithEvents pbx_Answer1 As PictureBox
    Friend WithEvents pbx_Answer3 As PictureBox
    Friend WithEvents btn_Check As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_ScoreNum As Label
    Friend WithEvents pbx_Question3 As PictureBox
    Friend WithEvents pbx_Question1 As PictureBox
    Friend WithEvents pbx_Question2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_Orange As Label
    Friend WithEvents lbl_DragonFruit As Label
    Friend WithEvents lbl_Banana As Label
    Friend WithEvents pbx_Trash As PictureBox
    Friend WithEvents lbl_Reset As Label
    Friend WithEvents lbl_Trash As Label
End Class
