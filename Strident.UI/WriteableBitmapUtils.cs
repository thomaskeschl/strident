using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Strident.UI
{
    public static class WriteableBitmapUtils
    {
        public static void setPixel(this WriteableBitmap bitmap, int x, int y, Color color)
        {
            if (y >= bitmap.PixelHeight || x >= bitmap.PixelWidth) return;

            if (y < 0 || x < 0) return;

            if (bitmap.Format != PixelFormats.Bgra32) return;

            bitmap.Lock();
            IntPtr buffer = bitmap.BackBuffer;
            int stride = bitmap.BackBufferStride;

            unsafe
            {
                byte* pixelBuffer = (byte*)buffer.ToPointer();
                int loc = y * stride + x * 4;
                pixelBuffer[loc] = color.B;
                pixelBuffer[loc + 1] = color.G;
                pixelBuffer[loc + 2] = color.R;
                pixelBuffer[loc + 3] = color.A;
            }

            bitmap.AddDirtyRect(new Int32Rect(x, y, 1, 1));
            bitmap.Unlock();
        }
    }
}
