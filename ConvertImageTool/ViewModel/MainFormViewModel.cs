using NLog;
using System;
using System.Drawing;
using ConvertImageTool.Common.FileResorce;
using ConvertImageTool.Common.ImageResorce;

namespace ConvertImageTool.ViewModel
{
    public class MainFormViewModel : BaseViewModel
    {
        Logger log = LogManager.GetCurrentClassLogger();

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
        private ConvertCondition _condition;


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
        public ConvertPattern CovertMethod
        {
            get { return this._condition.ConvertMethod; }
            set
            {
                if (this._condition.ConvertMethod == value)
                {
                    return;
                }
                else
                {
                    this._condition.ConvertMethod = value;
                    OnPropertyChanged("InputPathText");
                }
            }
        }


        public MainFormViewModel()
        {   this._inputPathText=String.Empty;
            this._inputImage = null;
            this._outputImage = null;

            this._condition = new ConvertCondition(ConvertPattern.Default,1);
        }

        public void LoadPicture()
        {
            try
            {
                using (Image tmpImage = FileOperation.LoadFromFilePath<Image>(this.InputPathText))
                {
                    this._inputImage = ImageOperation.Resize(tmpImage, 360, 360);
                }
            }
            catch(Exception ex)
            {
                log.Error("画像の取り込みに失敗しました。",ex.Message);
            }
        }

        public void ConvertPicture()
        {
            try
            {
                this._outputImage = ImageOperation.Convert(this.InputImage, this._condition);
            }
            catch (Exception ex)
            {
                log.Error("画像の変換に失敗しました。", ex.Message);
            }
        }


        ~MainFormViewModel()
        {
            if(this._inputImage!=null)
            {
                this._inputImage.Dispose();
            }

            if (this._outputImage != null)
            {
                this._outputImage.Dispose();
            }
        }
    }
}
