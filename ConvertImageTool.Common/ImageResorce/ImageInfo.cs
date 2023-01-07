using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertImageTool.Common.ImageResorce
{
    public class ImageInfo
    {
        public ImageInfo(Image inImageOrigin, int inHeight, int inWidth)
        {
            ImageOrigin = inImageOrigin;
            ImageConverted = null;
            Width = inWidth;
            Height = inHeight;
        }

        /// <summary>
        /// RGBパターン数
        /// </summary>
        public static int RGB_COLOR_PETERN = 3;

        /// <summary>
        /// 出力元画像
        /// </summary>
        public Image ImageOrigin { get; }

        /// <summary>
        /// 変換後画像
        /// </summary>
        public Image ImageConverted { get; set; }

        /// <summary>
        /// 画像の縦幅
        /// </summary>
        public int Height { get; }

        /// <summary>
        /// 画像の横幅
        /// </summary>
        public int Width { get; }


    }

    /// <summary>
    /// RBGパターン
    /// </summary>
    public enum Color_RGB
    {
        Red,
        Green,
        Blue
    }
}
