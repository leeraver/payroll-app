Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the Application
        Close()
    End Sub

    Private Sub btnSalary_Click(sender As Object, e As EventArgs) Handles btnSalary.Click
        ' Open Salary Form
        Dim frmSalary As New frmSalary

        frmSalary.ShowDialog()

    End Sub

    Private Sub btnHourly_Click(sender As Object, e As EventArgs) Handles btnHourly.Click
        ' Open Hourly Form
        Dim frmHourly As New frmHourly

        frmHourly.ShowDialog()

    End Sub

    Private Sub btnTotals_Click(sender As Object, e As EventArgs) Handles btnTotals.Click
        ' Declare Local Variables
        Dim dblDailyTotalGross As Double
        Dim dblDailyTotalNet As Double

        ' Do Calculations
        Call Calculations(dblDailyTotalGross, dblDailyTotalNet)

        ' Display Outputs
        MessageBox.Show("The Total Gross Pay for today is " & dblDailyTotalGross.ToString("C") & vbCr &
                        "The Total Net Pay for today is " & dblDailyTotalNet.ToString("C"))


    End Sub

    Private Sub Calculations(ByRef dblDailyTotalGross As Double, ByRef dblDailyTotalNet As Double)
        ' Do Calculations for running totals
        dblDailyTotalGross = Calculate_DailyTotalGross()
        dblDailyTotalNet = Calculate_DailyTotalNet()
    End Sub

    Private Sub SalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryToolStripMenuItem.Click
        ' Open Salary Form
        Dim frmSalary As New frmSalary

        frmSalary.ShowDialog()
    End Sub

    Private Sub HourlyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HourlyToolStripMenuItem.Click
        ' Open Hourly Form
        Dim frmHourly As New frmHourly

        frmHourly.ShowDialog()
    End Sub

    Private Sub DailyTotalsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyTotalsToolStripMenuItem.Click
        ' Declare Local Variables
        Dim dblDailyTotalGross As Double
        Dim dblDailyTotalNet As Double

        ' Do Calculations
        Call Calculations(dblDailyTotalGross, dblDailyTotalNet)

        ' Display Outputs
        MessageBox.Show("The Total Gross Pay for today is " & dblDailyTotalGross.ToString("C") & vbCr &
                        "The Total Net Pay for today is " & dblDailyTotalNet.ToString("C"))

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Close the Application
        Close()
    End Sub
End Class
