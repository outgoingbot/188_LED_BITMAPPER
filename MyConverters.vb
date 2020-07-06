Public Class MyConverters
    Public Shared Function ConvertTo16bpp(ByVal img As Image) As Bitmap
        Dim bmp As Bitmap = New Bitmap(img.Width, img.Height, System.Drawing.Imaging.PixelFormat.Format16bppRgb555)
        Dim gr As Graphics = Graphics.FromImage(bmp)
        gr.DrawImage(img, New Rectangle(0, 0, img.Width, img.Height))
        Return bmp
    End Function
End Class
