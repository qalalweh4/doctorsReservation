Public Class Login_registerForm


    'display the login panel'
    Private Sub ButtonGoToLogin_Click(sender As Object, e As EventArgs) Handles ButtonGoToLogin.Click
        Panel_Register1.Visible = False
        Panel_Login.Visible = True

    End Sub

    'display the register panel'
    Private Sub ButtonGoToRegister_Click(sender As Object, e As EventArgs) Handles ButtonGoToRegister.Click
        Panel_Register1.Visible = True
        Panel_Login.Visible = False
    End Sub

    Private Sub username_Register_TextChanged(sender As Object, e As EventArgs) Handles username_Register.TextChanged

    End Sub

    Private Sub email_Register_TextChanged(sender As Object, e As EventArgs) Handles email_Register.TextChanged

    End Sub

    Private Sub Password_Register_TextChanged(sender As Object, e As EventArgs) Handles Password_Register.TextChanged

    End Sub

    Private Sub Button_Register_Click(sender As Object, e As EventArgs) Handles Button_Register.Click
        'when authenticated go to the reservation form'
        Dim roomReservationForm As New ReservationForm()
        Me.Hide() ' Hide the current form
        roomReservationForm.Show()
    End Sub

    Private Sub username_Login_TextChanged(sender As Object, e As EventArgs) Handles username_Login.TextChanged

    End Sub

    Private Sub password_Login_TextChanged(sender As Object, e As EventArgs) Handles password_Login.TextChanged

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        'when authenticated go to the reservation form'
        Dim roomReservationForm As New ReservationForm()
        Me.Hide() ' Hide the current form
        roomReservationForm.Show()
    End Sub
End Class