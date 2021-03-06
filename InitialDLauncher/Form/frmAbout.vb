﻿Public Class frmAbout

    Dim htmlstring As String = "<center><h2>Developed by</h2>
I'm Not MentaL

<h2>Third Party</h2>
This application uses some parts which provided by third party.<br /><br />

Build with Microsoft Visual Studio 2015, <br />
ExtendedWebClient © ChrisD, <br />
Net Seal Theme © aeonhack<br />

<h2>Localization contributors</h2>
English - I'm Not MentaL<br />
中文 - I'm Not MentaL<br />
French - nucleaireland<br />

<h2>Community contributors</h2>
BearBo Ultra/ComputerNoob - Player Name, Legend Chapter & Chapter Level Offset,<br />
Lemon The Kid - Avatar Offset, Avatar Preview Pictures, Car Color, Car Engine/Rollbar Parts, Car Fullspec, Car Number Plate, Aura & etc, <br />
AkiiHoshi - Avatar Preview Pictures for InitialD 7, <br />
oPTToXenMe - Level Offset,<br />
Gammaガァマ - Car Name Offset,<br />
DSThanatos - Time Attack ID6 Offset,<br />
Turtle - Mileage Offset,<br />
I'm Not MentaL - Gender Offset, Time Attack ID7 Offset<br />

<h2>Thanks to</h2>
(alphabetically)<br />
Adrian Bloeß, Alexander Pfitzner (GTAInside), Black Tree Gaming Limited (Nexus Mods), Chanchai Boonsiri, Christine Guillory, Christopher Stewart (DoctorGTA), Daniel López Sánchez, Daniel Van der Meer, David Womacks, Насыров Адель, HCT Tuning, Heng Zhang, Jacky Ng, John Yang, Juiced Box Computers, Kenny, Kira Manell, Lei CHEN, Map1e, Marcelle Waul, Matthew Adair, Michael J Bradley (Digitalclips), obataku7, Paul Cybulska, Rob Campbell, Tan Hock, teknoparrot7, Timo Düsterhöft, William Argoud, Zhenjie Zou, Zigeng Ma, 鍇鍄 楊, 辰斐 丁, דור צרפתי
<br />
<h2>Special Thanks to</h2>
Reaver, Keb, Avail, NTAuthority<br />

<h2>Huge Thanks to</h2>
SEGA</center>"

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Translate()
        wbAbout.DocumentText = htmlstring
    End Sub

    Private Sub llblWebsite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblWebsite.LinkClicked
        Process.Start("https://www.imnotmental.com")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Translate()
        Select Case My.Settings.Language
            Case "English"
                lblVersion.Text = String.Format("Version: {0} Build: {1}", My.Application.Info.Version, frmEdit.buildDate)
                lblTitle.Text = "InitialD Arcade Stage Card Editor"
                Me.Text = "About"
                NsTheme1.Text = Me.Text
                btnDonate.Text = "Donate"
            Case "Chinese"
                lblVersion.Text = String.Format("版本: {0} 創建: {1}", My.Application.Info.Version, frmEdit.buildDate)
                lblTitle.Text = "頭文字D卡編輯器"
                Me.Text = "關於"
                NsTheme1.Text = Me.Text
                btnDonate.Text = "贊助"
            Case "French"
                lblVersion.Text = String.Format("Version: {0} Build: {1}", My.Application.Info.Version, frmEdit.buildDate)
                lblTitle.Text = "InitialD Arcade Stage Card Editor"
                Me.Text = "About"
                NsTheme1.Text = Me.Text
                btnDonate.Text = "Donate"
        End Select
    End Sub

    Private Sub btnDonate_Click(sender As Object, e As EventArgs) Handles btnDonate.Click
        Process.Start("https://www.paypal.me/IMNOTMENTAL")
    End Sub

    Private Sub frmAbout_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
        If Me.Location.Y <= -1 Then
            Me.Location = New Point(Me.Location.X, 0)
        End If
    End Sub
End Class