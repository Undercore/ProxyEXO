<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LV_Gather = New System.Windows.Forms.ListBox()
        Me.btn_Save2 = New System.Windows.Forms.Button()
        Me.TC_Gather = New System.Windows.Forms.NumericUpDown()
        Me.btn_Gather = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_ClearParsedProxies = New System.Windows.Forms.Button()
        Me.btn_SaveParsedProxies = New System.Windows.Forms.Button()
        Me.btn_Parse = New System.Windows.Forms.Button()
        Me.TB_Website = New System.Windows.Forms.TextBox()
        Me.LB_ParsedProxies = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.LB_Scraped = New System.Windows.Forms.ListBox()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Scrape = New System.Windows.Forms.Button()
        Me.RTB_ScrapedProxies = New System.Windows.Forms.RichTextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.LB_NonWorking = New System.Windows.Forms.ListBox()
        Me.ProxyImport = New System.Windows.Forms.Button()
        Me.LB_Working = New System.Windows.Forms.ListBox()
        Me.nonresponselabel = New System.Windows.Forms.Label()
        Me.responselabel = New System.Windows.Forms.Label()
        Me.ThreadCOUNT2 = New System.Windows.Forms.NumericUpDown()
        Me.TimeOUT = New System.Windows.Forms.NumericUpDown()
        Me.btn_Export = New System.Windows.Forms.Button()
        Me.btn_Check = New System.Windows.Forms.Button()
        Me.LB_ImportedProxies = New System.Windows.Forms.ListBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TimeOUT2 = New System.Windows.Forms.NumericUpDown()
        Me.btn_Export2 = New System.Windows.Forms.Button()
        Me.btn_Check2 = New System.Windows.Forms.Button()
        Me.LB_Checked = New System.Windows.Forms.ListBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label_ContainsProxies = New System.Windows.Forms.Label()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TB_Changelog = New System.Windows.Forms.TextBox()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.TC_Gather, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.ThreadCOUNT2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeOUT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.TimeOUT2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Controls.Add(Me.TabPage3)
        Me.TabControl.Controls.Add(Me.TabPage4)
        Me.TabControl.Controls.Add(Me.TabPage6)
        Me.TabControl.Controls.Add(Me.TabPage5)
        Me.TabControl.Controls.Add(Me.TabPage7)
        Me.TabControl.Location = New System.Drawing.Point(12, 12)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1463, 644)
        Me.TabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LV_Gather)
        Me.TabPage1.Controls.Add(Me.btn_Save2)
        Me.TabPage1.Controls.Add(Me.TC_Gather)
        Me.TabPage1.Controls.Add(Me.btn_Gather)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1455, 611)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "> Gather <"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LV_Gather
        '
        Me.LV_Gather.FormattingEnabled = True
        Me.LV_Gather.ItemHeight = 20
        Me.LV_Gather.Location = New System.Drawing.Point(7, 6)
        Me.LV_Gather.Name = "LV_Gather"
        Me.LV_Gather.Size = New System.Drawing.Size(1442, 544)
        Me.LV_Gather.TabIndex = 4
        '
        'btn_Save2
        '
        Me.btn_Save2.Location = New System.Drawing.Point(1259, 568)
        Me.btn_Save2.Name = "btn_Save2"
        Me.btn_Save2.Size = New System.Drawing.Size(190, 36)
        Me.btn_Save2.TabIndex = 3
        Me.btn_Save2.Text = "Save"
        Me.btn_Save2.UseVisualStyleBackColor = True
        '
        'TC_Gather
        '
        Me.TC_Gather.Location = New System.Drawing.Point(204, 578)
        Me.TC_Gather.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.TC_Gather.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TC_Gather.Name = "TC_Gather"
        Me.TC_Gather.Size = New System.Drawing.Size(120, 26)
        Me.TC_Gather.TabIndex = 2
        Me.TC_Gather.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'btn_Gather
        '
        Me.btn_Gather.Location = New System.Drawing.Point(7, 569)
        Me.btn_Gather.Name = "btn_Gather"
        Me.btn_Gather.Size = New System.Drawing.Size(190, 36)
        Me.btn_Gather.TabIndex = 1
        Me.btn_Gather.Text = "Gather"
        Me.btn_Gather.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.btn_ClearParsedProxies)
        Me.TabPage2.Controls.Add(Me.btn_SaveParsedProxies)
        Me.TabPage2.Controls.Add(Me.btn_Parse)
        Me.TabPage2.Controls.Add(Me.TB_Website)
        Me.TabPage2.Controls.Add(Me.LB_ParsedProxies)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1455, 611)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "> Parser <"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter a page to parse proxies from."
        '
        'btn_ClearParsedProxies
        '
        Me.btn_ClearParsedProxies.Location = New System.Drawing.Point(6, 497)
        Me.btn_ClearParsedProxies.Name = "btn_ClearParsedProxies"
        Me.btn_ClearParsedProxies.Size = New System.Drawing.Size(257, 32)
        Me.btn_ClearParsedProxies.TabIndex = 4
        Me.btn_ClearParsedProxies.Text = "Clear"
        Me.btn_ClearParsedProxies.UseVisualStyleBackColor = True
        '
        'btn_SaveParsedProxies
        '
        Me.btn_SaveParsedProxies.Location = New System.Drawing.Point(6, 535)
        Me.btn_SaveParsedProxies.Name = "btn_SaveParsedProxies"
        Me.btn_SaveParsedProxies.Size = New System.Drawing.Size(257, 32)
        Me.btn_SaveParsedProxies.TabIndex = 3
        Me.btn_SaveParsedProxies.Text = "Save"
        Me.btn_SaveParsedProxies.UseVisualStyleBackColor = True
        '
        'btn_Parse
        '
        Me.btn_Parse.Location = New System.Drawing.Point(6, 573)
        Me.btn_Parse.Name = "btn_Parse"
        Me.btn_Parse.Size = New System.Drawing.Size(257, 32)
        Me.btn_Parse.TabIndex = 2
        Me.btn_Parse.Text = "Parse"
        Me.btn_Parse.UseVisualStyleBackColor = True
        '
        'TB_Website
        '
        Me.TB_Website.Location = New System.Drawing.Point(3, 22)
        Me.TB_Website.Name = "TB_Website"
        Me.TB_Website.Size = New System.Drawing.Size(260, 26)
        Me.TB_Website.TabIndex = 1
        Me.TB_Website.Text = "http://www.samair.ru/proxy/ip-port/123373151.html"
        '
        'LB_ParsedProxies
        '
        Me.LB_ParsedProxies.FormattingEnabled = True
        Me.LB_ParsedProxies.ItemHeight = 20
        Me.LB_ParsedProxies.Location = New System.Drawing.Point(269, 22)
        Me.LB_ParsedProxies.Name = "LB_ParsedProxies"
        Me.LB_ParsedProxies.Size = New System.Drawing.Size(1180, 584)
        Me.LB_ParsedProxies.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.LB_Scraped)
        Me.TabPage3.Controls.Add(Me.btn_Exit)
        Me.TabPage3.Controls.Add(Me.btn_Save)
        Me.TabPage3.Controls.Add(Me.btn_Clear)
        Me.TabPage3.Controls.Add(Me.btn_Scrape)
        Me.TabPage3.Controls.Add(Me.RTB_ScrapedProxies)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1455, 611)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "> Scraper <"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'LB_Scraped
        '
        Me.LB_Scraped.FormattingEnabled = True
        Me.LB_Scraped.ItemHeight = 20
        Me.LB_Scraped.Location = New System.Drawing.Point(7, 283)
        Me.LB_Scraped.Name = "LB_Scraped"
        Me.LB_Scraped.Size = New System.Drawing.Size(1442, 284)
        Me.LB_Scraped.TabIndex = 9
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(270, 573)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(257, 32)
        Me.btn_Exit.TabIndex = 8
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(1192, 573)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(257, 32)
        Me.btn_Save.TabIndex = 7
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(929, 573)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(257, 32)
        Me.btn_Clear.TabIndex = 6
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Scrape
        '
        Me.btn_Scrape.Location = New System.Drawing.Point(7, 573)
        Me.btn_Scrape.Name = "btn_Scrape"
        Me.btn_Scrape.Size = New System.Drawing.Size(257, 32)
        Me.btn_Scrape.TabIndex = 5
        Me.btn_Scrape.Text = "Scrape"
        Me.btn_Scrape.UseVisualStyleBackColor = True
        '
        'RTB_ScrapedProxies
        '
        Me.RTB_ScrapedProxies.Location = New System.Drawing.Point(7, 7)
        Me.RTB_ScrapedProxies.Name = "RTB_ScrapedProxies"
        Me.RTB_ScrapedProxies.Size = New System.Drawing.Size(1442, 270)
        Me.RTB_ScrapedProxies.TabIndex = 0
        Me.RTB_ScrapedProxies.Text = "Copy & Paste a file containing proxies here. " & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.LB_NonWorking)
        Me.TabPage4.Controls.Add(Me.ProxyImport)
        Me.TabPage4.Controls.Add(Me.LB_Working)
        Me.TabPage4.Controls.Add(Me.nonresponselabel)
        Me.TabPage4.Controls.Add(Me.responselabel)
        Me.TabPage4.Controls.Add(Me.ThreadCOUNT2)
        Me.TabPage4.Controls.Add(Me.TimeOUT)
        Me.TabPage4.Controls.Add(Me.btn_Export)
        Me.TabPage4.Controls.Add(Me.btn_Check)
        Me.TabPage4.Controls.Add(Me.LB_ImportedProxies)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1455, 611)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "> Checker <"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'LB_NonWorking
        '
        Me.LB_NonWorking.FormattingEnabled = True
        Me.LB_NonWorking.ItemHeight = 20
        Me.LB_NonWorking.Location = New System.Drawing.Point(705, 307)
        Me.LB_NonWorking.Name = "LB_NonWorking"
        Me.LB_NonWorking.Size = New System.Drawing.Size(722, 244)
        Me.LB_NonWorking.TabIndex = 17
        '
        'ProxyImport
        '
        Me.ProxyImport.Location = New System.Drawing.Point(929, 565)
        Me.ProxyImport.Name = "ProxyImport"
        Me.ProxyImport.Size = New System.Drawing.Size(257, 32)
        Me.ProxyImport.TabIndex = 16
        Me.ProxyImport.Text = "Import"
        Me.ProxyImport.UseVisualStyleBackColor = True
        '
        'LB_Working
        '
        Me.LB_Working.FormattingEnabled = True
        Me.LB_Working.ItemHeight = 20
        Me.LB_Working.Location = New System.Drawing.Point(705, 7)
        Me.LB_Working.Name = "LB_Working"
        Me.LB_Working.Size = New System.Drawing.Size(725, 284)
        Me.LB_Working.TabIndex = 15
        '
        'nonresponselabel
        '
        Me.nonresponselabel.AutoSize = True
        Me.nonresponselabel.Location = New System.Drawing.Point(566, 582)
        Me.nonresponselabel.Name = "nonresponselabel"
        Me.nonresponselabel.Size = New System.Drawing.Size(0, 20)
        Me.nonresponselabel.TabIndex = 11
        '
        'responselabel
        '
        Me.responselabel.AutoSize = True
        Me.responselabel.Location = New System.Drawing.Point(397, 582)
        Me.responselabel.Name = "responselabel"
        Me.responselabel.Size = New System.Drawing.Size(0, 20)
        Me.responselabel.TabIndex = 10
        '
        'ThreadCOUNT2
        '
        Me.ThreadCOUNT2.Location = New System.Drawing.Point(803, 571)
        Me.ThreadCOUNT2.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.ThreadCOUNT2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ThreadCOUNT2.Name = "ThreadCOUNT2"
        Me.ThreadCOUNT2.Size = New System.Drawing.Size(120, 26)
        Me.ThreadCOUNT2.TabIndex = 9
        Me.ThreadCOUNT2.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'TimeOUT
        '
        Me.TimeOUT.Location = New System.Drawing.Point(271, 571)
        Me.TimeOUT.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.TimeOUT.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TimeOUT.Name = "TimeOUT"
        Me.TimeOUT.Size = New System.Drawing.Size(120, 26)
        Me.TimeOUT.TabIndex = 8
        Me.TimeOUT.Value = New Decimal(New Integer() {5000, 0, 0, 0})
        '
        'btn_Export
        '
        Me.btn_Export.Location = New System.Drawing.Point(1192, 565)
        Me.btn_Export.Name = "btn_Export"
        Me.btn_Export.Size = New System.Drawing.Size(257, 32)
        Me.btn_Export.TabIndex = 7
        Me.btn_Export.Text = "Save"
        Me.btn_Export.UseVisualStyleBackColor = True
        '
        'btn_Check
        '
        Me.btn_Check.Location = New System.Drawing.Point(7, 567)
        Me.btn_Check.Name = "btn_Check"
        Me.btn_Check.Size = New System.Drawing.Size(257, 32)
        Me.btn_Check.TabIndex = 6
        Me.btn_Check.Text = "Check"
        Me.btn_Check.UseVisualStyleBackColor = True
        '
        'LB_ImportedProxies
        '
        Me.LB_ImportedProxies.FormattingEnabled = True
        Me.LB_ImportedProxies.ItemHeight = 20
        Me.LB_ImportedProxies.Location = New System.Drawing.Point(7, 7)
        Me.LB_ImportedProxies.Name = "LB_ImportedProxies"
        Me.LB_ImportedProxies.Size = New System.Drawing.Size(692, 544)
        Me.LB_ImportedProxies.TabIndex = 12
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Label2)
        Me.TabPage6.Controls.Add(Me.TimeOUT2)
        Me.TabPage6.Controls.Add(Me.btn_Export2)
        Me.TabPage6.Controls.Add(Me.btn_Check2)
        Me.TabPage6.Controls.Add(Me.LB_Checked)
        Me.TabPage6.Location = New System.Drawing.Point(4, 29)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1455, 611)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "> Link Checker <"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(397, 581)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Time-out"
        '
        'TimeOUT2
        '
        Me.TimeOUT2.Location = New System.Drawing.Point(271, 579)
        Me.TimeOUT2.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.TimeOUT2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TimeOUT2.Name = "TimeOUT2"
        Me.TimeOUT2.Size = New System.Drawing.Size(120, 26)
        Me.TimeOUT2.TabIndex = 9
        Me.TimeOUT2.Value = New Decimal(New Integer() {5000, 0, 0, 0})
        '
        'btn_Export2
        '
        Me.btn_Export2.Location = New System.Drawing.Point(1192, 573)
        Me.btn_Export2.Name = "btn_Export2"
        Me.btn_Export2.Size = New System.Drawing.Size(257, 32)
        Me.btn_Export2.TabIndex = 8
        Me.btn_Export2.Text = "Export"
        Me.btn_Export2.UseVisualStyleBackColor = True
        '
        'btn_Check2
        '
        Me.btn_Check2.Location = New System.Drawing.Point(7, 573)
        Me.btn_Check2.Name = "btn_Check2"
        Me.btn_Check2.Size = New System.Drawing.Size(257, 32)
        Me.btn_Check2.TabIndex = 7
        Me.btn_Check2.Text = "Check"
        Me.btn_Check2.UseVisualStyleBackColor = True
        '
        'LB_Checked
        '
        Me.LB_Checked.FormattingEnabled = True
        Me.LB_Checked.ItemHeight = 20
        Me.LB_Checked.Location = New System.Drawing.Point(7, 7)
        Me.LB_Checked.Name = "LB_Checked"
        Me.LB_Checked.Size = New System.Drawing.Size(1445, 564)
        Me.LB_Checked.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label_ContainsProxies)
        Me.TabPage5.Location = New System.Drawing.Point(4, 29)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1455, 611)
        Me.TabPage5.TabIndex = 6
        Me.TabPage5.Text = "> Updates <"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label_ContainsProxies
        '
        Me.Label_ContainsProxies.AutoSize = True
        Me.Label_ContainsProxies.Location = New System.Drawing.Point(6, 588)
        Me.Label_ContainsProxies.Name = "Label_ContainsProxies"
        Me.Label_ContainsProxies.Size = New System.Drawing.Size(0, 20)
        Me.Label_ContainsProxies.TabIndex = 1
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.TB_Changelog)
        Me.TabPage7.Location = New System.Drawing.Point(4, 29)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(1455, 611)
        Me.TabPage7.TabIndex = 7
        Me.TabPage7.Text = "> Changelog <"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'TB_Changelog
        '
        Me.TB_Changelog.Location = New System.Drawing.Point(7, 7)
        Me.TB_Changelog.Multiline = True
        Me.TB_Changelog.Name = "TB_Changelog"
        Me.TB_Changelog.Size = New System.Drawing.Size(1442, 598)
        Me.TB_Changelog.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1487, 668)
        Me.Controls.Add(Me.TabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "ProxyEXO"
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.TC_Gather, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.ThreadCOUNT2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeOUT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.TimeOUT2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents btn_Gather As Button
    Friend WithEvents TC_Gather As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_ClearParsedProxies As Button
    Friend WithEvents btn_SaveParsedProxies As Button
    Friend WithEvents btn_Parse As Button
    Friend WithEvents TB_Website As TextBox
    Friend WithEvents LB_ParsedProxies As ListBox
    Friend WithEvents btn_Exit As Button
    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_Clear As Button
    Friend WithEvents btn_Scrape As Button
    Friend WithEvents RTB_ScrapedProxies As RichTextBox
    Friend WithEvents LB_Scraped As ListBox
    Friend WithEvents TimeOUT As NumericUpDown
    Friend WithEvents btn_Export As Button
    Friend WithEvents btn_Check As Button
    Friend WithEvents ThreadCOUNT2 As NumericUpDown
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents btn_Export2 As Button
    Friend WithEvents btn_Check2 As Button
    Friend WithEvents LB_Checked As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TimeOUT2 As NumericUpDown
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TB_Changelog As TextBox
    Friend WithEvents nonresponselabel As Label
    Friend WithEvents responselabel As Label
    Friend WithEvents LB_ImportedProxies As ListBox
    Friend WithEvents btn_Save2 As Button
    Friend WithEvents LV_Gather As ListBox
    Friend WithEvents LB_Working As ListBox
    Friend WithEvents ProxyImport As Button
    Friend WithEvents Label_ContainsProxies As Label
    Friend WithEvents LB_NonWorking As ListBox
End Class
