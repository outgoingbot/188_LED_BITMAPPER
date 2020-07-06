Public Class Form1

    Dim setting As Decimal
    Dim xcounter As Integer
    'Dim ycount As Integer
    Dim data2send As Byte
    Dim speed As Integer = 10
    Dim Image_File As String
    Dim overwrite As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim imagelocation As String = txtbox2.Text ' sets the image
        Image_File = "1"
        Call MySubX(imagelocation)
    End Sub



    Private Sub MySubX(ByVal imagelocation As String) 'subroutine for all single image click buttons (1 to 50)
        txtbox.Clear() 'clear the damn text box d3rp
        Dim LineCount As Integer = 0
        Dim LineCountOffset As Integer = 0

        '------------------------------converts image to 16 bit then flips on the Y axis-(visual ONLY)-----------
        Dim BMP1 As Image = Image.FromFile(imagelocation)                'BMP Load bottom up, so they are stored upsidedown
        Dim BMP2 As Image = MyConverters.ConvertTo16bpp(BMP1)            ' some glitch prevents 1bit images from rotating properly
        PictureBOX.Image = BMP2                                          ' So this is required to see the visual of the rotated BMP  
        BMP1.Dispose()

        ''PictureBOX.Image.RotateFlip(RotateFlipType.RotateNoneFlipY)      '
        '--------------------------------------------------------------------------------------------------------

        '----------------------------------Image to byte stream (HEX)--------------------------------------------    
        Dim myImage As Image = Image.FromFile(imagelocation) 'declare and set image to load as hex data
        Dim imgByteArray As Byte() = Nothing
        Dim result As String
        Dim imgMemoryStream As IO.MemoryStream = New IO.MemoryStream()
        myImage.Save(imgMemoryStream, System.Drawing.Imaging.ImageFormat.Bmp)
        imgByteArray = imgMemoryStream.GetBuffer()
        result = BitConverter.ToString(imgByteArray, 0) 'CONVERS DATA BUFFER HEX to STRING DATA SEPERATED BY "-"

        result = result.Remove(0, 186) 'REMOVES HEADER INFO from hex file
        For LineCount = 1 To 15
            result = result.Remove(6 * LineCount, 6)
        Next

        result = result.Remove(96, 395) 'REMOVES FOOTER INFO from hex file
        result = result.TrimEnd("-")
        result = result.Replace("-", ",0x")
        result = "0x" + result
        For LineCount = 1 To 15
            result = result.Insert(10 * LineCount + LineCountOffset, Environment.NewLine)
            LineCountOffset = LineCountOffset + 2
        Next
        result = "const char bitmap1[32] PROGMEM = { " + Environment.NewLine + result + " };"
        txtbox.Text = result

        myImage.Dispose()

    End Sub



    Private Sub MySub(ByVal imagelocation As String) 'subroutine for all single image click buttons (1 to 50)
        txtbox.Clear() 'clear the damn text box d3rp
        Dim LineCount As Integer = 0

        '------------------------------converts image to 16 bit then flips on the Y axis-(visual ONLY)-----------
        Dim BMP1 As Image = Image.FromFile(imagelocation)                'BMP Load bottom up, so they are stored upsidedown
        Dim BMP2 As Image = MyConverters.ConvertTo16bpp(BMP1)            ' some glitch prevents 1bit images from rotating properly
        PictureBOX.Image = BMP2                                          ' So this is required to see the visual of the rotated BMP  
        'PictureBOX.Image.RotateFlip(RotateFlipType.RotateNoneFlipY)      '
        '--------------------------------------------------------------------------------------------------------

        '----------------------------------Image to byte stream (HEX)--------------------------------------------    
        Dim myImage As Image = Image.FromFile(imagelocation) 'declare and set image to load as hex data
        Dim imgByteArray As Byte() = Nothing
        Dim result As String
        Dim imgMemoryStream As IO.MemoryStream = New IO.MemoryStream()
        myImage.Save(imgMemoryStream, System.Drawing.Imaging.ImageFormat.Bmp)
        imgByteArray = imgMemoryStream.GetBuffer()
        result = BitConverter.ToString(imgByteArray, 0) 'CONVERS DATA BUFFER HEX to STRING DATA SEPERATED BY "-"

        result = result.Remove(0, 354) 'REMOVES HEADER INFO from hex file
        result = result.Remove(384, 29) 'REMOVES FOOTER INFO from hex file
        result = result.TrimEnd("-")
        My.Computer.FileSystem.WriteAllText("C:\Users\Tower\Desktop\temp.txt", result, False) 'STORE AS TEMP TEXT FILE
        '-------------------------------------------------------------------------------------------------------

        '----------------------Read Temp HEX FILE one byte at a time and send over serial-----------------------
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\Users\Tower\Desktop\temp.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters("-") 'CSV HEX FILE byte seperater symbol
            Dim currentRow As String()
            While Not MyReader.EndOfData 'do until endoffile
                currentRow = MyReader.ReadFields()
                Dim currentField As String 'var for csv data
                Dim xcount As Integer 'used for loading bar visual
                For Each currentField In currentRow
                    Dim data2sendbyte As Int16 = Convert.ToInt32(currentField, 16) 'convert base16 byte stream to int value hex to decimal)
                    xcount = xcount + 1 'increment after csv value read from text file and sent
                    txtbox.AppendText("0x" + data2sendbyte.ToString("X") + ",") 'converts CSV hex
                    LineCount = LineCount + 1
                    If LineCount Mod 8 = 0 Then txtbox.AppendText(Environment.NewLine)
                Next
            End While
        End Using
        '----------------------------------------------------------------------------------------------------------

    End Sub

End Class
