
namespace ConvertImageTool
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenInputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenOutputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BrightnessAndContrastTab = new System.Windows.Forms.TabPage();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.OutputButton = new System.Windows.Forms.Button();
            this.ConvertMethodComboBox = new System.Windows.Forms.ComboBox();
            this.InputPictureBox = new System.Windows.Forms.PictureBox();
            this.OutputPictureBox = new System.Windows.Forms.PictureBox();
            this.ReferInputButton = new System.Windows.Forms.Button();
            this.InputPathText = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BrightnessAndContrastTab.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenInputFileDialog
            // 
            this.OpenInputFileDialog.FileName = "OpenInputFileDialog";
            // 
            // OpenOutputFileDialog
            // 
            this.OpenOutputFileDialog.FileName = "OpenOutputFileDialog";
            // 
            // BrightnessAndContrastTab
            // 
            this.BrightnessAndContrastTab.Controls.Add(this.InputPathText);
            this.BrightnessAndContrastTab.Controls.Add(this.ReferInputButton);
            this.BrightnessAndContrastTab.Controls.Add(this.OutputPictureBox);
            this.BrightnessAndContrastTab.Controls.Add(this.InputPictureBox);
            this.BrightnessAndContrastTab.Controls.Add(this.ControlPanel);
            this.BrightnessAndContrastTab.Location = new System.Drawing.Point(4, 22);
            this.BrightnessAndContrastTab.Name = "BrightnessAndContrastTab";
            this.BrightnessAndContrastTab.Padding = new System.Windows.Forms.Padding(3);
            this.BrightnessAndContrastTab.Size = new System.Drawing.Size(1078, 400);
            this.BrightnessAndContrastTab.TabIndex = 0;
            this.BrightnessAndContrastTab.Text = "Brightness and contrast";
            this.BrightnessAndContrastTab.UseVisualStyleBackColor = true;
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.ConvertMethodComboBox);
            this.ControlPanel.Controls.Add(this.OutputButton);
            this.ControlPanel.Location = new System.Drawing.Point(372, 6);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(334, 360);
            this.ControlPanel.TabIndex = 0;
            // 
            // OutputButton
            // 
            this.OutputButton.Location = new System.Drawing.Point(66, 324);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(216, 33);
            this.OutputButton.TabIndex = 0;
            this.OutputButton.Text = "出力";
            this.OutputButton.UseVisualStyleBackColor = true;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // ConvertMethodComboBox
            // 
            this.ConvertMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConvertMethodComboBox.FormattingEnabled = true;
            this.ConvertMethodComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ConvertMethodComboBox.Location = new System.Drawing.Point(15, 12);
            this.ConvertMethodComboBox.Name = "ConvertMethodComboBox";
            this.ConvertMethodComboBox.Size = new System.Drawing.Size(191, 20);
            this.ConvertMethodComboBox.TabIndex = 3;
            // 
            // InputPictureBox
            // 
            this.InputPictureBox.BackColor = System.Drawing.Color.DimGray;
            this.InputPictureBox.Location = new System.Drawing.Point(6, 6);
            this.InputPictureBox.Name = "InputPictureBox";
            this.InputPictureBox.Size = new System.Drawing.Size(360, 360);
            this.InputPictureBox.TabIndex = 1;
            this.InputPictureBox.TabStop = false;
            // 
            // OutputPictureBox
            // 
            this.OutputPictureBox.BackColor = System.Drawing.Color.DimGray;
            this.OutputPictureBox.Location = new System.Drawing.Point(712, 6);
            this.OutputPictureBox.Name = "OutputPictureBox";
            this.OutputPictureBox.Size = new System.Drawing.Size(360, 360);
            this.OutputPictureBox.TabIndex = 1;
            this.OutputPictureBox.TabStop = false;
            // 
            // ReferInputButton
            // 
            this.ReferInputButton.Location = new System.Drawing.Point(6, 371);
            this.ReferInputButton.Name = "ReferInputButton";
            this.ReferInputButton.Size = new System.Drawing.Size(80, 23);
            this.ReferInputButton.TabIndex = 0;
            this.ReferInputButton.Text = "参照";
            this.ReferInputButton.UseVisualStyleBackColor = true;
            this.ReferInputButton.Click += new System.EventHandler(this.ReferInputButton_Click);
            // 
            // InputPathText
            // 
            this.InputPathText.Location = new System.Drawing.Point(92, 373);
            this.InputPathText.Name = "InputPathText";
            this.InputPathText.ReadOnly = true;
            this.InputPathText.Size = new System.Drawing.Size(274, 19);
            this.InputPathText.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BrightnessAndContrastTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1086, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 442);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.BrightnessAndContrastTab.ResumeLayout(false);
            this.BrightnessAndContrastTab.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InputPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog OpenInputFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenOutputFileDialog;
        private System.Windows.Forms.TabPage BrightnessAndContrastTab;
        private System.Windows.Forms.TextBox InputPathText;
        private System.Windows.Forms.Button ReferInputButton;
        private System.Windows.Forms.PictureBox OutputPictureBox;
        private System.Windows.Forms.PictureBox InputPictureBox;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.ComboBox ConvertMethodComboBox;
        private System.Windows.Forms.Button OutputButton;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

