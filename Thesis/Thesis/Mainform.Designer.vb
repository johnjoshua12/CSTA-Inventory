<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainform))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblcsta = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlcontent = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblcsta)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(926, 61)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(106, 61)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblcsta
        '
        Me.lblcsta.AutoSize = True
        Me.lblcsta.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcsta.Location = New System.Drawing.Point(106, 20)
        Me.lblcsta.Name = "lblcsta"
        Me.lblcsta.Size = New System.Drawing.Size(653, 25)
        Me.lblcsta.TabIndex = 0
        Me.lblcsta.Text = "CSTA Kitchen Laboratory Management and Inventory System"
        Me.lblcsta.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 61)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(926, 38)
        Me.Panel2.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.InventoryToolStripMenuItem, Me.BorrowingToolStripMenuItem, Me.ReportToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(926, 38)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Image = CType(resources.GetObject("DashboardToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(92, 34)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventoryToolStripMenuItem1, Me.ItemsToolStripMenuItem, Me.CategoryToolStripMenuItem, Me.BrandToolStripMenuItem})
        Me.InventoryToolStripMenuItem.Image = CType(resources.GetObject("InventoryToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(58, 34)
        Me.InventoryToolStripMenuItem.Text = "Files"
        '
        'InventoryToolStripMenuItem1
        '
        Me.InventoryToolStripMenuItem1.Image = CType(resources.GetObject("InventoryToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.InventoryToolStripMenuItem1.Name = "InventoryToolStripMenuItem1"
        Me.InventoryToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.InventoryToolStripMenuItem1.Text = "Inventory"
        '
        'ItemsToolStripMenuItem
        '
        Me.ItemsToolStripMenuItem.Image = CType(resources.GetObject("ItemsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ItemsToolStripMenuItem.Name = "ItemsToolStripMenuItem"
        Me.ItemsToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.ItemsToolStripMenuItem.Text = "Items"
        '
        'CategoryToolStripMenuItem
        '
        Me.CategoryToolStripMenuItem.Image = CType(resources.GetObject("CategoryToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem"
        Me.CategoryToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.CategoryToolStripMenuItem.Text = "Category"
        '
        'BrandToolStripMenuItem
        '
        Me.BrandToolStripMenuItem.Image = CType(resources.GetObject("BrandToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BrandToolStripMenuItem.Name = "BrandToolStripMenuItem"
        Me.BrandToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.BrandToolStripMenuItem.Text = "Brand"
        '
        'BorrowingToolStripMenuItem
        '
        Me.BorrowingToolStripMenuItem.Image = CType(resources.GetObject("BorrowingToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BorrowingToolStripMenuItem.Name = "BorrowingToolStripMenuItem"
        Me.BorrowingToolStripMenuItem.Size = New System.Drawing.Size(90, 34)
        Me.BorrowingToolStripMenuItem.Text = "Borrowing"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Image = CType(resources.GetObject("ReportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(75, 34)
        Me.ReportToolStripMenuItem.Text = "Reports"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(73, 34)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'pnlcontent
        '
        Me.pnlcontent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlcontent.Location = New System.Drawing.Point(0, 99)
        Me.pnlcontent.Name = "pnlcontent"
        Me.pnlcontent.Size = New System.Drawing.Size(926, 436)
        Me.pnlcontent.TabIndex = 2
        '
        'Mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 535)
        Me.Controls.Add(Me.pnlcontent)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Mainform"
        Me.Text = "Mainform"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblcsta As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InventoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DashboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrowingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlcontent As System.Windows.Forms.Panel
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
