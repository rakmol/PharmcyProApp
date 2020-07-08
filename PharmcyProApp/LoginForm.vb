Public Class LoginForm
    Private Panel2 As Object

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(120, 0, 0, 0)


        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        Label3.BackColor = Color.Transparent

        Label1.ForeColor = Color.White
        Label2.ForeColor = Color.White
        Label3.ForeColor = Color.White

        TextBoxUsername.BackColor = Color.Gray
        TextBoxPassword.BackColor = Color.Gray

        TextBoxUsername.ForeColor = Color.Yellow
        TextBoxPassword.ForeColor = Color.Yellow

        Button_Login.FlatStyle = FlatStyle.Flat
        Button_Login.BackColor = Color.FromArgb(39, 174, 96)
        Button_Login.ForeColor = Color.White
        Button_Login.FlatAppearance.BorderColor = Color.White


    End Sub

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        If TextBoxUsername.Text = "attendant" And TextBoxPassword.Text = "123" Then
            MainPage.Show()
            Me.Hide()
        ElseIf TextBoxUsername.Text = "admin" And TextBoxPassword.Text = "admin123" Then
            AdminMainPage.Show()
            Me.Hide()
        ElseIf TextBoxUsername.Text = "" Then
            MsgBox("please Enter username")
        ElseIf TextBoxPassword.Text = "" Then
            MsgBox("Please Enter password")
        ElseIf TextBoxUsername.Text = "" And TextBoxPassword.Text = "" Then
            MsgBox("Provide Username and Password")

        End If
        TextBoxUsername.Clear()
        TextBoxPassword.Clear()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
