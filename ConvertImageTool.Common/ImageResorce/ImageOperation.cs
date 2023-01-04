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
        /// <returns>変換後画像、変換失敗の時はそのままの画像を返す</returns>
        public static Image Convert(Image inImage,ConvertCondition inConvertCondition)
        {
            switch(inConvertCondition.ConvertMethod)
            {
                case ConvertPattern.Reverse:
                    return Reverse(inImage,inConvertCondition);
                case ConvertPattern.Gamma:
                    return GammaAdjust(inImage,inConvertCondition);
                default:
                    return inImage;
            }
        }

        private static Image Reverse(Image inImage, ConvertCondition inConvertCondition)
        {
            return inImage;
        }

        private static Image GammaAdjust(Image inImage, ConvertCondition inConvertCondition)
        {
            return inImage;
        }
    }
}
