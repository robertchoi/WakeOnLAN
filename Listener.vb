﻿'    WakeOnLAN - Wake On LAN
'    Copyright (C) 2004-2019 Aquila Technology, LLC. <webmaster@aquilatech.com>
'
'    This file is part of WakeOnLAN.
'
'    WakeOnLAN is free software: you can redistribute it and/or modify
'    it under the terms of the GNU General Public License as published by
'    the Free Software Foundation, either version 3 of the License, or
'    (at your option) any later version.
'
'    WakeOnLAN is distributed in the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty of
'    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License for more details.
'
'    You should have received a copy of the GNU General Public License
'    along with WakeOnLAN.  If not, see <http://www.gnu.org/licenses/>.

Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.Linq
Imports Machines

Public Class Listener
    Private ReadOnly _gso As New StateObject
    Private Delegate Sub HitDelegate(ByVal so As StateObject, ByVal bytesRead As Integer, packetInfo As IPPacketInformation)
    Private ReadOnly _showHit As New HitDelegate(AddressOf Hit)

    Private Sub Listener_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Items.Clear()
        TextBoxDetails.Clear()
        TextBoxDetails.Font = New Font(FontFamily.GenericMonospace, TextBoxDetails.Font.Size)
    End Sub

    Private Sub Listener_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ReceiveMessages()
    End Sub

    Private Sub Listener_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _gso.Socket.Close()
    End Sub

    Private Sub ReceiveMessages()
        Try
            _gso.EndPoint = New IPEndPoint(IPAddress.Any, RegExTextBoxPort.Text)
            _gso.Socket = New Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)
            _gso.Socket.EnableBroadcast = True

            _gso.Socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, True)
            _gso.Socket.ExclusiveAddressUse = False

            _gso.Socket.Bind(_gso.EndPoint)
            _gso.Socket.BeginReceiveMessageFrom(_gso.Buffer, 0, _gso.Buffer.Length, SocketFlags.None, _gso.EndPoint, New AsyncCallback(AddressOf Async_Send_Receive), _gso)

        Catch ex As Exception
            ' Handle the HelpRequested event for the following message.
            AddHandler HelpRequested, AddressOf Listener_HelpRequested

            MessageBox.Show(ex.Message & "." & vbCrLf & "Click HELP for advice on fixing this.", "ReceiveMessages", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, 0, True)

            ' Remove the HelpRequested event handler to keep the event
            ' from being handled for other message boxes.
            RemoveHandler HelpRequested, AddressOf Listener_HelpRequested

        End Try
    End Sub

    Private Sub Async_Send_Receive(ByVal ar As IAsyncResult)
        Dim so As StateObject
        Dim bytesRead As Integer
        Dim flags As SocketFlags = SocketFlags.None
        Dim packetInfo As IPPacketInformation

        Try
            so = ar.AsyncState
            bytesRead = so.Socket.EndReceiveMessageFrom(ar, flags, so.EndPoint, packetInfo)
            Debug.WriteLine(Parse(so.Buffer, bytesRead))
            Hit(so, bytesRead, packetInfo)

            'Setup to receive the next packet
            so.Socket.BeginReceiveMessageFrom(so.Buffer, 0, so.Buffer.Length, SocketFlags.None, so.EndPoint, New AsyncCallback(AddressOf Async_Send_Receive), so)

        Catch eod As ObjectDisposedException
            Debug.WriteLine("Socket closed normally")

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Async_Send_Receive")

        End Try
    End Sub

    Private Sub ButtonSet_Click(sender As Object, e As EventArgs) Handles ButtonSet.Click
        If (_gso.Socket Is Nothing) Then Return
        _gso.Socket.Dispose()
        Application.DoEvents()
        Thread.Sleep(800)
        ReceiveMessages()
    End Sub

    Private Sub Hit(so As StateObject, bytesRead As Integer, packetInfo As IPPacketInformation)
        Dim mac As String
        Dim i As Integer

        Try
            If (ListView1.InvokeRequired) Then
                ListView1.Invoke(_showHit, so, bytesRead, packetInfo)
            Else
                Dim li As New ListViewItem
                ListView1.BeginUpdate()

                mac = Parse(so.Buffer, bytesRead)
                li.Text = mac
#If DISPLAY Then
                li.Text = li.Text.Substring(0, 9) & "00:00:00"
#End If

                li.ImageIndex = 0
                li.SubItems.Add(Now.ToShortTimeString)
                Dim hostName As String = (From m As Machine In Machines
                    Where (CompareMac(m.MAC, mac) = 0)
                    Select m.Name).FirstOrDefault()

                li.SubItems.Add(hostName)

                ' always insert it at the top
                ListView1.Items.Insert(0, li)

                ' the next 2 lines are to work around a bug
                ' in the listview sorting
                ListView1.Alignment = ListViewAlignment.Default
                ListView1.Alignment = ListViewAlignment.Top

                TextBoxDetails.AppendText(String.Format("{0} {1} {0}{2}", "---------------------", "Received Packet", Environment.NewLine))
                TextBoxDetails.AppendText(String.Format("{0,-20}{1}{2}", "Date: ", Now.ToLongDateString(), Environment.NewLine))
                TextBoxDetails.AppendText(String.Format("{0,-20}{1}{2}", "Time: ", Now.ToLongTimeString(), Environment.NewLine))
                TextBoxDetails.AppendText(String.Format("{0,-20}{1}{2}", "Source: ", so.EndPoint.ToString(), Environment.NewLine))
                TextBoxDetails.AppendText(String.Format("{0,-20}{1}{2}", "Destination: ", packetInfo.Address.ToString(), Environment.NewLine))
                TextBoxDetails.AppendText(String.Format("{0,-20}{1}{2}", "Length: ", bytesRead, Environment.NewLine))
                TextBoxDetails.AppendText(String.Format("{0,-20}{1}{2}", "Protocol: ", so.Socket.ProtocolType.ToString(), Environment.NewLine))
                TextBoxDetails.AppendText(String.Format("{0,-20}{1}{2}", "Port: ", RegExTextBoxPort.Text, Environment.NewLine))
                TextBoxDetails.AppendText(String.Format("{0,-20}{1}{2}", "Hostname: ", hostName, Environment.NewLine))

                TextBoxDetails.AppendText(String.Format("{0,-20}{1}{2}{2}", "MAC Address:", mac, Environment.NewLine))

                TextBoxDetails.AppendText(String.Format("Raw Data:{0}", Environment.NewLine))
                For row As Integer = 0 To (bytesRead / 16) - 1
                    TextBoxDetails.AppendText(String.Format("{0,-10}", ""))
                    For column As Integer = 0 To 15
                        i = column + row * 16
                        If i > bytesRead Then Exit For
                        TextBoxDetails.AppendText(String.Format("{0:X02} ", so.Buffer(i)))
                    Next
                    TextBoxDetails.AppendText(Environment.NewLine)
                    If i > bytesRead Then Exit For
                Next

                TextBoxDetails.AppendText(String.Format("{0}{0}", Environment.NewLine))
                ListView1.EndUpdate()

                If My.Settings.Sound Then
                    My.Computer.Audio.Play(My.Resources.blip, AudioPlayMode.Background)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "hit")

        End Try
    End Sub

    Private Function Parse(ByVal b As Byte(), l As Integer) As String
        Dim i As Int16
        Dim s As String = ""

        Try
            If l < 102 Then Return String.Empty

            For i = 0 To 5
                If b(i) <> 255 Then Return String.Empty
            Next

            For i = 1 To 15
                For j As Int16 = 0 To 5
                    If b(6 + j) <> b(6 + j + (i * 6)) Then
                        Return String.Empty
                    End If
                Next
            Next

            For i = 0 To 5
                If b(6 + i) < 16 Then
                    s &= "0"
                End If

                s &= Hex(b(6 + i))
                If i < 5 Then s &= ":"
            Next

            Return s

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Parse")
            Return String.Empty

        End Try
    End Function

    Private Sub Button_clear_Click(sender As Object, e As EventArgs) Handles Button_clear.Click
        ListView1.Items.Clear()
        TextBoxDetails.Clear()
    End Sub

    Private Sub Listener_HelpRequested(sender As Object, hlpevent As HelpEventArgs)
        ShowHelp(Me, "troubleshooting\listener.html")
    End Sub

    Private Sub RegExTextBoxPort_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RegExTextBoxPort.Validating
        If RegExTextBoxPort.IsValid() Then
            ErrorProvider1.SetError(sender, "")
        Else
            ErrorProvider1.SetError(sender, "Invalid Port")
        End If
    End Sub

End Class

Friend Class StateObject
    Public Buffer(127) As Byte
    Public Socket As Socket
    Public EndPoint As EndPoint
End Class