<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHourly
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHoursWorked = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHourlyWage = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCumulativeYearly = New System.Windows.Forms.TextBox()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblFederalTax = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.NextEmployeeToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(596, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboState)
        Me.GroupBox1.Controls.Add(Me.txtCumulativeYearly)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtHourlyWage)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtHoursWorked)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 403)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hourly Employee Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(32, 56)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(185, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(32, 110)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(185, 20)
        Me.txtLastName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hours Worked:"
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.Location = New System.Drawing.Point(32, 167)
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(185, 20)
        Me.txtHoursWorked.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Hourly Wage:"
        '
        'txtHourlyWage
        '
        Me.txtHourlyWage.Location = New System.Drawing.Point(32, 225)
        Me.txtHourlyWage.Name = "txtHourlyWage"
        Me.txtHourlyWage.Size = New System.Drawing.Size(185, 20)
        Me.txtHourlyWage.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cumulative Yearly Gross Pay:"
        '
        'txtCumulativeYearly
        '
        Me.txtCumulativeYearly.Location = New System.Drawing.Point(32, 287)
        Me.txtCumulativeYearly.Name = "txtCumulativeYearly"
        Me.txtCumulativeYearly.Size = New System.Drawing.Size(185, 20)
        Me.txtCumulativeYearly.TabIndex = 9
        '
        'cboState
        '
        Me.cboState.FormattingEnabled = True
        Me.cboState.Items.AddRange(New Object() {"Indiana", "Kentucky", "Ohio"})
        Me.cboState.Location = New System.Drawing.Point(32, 346)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(185, 21)
        Me.cboState.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "State"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblNetPay)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.lblFederalTax)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lblStateTax)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lblFICA)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblGrossPay)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(313, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(254, 403)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Totals"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Gross Pay:"
        '
        'lblGrossPay
        '
        Me.lblGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossPay.Location = New System.Drawing.Point(40, 83)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(176, 23)
        Me.lblGrossPay.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(37, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "FICA:"
        '
        'lblFICA
        '
        Me.lblFICA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFICA.Location = New System.Drawing.Point(40, 137)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(176, 23)
        Me.lblFICA.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(37, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "State Tax:"
        '
        'lblStateTax
        '
        Me.lblStateTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStateTax.Location = New System.Drawing.Point(40, 194)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(176, 23)
        Me.lblStateTax.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(37, 234)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Federal Tax:"
        '
        'lblFederalTax
        '
        Me.lblFederalTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFederalTax.Location = New System.Drawing.Point(40, 252)
        Me.lblFederalTax.Name = "lblFederalTax"
        Me.lblFederalTax.Size = New System.Drawing.Size(176, 23)
        Me.lblFederalTax.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(37, 296)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Net Pay:"
        '
        'lblNetPay
        '
        Me.lblNetPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetPay.Location = New System.Drawing.Point(40, 314)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(176, 23)
        Me.lblNetPay.TabIndex = 9
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(30, 477)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(139, 52)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(229, 477)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(139, 52)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next Employee"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(428, 477)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(139, 52)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.CalculateToolStripMenuItem.Text = "Calculate"
        '
        'NextEmployeeToolStripMenuItem
        '
        Me.NextEmployeeToolStripMenuItem.Name = "NextEmployeeToolStripMenuItem"
        Me.NextEmployeeToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.NextEmployeeToolStripMenuItem.Text = "Next Employee"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmHourly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 556)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmHourly"
        Me.Text = "Hourly Payroll Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHoursWorked As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboState As ComboBox
    Friend WithEvents txtCumulativeYearly As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHourlyWage As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblFICA As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblNetPay As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblFederalTax As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents CalculateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
