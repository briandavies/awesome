Public Class tab

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        settings.Visible = True


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub tab_Load(sender As Object, e As EventArgs) Handles Me.Load
        WebControl1.Source = New Uri(My.Settings.Homepage)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebControl1.Source = New Uri(My.Settings.Homepage)

    End Sub

    Private Sub WebControl1_LoadingFrame(sender As Object, e As Awesomium.Core.LoadingFrameEventArgs) Handles WebControl1.LoadingFrame
        PictureBox1.Visible = True

    End Sub

    Private Sub WebControl1_LoadingFrameComplete(sender As Object, e As Awesomium.Core.FrameEventArgs) Handles WebControl1.LoadingFrameComplete
        PictureBox1.Visible = False
        Parent.Text = WebControl1.Title
        TextBox1.Text = WebControl1.Source.ToString

    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_ShowCreatedWebView(sender As Object, e As Awesomium.Core.ShowCreatedWebViewEventArgs) Handles WebControl1.ShowCreatedWebView

    End Sub

    Private Sub AwesomeBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AwesomeBrowserToolStripMenuItem.Click
        settings.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If WebControl1.CanGoBack Then
            WebControl1.GoBack()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If WebControl1.CanGoForward Then
            WebControl1.GoForward()

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If WebControl1.IsNavigating Then
            WebControl1.Stop()

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebControl1.Reload(ignoreCache:=True)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".org") Or TextBox1.Text.Contains(".co.uk") Then
            Try
                WebControl1.Source = New Uri(TextBox1.Text)

            Catch ex As System.UriFormatException
                WebControl1.Source = New Uri("http://" + TextBox1.Text)
                TextBox1.Text = ("http://" + TextBox1.Text)


            End Try
        Else : WebControl1.Source = New Uri("http://www.google.co.uk/#q= " & TextBox1.Text)



        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".org") Or TextBox1.Text.Contains(".co.uk") Then

            End If
            Try
                WebControl1.Source = New Uri(TextBox1.Text)

            Catch ex As System.UriFormatException
                WebControl1.Source = New Uri("http://" + TextBox1.Text)
                TextBox1.Text = (TextBox1.Text)
               

            End Try
            REM Else : WebControl1.Source = New Uri("http://www.google.co.uk/#q=  " & TextBox1.Text)

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class