using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ConvertImageTool.Common.ImageResorce
{
    public static class ImageOperation
    {
        public static Image Resize(Image inImage, int inHeight,int inWidth)
        {
            if(inImage==null || inHeight<=0 || inHeight <=0)
            {
                return default(Image);
            }

            using (var bmp = new Bitmap(inImage))
            {
                return (Image)(new Bitmap(bmp, new Size(inHeight, inWidth)));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inConvertCondition"></param>
        /// <returns>変換後画像を返す</returns>
        public static Image Convert(ImageInfo inImageInfo,ConvertCondition inConvertCondition)
        {
            switch (inConvertCondition.ConvertMethod)
            {
                case ConvertPattern.Reverse:
                    return Reverse(inImageInfo, inConvertCondition);
                case ConvertPattern.Gamma:
                    return GammaAdjust(inImageInfo, inConvertCondition);
                default:
                    return inImageInfo.ImageOrigin;
            }
        }

        /// <summary>
        /// Imageクラスをbyte型配列に変換
        /// </summary>
        /// <param name="inImage"></param>
        /// <param name="inHeight"></param>
        /// <param name="inWidth"></param>
        /// <returns>byte型配列で返します。byte[Height,Width,Color]</returns>
        private static byte[,,] ConvertRGBImageToByte(Image inImage,int inHeight,int inWidth)
        {
            var data = new byte[inHeight, inWidth, 3];
            using (var bmp = new Bitmap(inImage))
            {
                for (int i = 0; i < inHeight; i++)
                {
                    for (int j = 0; j < inWidth; j++)
                    {
                        data[i, j, 0] = bmp.GetPixel(i, j).R;
                        data[i, j, 1] = bmp.GetPixel(i, j).G;
                        data[i, j, 2] = bmp.GetPixel(i, j).B;
                    }
                }
            }
            return data;
        }

        /// <summary>
        /// byte型配列をImageクラスに変換
        /// </summary>
        /// <param name="inByte"></param>
        /// <param name="inHeight"></param>
        /// <param name="inWidth"></param>
        /// <returns></returns>
        private static Image ConvertRGBbyteToImage(byte[,,] inByte, int inHeight, int inWidth)
        {
            var bmp = new Bitmap(inWidth, inHeight);

            for (int i = 0; i < inHeight; i++)
            {
                for (int j = 0; j < inWidth; j++)
                {
                    bmp.SetPixel(i, j, Color.FromArgb(inByte[i, j, (int)Color_RGB.Red], inByte[i, j, (int)Color_RGB.Green], inByte[i, j, (int)Color_RGB.Blue]));
                }
            }
            return bmp;
        }

        private static Image Reverse(ImageInfo inImageInfo, ConvertCondition inConvertCondition)
        {
            var imageByte = ConvertRGBImageToByte(inImageInfo.ImageOrigin, inImageInfo.Height, inImageInfo.Width);

            var height = inImageInfo.Height;
            var width = inImageInfo.Width;
            var color = ImageInfo.RGB_COLOR_PETERN;

            byte[,,] outData = new byte[height, width, color];
            for(int i=0; i< height; i++)
            {
                for(int j=0; j< width; j++)
                {
                    for(int col=0;col< color;col++)
                    {
                        //RGB255から引いて反転
                        outData[i, j, col] = (byte)(255-imageByte[i, j, col]);
                    }
                }
            }
            return ConvertRGBbyteToImage(outData, inImageInfo.Height, inImageInfo.Width);
        }

        private static Image GammaAdjust(ImageInfo inImageInfo, ConvertCondition inConvertCondition)
        {
            return inImageInfo.ImageOrigin;
        }
    }
}
