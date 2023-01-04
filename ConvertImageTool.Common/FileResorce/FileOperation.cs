using NLog;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ConvertImageTool.Common.FileResorce
{
    public class FileOperation
    {
        Logger log = LogManager.GetCurrentClassLogger();

        public static T LoadFromFilePath<T>(string inFilePath)
        {
            if (typeof(T) == typeof(Image))
            {
                return (T)(object)Image.FromFile(inFilePath);
            }

            return default(T);
        }

        public bool SaveImageToPNG(Image inImage,string inFilePath)
        {
            try
            {
                inImage.Save(inFilePath, System.Drawing.Imaging.ImageFormat.Png);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            return false;
        }

    }
}
