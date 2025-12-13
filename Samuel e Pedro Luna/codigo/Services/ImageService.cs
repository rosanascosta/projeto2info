using System.Drawing.Drawing2D;

namespace Projeto.Services;
public static class ImageService
{
    public static Bitmap? LoadResizedBitmap(string? filePath, Size targetSize)
    {
        if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath)) return null;

        byte[] bytes = File.ReadAllBytes(filePath);
        using var ms = new MemoryStream(bytes);
        using var src = Image.FromStream(ms);

        if (targetSize.Width <= 0 || targetSize.Height <= 0)
            return new Bitmap(src);

        var dest = new Bitmap(targetSize.Width, targetSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        using (var grafico = Graphics.FromImage(dest))
        {
            grafico.CompositingQuality = CompositingQuality.HighQuality;
            grafico.InterpolationMode = InterpolationMode.HighQualityBicubic;
            grafico.SmoothingMode = SmoothingMode.HighQuality;
            grafico.PixelOffsetMode = PixelOffsetMode.HighQuality;

            grafico.DrawImage(src, new Rectangle(0, 0, targetSize.Width, targetSize.Height));
        }

        return dest;
    }
}
