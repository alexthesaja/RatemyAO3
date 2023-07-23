Imports System.Net.Http
Imports HtmlAgilityPack
Imports Newtonsoft.Json.Linq
Public Class Form1

    Private Async Sub btnRate_Click(sender As Object, e As EventArgs) Handles btnRate.Click
        Dim url As String = txtURL.Text
        lbl5stars0.Visible = False

        Try
            Dim httpClient As New HttpClient()
            Dim response As HttpResponseMessage = Await httpClient.GetAsync(url)

            If response.IsSuccessStatusCode Then
                Dim htmlContent As String = Await response.Content.ReadAsStringAsync()

                ' Load the HTML content into the HtmlDocument
                Dim htmlDoc As New HtmlDocument()
                htmlDoc.LoadHtml(htmlContent)

                ' Find the "Kudos" element
                Dim kudosNode As HtmlNode = htmlDoc.DocumentNode.SelectSingleNode("//dd[@class='kudos']")
                Dim kudos As String = If(kudosNode IsNot Nothing, kudosNode.InnerText, "N/A")
                txtKudos.Text = kudos

                ' Find the "Hits" element
                Dim HitsNode As HtmlNode = htmlDoc.DocumentNode.SelectSingleNode("//dd[@class='hits']")
                Dim Hits As String = If(HitsNode IsNot Nothing, HitsNode.InnerText, "N/A")
                txtHits.Text = Hits

                Dim rate As Double = 0
                rate = (CDbl(txtKudos.Text) / CDbl(txtHits.Text)) * 100
                txtRate.Text = rate

                If rate >= 1.0 AndAlso rate <= 2.5 Then
                    lbl5stars.Visible = True
                    lbl4stars.Visible = False
                    lbl3stars.Visible = False
                    lbl2stars.Visible = False
                    lbl1star.Visible = False

                ElseIf rate > 2.5 AndAlso rate <= 3.5 Then
                    lbl4stars.Visible = True
                    lbl5stars.Visible = False
                    lbl3stars.Visible = False
                    lbl2stars.Visible = False
                    lbl1star.Visible = False

                ElseIf rate > 3.5 AndAlso rate <= 4.5 Then
                    lbl5stars.Visible = False
                    lbl4stars.Visible = False
                    lbl3stars.Visible = True
                    lbl2stars.Visible = False
                    lbl1star.Visible = False

                ElseIf rate > 4.5 AndAlso rate <= 10.0 Then
                    lbl5stars.Visible = False
                    lbl4stars.Visible = False
                    lbl3stars.Visible = False
                    lbl2stars.Visible = True
                    lbl1star.Visible = False
                Else
                    lbl5stars.Visible = False
                    lbl4stars.Visible = False
                    lbl3stars.Visible = False
                    lbl2stars.Visible = False
                    lbl1star.Visible = True

                End If

            Else
                MessageBox.Show("Error retrieving data from the URL.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub ao3Link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ao3Link.LinkClicked

        Process.Start(txtURL.Text)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl5stars0.Visible = True
        lbl5stars.Visible = False
        lbl4stars.Visible = False
        lbl3stars.Visible = False
        lbl2stars.Visible = False
        lbl1star.Visible = False

    End Sub
End Class