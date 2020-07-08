Public Class TrialAttendantPage
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        HomePanel.Visible = True
        TransactPanel.Visible = False
        HistoryPanel.Visible = False
        DashbooardPanel.Visible = False
    End Sub

    Private Sub btnTransact_Click(sender As Object, e As EventArgs) Handles btnTransact.Click
        HomePanel.Visible = False
        TransactPanel.Visible = True
        HistoryPanel.Visible = False
        DashbooardPanel.Visible = False
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        HomePanel.Visible = False
        TransactPanel.Visible = False
        HistoryPanel.Visible = True
        DashbooardPanel.Visible = False
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        HomePanel.Visible = False
        TransactPanel.Visible = False
        HistoryPanel.Visible = False
        DashbooardPanel.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Qty As Decimal = Decimal.Parse(QtyTBox.Text)
        Dim Price As Decimal = Decimal.Parse(PriceTbox.Text)
        Dim Sum As Decimal = Qty * Price

        DGV.Rows.Add(Qty, Price, Sum)

    End Sub
End Class