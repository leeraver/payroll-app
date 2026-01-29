Public Class frmSalary
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Declare Local Variables
        Dim strFirstName As String
        Dim strLastName As String
        Dim dblYearlySalary As Double
        Dim dblCumulativeYearly As Double
        Dim strState As String
        Dim dblGrossPay As Double
        Dim dblFICA As Double
        Dim dblStateTax As Double
        Dim dblFederalTax As Double
        Dim dblNetPay As Double
        Dim blnValidated As Boolean = True

        ' Get and Validate Inputs
        Call Get_Validate_Input(blnValidated, strFirstName, strLastName, dblYearlySalary, dblCumulativeYearly, strState)

        ' Do Calculations
        If blnValidated Then
            Call Calculations(dblYearlySalary, dblCumulativeYearly, strState, dblGrossPay, dblFICA, dblStateTax, dblFederalTax, dblNetPay)
            Call Display_Outputs(dblGrossPay, dblFICA, dblStateTax, dblFederalTax, dblNetPay)
        End If


    End Sub

    Private Sub Get_Validate_Input(ByRef blnValidated As Boolean, ByRef strFirstName As String, ByRef strLastName As String, ByRef dblYearlySalary As Double,
                                   ByRef dblCumulativeYearly As Double, ByRef strState As String)
        ' Get and Validate Input
        Call Get_Validate_FirstName(blnValidated, strFirstName)
        Call Get_Validate_LastName(blnValidated, strLastName)
        Call Get_Validate_YearlySalary(blnValidated, dblYearlySalary)
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

    Private Sub Get_Validate_YearlySalary(ByRef blnValidated As Boolean, ByRef dblYearlySalary As Double)
        ' Get and Validate Yearly Salary
        If Double.TryParse(txtYearlySalary.Text, dblYearlySalary) Then
            If dblYearlySalary <= 0 Then
                MessageBox.Show("Yearly Salary must be greater than 0.")
                txtYearlySalary.Focus()
                blnValidated = False
            End If
        Else
            MessageBox.Show("Yearly Salary is required and must be a number.")
            txtYearlySalary.Focus()
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

    Private Sub Calculations(ByVal dblYearlySalary As Double, ByVal dblCumulativeYearly As Double, ByVal strState As String, ByRef dblGrossPay As Double,
                             ByRef dblFICA As Double, ByRef dblStateTax As Double, ByRef dblFederalTax As Double, ByRef dblNetPay As Double)
        ' Do Calculations for Salary Employees
        dblGrossPay = Calculate_Salary_GrossPay(dblYearlySalary)
        dblFICA = Calculate_FICA(dblCumulativeYearly, dblGrossPay)
        dblStateTax = Calculate_StateTax(dblGrossPay, strState)
        dblFederalTax = Calculate_FederalTax(dblGrossPay)
        dblNetPay = Calculate_Salary_NetPay(dblGrossPay, dblFICA, dblStateTax, dblFederalTax)

    End Sub

    Private Sub Display_Outputs(ByVal dblGrossPay As Double, ByVal dblFICA As Double, ByVal dblStateTax As Double, ByVal dblFederalTax As Double, ByVal dblNetPay As Double)
        ' Display Outputs for Salary Employee
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
        txtYearlySalary.Clear()
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
        ' Close Form
        Close()
    End Sub

    Private Sub CalculateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateToolStripMenuItem.Click
        ' Declare Local Variables
        Dim strFirstName As String
        Dim strLastName As String
        Dim dblYearlySalary As Double
        Dim dblCumulativeYearly As Double
        Dim strState As String
        Dim dblGrossPay As Double
        Dim dblFICA As Double
        Dim dblStateTax As Double
        Dim dblFederalTax As Double
        Dim dblNetPay As Double
        Dim blnValidated As Boolean = True

        ' Get and Validate Inputs
        Call Get_Validate_Input(blnValidated, strFirstName, strLastName, dblYearlySalary, dblCumulativeYearly, strState)

        ' Do Calculations
        If blnValidated Then
            Call Calculations(dblYearlySalary, dblCumulativeYearly, strState, dblGrossPay, dblFICA, dblStateTax, dblFederalTax, dblNetPay)
            Call Display_Outputs(dblGrossPay, dblFICA, dblStateTax, dblFederalTax, dblNetPay)
        End If

    End Sub

    Private Sub NextEmpoyeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextEmpoyeeToolStripMenuItem.Click
        ' Clear all Form Inputs and Outputs
        txtFirstName.Clear()
        txtLastName.Clear()
        txtYearlySalary.Clear()
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
        ' Close Form
        Close()
    End Sub
End Class