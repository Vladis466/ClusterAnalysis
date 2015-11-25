<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.KmethodLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3KMediod = New System.Windows.Forms.Label()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.clustAnalys = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(42, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 273)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.clustAnalys)
        Me.Panel2.Controls.Add(Me.KmethodLabel)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3KMediod)
        Me.Panel2.Location = New System.Drawing.Point(-30, -12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(637, 285)
        Me.Panel2.TabIndex = 1
        '
        'KmethodLabel
        '
        Me.KmethodLabel.Location = New System.Drawing.Point(51, 51)
        Me.KmethodLabel.Name = "KmethodLabel"
        Me.KmethodLabel.Size = New System.Drawing.Size(491, 223)
        Me.KmethodLabel.TabIndex = 0
        Me.KmethodLabel.Text = resources.GetString("KmethodLabel.Text")
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(51, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(494, 223)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label3KMediod
        '
        Me.Label3KMediod.Location = New System.Drawing.Point(51, 51)
        Me.Label3KMediod.Name = "Label3KMediod"
        Me.Label3KMediod.Size = New System.Drawing.Size(491, 223)
        Me.Label3KMediod.TabIndex = 1
        Me.Label3KMediod.Text = resources.GetString("Label3KMediod.Text")
        '
        'PreviousButton
        '
        Me.PreviousButton.Location = New System.Drawing.Point(84, 317)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(144, 50)
        Me.PreviousButton.TabIndex = 1
        Me.PreviousButton.Text = "Previous"
        Me.PreviousButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(431, 317)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(144, 50)
        Me.NextButton.TabIndex = 2
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'clustAnalys
        '
        Me.clustAnalys.AutoSize = True
        Me.clustAnalys.Font = New System.Drawing.Font("Garamond", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clustAnalys.Location = New System.Drawing.Point(22, 6)
        Me.clustAnalys.Name = "clustAnalys"
        Me.clustAnalys.Size = New System.Drawing.Size(559, 45)
        Me.clustAnalys.TabIndex = 3
        Me.clustAnalys.Text = "Vlad's Cluster Analysis Solution"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 379)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PreviousButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents KmethodLabel As Label
    Friend WithEvents Label3KMediod As Label
    Friend WithEvents clustAnalys As Label
End Class
