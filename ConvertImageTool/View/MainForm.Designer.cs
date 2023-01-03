
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BrightnessAndContrastTab = new System.Windows.Forms.TabPage();
            this.InputPathText = new System.Windows.Forms.TextBox();
            this.ReferInputButton = new System.Windows.Forms.Button();
            this.OutputPictureBox = new System.Windows.Forms.PictureBox();
            this.InputPictureBox = new System.Windows.Forms.PictureBox();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.OutPutButton = new System.Windows.Forms.Button();
            this.GammaTab = new System.Windows.Forms.TabPage();
            this.OpenInputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenOutputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.BrightnessAndContrastTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputPictureBox)).BeginInit();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BrightnessAndContrastTab);
            this.tabControl1.Controls.Add(this.GammaTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1086, 426);
            this.tabControl1.TabIndex = 0;
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
            // InputPathText
            // 
            this.InputPathText.Location = new System.Drawing.Point(92, 373);
            this.InputPathText.Name = "InputPathText";
            this.InputPathText.ReadOnly = true;
            this.InputPathText.Size = new System.Drawing.Size(274, 19);
            this.InputPathText.TabIndex = 1;
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
            // OutputPictureBox
            // 
            this.OutputPictureBox.BackColor = System.Drawing.Color.DimGray;
            this.OutputPictureBox.Location = new System.Drawing.Point(712, 6);
            this.OutputPictureBox.Name = "OutputPictureBox";
            this.OutputPictureBox.Size = new System.Drawing.Size(360, 360);
            this.OutputPictureBox.TabIndex = 1;
            this.OutputPictureBox.TabStop = false;
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
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.OutPutButton);
            this.ControlPanel.Location = new System.Drawing.Point(372, 6);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(334, 360);
            this.ControlPanel.TabIndex = 0;
            // 
            // OutPutButton
            // 
            this.OutPutButton.Location = new System.Drawing.Point(45, 307);
            this.OutPutButton.Name = "OutPutButton";
            this.OutPutButton.Size = new System.Drawing.Size(245, 39);
            this.OutPutButton.TabIndex = 0;
            this.OutPutButton.Text = "出力";
            this.OutPutButton.UseVisualStyleBackColor = true;
            // 
            // GammaTab
            // 
            this.GammaTab.Location = new System.Drawing.Point(4, 22);
            this.GammaTab.Name = "GammaTab";
            this.GammaTab.Padding = new System.Windows.Forms.Padding(3);
            this.GammaTab.Size = new System.Drawing.Size(1078, 400);
            this.GammaTab.TabIndex = 1;
            this.GammaTab.Text = "Gamma";
            this.GammaTab.UseVisualStyleBackColor = true;
            // 
            // OpenInputFileDialog
            // 
            this.OpenInputFileDialog.FileName = "OpenInputFileDialog";
            // 
            // OpenOutputFileDialog
            // 
            this.OpenOutputFileDialog.FileName = "OpenOutputFileDialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 442);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.BrightnessAndContrastTab.ResumeLayout(false);
            this.BrightnessAndContrastTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputPictureBox)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage BrightnessAndContrastTab;
        private System.Windows.Forms.TabPage GammaTab;
        private System.Windows.Forms.PictureBox OutputPictureBox;
        private System.Windows.Forms.PictureBox InputPictureBox;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button OutPutButton;
        private System.Windows.Forms.TextBox InputPathText;
        private System.Windows.Forms.Button ReferInputButton;
        private System.Windows.Forms.OpenFileDialog OpenInputFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenOutputFileDialog;
    }
}

