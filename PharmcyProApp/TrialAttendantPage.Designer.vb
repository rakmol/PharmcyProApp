<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrialAttendantPage
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
        Me.pnLeft = New System.Windows.Forms.Panel()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnTransact = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlContent1 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.HomePanel = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TransactPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PriceTbox = New System.Windows.Forms.TextBox()
        Me.QtyTBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HistoryPanel = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DashbooardPanel = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.pnLeft.SuspendLayout()
        Me.pnlContent1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.HomePanel.SuspendLayout()
        Me.TransactPanel.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HistoryPanel.SuspendLayout()
        Me.DashbooardPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnLeft
        '
        Me.pnLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.pnLeft.Controls.Add(Me.btnDashboard)
        Me.pnLeft.Controls.Add(Me.btnTransact)
        Me.pnLeft.Controls.Add(Me.btnHistory)
        Me.pnLeft.Controls.Add(Me.btnHome)
        Me.pnLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnLeft.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnLeft.Name = "pnLeft"
        Me.pnLeft.Size = New System.Drawing.Size(173, 461)
        Me.pnLeft.TabIndex = 0
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDashboard.Location = New System.Drawing.Point(0, 241)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(173, 60)
        Me.btnDashboard.TabIndex = 3
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnTransact
        '
        Me.btnTransact.BackColor = System.Drawing.Color.Transparent
        Me.btnTransact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransact.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransact.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnTransact.Location = New System.Drawing.Point(0, 116)
        Me.btnTransact.Name = "btnTransact"
        Me.btnTransact.Size = New System.Drawing.Size(173, 60)
        Me.btnTransact.TabIndex = 2
        Me.btnTransact.Text = "Transact"
        Me.btnTransact.UseVisualStyleBackColor = False
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.Transparent
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnHistory.Location = New System.Drawing.Point(0, 176)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(173, 60)
        Me.btnHistory.TabIndex = 1
        Me.btnHistory.Text = "History"
        Me.btnHistory.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnHome.Location = New System.Drawing.Point(0, 56)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(173, 60)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(173, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(761, 56)
        Me.pnlTop.TabIndex = 1
        '
        'pnlContent1
        '
        Me.pnlContent1.Controls.Add(Me.Panel1)
        Me.pnlContent1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent1.Location = New System.Drawing.Point(173, 56)
        Me.pnlContent1.Name = "pnlContent1"
        Me.pnlContent1.Size = New System.Drawing.Size(761, 405)
        Me.pnlContent1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(761, 405)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(761, 405)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(261, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(259, 75)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'HomePanel
        '
        Me.HomePanel.Controls.Add(Me.Button2)
        Me.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HomePanel.Location = New System.Drawing.Point(173, 56)
        Me.HomePanel.Name = "HomePanel"
        Me.HomePanel.Size = New System.Drawing.Size(761, 405)
        Me.HomePanel.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(191, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(339, 147)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Home"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TransactPanel
        '
        Me.TransactPanel.Controls.Add(Me.Label2)
        Me.TransactPanel.Controls.Add(Me.Label1)
        Me.TransactPanel.Controls.Add(Me.PriceTbox)
        Me.TransactPanel.Controls.Add(Me.QtyTBox)
        Me.TransactPanel.Controls.Add(Me.Button3)
        Me.TransactPanel.Controls.Add(Me.DGV)
        Me.TransactPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransactPanel.Location = New System.Drawing.Point(173, 56)
        Me.TransactPanel.Name = "TransactPanel"
        Me.TransactPanel.Size = New System.Drawing.Size(761, 405)
        Me.TransactPanel.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(379, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Price"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Qty"
        '
        'PriceTbox
        '
        Me.PriceTbox.Location = New System.Drawing.Point(350, 50)
        Me.PriceTbox.Name = "PriceTbox"
        Me.PriceTbox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTbox.TabIndex = 3
        '
        'QtyTBox
        '
        Me.QtyTBox.Location = New System.Drawing.Point(125, 50)
        Me.QtyTBox.Name = "QtyTBox"
        Me.QtyTBox.Size = New System.Drawing.Size(100, 20)
        Me.QtyTBox.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(416, 191)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Quantity, Me.Price, Me.Sum})
        Me.DGV.Location = New System.Drawing.Point(55, 123)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(324, 150)
        Me.DGV.TabIndex = 0
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        '
        'Sum
        '
        Me.Sum.HeaderText = "Sum"
        Me.Sum.Name = "Sum"
        '
        'HistoryPanel
        '
        Me.HistoryPanel.Controls.Add(Me.Button4)
        Me.HistoryPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HistoryPanel.Location = New System.Drawing.Point(173, 56)
        Me.HistoryPanel.Name = "HistoryPanel"
        Me.HistoryPanel.Size = New System.Drawing.Size(761, 405)
        Me.HistoryPanel.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(191, 50)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(339, 147)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "History"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DashbooardPanel
        '
        Me.DashbooardPanel.Controls.Add(Me.Button5)
        Me.DashbooardPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashbooardPanel.Location = New System.Drawing.Point(173, 56)
        Me.DashbooardPanel.Name = "DashbooardPanel"
        Me.DashbooardPanel.Size = New System.Drawing.Size(761, 405)
        Me.DashbooardPanel.TabIndex = 3
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(191, 50)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(339, 147)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Dashboard"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TrialAttendantPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 461)
        Me.Controls.Add(Me.TransactPanel)
        Me.Controls.Add(Me.HomePanel)
        Me.Controls.Add(Me.DashbooardPanel)
        Me.Controls.Add(Me.HistoryPanel)
        Me.Controls.Add(Me.pnlContent1)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnLeft)
        Me.Name = "TrialAttendantPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TrialAttendantPage"
        Me.pnLeft.ResumeLayout(False)
        Me.pnlContent1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.HomePanel.ResumeLayout(False)
        Me.TransactPanel.ResumeLayout(False)
        Me.TransactPanel.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HistoryPanel.ResumeLayout(False)
        Me.DashbooardPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnLeft As Panel
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlContent1 As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnTransact As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents HomePanel As Panel
    Friend WithEvents TransactPanel As Panel
    Friend WithEvents HistoryPanel As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DashbooardPanel As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PriceTbox As TextBox
    Friend WithEvents QtyTBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Sum As DataGridViewTextBoxColumn
End Class
