Imports System.Text.RegularExpressions, System.Threading, System.Net, System.IO, System.Text
Public Class MainForm
    Dim links, proxies As New List(Of String)()
    Dim ParseProxiesOfPage As New ArrayList
    Dim t_list As New List(Of Thread)
    Dim done As Integer
    Dim thread_status As Boolean
    Dim thread_status2 As Boolean
    Private client As WebClient
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        client = New WebClient
        Dim FileName As String = Application.StartupPath & "\Sources.txt"
        For Each item In File.ReadAllLines(FileName)
            item = item.Replace(" ", "")
            links.Add(item)
        Next
        Using client As New WebClient
            TB_Changelog.ReadOnly = True
            TB_Changelog.Text = client.DownloadString("http://pastebin.com/raw/7C1SdQQy")
        End Using
    End Sub
    Private Sub btn_Gather_Click(sender As Object, e As EventArgs) Handles btn_Gather.Click
        thread_status = True
        Dim threads As Integer = TC_Gather.Value
        ThreadPool.SetMinThreads(threads, threads)
        ThreadPool.SetMaxThreads(threads, threads)
        ServicePointManager.DefaultConnectionLimit = threads
        ServicePointManager.Expect100Continue = True
        For Each link In links
            ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf scraper), link)
        Next
    End Sub

    Private Sub btn_Parse_Click(sender As Object, e As EventArgs) Handles btn_Parse.Click
        Using wc As New WebClient
            Try
                Dim source As String = wc.DownloadString(TB_Website.Text)
                Dim expression As New Regex("(\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\:[0-9]{1,5}\b)")
                Dim mtac As MatchCollection = expression.Matches(source)

                For Each item As Match In mtac
                    Dim capt As String = item.Groups(1).Value
                    Debug.WriteLine(capt)
                    LB_ParsedProxies.Items.Add(capt)
                    If Not proxies.Contains(capt) Then
                        proxies.Add(capt)
                        Text = "Proxies Parsed: " & LB_ParsedProxies.Items.Count.ToString()

                        If LB_ParsedProxies.InvokeRequired = True Then
                            LB_ParsedProxies.Invoke(Sub()
                                                        LB_ParsedProxies.Items.Add(capt)
                                                    End Sub)
                        End If
                    End If
                Next
                LB_ParsedProxies.TopIndex = LB_ParsedProxies.Items.Count - 1
            Catch
                MessageBox.Show("There was an error when parsing proxies from the page.", "MultiCore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub btn_Scrape_Click(sender As Object, e As EventArgs) Handles btn_Scrape.Click
        Dim source As String = RTB_ScrapedProxies.Text

        Dim expression As New Regex("\b((\d{1,3}\.){3}\d{1,3})(?:.{1,}?)(\d{1,5})\b")
        Dim MatchCollection As MatchCollection = expression.Matches(source)

        For Each item As Match In MatchCollection
            Dim Unparsed As String = item.Groups(1).Value + ":" + item.Groups(3).Value
            LB_Scraped.Items.Add(Unparsed)
            Try
                If Not proxies.Contains(Unparsed) Then
                    proxies.Add(Unparsed)
                    If LB_Scraped.InvokeRequired = True Then
                        LB_Scraped.Invoke(Sub()
                                              LB_ParsedProxies.Items.Add(Unparsed)
                                          End Sub)
                    End If
                End If
            Catch ex As Exception
                'Do not put anything here, it will spam the output
            End Try
        Next
        LB_Scraped.TopIndex = LB_Scraped.Items.Count - 1
    End Sub

    Private Sub btn_Check_Click(sender As Object, e As EventArgs) Handles btn_Check.Click
        thread_status2 = True
        Dim threads As Integer = ThreadCOUNT2.Value
        ThreadPool.SetMinThreads(threads, threads)
        ThreadPool.SetMaxThreads(threads, threads)
        ServicePointManager.DefaultConnectionLimit = threads
        ServicePointManager.Expect100Continue = True
        For Each Proxy In proxies
            ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf CheckProxies), Proxy)
        Next
    End Sub
    Public Function CheckProxies(ByVal proxies2 As String) As String
        If Label_ContainsProxies.Text = ("") Then
            MessageBox.Show("Open a file first")
        End If
        If Label_ContainsProxies.Text <> "" Then
            Dim proxies As New List(Of String)
            Using sr As New StreamReader(Label_ContainsProxies.Text)
                While sr.Peek <> -1
                    proxies.Add(sr.ReadLine())
                End While
            End Using
            Dim myProxy As WebProxy

            For Each proxy As String In proxies
                Try
                    myProxy = New WebProxy(proxy)
                    Dim r As HttpWebRequest = WebRequest.Create("http://www.google.com/")
                    r.UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/29.0.1547.2 Safari/537.36"
                    r.Timeout = TimeOUT2.Value
                    r.Proxy = myProxy
                    Dim re As HttpWebResponse = r.GetResponse()
                    LB_Working.Items.Add("Responsive proxy: " & proxy)
                    responselabel.Text = "Response: " & LB_Working.Items.Count
                Catch ex As Exception
                    LB_NonWorking.Items.Add("Unresponsive proxy: " & proxy)
                    nonresponselabel.Text = "Unresponsive: " & LB_NonWorking.Items.Count
                End Try
            Next
            Name = "ProxyEXO // Responsive Proxies: " & LB_Working.Items.Count & " // Unresponsive Proxies: " & LB_NonWorking.Items.Count
            LB_Working.TopIndex = LB_Working.Items.Count - 1
            LB_NonWorking.TopIndex = LB_NonWorking.Items.Count - 1
        End If
        Return Nothing
    End Function

    Private Sub btn_Check2_Click(sender As Object, e As EventArgs) Handles btn_Check2.Click
        For Each link As String In links
            Try
                Dim WebRequest As HttpWebRequest = WebRequest.Create(link)
                WebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/29.0.1547.2 Safari/537.36"
                WebRequest.Timeout = TimeOUT.Value
                Dim re As HttpWebResponse = WebRequest.GetResponse()
                LB_Checked.Items.Add("Responsive: " & link)
                Update()
            Catch ex As Exception
                LB_Checked.Items.Add("Unresponsive: " & link)
                Update()
            End Try
        Next
        LB_Checked.TopIndex = LB_Checked.Items.Count - 1
    End Sub

    Private Sub btn_Export2_Click(sender As Object, e As EventArgs) Handles btn_Export2.Click
        If LB_Checked.Items.Count = (0) Then MessageBox.Show("Please check proxies first!.", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        Dim S_W As IO.StreamWriter
        Dim itms() As String = {LB_Checked.Items.ToString}
        Dim save As New SaveFileDialog With {.FileName = "Checked Links", .Filter = "Checked Links (*.txt)|*.txt|ALL Files (*.*)|*.*", .CheckPathExists = True}
        save.ShowDialog(Me)
        S_W = New StreamWriter(save.FileName)
        For it As Integer = 0 To LB_Checked.Items.Count - 1
            S_W.WriteLine(LB_Checked.Items.Item(it))
        Next
        S_W.Close()
        MessageBox.Show("Links checked and saved:: " & LB_Checked.Items.Count.ToString())
    End Sub

    Private Sub btn_Save2_Click(sender As Object, e As EventArgs) Handles btn_Save2.Click
        If LV_Gather.Items.Count = (0) Then MessageBox.Show("Please Scrape Proxies First.", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        Dim S_W As IO.StreamWriter
        Dim itms() As String = {LV_Gather.Items.ToString}
        Dim save As New SaveFileDialog With {.FileName = "Grabbed Proxies", .Filter = "Grabbed Proxies (*.txt)|*.txt|ALL Files (*.*)|*.*", .CheckPathExists = True}
        save.ShowDialog(Me)
        S_W = New StreamWriter(save.FileName)
        For it As Integer = 0 To LV_Gather.Items.Count - 1
            S_W.WriteLine(LV_Gather.Items.Item(it))
        Next
        S_W.Close()
        MessageBox.Show("Proxies Saved: " & LV_Gather.Items.Count.ToString())
    End Sub

    Private Sub ProxyImport_Click(sender As Object, e As EventArgs) Handles ProxyImport.Click
        Dim IMPORTproxies As New OpenFileDialog
        IMPORTproxies.RestoreDirectory = True
        IMPORTproxies.Multiselect = False
        IMPORTproxies.Filter = "txt files (*.txt)|*.txt"
        IMPORTproxies.FilterIndex = 1
        IMPORTproxies.ShowDialog()
        If (Not IMPORTproxies.FileName = Nothing) Then
            Dim proxies As New List(Of String)
            Dim TheFile As String = IMPORTproxies.FileName
            Dim reader As New StreamReader(TheFile)
            Do Until reader.EndOfStream
                LB_ImportedProxies.Items.Add(reader.ReadLine)
            Loop
            Using sr As New StreamReader(IMPORTproxies.FileName)
                While sr.Peek <> -1
                    proxies.Add(sr.ReadLine())
                    Label_ContainsProxies.Text = TheFile
                End While
            End Using
        End If
        'MessageBox.Show("Imported proxies: " & proxies.Count, "ProxyEXO", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function scraper(ByVal link As String) As String
        Try
            Dim source As String = (New WebClient).DownloadString(link)
            Dim expression As New Regex("\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\:[0-9]{1,5}\b")
            Dim mtac As MatchCollection = expression.Matches(source)
            For Each itemcode As Match In mtac
                If Not proxies.Contains(itemcode.ToString) Then
                    proxies.Add(itemcode.ToString)
                    If LV_Gather.InvokeRequired = True Then
                        LV_Gather.Invoke(Sub()
                                             LV_Gather.Items.Add(itemcode.ToString)
                                         End Sub)
                    End If
                End If
            Next
            LV_Gather.TopIndex = LV_Gather.Items.Count - 1
            Text = "| ProxyEXO | Proxies Scraped: " & LV_Gather.Items.Count
        Catch ex As Exception
            '
        End Try
        Return 0
    End Function

End Class
