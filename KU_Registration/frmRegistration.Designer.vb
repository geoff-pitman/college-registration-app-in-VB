<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistration))
        Me.grpCourse = New System.Windows.Forms.GroupBox()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.cboHours = New System.Windows.Forms.ComboBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.picLogoKU = New System.Windows.Forms.PictureBox()
        Me.grpProgram = New System.Windows.Forms.GroupBox()
        Me.radNonresident = New System.Windows.Forms.RadioButton()
        Me.radResident = New System.Windows.Forms.RadioButton()
        Me.chkFirsttime = New System.Windows.Forms.CheckBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnFinalize = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstCart = New System.Windows.Forms.ListBox()
        Me.lblCart = New System.Windows.Forms.Label()
        Me.grpTotals = New System.Windows.Forms.GroupBox()
        Me.txtTotalOwed = New System.Windows.Forms.TextBox()
        Me.txtTotalFees = New System.Windows.Forms.TextBox()
        Me.txtTotalTuition = New System.Windows.Forms.TextBox()
        Me.txtTotalHours = New System.Windows.Forms.TextBox()
        Me.lblTotalOwed = New System.Windows.Forms.Label()
        Me.lblTotalFees = New System.Windows.Forms.Label()
        Me.lblTotalTuition = New System.Windows.Forms.Label()
        Me.lblTotalHours = New System.Windows.Forms.Label()
        Me.lblCourseList = New System.Windows.Forms.Label()
        Me.lblHoursList = New System.Windows.Forms.Label()
        Me.grpCourse.SuspendLayout()
        CType(Me.picLogoKU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProgram.SuspendLayout()
        Me.grpTotals.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCourse
        '
        Me.grpCourse.Controls.Add(Me.lblHours)
        Me.grpCourse.Controls.Add(Me.txtCourse)
        Me.grpCourse.Controls.Add(Me.cboHours)
        Me.grpCourse.Controls.Add(Me.lblCourse)
        Me.grpCourse.Location = New System.Drawing.Point(27, 34)
        Me.grpCourse.Name = "grpCourse"
        Me.grpCourse.Size = New System.Drawing.Size(341, 87)
        Me.grpCourse.TabIndex = 0
        Me.grpCourse.TabStop = False
        Me.grpCourse.Text = "Selected Course"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(227, 24)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(35, 13)
        Me.lblHours.TabIndex = 3
        Me.lblHours.Text = "Hours"
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(24, 43)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(151, 20)
        Me.txtCourse.TabIndex = 2
        '
        'cboHours
        '
        Me.cboHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHours.DropDownWidth = 40
        Me.cboHours.FormattingEnabled = True
        Me.cboHours.Items.AddRange(New Object() {".5", "1", "1.5", "2", "2.5", "3", "3.5", "4", "4.5", "5", "5.5"})
        Me.cboHours.Location = New System.Drawing.Point(227, 43)
        Me.cboHours.Name = "cboHours"
        Me.cboHours.Size = New System.Drawing.Size(57, 21)
        Me.cboHours.TabIndex = 3
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(21, 27)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(40, 13)
        Me.lblCourse.TabIndex = 0
        Me.lblCourse.Text = "Course"
        '
        'picLogoKU
        '
        Me.picLogoKU.Image = CType(resources.GetObject("picLogoKU.Image"), System.Drawing.Image)
        Me.picLogoKU.Location = New System.Drawing.Point(662, 34)
        Me.picLogoKU.Name = "picLogoKU"
        Me.picLogoKU.Size = New System.Drawing.Size(142, 87)
        Me.picLogoKU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogoKU.TabIndex = 1
        Me.picLogoKU.TabStop = False
        '
        'grpProgram
        '
        Me.grpProgram.Controls.Add(Me.radNonresident)
        Me.grpProgram.Controls.Add(Me.radResident)
        Me.grpProgram.Location = New System.Drawing.Point(412, 34)
        Me.grpProgram.Name = "grpProgram"
        Me.grpProgram.Size = New System.Drawing.Size(153, 87)
        Me.grpProgram.TabIndex = 2
        Me.grpProgram.TabStop = False
        Me.grpProgram.Text = "Program"
        '
        'radNonresident
        '
        Me.radNonresident.AutoSize = True
        Me.radNonresident.Location = New System.Drawing.Point(16, 51)
        Me.radNonresident.Name = "radNonresident"
        Me.radNonresident.Size = New System.Drawing.Size(90, 17)
        Me.radNonresident.TabIndex = 3
        Me.radNonresident.TabStop = True
        Me.radNonresident.Text = "Non-Resident"
        Me.radNonresident.UseVisualStyleBackColor = True
        '
        'radResident
        '
        Me.radResident.AutoSize = True
        Me.radResident.Location = New System.Drawing.Point(16, 27)
        Me.radResident.Name = "radResident"
        Me.radResident.Size = New System.Drawing.Size(67, 17)
        Me.radResident.TabIndex = 2
        Me.radResident.TabStop = True
        Me.radResident.Text = "Resident"
        Me.radResident.UseVisualStyleBackColor = True
        '
        'chkFirsttime
        '
        Me.chkFirsttime.AutoSize = True
        Me.chkFirsttime.Location = New System.Drawing.Point(428, 136)
        Me.chkFirsttime.Name = "chkFirsttime"
        Me.chkFirsttime.Size = New System.Drawing.Size(111, 17)
        Me.chkFirsttime.TabIndex = 3
        Me.chkFirsttime.Text = "First Time Student"
        Me.chkFirsttime.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(638, 203)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 41)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(638, 273)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 41)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnFinalize
        '
        Me.btnFinalize.Location = New System.Drawing.Point(746, 203)
        Me.btnFinalize.Name = "btnFinalize"
        Me.btnFinalize.Size = New System.Drawing.Size(75, 39)
        Me.btnFinalize.TabIndex = 6
        Me.btnFinalize.Text = "Finalize"
        Me.btnFinalize.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(746, 273)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 41)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(746, 450)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 38)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstCart
        '
        Me.lstCart.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCart.FormattingEnabled = True
        Me.lstCart.ItemHeight = 14
        Me.lstCart.Location = New System.Drawing.Point(27, 224)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(277, 256)
        Me.lstCart.TabIndex = 9
        '
        'lblCart
        '
        Me.lblCart.AutoSize = True
        Me.lblCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCart.Location = New System.Drawing.Point(24, 186)
        Me.lblCart.Name = "lblCart"
        Me.lblCart.Size = New System.Drawing.Size(74, 13)
        Me.lblCart.TabIndex = 10
        Me.lblCart.Text = "Shopping Cart"
        '
        'grpTotals
        '
        Me.grpTotals.Controls.Add(Me.txtTotalOwed)
        Me.grpTotals.Controls.Add(Me.txtTotalFees)
        Me.grpTotals.Controls.Add(Me.txtTotalTuition)
        Me.grpTotals.Controls.Add(Me.txtTotalHours)
        Me.grpTotals.Controls.Add(Me.lblTotalOwed)
        Me.grpTotals.Controls.Add(Me.lblTotalFees)
        Me.grpTotals.Controls.Add(Me.lblTotalTuition)
        Me.grpTotals.Controls.Add(Me.lblTotalHours)
        Me.grpTotals.Location = New System.Drawing.Point(377, 203)
        Me.grpTotals.Name = "grpTotals"
        Me.grpTotals.Size = New System.Drawing.Size(200, 188)
        Me.grpTotals.TabIndex = 11
        Me.grpTotals.TabStop = False
        Me.grpTotals.Text = "Totals"
        '
        'txtTotalOwed
        '
        Me.txtTotalOwed.Location = New System.Drawing.Point(88, 144)
        Me.txtTotalOwed.Name = "txtTotalOwed"
        Me.txtTotalOwed.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalOwed.TabIndex = 7
        '
        'txtTotalFees
        '
        Me.txtTotalFees.Location = New System.Drawing.Point(88, 108)
        Me.txtTotalFees.Name = "txtTotalFees"
        Me.txtTotalFees.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalFees.TabIndex = 6
        '
        'txtTotalTuition
        '
        Me.txtTotalTuition.Location = New System.Drawing.Point(88, 70)
        Me.txtTotalTuition.Name = "txtTotalTuition"
        Me.txtTotalTuition.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalTuition.TabIndex = 5
        '
        'txtTotalHours
        '
        Me.txtTotalHours.Location = New System.Drawing.Point(88, 34)
        Me.txtTotalHours.Name = "txtTotalHours"
        Me.txtTotalHours.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalHours.TabIndex = 4
        '
        'lblTotalOwed
        '
        Me.lblTotalOwed.AutoSize = True
        Me.lblTotalOwed.Location = New System.Drawing.Point(7, 144)
        Me.lblTotalOwed.Name = "lblTotalOwed"
        Me.lblTotalOwed.Size = New System.Drawing.Size(62, 13)
        Me.lblTotalOwed.TabIndex = 3
        Me.lblTotalOwed.Text = "Total Owed"
        '
        'lblTotalFees
        '
        Me.lblTotalFees.AutoSize = True
        Me.lblTotalFees.Location = New System.Drawing.Point(7, 108)
        Me.lblTotalFees.Name = "lblTotalFees"
        Me.lblTotalFees.Size = New System.Drawing.Size(30, 13)
        Me.lblTotalFees.TabIndex = 2
        Me.lblTotalFees.Text = "Fees"
        '
        'lblTotalTuition
        '
        Me.lblTotalTuition.AutoSize = True
        Me.lblTotalTuition.Location = New System.Drawing.Point(7, 70)
        Me.lblTotalTuition.Name = "lblTotalTuition"
        Me.lblTotalTuition.Size = New System.Drawing.Size(39, 13)
        Me.lblTotalTuition.TabIndex = 1
        Me.lblTotalTuition.Text = "Tuition"
        '
        'lblTotalHours
        '
        Me.lblTotalHours.AutoSize = True
        Me.lblTotalHours.Location = New System.Drawing.Point(7, 34)
        Me.lblTotalHours.Name = "lblTotalHours"
        Me.lblTotalHours.Size = New System.Drawing.Size(35, 13)
        Me.lblTotalHours.TabIndex = 0
        Me.lblTotalHours.Text = "Hours"
        '
        'lblCourseList
        '
        Me.lblCourseList.AutoSize = True
        Me.lblCourseList.Location = New System.Drawing.Point(24, 208)
        Me.lblCourseList.Name = "lblCourseList"
        Me.lblCourseList.Size = New System.Drawing.Size(45, 13)
        Me.lblCourseList.TabIndex = 12
        Me.lblCourseList.Text = "Courses"
        '
        'lblHoursList
        '
        Me.lblHoursList.AutoSize = True
        Me.lblHoursList.Location = New System.Drawing.Point(209, 208)
        Me.lblHoursList.Name = "lblHoursList"
        Me.lblHoursList.Size = New System.Drawing.Size(35, 13)
        Me.lblHoursList.TabIndex = 13
        Me.lblHoursList.Text = "Hours"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 500)
        Me.Controls.Add(Me.lblHoursList)
        Me.Controls.Add(Me.lblCourseList)
        Me.Controls.Add(Me.grpTotals)
        Me.Controls.Add(Me.lblCart)
        Me.Controls.Add(Me.lstCart)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnFinalize)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.chkFirsttime)
        Me.Controls.Add(Me.grpProgram)
        Me.Controls.Add(Me.picLogoKU)
        Me.Controls.Add(Me.grpCourse)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frmMain"
        Me.Text = "KU Registration"
        Me.grpCourse.ResumeLayout(False)
        Me.grpCourse.PerformLayout()
        CType(Me.picLogoKU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProgram.ResumeLayout(False)
        Me.grpProgram.PerformLayout()
        Me.grpTotals.ResumeLayout(False)
        Me.grpTotals.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpCourse As System.Windows.Forms.GroupBox
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents cboHours As System.Windows.Forms.ComboBox
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents picLogoKU As System.Windows.Forms.PictureBox
    Friend WithEvents grpProgram As System.Windows.Forms.GroupBox
    Friend WithEvents radNonresident As System.Windows.Forms.RadioButton
    Friend WithEvents radResident As System.Windows.Forms.RadioButton
    Friend WithEvents chkFirsttime As System.Windows.Forms.CheckBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnFinalize As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lstCart As System.Windows.Forms.ListBox
    Friend WithEvents lblCart As System.Windows.Forms.Label
    Friend WithEvents grpTotals As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalOwed As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalFees As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalTuition As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalHours As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalOwed As System.Windows.Forms.Label
    Friend WithEvents lblTotalFees As System.Windows.Forms.Label
    Friend WithEvents lblTotalTuition As System.Windows.Forms.Label
    Friend WithEvents lblTotalHours As System.Windows.Forms.Label
    Friend WithEvents lblCourseList As System.Windows.Forms.Label
    Friend WithEvents lblHoursList As System.Windows.Forms.Label

End Class
