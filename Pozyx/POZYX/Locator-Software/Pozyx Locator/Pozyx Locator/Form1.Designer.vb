<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Detect = New System.Windows.Forms.Button()
        Me.SerialMonitor = New System.Windows.Forms.RichTextBox()
        Me.COM_port = New System.Windows.Forms.ComboBox()
        Me.Plot = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.locator_chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.AutoScroll = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.Tab_Position = New System.Windows.Forms.TabPage()
        Me.btnClear1 = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAnch4 = New System.Windows.Forms.MaskedTextBox()
        Me.txtAnch3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAnch2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAnch1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tab_Location = New System.Windows.Forms.TabPage()
        Me.chk_auto2 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.richrange = New System.Windows.Forms.RichTextBox()
        Me.BTN_Data = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.chk_pos = New System.Windows.Forms.RadioButton()
        Me.chkrange = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.locator_chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab.SuspendLayout()
        Me.Tab_Position.SuspendLayout()
        Me.Tab_Location.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Detect
        '
        Me.Detect.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detect.Location = New System.Drawing.Point(5, 51)
        Me.Detect.Name = "Detect"
        Me.Detect.Size = New System.Drawing.Size(134, 24)
        Me.Detect.TabIndex = 0
        Me.Detect.Text = "Detect Ports"
        Me.Detect.UseVisualStyleBackColor = True
        '
        'SerialMonitor
        '
        Me.SerialMonitor.BackColor = System.Drawing.Color.White
        Me.SerialMonitor.Location = New System.Drawing.Point(7, 82)
        Me.SerialMonitor.Name = "SerialMonitor"
        Me.SerialMonitor.ReadOnly = True
        Me.SerialMonitor.Size = New System.Drawing.Size(517, 438)
        Me.SerialMonitor.TabIndex = 1
        Me.SerialMonitor.Text = ""
        '
        'COM_port
        '
        Me.COM_port.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.COM_port.FormattingEnabled = True
        Me.COM_port.Location = New System.Drawing.Point(5, 27)
        Me.COM_port.Name = "COM_port"
        Me.COM_port.Size = New System.Drawing.Size(134, 21)
        Me.COM_port.Sorted = True
        Me.COM_port.TabIndex = 3
        '
        'Plot
        '
        Me.Plot.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Plot.Location = New System.Drawing.Point(368, 28)
        Me.Plot.Name = "Plot"
        Me.Plot.Size = New System.Drawing.Size(416, 47)
        Me.Plot.TabIndex = 4
        Me.Plot.Text = "Connect"
        Me.Plot.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'locator_chart
        '
        ChartArea1.Name = "ChartArea1"
        Me.locator_chart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.locator_chart.Legends.Add(Legend1)
        Me.locator_chart.Location = New System.Drawing.Point(532, 630)
        Me.locator_chart.Name = "locator_chart"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.YValuesPerPoint = 2
        Me.locator_chart.Series.Add(Series1)
        Me.locator_chart.Size = New System.Drawing.Size(10, 10)
        Me.locator_chart.TabIndex = 5
        Me.locator_chart.Text = "Chart1"
        '
        'AutoScroll
        '
        Me.AutoScroll.AutoSize = True
        Me.AutoScroll.Location = New System.Drawing.Point(6, 528)
        Me.AutoScroll.Name = "AutoScroll"
        Me.AutoScroll.Size = New System.Drawing.Size(74, 17)
        Me.AutoScroll.TabIndex = 7
        Me.AutoScroll.Text = "AutoScroll"
        Me.AutoScroll.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.BackgroundImage = Global.Pozyx_Locator.My.Resources.Resources.grid2
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(530, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(524, 525)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1135, 88)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(30, 520)
        Me.TextBox1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Label1.Location = New System.Drawing.Point(1137, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 516)
        Me.Label1.TabIndex = 9
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.Tab_Position)
        Me.Tab.Controls.Add(Me.Tab_Location)
        Me.Tab.Location = New System.Drawing.Point(5, 82)
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(1065, 574)
        Me.Tab.TabIndex = 10
        '
        'Tab_Position
        '
        Me.Tab_Position.Controls.Add(Me.btnClear1)
        Me.Tab_Position.Controls.Add(Me.btnCheck)
        Me.Tab_Position.Controls.Add(Me.Label13)
        Me.Tab_Position.Controls.Add(Me.Label12)
        Me.Tab_Position.Controls.Add(Me.Label11)
        Me.Tab_Position.Controls.Add(Me.txtAnch4)
        Me.Tab_Position.Controls.Add(Me.txtAnch3)
        Me.Tab_Position.Controls.Add(Me.Label10)
        Me.Tab_Position.Controls.Add(Me.txtAnch2)
        Me.Tab_Position.Controls.Add(Me.Label9)
        Me.Tab_Position.Controls.Add(Me.txtAnch1)
        Me.Tab_Position.Controls.Add(Me.Label8)
        Me.Tab_Position.Controls.Add(Me.PictureBox1)
        Me.Tab_Position.Controls.Add(Me.Label1)
        Me.Tab_Position.Controls.Add(Me.SerialMonitor)
        Me.Tab_Position.Controls.Add(Me.TextBox1)
        Me.Tab_Position.Controls.Add(Me.AutoScroll)
        Me.Tab_Position.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Position.Name = "Tab_Position"
        Me.Tab_Position.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Position.Size = New System.Drawing.Size(1057, 548)
        Me.Tab_Position.TabIndex = 0
        Me.Tab_Position.Text = "Tag Position"
        Me.Tab_Position.UseVisualStyleBackColor = True
        '
        'btnClear1
        '
        Me.btnClear1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear1.Location = New System.Drawing.Point(454, 522)
        Me.btnClear1.Name = "btnClear1"
        Me.btnClear1.Size = New System.Drawing.Size(70, 23)
        Me.btnClear1.TabIndex = 22
        Me.btnClear1.Text = "Clear"
        Me.btnClear1.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.SystemColors.Info
        Me.btnCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCheck.Location = New System.Drawing.Point(447, 18)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(77, 57)
        Me.btnCheck.TabIndex = 21
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(294, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(139, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "x (mm)       y (mm)       z (mm)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(230, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Tag = "0x6925"
        Me.Label12.Text = "Anchor 4"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(230, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Tag = "0x6e77"
        Me.Label11.Text = "Anchor 3"
        '
        'txtAnch4
        '
        Me.txtAnch4.Location = New System.Drawing.Point(286, 56)
        Me.txtAnch4.Mask = "   0000   ;   0000   ;   0000   "
        Me.txtAnch4.Name = "txtAnch4"
        Me.txtAnch4.Size = New System.Drawing.Size(147, 20)
        Me.txtAnch4.TabIndex = 17
        Me.txtAnch4.Tag = "0x6925"
        Me.txtAnch4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAnch4.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'txtAnch3
        '
        Me.txtAnch3.Location = New System.Drawing.Point(286, 30)
        Me.txtAnch3.Mask = "   0000   ;   0000   ;   0000   "
        Me.txtAnch3.Name = "txtAnch3"
        Me.txtAnch3.Size = New System.Drawing.Size(147, 20)
        Me.txtAnch3.TabIndex = 16
        Me.txtAnch3.Tag = "0x6e77"
        Me.txtAnch3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAnch3.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Tag = "0x6e74"
        Me.Label10.Text = "Anchor 2"
        '
        'txtAnch2
        '
        Me.txtAnch2.Location = New System.Drawing.Point(65, 53)
        Me.txtAnch2.Mask = "   0000   ;   0000   ;   0000   "
        Me.txtAnch2.Name = "txtAnch2"
        Me.txtAnch2.Size = New System.Drawing.Size(147, 20)
        Me.txtAnch2.TabIndex = 14
        Me.txtAnch2.Tag = "0x6e74"
        Me.txtAnch2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAnch2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Tag = "0x6e67"
        Me.Label9.Text = "Anchor 1"
        '
        'txtAnch1
        '
        Me.txtAnch1.Location = New System.Drawing.Point(65, 29)
        Me.txtAnch1.Mask = "   0000   ;   0000   ;   0000   "
        Me.txtAnch1.Name = "txtAnch1"
        Me.txtAnch1.Size = New System.Drawing.Size(147, 20)
        Me.txtAnch1.TabIndex = 11
        Me.txtAnch1.Tag = "0x6e67"
        Me.txtAnch1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAnch1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(73, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "x (mm)       y (mm)       z (mm)"
        '
        'Tab_Location
        '
        Me.Tab_Location.AutoScroll = True
        Me.Tab_Location.Controls.Add(Me.Button1)
        Me.Tab_Location.Controls.Add(Me.chk_auto2)
        Me.Tab_Location.Controls.Add(Me.Label7)
        Me.Tab_Location.Controls.Add(Me.Label6)
        Me.Tab_Location.Controls.Add(Me.Label5)
        Me.Tab_Location.Controls.Add(Me.Label4)
        Me.Tab_Location.Controls.Add(Me.Label3)
        Me.Tab_Location.Controls.Add(Me.Label2)
        Me.Tab_Location.Controls.Add(Me.ShapeContainer1)
        Me.Tab_Location.Controls.Add(Me.richrange)
        Me.Tab_Location.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Location.Name = "Tab_Location"
        Me.Tab_Location.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Location.Size = New System.Drawing.Size(1057, 548)
        Me.Tab_Location.TabIndex = 1
        Me.Tab_Location.Text = "Location"
        Me.Tab_Location.UseVisualStyleBackColor = True
        '
        'chk_auto2
        '
        Me.chk_auto2.AutoSize = True
        Me.chk_auto2.Location = New System.Drawing.Point(11, 525)
        Me.chk_auto2.Name = "chk_auto2"
        Me.chk_auto2.Size = New System.Drawing.Size(77, 17)
        Me.chk_auto2.TabIndex = 9
        Me.chk_auto2.Text = "Auto Scroll"
        Me.chk_auto2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 28)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Sl. No."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(843, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 28)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TIMESTAMP"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(628, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "TAG4 :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(450, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TAG3:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(274, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TAG2:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TAG1:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1051, 542)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 798
        Me.LineShape5.X2 = 798
        Me.LineShape5.Y1 = 36
        Me.LineShape5.Y2 = 518
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 626
        Me.LineShape4.X2 = 626
        Me.LineShape4.Y1 = 36
        Me.LineShape4.Y2 = 518
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.Tag = "7"
        Me.LineShape3.X1 = 440
        Me.LineShape3.X2 = 440
        Me.LineShape3.Y1 = 36
        Me.LineShape3.Y2 = 518
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 258
        Me.LineShape2.X2 = 258
        Me.LineShape2.Y1 = 36
        Me.LineShape2.Y2 = 518
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 74
        Me.LineShape1.X2 = 74
        Me.LineShape1.Y1 = 36
        Me.LineShape1.Y2 = 518
        '
        'richrange
        '
        Me.richrange.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.richrange.Location = New System.Drawing.Point(11, 38)
        Me.richrange.Name = "richrange"
        Me.richrange.Size = New System.Drawing.Size(1040, 482)
        Me.richrange.TabIndex = 7
        Me.richrange.Text = ""
        '
        'BTN_Data
        '
        Me.BTN_Data.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Data.Location = New System.Drawing.Point(790, 29)
        Me.BTN_Data.Name = "BTN_Data"
        Me.BTN_Data.Size = New System.Drawing.Size(280, 47)
        Me.BTN_Data.TabIndex = 11
        Me.BTN_Data.Text = "Export Data"
        Me.BTN_Data.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1073, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveDataToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.MenuToolStripMenuItem.Text = "File"
        '
        'SaveDataToolStripMenuItem
        '
        Me.SaveDataToolStripMenuItem.Name = "SaveDataToolStripMenuItem"
        Me.SaveDataToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.SaveDataToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SaveDataToolStripMenuItem.Text = "&Open..."
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ResetToolStripMenuItem.Text = "Re&set"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'chk_pos
        '
        Me.chk_pos.AutoSize = True
        Me.chk_pos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_pos.Location = New System.Drawing.Point(145, 52)
        Me.chk_pos.Name = "chk_pos"
        Me.chk_pos.Size = New System.Drawing.Size(217, 24)
        Me.chk_pos.TabIndex = 13
        Me.chk_pos.TabStop = True
        Me.chk_pos.Text = "Positioning (Anchor +Tags)"
        Me.chk_pos.UseVisualStyleBackColor = True
        '
        'chkrange
        '
        Me.chkrange.AutoSize = True
        Me.chkrange.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkrange.Location = New System.Drawing.Point(145, 27)
        Me.chkrange.Name = "chkrange"
        Me.chkrange.Size = New System.Drawing.Size(171, 24)
        Me.chkrange.TabIndex = 14
        Me.chkrange.TabStop = True
        Me.chkrange.Text = "Ranging (Tags Only)"
        Me.chkrange.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(981, 522)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1073, 681)
        Me.Controls.Add(Me.chkrange)
        Me.Controls.Add(Me.chk_pos)
        Me.Controls.Add(Me.BTN_Data)
        Me.Controls.Add(Me.Tab)
        Me.Controls.Add(Me.locator_chart)
        Me.Controls.Add(Me.Plot)
        Me.Controls.Add(Me.COM_port)
        Me.Controls.Add(Me.Detect)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pozyx Visualizer"
        CType(Me.locator_chart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab.ResumeLayout(False)
        Me.Tab_Position.ResumeLayout(False)
        Me.Tab_Position.PerformLayout()
        Me.Tab_Location.ResumeLayout(False)
        Me.Tab_Location.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Detect As System.Windows.Forms.Button
    Friend WithEvents COM_port As System.Windows.Forms.ComboBox
    Friend WithEvents Plot As System.Windows.Forms.Button
    Private WithEvents SerialMonitor As System.Windows.Forms.RichTextBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents locator_chart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents AutoScroll As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tab As System.Windows.Forms.TabControl
    Friend WithEvents Tab_Position As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Location As System.Windows.Forms.TabPage
    Friend WithEvents BTN_Data As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAnch1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAnch4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtAnch3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAnch2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chk_pos As System.Windows.Forms.RadioButton
    Friend WithEvents chkrange As System.Windows.Forms.RadioButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents richrange As System.Windows.Forms.RichTextBox
    Friend WithEvents chk_auto2 As System.Windows.Forms.CheckBox
    Friend WithEvents btnClear1 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
