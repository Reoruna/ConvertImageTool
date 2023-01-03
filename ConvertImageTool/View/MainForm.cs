using ConvertImageTool.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertImageTool
{
    public partial class MainForm : Form
    {

        private MainFormViewModel _viewModel;

        public MainForm()
        {
            InitializeComponent();
            this._viewModel = new MainFormViewModel();

            this.InputPathText.DataBindings.Add("Text", this._viewModel, "InputPathText");

        }

        private void ReferInputButton_Click(object sender, EventArgs e)
        {
            if(this.OpenInputFileDialog.ShowDialog()==DialogResult.OK)
            {
                this._viewModel.InputPathText = this.OpenInputFileDialog.FileName;
                this._viewModel.LoadPicture();
                this.InputPictureBox.Image = this._viewModel.InputImage;
            }
        }

    }
}
