Public Class Loginform

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Admin" And TextBox2.Text = "Test123" Then
            MsgBox("You are Now Logged In", MsgBoxStyle.Information, "Login")
            Form1.Show()
            Me.Hide()
        Else
            If TextBox1.Text = "" And TextBox2.Text = "" Then
                MsgBox("No Username and/or Password Found!", MsgBoxStyle.Critical, "Error")
            Else
                If TextBox1.Text = "" Then
                    MsgBox("No Username Found!", MsgBoxStyle.Critical, "Error")
                Else
                    If TextBox2.Text = "" Then
                        MsgBox("No Password Found!", MsgBoxStyle.Critical, "Error")
                    Else
                        MsgBox("Invalid Username And/Or Password!", MsgBoxStyle.Critical, "Error")

                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

End Class