<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.ReturntoForm1 = New System.Windows.Forms.Button()
        Me.Attribute1TextBox = New System.Windows.Forms.TextBox()
        Me.Attribute2TextBox = New System.Windows.Forms.TextBox()
        Me.Attribute1 = New System.Windows.Forms.Label()
        Me.Attribute2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.InsertObject = New System.Windows.Forms.Button()
        Me.FileInsertButton = New System.Windows.Forms.Button()
        Me.AmountEntered = New System.Windows.Forms.Label()
        Me.AmtEnteredShow = New System.Windows.Forms.Label()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.KmeansButton = New System.Windows.Forms.Button()
        Me.KmediodButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SSEMLabel = New System.Windows.Forms.Label()
        Me.SSE2Label = New System.Windows.Forms.Label()
        Me.Medoid2ListBox = New System.Windows.Forms.ListBox()
        Me.MedoidEndLabel = New System.Windows.Forms.Label()
        Me.Medoid1ListBox = New System.Windows.Forms.ListBox()
        Me.medoidStartLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SSECLabel = New System.Windows.Forms.Label()
        Me.SSE1Label = New System.Windows.Forms.Label()
        Me.centroid2ListBox = New System.Windows.Forms.ListBox()
        Me.centroidEndLabel = New System.Windows.Forms.Label()
        Me.centroid1ListBox = New System.Windows.Forms.ListBox()
        Me.centroidStartLabel = New System.Windows.Forms.Label()
        Me.AccessButton = New System.Windows.Forms.Button()
        Me.numClusterLabel = New System.Windows.Forms.Label()
        Me.clusterAmtUpDown = New System.Windows.Forms.NumericUpDown()
        Me.InsRandButton = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.clusterAmtUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReturntoForm1
        '
        Me.ReturntoForm1.Location = New System.Drawing.Point(12, 476)
        Me.ReturntoForm1.Name = "ReturntoForm1"
        Me.ReturntoForm1.Size = New System.Drawing.Size(107, 44)
        Me.ReturntoForm1.TabIndex = 0
        Me.ReturntoForm1.Text = "Previous"
        Me.ReturntoForm1.UseVisualStyleBackColor = True
        '
        'Attribute1TextBox
        '
        Me.Attribute1TextBox.Location = New System.Drawing.Point(26, 55)
        Me.Attribute1TextBox.Name = "Attribute1TextBox"
        Me.Attribute1TextBox.Size = New System.Drawing.Size(103, 22)
        Me.Attribute1TextBox.TabIndex = 1
        Me.Attribute1TextBox.Text = "23"
        '
        'Attribute2TextBox
        '
        Me.Attribute2TextBox.Location = New System.Drawing.Point(137, 55)
        Me.Attribute2TextBox.Name = "Attribute2TextBox"
        Me.Attribute2TextBox.Size = New System.Drawing.Size(103, 22)
        Me.Attribute2TextBox.TabIndex = 2
        '
        'Attribute1
        '
        Me.Attribute1.AutoSize = True
        Me.Attribute1.Location = New System.Drawing.Point(23, 35)
        Me.Attribute1.Name = "Attribute1"
        Me.Attribute1.Size = New System.Drawing.Size(96, 17)
        Me.Attribute1.TabIndex = 3
        Me.Attribute1.Text = "First Attribute:"
        '
        'Attribute2
        '
        Me.Attribute2.AutoSize = True
        Me.Attribute2.Location = New System.Drawing.Point(134, 35)
        Me.Attribute2.Name = "Attribute2"
        Me.Attribute2.Size = New System.Drawing.Size(117, 17)
        Me.Attribute2.TabIndex = 4
        Me.Attribute2.Text = "Second Attribute:"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(415, 35)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(155, 484)
        Me.ListBox1.TabIndex = 5
        '
        'InsertObject
        '
        Me.InsertObject.Enabled = False
        Me.InsertObject.Location = New System.Drawing.Point(257, 35)
        Me.InsertObject.Name = "InsertObject"
        Me.InsertObject.Size = New System.Drawing.Size(61, 47)
        Me.InsertObject.TabIndex = 6
        Me.InsertObject.Text = "InsertObject"
        Me.InsertObject.UseVisualStyleBackColor = True
        '
        'FileInsertButton
        '
        Me.FileInsertButton.Location = New System.Drawing.Point(26, 88)
        Me.FileInsertButton.Name = "FileInsertButton"
        Me.FileInsertButton.Size = New System.Drawing.Size(103, 44)
        Me.FileInsertButton.TabIndex = 7
        Me.FileInsertButton.Text = "Insert From File"
        Me.FileInsertButton.UseVisualStyleBackColor = True
        '
        'AmountEntered
        '
        Me.AmountEntered.Location = New System.Drawing.Point(337, 32)
        Me.AmountEntered.Name = "AmountEntered"
        Me.AmountEntered.Size = New System.Drawing.Size(61, 20)
        Me.AmountEntered.TabIndex = 8
        Me.AmountEntered.Text = "Entries"
        '
        'AmtEnteredShow
        '
        Me.AmtEnteredShow.AutoSize = True
        Me.AmtEnteredShow.Location = New System.Drawing.Point(350, 52)
        Me.AmtEnteredShow.Name = "AmtEnteredShow"
        Me.AmtEnteredShow.Size = New System.Drawing.Size(0, 17)
        Me.AmtEnteredShow.TabIndex = 9
        '
        'resetButton
        '
        Me.resetButton.BackColor = System.Drawing.Color.MediumTurquoise
        Me.resetButton.Location = New System.Drawing.Point(295, 88)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(103, 44)
        Me.resetButton.TabIndex = 10
        Me.resetButton.Text = "Reset Values!"
        Me.resetButton.UseVisualStyleBackColor = False
        '
        'KmeansButton
        '
        Me.KmeansButton.Enabled = False
        Me.KmeansButton.Location = New System.Drawing.Point(18, 163)
        Me.KmeansButton.Name = "KmeansButton"
        Me.KmeansButton.Size = New System.Drawing.Size(93, 43)
        Me.KmeansButton.TabIndex = 11
        Me.KmeansButton.Text = "Calculate K-Means"
        Me.KmeansButton.UseVisualStyleBackColor = True
        '
        'KmediodButton
        '
        Me.KmediodButton.Enabled = False
        Me.KmediodButton.Location = New System.Drawing.Point(295, 163)
        Me.KmediodButton.Name = "KmediodButton"
        Me.KmediodButton.Size = New System.Drawing.Size(103, 43)
        Me.KmediodButton.TabIndex = 12
        Me.KmediodButton.Text = "Calculate K-Medoid"
        Me.KmediodButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Location = New System.Drawing.Point(3, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(563, 10)
        Me.Panel1.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Controls.Add(Me.SSEMLabel)
        Me.Panel3.Controls.Add(Me.SSE2Label)
        Me.Panel3.Controls.Add(Me.Medoid2ListBox)
        Me.Panel3.Controls.Add(Me.MedoidEndLabel)
        Me.Panel3.Controls.Add(Me.Medoid1ListBox)
        Me.Panel3.Controls.Add(Me.medoidStartLabel)
        Me.Panel3.Location = New System.Drawing.Point(211, 212)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(187, 258)
        Me.Panel3.TabIndex = 15
        '
        'SSEMLabel
        '
        Me.SSEMLabel.AutoSize = True
        Me.SSEMLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SSEMLabel.Location = New System.Drawing.Point(29, 233)
        Me.SSEMLabel.Name = "SSEMLabel"
        Me.SSEMLabel.Size = New System.Drawing.Size(0, 17)
        Me.SSEMLabel.TabIndex = 6
        '
        'SSE2Label
        '
        Me.SSE2Label.AutoSize = True
        Me.SSE2Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SSE2Label.Location = New System.Drawing.Point(26, 216)
        Me.SSE2Label.Name = "SSE2Label"
        Me.SSE2Label.Size = New System.Drawing.Size(149, 17)
        Me.SSE2Label.TabIndex = 5
        Me.SSE2Label.Text = "Error Sum of Squares:"
        '
        'Medoid2ListBox
        '
        Me.Medoid2ListBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Medoid2ListBox.ForeColor = System.Drawing.SystemColors.Window
        Me.Medoid2ListBox.FormattingEnabled = True
        Me.Medoid2ListBox.ItemHeight = 16
        Me.Medoid2ListBox.Location = New System.Drawing.Point(25, 136)
        Me.Medoid2ListBox.Name = "Medoid2ListBox"
        Me.Medoid2ListBox.Size = New System.Drawing.Size(126, 68)
        Me.Medoid2ListBox.TabIndex = 6
        '
        'MedoidEndLabel
        '
        Me.MedoidEndLabel.AutoSize = True
        Me.MedoidEndLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MedoidEndLabel.Location = New System.Drawing.Point(23, 116)
        Me.MedoidEndLabel.Name = "MedoidEndLabel"
        Me.MedoidEndLabel.Size = New System.Drawing.Size(128, 17)
        Me.MedoidEndLabel.TabIndex = 5
        Me.MedoidEndLabel.Text = "Starting x Medoids:"
        '
        'Medoid1ListBox
        '
        Me.Medoid1ListBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Medoid1ListBox.ForeColor = System.Drawing.SystemColors.Window
        Me.Medoid1ListBox.FormattingEnabled = True
        Me.Medoid1ListBox.ItemHeight = 16
        Me.Medoid1ListBox.Location = New System.Drawing.Point(26, 34)
        Me.Medoid1ListBox.Name = "Medoid1ListBox"
        Me.Medoid1ListBox.Size = New System.Drawing.Size(126, 68)
        Me.Medoid1ListBox.TabIndex = 4
        '
        'medoidStartLabel
        '
        Me.medoidStartLabel.AutoSize = True
        Me.medoidStartLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.medoidStartLabel.Location = New System.Drawing.Point(24, 13)
        Me.medoidStartLabel.Name = "medoidStartLabel"
        Me.medoidStartLabel.Size = New System.Drawing.Size(128, 17)
        Me.medoidStartLabel.TabIndex = 1
        Me.medoidStartLabel.Text = "Starting x Medoids:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Controls.Add(Me.SSECLabel)
        Me.Panel2.Controls.Add(Me.SSE1Label)
        Me.Panel2.Controls.Add(Me.centroid2ListBox)
        Me.Panel2.Controls.Add(Me.centroidEndLabel)
        Me.Panel2.Controls.Add(Me.centroid1ListBox)
        Me.Panel2.Controls.Add(Me.centroidStartLabel)
        Me.Panel2.Location = New System.Drawing.Point(18, 212)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(187, 258)
        Me.Panel2.TabIndex = 16
        '
        'SSECLabel
        '
        Me.SSECLabel.AutoSize = True
        Me.SSECLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SSECLabel.Location = New System.Drawing.Point(22, 233)
        Me.SSECLabel.Name = "SSECLabel"
        Me.SSECLabel.Size = New System.Drawing.Size(0, 17)
        Me.SSECLabel.TabIndex = 5
        '
        'SSE1Label
        '
        Me.SSE1Label.AutoSize = True
        Me.SSE1Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SSE1Label.Location = New System.Drawing.Point(22, 216)
        Me.SSE1Label.Name = "SSE1Label"
        Me.SSE1Label.Size = New System.Drawing.Size(149, 17)
        Me.SSE1Label.TabIndex = 4
        Me.SSE1Label.Text = "Error Sum of Squares:"
        '
        'centroid2ListBox
        '
        Me.centroid2ListBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.centroid2ListBox.ForeColor = System.Drawing.SystemColors.Window
        Me.centroid2ListBox.FormattingEnabled = True
        Me.centroid2ListBox.ItemHeight = 16
        Me.centroid2ListBox.Location = New System.Drawing.Point(22, 136)
        Me.centroid2ListBox.Name = "centroid2ListBox"
        Me.centroid2ListBox.Size = New System.Drawing.Size(126, 68)
        Me.centroid2ListBox.TabIndex = 3
        '
        'centroidEndLabel
        '
        Me.centroidEndLabel.AutoSize = True
        Me.centroidEndLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.centroidEndLabel.Location = New System.Drawing.Point(19, 116)
        Me.centroidEndLabel.Name = "centroidEndLabel"
        Me.centroidEndLabel.Size = New System.Drawing.Size(116, 17)
        Me.centroidEndLabel.TabIndex = 2
        Me.centroidEndLabel.Text = "Final x Centroids:"
        '
        'centroid1ListBox
        '
        Me.centroid1ListBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.centroid1ListBox.ForeColor = System.Drawing.SystemColors.Window
        Me.centroid1ListBox.FormattingEnabled = True
        Me.centroid1ListBox.ItemHeight = 16
        Me.centroid1ListBox.Location = New System.Drawing.Point(22, 34)
        Me.centroid1ListBox.Name = "centroid1ListBox"
        Me.centroid1ListBox.Size = New System.Drawing.Size(126, 68)
        Me.centroid1ListBox.TabIndex = 1
        '
        'centroidStartLabel
        '
        Me.centroidStartLabel.AutoSize = True
        Me.centroidStartLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.centroidStartLabel.Location = New System.Drawing.Point(19, 13)
        Me.centroidStartLabel.Name = "centroidStartLabel"
        Me.centroidStartLabel.Size = New System.Drawing.Size(143, 17)
        Me.centroidStartLabel.TabIndex = 0
        Me.centroidStartLabel.Text = "Starting  x  Centroids:"
        '
        'AccessButton
        '
        Me.AccessButton.Location = New System.Drawing.Point(291, 476)
        Me.AccessButton.Name = "AccessButton"
        Me.AccessButton.Size = New System.Drawing.Size(107, 44)
        Me.AccessButton.TabIndex = 17
        Me.AccessButton.Text = "Send to DB"
        Me.AccessButton.UseVisualStyleBackColor = True
        '
        'numClusterLabel
        '
        Me.numClusterLabel.AutoSize = True
        Me.numClusterLabel.Location = New System.Drawing.Point(177, 163)
        Me.numClusterLabel.Name = "numClusterLabel"
        Me.numClusterLabel.Size = New System.Drawing.Size(59, 17)
        Me.numClusterLabel.TabIndex = 18
        Me.numClusterLabel.Text = "Clusters"
        '
        'clusterAmtUpDown
        '
        Me.clusterAmtUpDown.Location = New System.Drawing.Point(180, 184)
        Me.clusterAmtUpDown.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.clusterAmtUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.clusterAmtUpDown.Name = "clusterAmtUpDown"
        Me.clusterAmtUpDown.Size = New System.Drawing.Size(48, 22)
        Me.clusterAmtUpDown.TabIndex = 19
        Me.clusterAmtUpDown.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'InsRandButton
        '
        Me.InsRandButton.Location = New System.Drawing.Point(137, 88)
        Me.InsRandButton.Name = "InsRandButton"
        Me.InsRandButton.Size = New System.Drawing.Size(103, 44)
        Me.InsRandButton.TabIndex = 20
        Me.InsRandButton.Text = "Generate Values"
        Me.InsRandButton.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 532)
        Me.Controls.Add(Me.InsRandButton)
        Me.Controls.Add(Me.clusterAmtUpDown)
        Me.Controls.Add(Me.numClusterLabel)
        Me.Controls.Add(Me.AccessButton)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.KmediodButton)
        Me.Controls.Add(Me.KmeansButton)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.AmtEnteredShow)
        Me.Controls.Add(Me.AmountEntered)
        Me.Controls.Add(Me.FileInsertButton)
        Me.Controls.Add(Me.InsertObject)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Attribute2)
        Me.Controls.Add(Me.Attribute1)
        Me.Controls.Add(Me.Attribute2TextBox)
        Me.Controls.Add(Me.Attribute1TextBox)
        Me.Controls.Add(Me.ReturntoForm1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.clusterAmtUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReturntoForm1 As Button
    Friend WithEvents Attribute1TextBox As TextBox
    Friend WithEvents Attribute2TextBox As TextBox
    Friend WithEvents Attribute1 As Label
    Friend WithEvents Attribute2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents InsertObject As Button
    Friend WithEvents FileInsertButton As Button
    Friend WithEvents AmountEntered As Label
    Friend WithEvents AmtEnteredShow As Label
    Friend WithEvents resetButton As Button
    Friend WithEvents KmeansButton As Button
    Friend WithEvents KmediodButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AccessButton As Button
    Friend WithEvents medoidStartLabel As Label
    Friend WithEvents centroidStartLabel As Label
    Friend WithEvents centroid1ListBox As ListBox
    Friend WithEvents numClusterLabel As Label
    Friend WithEvents clusterAmtUpDown As NumericUpDown
    Friend WithEvents centroidEndLabel As Label
    Friend WithEvents centroid2ListBox As ListBox
    Friend WithEvents InsRandButton As Button
    Friend WithEvents Medoid2ListBox As ListBox
    Friend WithEvents MedoidEndLabel As Label
    Friend WithEvents Medoid1ListBox As ListBox
    Friend WithEvents SSE2Label As Label
    Friend WithEvents SSE1Label As Label
    Friend WithEvents SSEMLabel As Label
    Friend WithEvents SSECLabel As Label
End Class
