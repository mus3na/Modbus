<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        RichTextBox1 = New RichTextBox()
        Button1 = New Button()
        TextBox5 = New TextBox()
        Label10 = New Label()
        Label12 = New Label()
        ComboBox1 = New ComboBox()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox4 = New ComboBox()
        ComboBox5 = New ComboBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        TextBox6 = New TextBox()
        Label13 = New Label()
        Label18 = New Label()
        ComboBox6 = New ComboBox()
        RichTextBox2 = New RichTextBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 20)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 25)
        Label1.TabIndex = 0
        Label1.Text = "IP Address:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 61)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 25)
        Label2.TabIndex = 0
        Label2.Text = "TCP Port:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 20)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 25)
        Label3.TabIndex = 0
        Label3.Text = "Device ID:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 101)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 25)
        Label4.TabIndex = 0
        Label4.Text = "Address:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(200, 17)
        TextBox1.Margin = New Padding(4, 5, 4, 5)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 1
        TextBox1.Text = "127.0.0.1"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(200, 58)
        TextBox2.Margin = New Padding(4, 5, 4, 5)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(50, 31)
        TextBox2.TabIndex = 2
        TextBox2.Text = "502"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(200, 17)
        TextBox3.Margin = New Padding(4, 5, 4, 5)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(50, 31)
        TextBox3.TabIndex = 1
        TextBox3.Text = "3"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(200, 95)
        TextBox4.Margin = New Padding(4, 5, 4, 5)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(70, 31)
        TextBox4.TabIndex = 3
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Enabled = False
        RichTextBox1.Location = New Point(517, 20)
        RichTextBox1.Margin = New Padding(4, 5, 4, 5)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(405, 370)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = ""
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(769, 610)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 40)
        Button1.TabIndex = 4
        Button1.Text = "Read"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(200, 17)
        TextBox5.Margin = New Padding(4, 5, 4, 5)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(70, 31)
        TextBox5.TabIndex = 1
        TextBox5.Text = "1000"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(20, 20)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(128, 25)
        Label10.TabIndex = 0
        Label10.Text = "Time Out (ms):"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(20, 59)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(83, 25)
        Label12.TabIndex = 0
        Label12.Text = "Protocol:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Enabled = False
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Modbus TCP", "Modbus RTU over TCP/IP", "Modbus RTU"})
        ComboBox1.Location = New Point(200, 56)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(240, 33)
        ComboBox1.TabIndex = 2
        ComboBox1.Text = "Modbus TCP"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(20, 103)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(48, 25)
        Label14.TabIndex = 0
        Label14.Text = "Port:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(20, 144)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(66, 25)
        Label15.TabIndex = 0
        Label15.Text = "Bitrate:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(20, 185)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(59, 25)
        Label16.TabIndex = 0
        Label16.Text = "Parity:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(20, 226)
        Label17.Margin = New Padding(4, 0, 4, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(87, 25)
        Label17.TabIndex = 0
        Label17.Text = "Stop bits:"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Enabled = False
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9"})
        ComboBox2.Location = New Point(200, 100)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(100, 33)
        ComboBox2.TabIndex = 3
        ComboBox2.Text = "COM1"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Enabled = False
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"})
        ComboBox3.Location = New Point(200, 141)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(100, 33)
        ComboBox3.TabIndex = 4
        ComboBox3.Text = "115200"
        ' 
        ' ComboBox4
        ' 
        ComboBox4.Enabled = False
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"NONE", "ODD", "EVEN", "MARK", "SPACE"})
        ComboBox4.Location = New Point(200, 182)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(100, 33)
        ComboBox4.TabIndex = 5
        ComboBox4.Text = "NONE"
        ' 
        ' ComboBox5
        ' 
        ComboBox5.Enabled = False
        ComboBox5.FormattingEnabled = True
        ComboBox5.Items.AddRange(New Object() {"1", "2"})
        ComboBox5.Location = New Point(200, 223)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(100, 33)
        ComboBox5.TabIndex = 6
        ComboBox5.Text = "1"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Location = New Point(20, 20)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(472, 110)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(TextBox5)
        Panel2.Controls.Add(ComboBox5)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(ComboBox4)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(ComboBox3)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(ComboBox2)
        Panel2.Controls.Add(Label15)
        Panel2.Controls.Add(Label17)
        Panel2.Controls.Add(Label16)
        Panel2.Location = New Point(20, 150)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(472, 280)
        Panel2.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(TextBox6)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(Label18)
        Panel3.Controls.Add(ComboBox6)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(TextBox3)
        Panel3.Controls.Add(TextBox4)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(20, 450)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(472, 200)
        Panel3.TabIndex = 3
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(200, 136)
        TextBox6.Margin = New Padding(4, 5, 4, 5)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(70, 31)
        TextBox6.TabIndex = 4
        TextBox6.Text = "2"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(20, 142)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(70, 25)
        Label13.TabIndex = 0
        Label13.Text = "Length:"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(20, 57)
        Label18.Margin = New Padding(4, 0, 4, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(53, 25)
        Label18.TabIndex = 0
        Label18.Text = "Type:"
        ' 
        ' ComboBox6
        ' 
        ComboBox6.FormattingEnabled = True
        ComboBox6.Items.AddRange(New Object() {"Holding Registers", "Input Registers"})
        ComboBox6.Location = New Point(200, 54)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(200, 33)
        ComboBox6.TabIndex = 2
        ComboBox6.Text = "Holding Registers"
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.BackColor = SystemColors.Control
        RichTextBox2.BorderStyle = BorderStyle.None
        RichTextBox2.Enabled = False
        RichTextBox2.Location = New Point(517, 400)
        RichTextBox2.Margin = New Padding(4, 5, 4, 5)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(405, 200)
        RichTextBox2.TabIndex = 0
        RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(946, 666)
        Controls.Add(RichTextBox2)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(RichTextBox1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        Text = "Modbus Master - Ir. Ts. Musnazril Bin Mustaq Khan"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents RichTextBox2 As RichTextBox

End Class
