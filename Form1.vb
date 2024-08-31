Imports System.Net.Sockets

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Ensure a protocol is selected
        If ComboBox6.SelectedIndex = -1 Then
            MessageBox.Show("Please select a protocol first.")
            Return
        End If

        ' Validate IP Address
        Dim ipAddress As String = TextBox1.Text.Trim()
        If String.IsNullOrEmpty(ipAddress) OrElse Not IsValidIPAddress(ipAddress) Then
            MessageBox.Show("Invalid IP address. Please enter a valid IP.")
            Return
        End If

        ' Validate Port
        Dim port As Integer
        If Not Int32.TryParse(TextBox2.Text.Trim(), port) OrElse port <= 0 OrElse port > 65535 Then
            MessageBox.Show("Invalid port number. Please enter a valid port between 1 and 65535.")
            Return
        End If

        ' Validate Unit ID
        Dim unitId As Byte
        If Not Byte.TryParse(TextBox3.Text.Trim(), unitId) Then
            MessageBox.Show("Invalid Unit ID. Please enter a valid Unit ID.")
            Return
        End If

        ' Validate Start Address
        Dim startAddress As Integer
        If Not Int32.TryParse(TextBox4.Text.Trim(), startAddress) Then
            MessageBox.Show("Invalid register address. Please enter a valid integer.")
            Return
        End If

        ' Validate Number of Registers
        Dim numberOfRegisters As Integer
        If Not Int32.TryParse(TextBox6.Text.Trim(), numberOfRegisters) OrElse numberOfRegisters <= 0 Then
            MessageBox.Show("Invalid number of registers. Please enter a positive integer.")
            Return
        End If

        ' Validate Timeout
        Dim timeout As Integer
        If Not Int32.TryParse(TextBox5.Text.Trim(), timeout) OrElse timeout < 0 Then
            MessageBox.Show("Invalid timeout value. Please enter a non-negative integer.")
            Return
        End If

        Dim functionCode As Byte = If(ComboBox6.SelectedIndex = 0, 3, 4) ' 3 for Holding Registers, 4 for Input Registers

        Try
            Using client As New TcpClient(ipAddress, port)
                client.ReceiveTimeout = timeout
                client.SendTimeout = timeout

                Dim stream As NetworkStream = client.GetStream()

                ' Prepare and send the Modbus request
                Dim request As Byte() = PrepareModbusRequest(unitId, functionCode, startAddress, numberOfRegisters)
                stream.Write(request, 0, request.Length)

                ' Receive and process the response
                Dim response As Byte() = New Byte(255) {}
                Dim bytesRead As Integer = stream.Read(response, 0, response.Length)

                DisplayResponse(response, bytesRead)
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error communicating with the device: {ex.Message}")
        End Try
    End Sub

    Private Function IsValidIPAddress(ipAddress As String) As Boolean
        Return System.Net.IPAddress.TryParse(ipAddress, Nothing)
    End Function

    Private Function PrepareModbusRequest(unitId As Byte, functionCode As Byte, startAddress As Integer, numberOfRegisters As Integer) As Byte()
        Dim request As Byte() = New Byte(11) {}
        request(0) = 0 ' Transaction Identifier High
        request(1) = 0 ' Transaction Identifier Low
        request(2) = 0 ' Protocol Identifier High
        request(3) = 0 ' Protocol Identifier Low
        request(4) = 0 ' Length High (Remaining bytes)
        request(5) = 6 ' Length Low
        request(6) = unitId ' Unit Identifier
        request(7) = functionCode ' Function Code
        request(8) = CType((startAddress >> 8) And 255, Byte) ' Starting Address High
        request(9) = CType(startAddress And 255, Byte) ' Starting Address Low
        request(10) = CType((numberOfRegisters >> 8) And 255, Byte) ' Number of Registers High
        request(11) = CType(numberOfRegisters And 255, Byte) ' Number of Registers Low
        Return request
    End Function

    Private Sub DisplayResponse(response As Byte(), bytesRead As Integer)
        RichTextBox1.Clear()
        If bytesRead > 9 Then ' Ensure there are bytes to read
            For i As Integer = 9 To bytesRead - 1 Step 2
                Dim registerValue As Integer = response(i) * 256 + response(i + 1)
                RichTextBox1.AppendText($"{registerValue}{Environment.NewLine}")
            Next
        Else
            RichTextBox1.AppendText("No data received or incomplete response.")
        End If
    End Sub
End Class

