using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertImageTool.Common.ImageResorce
{
    public class ConvertCondition
    {
        public ConvertCondition(ConvertPattern convertMethod, int gammaBeta)
        {
            this.ConvertMethod = convertMethod;
            this.GammaBeta = gammaBeta;
        }

        /// <summary>
        /// 変換方法
        /// </summary>
        public ConvertPattern ConvertMethod { get; set; }


        /// <summary>
        /// ガンマβ値
        /// </summary>
        public int GammaBeta { get; set; }


    }

    public enum ConvertPattern
    {

        Default=0,
        Reverse=1,
        Gamma=2
    }
}
