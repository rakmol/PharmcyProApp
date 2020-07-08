Imports MySql.Data.MySqlClient

Public Class MainPage
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Sub TransactionLoad()
        Dim connection As New MySqlConnection("server=localhost;port=3306;database=transactions;username=root;password=;")
        Dim command As New MySqlCommand("INSERT INTO `transactionsales` (`ProductName`, `ProductPrice`, `ProductQuantity`) VALUES (@pname, @price, @pquantity)", connection)

        command.Parameters.Add("@pname", MySqlDbType.VarChar).Value = Ptbox.Text
        command.Parameters.Add("@price", MySqlDbType.Int24).Value = TboxPrice.Text
        command.Parameters.Add("@pquantity", MySqlDbType.Int24).Value = TboxQty.Text

        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Items added successfully")
        Else
            MessageBox.Show("ERROR ADDING ITEMS")
        End If

        connection.Close()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Public Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        TransactionLoad()

        Dim Price As Decimal = Decimal.Parse(TboxPrice.Text)
        Dim Qty As Decimal = Decimal.Parse(TboxQty.Text)
        Dim Sum As Decimal = Price * Qty


        DGV.Rows.Add(Ptbox.Text, Price, Qty, Sum)
        DGV2.Rows.Add(Ptbox.Text, Price, Qty)


        Clear_Box()

        Dim TotalAmount As Decimal = 0
        Dim Cur As String = "Ghc"
        For i = 0 To DGV.Rows.Count - 1
            TotalAmount += DGV.Rows(i).Cells(3).Value
        Next
        Dim v As String = $"{Cur}{TotalAmount}"

        TPrice.Text = v
        dashboardtPrice.Text = v


    End Sub


    Private Sub Clear_Box()
        TboxPrice.Clear()
        TboxQty.Clear()

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TboxQty.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub ClearAllBtn_Click(sender As Object, e As EventArgs)
        Me.DGV.Rows.Clear()

    End Sub

    Private Sub RemoveRowBtn_Click(sender As Object, e As EventArgs)
        If DGV.SelectedRows.Count > 0 Then
            For i As Integer = DGV.SelectedRows.Count - 1 To 0 Step -1
                DGV.Rows.RemoveAt(DGV.SelectedRows(i).Index)

            Next
        Else
            MessageBox.Show("No rows to select")
        End If

    End Sub

    Private Sub DGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        DGV.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        Dim TotalAmount As Decimal = 0
        Dim Cur As String = "Ghc"
        For i = 0 To DGV.Rows.Count - 1
            TotalAmount += DGV.Rows(i).Cells(1).Value
        Next
        Dim v As String = $"{Cur}{TotalAmount}"
        TPrice.Text = v
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs)
        Dim TotalAmount As Decimal = 0
        Dim Cur As String = "Ghc"
        For i = 0 To DGV.Rows.Count - 1
            TotalAmount += DGV.Rows(i).Cells(1).Value
        Next
        Dim v As String = $"{Cur}{TotalAmount}"
        TPrice.Text = v
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        If DGV.SelectedRows.Count > 0 Then
            For i As Integer = DGV.SelectedRows.Count - 1 To 0 Step -1
                DGV.Rows.RemoveAt(DGV.SelectedRows(i).Index)

            Next
        Else
            MessageBox.Show("No rows to select")
        End If
    End Sub

    Private Sub TPrice_Click(sender As Object, e As EventArgs) Handles TPrice.Click

    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Dim TotalAmount As Decimal = 0
        Dim Cur As String = "Ghc"
        For i = 0 To DGV.Rows.Count - 1
            TotalAmount += DGV.Rows(i).Cells(3).Value
        Next
        Dim v As String = $"{Cur}{TotalAmount}"
        TPrice.Text = v

    End Sub

    Private Sub Guna2CircleButton3_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton3.Click
        Me.DGV.Rows.Clear()
    End Sub

    Private Sub Ptbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Ptbox.SelectedIndexChanged
        Dim connection As New MySqlConnection("server=localhost;port=3306;database=drugsinformation;username=root;password=")
        Dim READER As MySqlDataReader
        Try
            connection.Open()
            Dim query As String
            query = "select * from drugs where DrugName='" & Ptbox.Text & "'"

            COMMAND = New MySqlCommand(query, connection)
            READER = COMMAND.ExecuteReader
            While READER.Read = True
                TboxPrice.Text = READER("Cost_Price")
            End While
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            COMMAND.Dispose()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim Result As DialogResult
        Result = MsgBox("Would you like to logout?", vbOKCancel, "Logout")
        If Result = DialogResult.OK Then
            LoginForm.Show()
            Me.Close()
        ElseIf Result = Windows.Forms.DialogResult.Cancel Then
            Me.Show()
        End If
    End Sub

    Private Sub TransactPanel_Paint(sender As Object, e As PaintEventArgs) Handles TransactPanel.Paint
        Dim connection As New MySqlConnection("server=localhost;port=3306;database=drugsinformation;username=root;password=")
        Dim READER As MySqlDataReader
        Try
            connection.Open()
            Dim Query As String
            Query = "select * from drugs"
            COMMAND = New MySqlCommand(Query, connection)
            READER = COMMAND.ExecuteReader
            While READER.Read = True
                Dim pList As String
                pList = READER("DrugName")
                Ptbox.Items.Add(pList)
            End While
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        HomePanel.Visible = True
        TransactPanel.Visible = False
        DashboardPanel.Visible = False
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        HomePanel.Visible = False
        TransactPanel.Visible = True
        DashboardPanel.Visible = False
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        HomePanel.Visible = False
        TransactPanel.Visible = False
        DashboardPanel.Visible = True

    End Sub

    Private bitmap As Bitmap

    Private Sub Guna2Button1_Click_2(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        e.Graphics.DrawString("Welcome to Pharmapro", New Font("Arial", 19, FontStyle.Bold), Brushes.Black, New Point(300, 20))
        e.Graphics.DrawString("Date:" + DateTime.Now, New Font("Arial", 19, FontStyle.Regular), Brushes.Red, New Point(20, 70))
        e.Graphics.DrawString("=================================================================", New Font("Arial", 19, FontStyle.Regular), Brushes.Black, New Point(20, 90))
        e.Graphics.DrawString("Product Description", New Font("Arial", 19, FontStyle.Regular), Brushes.Black, New Point(20, 110))
        e.Graphics.DrawString("Item", New Font("Arial", 19, FontStyle.Regular), Brushes.Black, New Point(300, 110))
        e.Graphics.DrawString("Quantity", New Font("Arial", 19, FontStyle.Regular), Brushes.Black, New Point(500, 110))
        e.Graphics.DrawString("Price", New Font("Arial", 19, FontStyle.Regular), Brushes.Black, New Point(700, 110))
        e.Graphics.DrawString("=================================================================", New Font("Arial", 19, FontStyle.Regular), Brushes.Black, New Point(20, 130))


        e.Graphics.DrawString("=================================================================", New Font("Arial", 19, FontStyle.Regular), Brushes.Black, New Point(20, 760))
        e.Graphics.DrawString("Total Amount:" + TPrice.Text, New Font("Arial", 19, FontStyle.Regular), Brushes.Black, New Point(20, 800))

    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click

    End Sub

    Private Sub dashboardtPrice_TextChanged(sender As Object, e As EventArgs) Handles dashboardtPrice.TextChanged

    End Sub
End Class