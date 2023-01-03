using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertImageTool.ViewModel
{
    public class MainFormViewModel : BaseViewModel
    {
        //private System.Windows.Forms.TabControl tabControl1;
        //private System.Windows.Forms.TabPage BrightnessAndContrastTab;
        //private System.Windows.Forms.TabPage GammaTab;
        //private System.Windows.Forms.PictureBox OutputPictureBox;
        //private System.Windows.Forms.PictureBox InputPictureBox;
        //private System.Windows.Forms.Panel ControlPanel;
        //private System.Windows.Forms.Button OutPutButton;
        //private System.Windows.Forms.TextBox OutputPathText;
        //private System.Windows.Forms.TextBox InputPathText;
        //private System.Windows.Forms.Button ReferOutputButton;
        //private System.Windows.Forms.Button ReferInputButton;
        //private System.Windows.Forms.OpenFileDialog OpenInputFileDialog;
        //private System.Windows.Forms.OpenFileDialog OpenOutputFileDialog;

        private string _inputPathText;
        private Image _inputImage;
        private Image _outputImage;


        public string InputPathText
        {
            get { return this._inputPathText; }
            set 
            {
                if(this._inputPathText==value)
                {
                    return;
                }
                else
                {
                    this._inputPathText = value;
                    OnPropertyChanged("InputPathText");
                }
            }
        }
        public Image InputImage
        {
            get { return this._inputImage; }
        }
        public Image OutputImage
        {
            get { return this._outputImage; }
        }


        public MainFormViewModel()
        {   this._inputPathText=String.Empty;
            this._inputImage = null;
            this._outputImage = null;

        }

        public void LoadPicture()
        {
            this._inputImage = Image.FromFile(this.InputPathText);            
        }


        ~MainFormViewModel()
        {
            this._inputImage.Dispose();
            this._outputImage.Dispose();

        }
    }
}
