<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddItems))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbladdinv = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pnlDE = New System.Windows.Forms.Panel()
        Me.lblDOW = New System.Windows.Forms.Label()
        Me.DTPDOW = New System.Windows.Forms.DateTimePicker()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboxStatus = New System.Windows.Forms.ComboBox()
        Me.lblexpdate = New System.Windows.Forms.Label()
        Me.DTPexpdate = New System.Windows.Forms.DateTimePicker()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.cboxBrand = New System.Windows.Forms.ComboBox()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.txtqntty = New System.Windows.Forms.TextBox()
        Me.lblSerialNo = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblItemCode = New System.Windows.Forms.Label()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlDE.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.lbladdinv)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(443, 66)
        Me.Panel1.TabIndex = 0
        '
        'lbladdinv
        '
        Me.lbladdinv.AutoSize = True
        Me.lbladdinv.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdinv.ForeColor = System.Drawing.Color.Black
        Me.lbladdinv.Location = New System.Drawing.Point(12, 22)
        Me.lbladdinv.Name = "lbladdinv"
        Me.lbladdinv.Size = New System.Drawing.Size(151, 23)
        Me.lbladdinv.TabIndex = 1
        Me.lbladdinv.Text = "ADD Inventory"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 348)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(443, 52)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(354, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(89, 52)
        Me.Panel3.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(10, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(71, 37)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'pnlDE
        '
        Me.pnlDE.BackColor = System.Drawing.Color.SkyBlue
        Me.pnlDE.Controls.Add(Me.lblDOW)
        Me.pnlDE.Controls.Add(Me.DTPDOW)
        Me.pnlDE.Controls.Add(Me.lblStatus)
        Me.pnlDE.Controls.Add(Me.cboxStatus)
        Me.pnlDE.Controls.Add(Me.lblexpdate)
        Me.pnlDE.Controls.Add(Me.DTPexpdate)
        Me.pnlDE.Controls.Add(Me.txtSerial)
        Me.pnlDE.Controls.Add(Me.cboxBrand)
        Me.pnlDE.Controls.Add(Me.lblqty)
        Me.pnlDE.Controls.Add(Me.txtqntty)
        Me.pnlDE.Controls.Add(Me.lblSerialNo)
        Me.pnlDE.Controls.Add(Me.lblBrand)
        Me.pnlDE.Controls.Add(Me.lblItemCode)
        Me.pnlDE.Controls.Add(Me.txtItemCode)
        Me.pnlDE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDE.Location = New System.Drawing.Point(0, 66)
        Me.pnlDE.Name = "pnlDE"
        Me.pnlDE.Size = New System.Drawing.Size(443, 282)
        Me.pnlDE.TabIndex = 1
        '
        'lblDOW
        '
        Me.lblDOW.AutoSize = True
        Me.lblDOW.Location = New System.Drawing.Point(230, 106)
        Me.lblDOW.Name = "lblDOW"
        Me.lblDOW.Size = New System.Drawing.Size(106, 16)
        Me.lblDOW.TabIndex = 17
        Me.lblDOW.Text = "Date of Warranty"
        '
        'DTPDOW
        '
        Me.DTPDOW.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDOW.Location = New System.Drawing.Point(226, 125)
        Me.DTPDOW.Name = "DTPDOW"
        Me.DTPDOW.Size = New System.Drawing.Size(197, 23)
        Me.DTPDOW.TabIndex = 16
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(228, 63)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(44, 16)
        Me.lblStatus.TabIndex = 15
        Me.lblStatus.Text = "Status"
        '
        'cboxStatus
        '
        Me.cboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxStatus.FormattingEnabled = True
        Me.cboxStatus.Location = New System.Drawing.Point(226, 78)
        Me.cboxStatus.Name = "cboxStatus"
        Me.cboxStatus.Size = New System.Drawing.Size(197, 24)
        Me.cboxStatus.TabIndex = 14
        '
        'lblexpdate
        '
        Me.lblexpdate.AutoSize = True
        Me.lblexpdate.Location = New System.Drawing.Point(13, 154)
        Me.lblexpdate.Name = "lblexpdate"
        Me.lblexpdate.Size = New System.Drawing.Size(64, 16)
        Me.lblexpdate.TabIndex = 13
        Me.lblexpdate.Text = "Expiration"
        '
        'DTPexpdate
        '
        Me.DTPexpdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPexpdate.Location = New System.Drawing.Point(11, 173)
        Me.DTPexpdate.Name = "DTPexpdate"
        Me.DTPexpdate.Size = New System.Drawing.Size(196, 23)
        Me.DTPexpdate.TabIndex = 12
        '
        'txtSerial
        '
        Me.txtSerial.Location = New System.Drawing.Point(11, 79)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(198, 23)
        Me.txtSerial.TabIndex = 11
        '
        'cboxBrand
        '
        Me.cboxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxBrand.FormattingEnabled = True
        Me.cboxBrand.Location = New System.Drawing.Point(226, 33)
        Me.cboxBrand.Name = "cboxBrand"
        Me.cboxBrand.Size = New System.Drawing.Size(197, 24)
        Me.cboxBrand.TabIndex = 4
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Location = New System.Drawing.Point(12, 106)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(55, 16)
        Me.lblqty.TabIndex = 10
        Me.lblqty.Text = "Quantity"
        '
        'txtqntty
        '
        Me.txtqntty.Location = New System.Drawing.Point(11, 125)
        Me.txtqntty.Name = "txtqntty"
        Me.txtqntty.Size = New System.Drawing.Size(198, 23)
        Me.txtqntty.TabIndex = 3
        '
        'lblSerialNo
        '
        Me.lblSerialNo.AutoSize = True
        Me.lblSerialNo.Location = New System.Drawing.Point(13, 64)
        Me.lblSerialNo.Name = "lblSerialNo"
        Me.lblSerialNo.Size = New System.Drawing.Size(64, 16)
        Me.lblSerialNo.TabIndex = 8
        Me.lblSerialNo.Text = "Serial No."
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Location = New System.Drawing.Point(230, 13)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(78, 16)
        Me.lblBrand.TabIndex = 3
        Me.lblBrand.Text = "Brand Name"
        '
        'lblItemCode
        '
        Me.lblItemCode.AutoSize = True
        Me.lblItemCode.Location = New System.Drawing.Point(11, 14)
        Me.lblItemCode.Name = "lblItemCode"
        Me.lblItemCode.Size = New System.Drawing.Size(67, 16)
        Me.lblItemCode.TabIndex = 2
        Me.lblItemCode.Text = "Item Code"
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(12, 33)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(197, 23)
        Me.txtItemCode.TabIndex = 2
        '
        'AddItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 400)
        Me.Controls.Add(Me.pnlDE)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AddItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddItems"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.pnlDE.ResumeLayout(False)
        Me.pnlDE.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbladdinv As System.Windows.Forms.Label
    Friend WithEvents pnlDE As System.Windows.Forms.Panel
    Friend WithEvents lblSerialNo As System.Windows.Forms.Label
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents lblItemCode As System.Windows.Forms.Label
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents txtqntty As System.Windows.Forms.TextBox
    Friend WithEvents cboxBrand As System.Windows.Forms.ComboBox
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtSerial As System.Windows.Forms.TextBox
    Friend WithEvents lblexpdate As System.Windows.Forms.Label
    Friend WithEvents DTPexpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboxStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblDOW As System.Windows.Forms.Label
    Friend WithEvents DTPDOW As System.Windows.Forms.DateTimePicker
End Class
