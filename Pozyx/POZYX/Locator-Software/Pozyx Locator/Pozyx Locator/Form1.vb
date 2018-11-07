''  hhttp://www.martyncurrey.com/arduino-and-visual-basic-part-1-receiving-data-from-the-arduino/'

Imports System
Imports System.IO.Ports


Public Class Form1
    Dim receivedData As String = "" 'Com recievd data variable
    Dim comPORT As String   ' com port poition
    Dim dtposition As New DataTable
    Dim Tag1 As String = "0x6972"
    Dim Tag2 As String = "0x696d"
    Dim Tag3 As String = "0x6e2b"
    Dim Tag4 As String = "0x690c"
    Dim p1 As New System.Drawing.Pen(Color.Red, 4)
    Dim p2 As New System.Drawing.Pen(Color.Blue, 4)
    Dim p3 As New System.Drawing.Pen(Color.Green, 4)
    Dim p4 As New System.Drawing.Pen(Color.Yellow, 4)
    Dim X1, X2, X3, X4, Y1, Y2, Y3, Y4 As Integer
    Dim g As System.Drawing.Graphics
    Dim TXData As String = ""
    Dim slno As Integer = 0
    Dim dist(4)
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        comPORT = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            COM_port.Items.Add(sp)
        Next
        ' Limits user interaction
        Me.chk_pos.Enabled = False
        Me.chkrange.Enabled = False
        Me.Tab.Enabled = False
        Me.Plot.Enabled = False
        Me.BTN_Data.Enabled = False
    End Sub


    Private Sub COM_port_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COM_port.SelectedIndexChanged
        If (COM_port.SelectedItem <> "") Then
            comPORT = COM_port.SelectedItem
            Me.chk_pos.Enabled = True
            Me.chkrange.Enabled = True
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        receivedData = ReceiveSerialData()
        If Me.chk_pos.Checked = True Then
            SerialMonitor.AppendText(receivedData + "      " + Convert.ToString(Format(Now, "hh:mm:ss tt")) + ";" & vbNewLine)
            If Me.AutoScroll.Checked = True Then
                SerialMonitor.ScrollToCaret()
            End If
            plotting(receivedData)
        ElseIf Me.chkrange.Checked = True Then
            dist = Split(receivedData, ";")
            Dim space = "                               "
            Try
                richrange.AppendText("   " + Convert.ToString(slno) + space + dist(0) + space + dist(1) + space + dist(2) + space + dist(3) + space + Convert.ToString(Format(Now, "hh:mm:ss tt")) + ";" & vbNewLine)
                slno = slno + 1
                If Me.chk_auto2.Checked = True Then
                    richrange.ScrollToCaret()
                End If
            Catch
            End Try
        End If

    End Sub
    Function plotting(receivedData As String)
        Try
            Dim ID = Split(receivedData, ";")
            If (ID.Length > 1) Then
                Dim Tagx = ID(0).Split("x") 'Split(ID(0), "x")
                Dim i As String = "0x" + Tagx(1)
                PictureBox1.Refresh()
                g = PictureBox1.CreateGraphics
                Dim X As Integer = (Int(ID(1)) / 10)
                Dim Y As Integer = PictureBox1.Size.Height - (Int(ID(2)) / 10)
                ' Y1 = Y2 = Y3 = Y4 = X1 = X2 = X3 = X4 = -10
                If String.Compare(i, Tag1) = 1 Then
                    X1 = X
                    Y1 = Y
                ElseIf String.Compare(i, Tag2) = 1 Then
                    X2 = X
                    Y2 = Y

                ElseIf String.Compare(i, Tag3) = 1 Then
                    X3 = X
                    Y3 = Y
                ElseIf String.Compare(i, Tag4) = 1 Then
                    X4 = X
                    Y4 = Y
                End If
                g.DrawEllipse(p1, X1, Y1, 5, 5)
                g.DrawEllipse(p2, X2, Y2, 5, 5)
                g.DrawEllipse(p3, X3, Y3, 5, 5)
                g.DrawEllipse(p4, X4, Y4, 5, 5)

                Label1.Height = ID(3) / 2500 * 516
                Label1.Top = 516 - Label1.Height + 14
            End If
        Catch ex As Exception

        End Try
    End Function
    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try

    End Function


    Private Sub SaveDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveDataToolStripMenuItem.Click
        Dim myStream As System.IO.Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = System.IO.Directory.GetCurrentDirectory()
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = openFileDialog1.OpenFile()
                Dim objReader As New System.IO.StreamReader(myStream)
                Dim data = objReader.ReadToEnd()
                If (myStream IsNot Nothing) Then
                    If chk_pos.Checked = True Then
                        SerialMonitor.Text = data
                    ElseIf chkrange.Checked = True Then
                        richrange.Text = data
                    End If
                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
    End Sub



    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If (txtAnch1.Text.Contains("_") Or txtAnch2.Text.Contains("_") Or txtAnch3.Text.Contains("_") Or txtAnch4.Text.Contains("_")) Then
            MessageBox.Show(" Please Enter all Anchor coordinates")
            Exit Sub
        End If
        Me.btnCheck.Text = "Anchor Fixed"
        Me.btnCheck.ForeColor = Color.Ivory
        Me.btnCheck.BackColor = Color.LightGreen
        Me.btnCheck.Enabled = False
        Me.txtAnch1.Enabled = False
        Me.txtAnch2.Enabled = False
        Me.txtAnch3.Enabled = False
        Me.txtAnch4.Enabled = False
        'End If
        TXData = TXData + Strings.Left(txtAnch1.Text, 4) + ";" + Strings.Left(txtAnch2.Text, 4) + ";" + Strings.Left(txtAnch3.Text, 4) + ";" + Strings.Left(txtAnch4.Text, 4) + ";" '' x coordinates
        TXData = TXData + Strings.Right(Strings.Left(txtAnch1.Text, 8), 4) + ";" + Strings.Right(Strings.Left(txtAnch2.Text, 8), 4) + ";" + Strings.Right(Strings.Left(txtAnch3.Text, 8), 4) + ";" + Strings.Right(Strings.Left(txtAnch4.Text, 8), 4) + ";" '' y coordinates
        TXData = TXData + Strings.Right(txtAnch1.Text, 4) + ";" + Strings.Right(txtAnch2.Text, 4) + ";" + Strings.Right(txtAnch3.Text, 4) + ";" + Strings.Right(txtAnch4.Text, 4) + ";" '' z coordinates
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub chk_pos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_pos.CheckedChanged
        If Me.chk_pos.Checked = True Then
            Me.chkrange.Checked = False
            Me.Tab.SelectTab(0)
            Me.Tab.Enabled = True
            TXData = ";0;"
            Me.Plot.Enabled = True
            Me.Plot.Text = "Dis-Connect"
            Plot_Click(sender, e)
        End If
    End Sub

    Private Sub chkrange_CheckedChanged(sender As Object, e As EventArgs) Handles chkrange.CheckedChanged
        If Me.chkrange.Checked = True Then
            Me.chk_pos.Checked = False
            Me.Tab.SelectTab(1)
            Me.Tab.Enabled = True
            TXData = ";1;"
            Me.Plot.Enabled = True
            Me.Plot.Text = "Dis-Connect"
            Plot_Click(sender, e)
        End If
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        Application.Restart()
    End Sub

   
    Private Sub Detect_Click(sender As Object, e As EventArgs) Handles Detect.Click
        COM_port.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            COM_port.Items.Add(sp)
        Next
        Try
            Me.COM_port.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear1_Click(sender As Object, e As EventArgs) Handles btnClear1.Click
        Me.SerialMonitor.Text = ""
    End Sub

    Private Sub BTN_Data_Click(sender As Object, e As EventArgs) Handles BTN_Data.Click
        Dim path As String = System.IO.Directory.GetCurrentDirectory()
        Dim filein As Object
        filein = InputBox("Enter filename suffix?", "Getting filename input", "")
        Dim filename = filein + "-" + Convert.ToString(Format(Now, "hhmmsstt"))
        Dim objWriter As New System.IO.StreamWriter(path + "\" + filename + ".txt", True)
        objWriter.WriteLine(richrange.Text)
        objWriter.WriteLine(SerialMonitor.Text)
        objWriter.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim path As String = System.IO.Directory.GetCurrentDirectory()
        Dim filein As Object
        filein = InputBox("Enter filename suffix?", "Getting filename input", "")
        Dim filename = filein + "-" + Convert.ToString(Format(Now, "hhmmsstt"))
        Dim objWriter As New System.IO.StreamWriter(path + "\" + filename + ".txt", True)
        objWriter.WriteLine(richrange.Text)
        objWriter.WriteLine(SerialMonitor.Text)
        objWriter.Close()
    End Sub

   

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show(" Version: 1.0" & vbNewLine & "Author(s): Nilankan Chaudhuri" & vbNewLine & "Healthcare Ergonomics Analytics Laboratory", "About")
    End Sub

    Private Sub Plot_Click(sender As Object, e As EventArgs) Handles Plot.Click
        If TXData Is Nothing Then
            MessageBox.Show("Select Process First")
        Else
            Try
                If (Plot.Text = "Connect") Then
                    If Me.btnCheck.Text = "Check" And Me.chk_pos.Checked = True Then
                        MessageBox.Show("Enter Anchor positions first")
                        Exit Sub
                    End If
                    SerialPort1.Close()
                    SerialPort1.PortName = comPORT
                    SerialPort1.BaudRate = 115200
                    SerialPort1.DataBits = 8
                    SerialPort1.Parity = Parity.None
                    SerialPort1.StopBits = StopBits.One
                    SerialPort1.Handshake = Handshake.None
                    SerialPort1.Encoding = System.Text.Encoding.Default 'very important!
                    SerialPort1.ReadTimeout = 10000

                    SerialPort1.Open()
                    Plot.Text = "Dis-connect"
                    SerialPort1.Write(TXData)
                    Timer1.Enabled = True
                    Me.BTN_Data.Enabled = True
                Else
                    SerialPort1.Close()
                    Plot.Text = "Connect"
                    Timer1.Enabled = False
                    Me.BTN_Data.Enabled = False
                End If
            Catch
                MessageBox.Show(" Error Reading Port. Select Correct Port")
                Plot.Text = "Connect"
                Timer1.Enabled = False
            End Try

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        richrange.Text = ""
    End Sub
End Class
