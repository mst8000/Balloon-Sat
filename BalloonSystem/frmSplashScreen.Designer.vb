<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplashScreen
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
        Me.lblApplicationTitle = New System.Windows.Forms.Label()
        Me.pnlDetailsLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.pnlMainLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.pnlDetailsLayout.SuspendLayout()
        Me.pnlMainLayout.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblApplicationTitle
        '
        Me.lblApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblApplicationTitle.Font = New System.Drawing.Font("Meiryo UI", 15.0!)
        Me.lblApplicationTitle.Location = New System.Drawing.Point(246, 3)
        Me.lblApplicationTitle.Name = "lblApplicationTitle"
        Me.lblApplicationTitle.Size = New System.Drawing.Size(247, 212)
        Me.lblApplicationTitle.TabIndex = 0
        Me.lblApplicationTitle.Text = "アプリケーション タイトル"
        Me.lblApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'pnlDetailsLayout
        '
        Me.pnlDetailsLayout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlDetailsLayout.BackColor = System.Drawing.Color.Transparent
        Me.pnlDetailsLayout.ColumnCount = 1
        Me.pnlDetailsLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.pnlDetailsLayout.Controls.Add(Me.lblVersion, 0, 0)
        Me.pnlDetailsLayout.Controls.Add(Me.lblCopyright, 0, 1)
        Me.pnlDetailsLayout.Location = New System.Drawing.Point(246, 221)
        Me.pnlDetailsLayout.Name = "pnlDetailsLayout"
        Me.pnlDetailsLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlDetailsLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlDetailsLayout.Size = New System.Drawing.Size(247, 79)
        Me.pnlDetailsLayout.TabIndex = 1
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(3, 9)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(241, 20)
        Me.lblVersion.TabIndex = 1
        Me.lblVersion.Text = "Version {0}.{1} Build {2} Revision {3}"
        '
        'lblCopyright
        '
        Me.lblCopyright.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCopyright.BackColor = System.Drawing.Color.Transparent
        Me.lblCopyright.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.Location = New System.Drawing.Point(3, 39)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(241, 40)
        Me.lblCopyright.TabIndex = 2
        Me.lblCopyright.Text = "著作権"
        '
        'pnlMainLayout
        '
        Me.pnlMainLayout.ColumnCount = 2
        Me.pnlMainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243.0!))
        Me.pnlMainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.pnlMainLayout.Controls.Add(Me.pnlDetailsLayout, 1, 1)
        Me.pnlMainLayout.Controls.Add(Me.pbxLogo, 0, 0)
        Me.pnlMainLayout.Controls.Add(Me.ProgressBar1, 0, 1)
        Me.pnlMainLayout.Controls.Add(Me.lblApplicationTitle, 1, 0)
        Me.pnlMainLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainLayout.Location = New System.Drawing.Point(0, 0)
        Me.pnlMainLayout.Name = "pnlMainLayout"
        Me.pnlMainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218.0!))
        Me.pnlMainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.pnlMainLayout.Size = New System.Drawing.Size(496, 303)
        Me.pnlMainLayout.TabIndex = 0
        '
        'pbxLogo
        '
        Me.pbxLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxLogo.Image = Global.BalloonSystem.My.Resources.Resources.icon_128
        Me.pbxLogo.Location = New System.Drawing.Point(3, 3)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(237, 212)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxLogo.TabIndex = 2
        Me.pbxLogo.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ProgressBar1.Location = New System.Drawing.Point(26, 221)
        Me.ProgressBar1.MarqueeAnimationSpeed = 50
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(190, 10)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 3
        Me.ProgressBar1.Value = 20
        '
        'frmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(496, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlMainLayout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSplashScreen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlDetailsLayout.ResumeLayout(False)
        Me.pnlMainLayout.ResumeLayout(False)
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblApplicationTitle As System.Windows.Forms.Label
    Friend WithEvents pnlDetailsLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents pnlMainLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar

End Class
