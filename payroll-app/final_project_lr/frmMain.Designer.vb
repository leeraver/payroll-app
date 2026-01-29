<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnSalary = New System.Windows.Forms.Button()
        Me.btnHourly = New System.Windows.Forms.Button()
        Me.btnTotals = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EmployeeTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HourlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyTotalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalary
        '
        Me.btnSalary.Location = New System.Drawing.Point(50, 52)
        Me.btnSalary.Name = "btnSalary"
        Me.btnSalary.Size = New System.Drawing.Size(188, 56)
        Me.btnSalary.TabIndex = 0
        Me.btnSalary.Text = "Salary"
        Me.btnSalary.UseVisualStyleBackColor = True
        '
        'btnHourly
        '
        Me.btnHourly.Location = New System.Drawing.Point(50, 135)
        Me.btnHourly.Name = "btnHourly"
        Me.btnHourly.Size = New System.Drawing.Size(188, 56)
        Me.btnHourly.TabIndex = 1
        Me.btnHourly.Text = "Hourly"
        Me.btnHourly.UseVisualStyleBackColor = True
        '
        'btnTotals
        '
        Me.btnTotals.Location = New System.Drawing.Point(50, 220)
        Me.btnTotals.Name = "btnTotals"
        Me.btnTotals.Size = New System.Drawing.Size(188, 56)
        Me.btnTotals.TabIndex = 2
        Me.btnTotals.Text = "Daily Totals"
        Me.btnTotals.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(50, 307)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(188, 56)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeTypeToolStripMenuItem, Me.DailyTotalsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(293, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EmployeeTypeToolStripMenuItem
        '
        Me.EmployeeTypeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalaryToolStripMenuItem, Me.HourlyToolStripMenuItem})
        Me.EmployeeTypeToolStripMenuItem.Name = "EmployeeTypeToolStripMenuItem"
        Me.EmployeeTypeToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.EmployeeTypeToolStripMenuItem.Text = "Employee Type"
        '
        'SalaryToolStripMenuItem
        '
        Me.SalaryToolStripMenuItem.Name = "SalaryToolStripMenuItem"
        Me.SalaryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalaryToolStripMenuItem.Text = "Salary"
        '
        'HourlyToolStripMenuItem
        '
        Me.HourlyToolStripMenuItem.Name = "HourlyToolStripMenuItem"
        Me.HourlyToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HourlyToolStripMenuItem.Text = "Hourly"
        '
        'DailyTotalsToolStripMenuItem
        '
        Me.DailyTotalsToolStripMenuItem.Name = "DailyTotalsToolStripMenuItem"
        Me.DailyTotalsToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.DailyTotalsToolStripMenuItem.Text = "Daily Totals"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 411)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTotals)
        Me.Controls.Add(Me.btnHourly)
        Me.Controls.Add(Me.btnSalary)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Weekly Payroll Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalary As Button
    Friend WithEvents btnHourly As Button
    Friend WithEvents btnTotals As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmployeeTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HourlyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DailyTotalsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
