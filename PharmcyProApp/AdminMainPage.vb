Imports MySql.Data.MySqlClient

Public Class AdminMainPage



    Dim tables As DataTableCollection
    Dim souce1 As New BindingSource
    Public sql As String
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader

    Dim str As String = "datasource=localhost;port=3306;username=root;password=;database=drugsinformation; convert zero datetime=True"
    Dim conn As New MySqlConnection(str)

    Sub transactionsales()
        Dim stron As String = "datasource=localhost;port=3306;username=root;password=;database= transactions;"
        Dim conn As New MySqlConnection(stron)

        Dim query As String = "select * from transactionsales"
        Dim da As New MySqlDataAdapter(query, stron)
        Dim ds As New DataSet
        da.Fill(ds, "admin")
        dataGridView3.DataSource = ds.Tables(0)

        conn.Close()
    End Sub


    Sub load()
        Dim query As String = "select * from drugs"
        Dim da As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet
        da.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)

        conn.Close()

        txtboxProductId.Clear()
        txtboxProductName.Clear()
        txtboxProductPrice.Clear()
        txtboxBatchNo.Clear()
        txtboxProductionDate.Clear()
        txtboxExpiryDate.Clear()
        txtboxManufacturer.Clear()
        txtboxQuantity.Clear()

    End Sub


    Private Sub HomeButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddItemButton_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub DashboardItemButton_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddItemButton_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        HomePanel.Visible = True
        ManageProductsPanel.Visible = False
        DashboardPanel.Visible = False
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        HomePanel.Visible = False
        ManageProductsPanel.Visible = True
        DashboardPanel.Visible = False
    End Sub

    Private Sub Guna2Button3_Click_1(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        HomePanel.Visible = False
        ManageProductsPanel.Visible = False
        DashboardPanel.Visible = True


    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HomePanel_Paint(sender As Object, e As PaintEventArgs) Handles HomePanel.Paint

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)
        ProdcutsListsPanel.Visible = False
        ExpiredProductsPanel.Visible = False
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        ProdcutsListsPanel.Visible = True
        ExpiredProductsPanel.Visible = False
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        ProdcutsListsPanel.Visible = False
        ExpiredProductsPanel.Visible = True
    End Sub

    Private Sub AddItemPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button7_Click_1(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        load()       
    End Sub

    Private Sub ProdcutsListsPanel_Paint(sender As Object, e As PaintEventArgs) Handles ProdcutsListsPanel.Paint

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Guna2Button8_Click_1(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Dim Result As DialogResult
        Result = MsgBox("Would you like to logout?", vbOKCancel, "Logout")
        If Result = DialogResult.OK Then
            LoginForm.Show()
            Me.Close()
        ElseIf Result = Windows.Forms.DialogResult.Cancel Then
            Me.Show()
        End If
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        Dim connection As New MySqlConnection("server=localhost;port=3306;database=drugsinformation;username=root;password=; convert zero datetime=True")
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet

        Try
            connection.Open()
            adapter = New MySqlDataAdapter("select * from drugs where DrugName like '%" & txtboxSearch.Text & "%'", connection)
            adapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            connection.Close()

            txtboxProductId.Clear()
            txtboxProductName.Clear()
            txtboxProductPrice.Clear()
            txtboxBatchNo.Clear()
            txtboxProductionDate.Clear()
            txtboxExpiryDate.Clear()
            txtboxManufacturer.Clear()
            txtboxQuantity.Clear()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Guna2Button10_Click_1(sender As Object, e As EventArgs) 

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Guna2Button10_Click_2(sender As Object, e As EventArgs) Handles Guna2Button10.Click
        Dim connection As New MySqlConnection("server=localhost;port=3306;database=drugsinformation;username=root;password=; convert zero datetime=True")
        Dim command As New MySqlCommand("INSERT INTO `drugs` (`DrugID`, `DrugName`, `Cost_Price`, `BatchNo`, `ProductionDate`, `ExpiryDate`, `Manufacturer`,`Quantity`) VALUES (@did, @dname, @cprice, @bno, @pdate, @edate, @manu,@pquantity)", connection)
        command.Parameters.Add("@did", MySqlDbType.Int24).Value = txtboxProductId.Text
        command.Parameters.Add("@dname", MySqlDbType.VarChar).Value = txtboxProductName.Text
        command.Parameters.Add("@cprice", MySqlDbType.Int24).Value = txtboxProductPrice.Text
        command.Parameters.Add("@bno", MySqlDbType.Int24).Value = txtboxBatchNo.Text
        command.Parameters.Add("@pdate", MySqlDbType.Date).Value = txtboxProductionDate.Text
        command.Parameters.Add("@edate", MySqlDbType.Date).Value = txtboxExpiryDate.Text
        command.Parameters.Add("@manu", MySqlDbType.VarChar).Value = txtboxManufacturer.Text
        command.Parameters.Add("@pquantity", MySqlDbType.Int24).Value = txtboxQuantity.Text



        connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Items added successfully")
        Else
            MessageBox.Show("ERROR ADDING ITEMS")
        End If
        connection.Close()

        txtboxProductId.Clear()
        txtboxProductName.Clear()
        txtboxProductPrice.Clear()
        txtboxBatchNo.Clear()
        txtboxProductionDate.Clear()
        txtboxExpiryDate.Clear()
        txtboxManufacturer.Clear()
        txtboxQuantity.Clear()

        load()
    End Sub

    Private Sub Guna2Button9_Click_1(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        Dim rndnumber As Random
        Dim number As Integer
        rndnumber = New Random
        number = rndnumber.Next(1000000, 9999999)
        txtboxProductId.Text = number.ToString
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            txtboxProductId.Text = row.Cells(0).Value.ToString()
            txtboxProductName.Text = row.Cells(1).Value.ToString()
            txtboxProductPrice.Text = row.Cells(2).Value.ToString()
            txtboxBatchNo.Text = row.Cells(3).Value.ToString()
            txtboxProductionDate.Text = row.Cells(4).Value.ToString()
            txtboxExpiryDate.Text = row.Cells(5).Value.ToString()
            txtboxManufacturer.Text = row.Cells(6).Value.ToString()
            txtboxQuantity.Text = row.Cells(7).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2Button11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button11_Click_1(sender As Object, e As EventArgs) Handles Guna2Button11.Click
        Dim connection As New MySqlConnection("server=localhost;port=3306;database=drugsinformation;username=root;password=")
        connection.Open()
        Try

            cmd = connection.CreateCommand()
            cmd.CommandText = "delete from drugs where DrugId=@did;"
            cmd.Parameters.AddWithValue("@did", txtboxProductId.Text)
            cmd.ExecuteNonQuery()

            load()
        Catch ex As Exception

        End Try



    End Sub

    Private Sub Guna2Button12_Click(sender As Object, e As EventArgs) Handles Guna2Button12.Click
        Dim connection As New MySqlConnection("server=localhost;port=3306;database=drugsinformation;username=root;password=; convert zero datetime=True")
        connection.Open()

        Try
            cmd = connection.CreateCommand()
            cmd.CommandText = "update drugs set DrugName=@dname,Cost_Price=@cprice,BatchNo=@bno,ProductionDate=@pdate,ExpiryDate=@edate,Manufacturer=@manu,Quantity=@pquantity where DrugId=@did"
            cmd.Parameters.AddWithValue("@did", txtboxProductId.Text)
            cmd.Parameters.AddWithValue("@dname", txtboxProductName.Text)
            cmd.Parameters.AddWithValue("@cprice", txtboxProductPrice.Text)
            cmd.Parameters.AddWithValue("@bno", txtboxBatchNo.Text)
            cmd.Parameters.AddWithValue("@pdate", txtboxProductionDate.Text)
            cmd.Parameters.AddWithValue("@edate", txtboxExpiryDate.Text)
            cmd.Parameters.AddWithValue("@manu", txtboxManufacturer.Text)
            cmd.Parameters.AddWithValue("@pquantity", txtboxQuantity.Text)
            cmd.ExecuteNonQuery()
            load()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Guna2Button4_Click_1(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        transactionsales()

        Dim stron As String = "datasource=localhost;port=3306;username=root;password=;database= transactions;"
        Dim conn As New MySqlConnection(stron)

        Dim query As String = "select * from transactionsales"
        Dim da As New MySqlDataAdapter(query, stron)
        Dim ds As New DataSet
        da.Fill(ds, "admin")
        dataGridView3.DataSource = ds.Tables(0)

        conn.Close()
    End Sub

    Private Sub adminTprice_TextChanged(sender As Object, e As EventArgs) Handles adminTprice.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class