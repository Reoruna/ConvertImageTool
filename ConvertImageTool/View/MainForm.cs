using ConvertImageTool.Common;
using ConvertImageTool.Common.ImageResorce;
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
            this.ConvertMethodComboBox.DataSource = Enum.GetValues(typeof(ConvertPattern));
            this.FormLoad();
        }

        private void FormLoad()
        {
            this.ConvertMethodComboBox.SelectedIndex = 0;
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

        private void OutputButton_Click(object sender, EventArgs e)
        {
            this._viewModel.ConvertPicture();
            this.OutputPictureBox.Image = this._viewModel.OutputImage;
        }

        private void ConvertMethodComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this._viewModel.CovertMethod = (ConvertPattern)this.ConvertMethodComboBox.SelectedValue;
        }
    }
}
