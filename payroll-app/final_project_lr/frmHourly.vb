Public Class frmHourly
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Declare Local Variables
        Dim strFirstName As String
        Dim strLastName As String
        Dim shrHoursWorked As Short
        Dim dblHourlyWage As Double
        Dim dblCumulativeYearly As Double
        Dim strState As String
        Dim dblGrossPay As Double
        Dim dblFICA As Double
        Dim dblStateTax As Double
        Dim dblFederalTax As Double
        Dim dblNetPay As Double
        Dim blnValidated As Boolean = True

        ' Get and Validate Inputs
        Call Get_Validate_Input(blnValidated, strFirstName, strLastName, shrHoursWorked, dblHourlyWage, dblCumulativeYearly, strState)

        ' Do Calculations
        If blnValidated Then
            Call Calculations(shrHoursWorked, dblHourlyWage, dblCumulativeYearly, strState, dblGrossPay, dblFICA, dblStateTax, dblFederalTax, dblNetPay)
            Call Display_Outputs(dblGrossPay, dblFICA, dblStateTax, dblFederalTax, dblNetPay)
        End If


    End Sub

    Private Sub Get_Validate_Input(ByRef blnValidated As Boolean, ByRef strFirstName As String, ByRef strLastName As String, ByRef shrHoursWorked As Short,
                                   ByRef dblHourlyWage As Double, ByRef dblCumulativeYearly As Double, ByRef strState As String)
        ' Get and Validate Input
        Call Get_Validate_FirstName(blnValidated, strFirstName)
        Call Get_Validate_LastName(blnValidated, strLastName)
        Call Get_Validate_HoursWorked(blnValidated, shrHoursWorked)
        Call Get_Validate_HourlyWage(blnValidated, dblHourlyWage)
        Call Get_Validate_CumulativeYearly(blnValidated, dblCumulativeYearly)
        Call Get_Validate_State(blnValidated, strState)

    End Sub

    Private Sub Get_Validate_FirstName(ByRef blnValidated As Boolean, ByRef strFirstName As String)
        ' Get and Validate First Name
        strFirstName = txtFirstName.Text

        If strFirstName = String.Empty Then
            MessageBox.Show("First Name is required.")
            txtFirstName.Focus()
            blnValidated = False
        End If
    End Sub

    Private Sub Get_Validate_LastName(ByRef blnValidated As Boolean, ByRef strLastName As String)
        ' Get and Validate Last Name
        strLastName = txtLastName.Text

        If strLastName = String.Empty Then
            MessageBox.Show("Last Name is required.")
            txtLastName.Focus()
            blnValidated = False
        End If
    End Sub

    Private Sub Get_Validate_HoursWorked(ByRef blnValidated As Boolean, ByRef shrHoursWorked As Short)
        ' Get and Validate Hours Worked

        If Short.TryParse(txtHoursWorked.Text, shrHoursWorked) Then
            If shrHoursWorked <= 0 Then
                MessageBox.Show("Hours Worked must be greater than 0.")
                txtHoursWorked.Focus()
                blnValidated = False
            End If
        Else
            MessageBox.Show("Hours Worked is required and must be a number.")
            txtHoursWorked.Focus()
            blnValidated = False
        End If
    End Sub

    Private Sub Get_Validate_HourlyWage(ByRef blnValidated As Boolean, ByRef dblHourlyWage As Double)
        ' Get and Validate Hourly Wage

        If Double.TryParse(txtHourlyWage.Text, dblHourlyWage) Then
            If dblHourlyWage <= 0 Then
                MessageBox.Show("Hourly Wage must be greater than 0")
                txtHourlyWage.Focus()
                blnValidated = False
            End If
        Else
            MessageBox.Show("Hourly Wage is required and must be a number.")
            txtHourlyWage.Focus()
            blnValidated = False
        End If
    End Sub

    Private Sub Get_Validate_CumulativeYearly(ByRef blnValidated As Boolean, ByRef dblCumulativeYearly As Double)
        ' Get and Validate Cumulative Yearly

        If Double.TryParse(txtCumulativeYearly.Text, dblCumulativeYearly) Then
            If dblCumulativeYearly < 0 Then
                MessageBox.Show("Cumulative Yearly Gross Pay must be a positive number.")
                txtCumulativeYearly.Focus()
                blnValidated = False
            End If
        Else
            MessageBox.Show("Cumulative Yearly Gross Pay is required and must be a number.")
            txtCumulativeYearly.Focus()
            blnValidated = False
        End If
    End Sub

    Private Sub Get_Validate_State(ByRef blnValidated As Boolean, ByRef strState As String)
        ' Get and Validate State
        strState = cboState.Text

        If strState = String.Empty Then
            MessageBox.Show("State is required.")
            cboState.Focus()
            blnValidated = False
        End If
    End Sub

    Private Sub Calculations(ByVal shrHoursWorked As Short, ByVal dblHourlyWage As Double, ByVal dblCumulativeYearly As Double, ByVal strState As String, ByRef dblGrossPay As Double,
                             ByRef dblFICA As Double, ByRef dblStateTax As Double, ByRef dblFederalTax As Double, ByRef dblNetPay As Double)
        ' Do Calculations for Hourly Employees
        dblGrossPay = Calculate_Hourly_GrossPay(shrHoursWorked, dblHourlyWage)
        dblFICA = Calculate_FICA(dblCumulativeYearly, dblGrossPay)
        dblStateTax = Calculate_StateTax(dblGrossPay, strState)
        dblFederalTax = Calculate_FederalTax(dblGrossPay)
        dblNetPay = Calculate_Hourly_NetPay(dblGrossPay, dblFICA, dblStateTax, dblFederalTax)

    End Sub

    Private Sub Display_Outputs(ByVal dblGrossPay As Double, ByVal dblFICA As Double, ByVal dblStateTax As Double, ByVal dblFederalTax As Double, ByVal dblNetPay As Double)
        ' Display Outputs for Hourly Employee
        lblGrossPay.Text = dblGrossPay.ToString("C")
        lblFICA.Text = dblFICA.ToString("C")
        lblStateTax.Text = dblStateTax.ToString("C")
        lblFederalTax.Text = dblFederalTax.ToString("C")
        lblNetPay.Text = dblNetPay.ToString("C")

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Clear all Form Inputs and Outputs
        txtFirstName.Clear()
        txtLastName.Clear()
        txtHoursWorked.Clear()
        txtHourlyWage.Clear()
        txtCumulativeYearly.Clear()
        cboState.ResetText()

        lblGrossPay.ResetText()
        lblFICA.ResetText()
        lblStateTax.ResetText()
        lblFederalTax.ResetText()
        lblNetPay.ResetText()

        ' Focus on input for next entry
        txtFirstName.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close Hourly Form
        Close()
    End Sub

    Private Sub CalculateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateToolStripMenuItem.Click
        ' Declare Local Variables
        Dim strFirstName As String
        Dim strLastName As String
        Dim shrHoursWorked As Short
        Dim dblHourlyWage As Double
        Dim dblCumulativeYearly As Double
        Dim strState As String
        Dim dblGrossPay As Double
        Dim dblFICA As Double
        Dim dblStateTax As Double
        Dim dblFederalTax As Double
        Dim dblNetPay As Double
        Dim blnValidated As Boolean = True

        ' Get and Validate Inputs
        Call Get_Validate_Input(blnValidated, strFirstName, strLastName, shrHoursWorked, dblHourlyWage, dblCumulativeYearly, strState)

        ' Do Calculations
        If blnValidated Then
            Call Calculations(shrHoursWorked, dblHourlyWage, dblCumulativeYearly, strState, dblGrossPay, dblFICA, dblStateTax, dblFederalTax, dblNetPay)
            Call Display_Outputs(dblGrossPay, dblFICA, dblStateTax, dblFederalTax, dblNetPay)
        End If

    End Sub

    Private Sub NextEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextEmployeeToolStripMenuItem.Click
        ' Clear all Form Inputs and Outputs
        txtFirstName.Clear()
        txtLastName.Clear()
        txtHoursWorked.Clear()
        txtHourlyWage.Clear()
        txtCumulativeYearly.Clear()
        cboState.ResetText()

        lblGrossPay.ResetText()
        lblFICA.ResetText()
        lblStateTax.ResetText()
        lblFederalTax.ResetText()
        lblNetPay.ResetText()

        ' Focus on input for next entry
        txtFirstName.Focus()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Close Hourly Form
        Close()
    End Sub
End Class