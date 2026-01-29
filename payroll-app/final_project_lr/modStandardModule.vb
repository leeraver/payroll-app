Module modStandardModule

    ' Declare Class Constants
    Const shrPayPeriods As Short = 52
    Const shrFullTime As Short = 40
    Const dblOvertimeRate As Double = 1.5
    Const dblSocialSecurityRate As Double = 0.062
    Const intSocialSecurityCutoff As Integer = 125000
    Const dblMedicareRate As Double = 0.0145
    Const dblOhioTaxRate As Double = 0.065
    Const dblKentuckyTaxRate As Double = 0.06
    Const dblIndianaTaxRate As Double = 0.055

    ' Declare Class Variables
    Dim dblDailyHourlyGross As Double
    Dim dblDailyHourlyNet As Double
    Dim dblDailySalaryGross As Double
    Dim dblDailySalaryNet As Double

    Public Function Calculate_Hourly_GrossPay(ByVal shrHoursWorked As Short, ByVal dblHourlyWage As Double) As Double
        ' Calculate Hourly Gross Pay
        Dim dblGrossPay As Double

        If shrHoursWorked <= shrFullTime Then
            dblGrossPay = shrHoursWorked * dblHourlyWage
        Else
            dblGrossPay = (shrFullTime * dblHourlyWage) + ((shrHoursWorked - shrFullTime) * (dblHourlyWage * dblOvertimeRate))
        End If

        ' Add Gross Pay to Hourly Gross Daily Total
        dblDailyHourlyGross += dblGrossPay

        Return dblGrossPay

    End Function

    Public Function Calculate_Salary_GrossPay(ByRef dblYearlySalary As Double) As Double
        ' Calculate Salary Gross Pay
        Dim dblGrossPay As Double

        dblGrossPay = dblYearlySalary / shrPayPeriods

        ' Add Gross Pay to Salary Gross Daily Total
        dblDailySalaryGross += dblGrossPay

        Return dblGrossPay

    End Function

    Public Function Calculate_FICA(ByVal dblCumulativeYearly As Double, ByVal dblGrossPay As Double) As Double
        ' Calculate FICA
        Dim dblSocialSecurity As Double
        Dim dblMedicare As Double

        dblSocialSecurity = Calculate_SocialSecurity(dblCumulativeYearly, dblGrossPay)
        dblMedicare = Calculate_Medicare(dblGrossPay)

        Return dblSocialSecurity + dblMedicare

    End Function

    Private Function Calculate_SocialSecurity(ByVal dblCumulativeYearly As Double, ByVal dblGrossPay As Double) As Double
        ' Calculate Social Security Tax
        Dim dblSocialSecurity As Double

        If (dblCumulativeYearly + dblGrossPay) <= intSocialSecurityCutoff Then
            dblSocialSecurity = dblGrossPay * dblSocialSecurityRate
        Else
            If dblCumulativeYearly < intSocialSecurityCutoff Then
                dblSocialSecurity = (intSocialSecurityCutoff - dblCumulativeYearly) * dblSocialSecurityRate
            Else
                dblSocialSecurity = 0
            End If
        End If

        Return dblSocialSecurity

    End Function

    Private Function Calculate_Medicare(ByVal dblGrossPay As Double) As Double
        ' Calculate Medicare Tax
        Return dblGrossPay * dblMedicareRate

    End Function

    Public Function Calculate_StateTax(ByVal dblGrossPay As Double, ByVal strState As String) As Double
        ' Calculate State Tax Based on State
        Dim dblStateTax As Double

        If strState = "Ohio" Then
            dblStateTax = dblGrossPay * dblOhioTaxRate
        End If

        If strState = "Kentucky" Then
            dblStateTax = dblGrossPay * dblKentuckyTaxRate
        End If

        If strState = "Indiana" Then
            dblStateTax = dblGrossPay * dblIndianaTaxRate
        End If

        Return dblStateTax

    End Function

    Public Function Calculate_FederalTax(ByVal dblGrossPay As Double) As Double
        ' Calculate Federal Tax based on Gross Pay Amount
        Dim dblFederalTax As Double

        If dblGrossPay <= 50 Then
            dblFederalTax = 0
        End If

        If dblGrossPay > 50 And dblGrossPay <= 500 Then
            dblFederalTax = (dblGrossPay - 50) * 0.1
        End If

        If dblGrossPay > 500 And dblGrossPay <= 2500 Then
            dblFederalTax = 45 + ((dblGrossPay - 500) * 0.15)
        End If

        If dblGrossPay > 2500 And dblGrossPay <= 5000 Then
            dblFederalTax = 345 + ((dblGrossPay - 2500) * 0.2)
        End If

        If dblGrossPay > 5000 Then
            dblFederalTax = 845 + ((dblGrossPay - 5000) * 0.25)
        End If

        Return dblFederalTax

    End Function

    Public Function Calculate_Hourly_NetPay(ByVal dblGrossPay As Double, ByVal dblFICA As Double, ByVal dblStateTax As Double, ByVal dblFederalTax As Double) As Double
        ' Calculate Net Pay
        Dim dblNetPay As Double

        dblNetPay = dblGrossPay - dblFICA - dblStateTax - dblFederalTax

        ' Add Net Pay to running Daily total for Hourly
        dblDailyHourlyNet += dblNetPay

        Return dblNetPay

    End Function

    Public Function Calculate_Salary_NetPay(ByVal dblGrossPay As Double, ByVal dblFICA As Double, ByVal dblStateTax As Double, ByVal dblFederalTax As Double) As Double
        ' Calculate Net Pay
        Dim dblNetPay As Double

        dblNetPay = dblGrossPay - dblFICA - dblStateTax - dblFederalTax

        ' Add Net Pay to running Daily total for Salary
        dblDailySalaryNet += dblNetPay

        Return dblNetPay

    End Function

    Public Function Calculate_DailyTotalGross() As Double
        ' Calculate the Running totals for the day for Gross Pay
        Return dblDailyHourlyGross + dblDailySalaryGross
    End Function

    Public Function Calculate_DailyTotalNet() As Double
        ' Calculate the Running totals for the day for Net Pay
        Return dblDailyHourlyNet + dblDailySalaryNet
    End Function

End Module
