namespace DCS显示器设置
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.filePath = new System.Windows.Forms.TextBox();
            this.label_DCS_path = new System.Windows.Forms.Label();
            this.buttonSelectDcsPath = new System.Windows.Forms.Button();
            this.LabelMods = new System.Windows.Forms.Label();
            this.listBoxMod = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxFA18C = new System.Windows.Forms.CheckBox();
            this.checkBoxF16C = new System.Windows.Forms.CheckBox();
            this.checkBoxAV8B = new System.Windows.Forms.CheckBox();
            this.checkBoxAH64D = new System.Windows.Forms.CheckBox();
            this.checkBoxA10C2 = new System.Windows.Forms.CheckBox();
            this.checkBoxA10C = new System.Windows.Forms.CheckBox();
            this.checkBoxALL = new System.Windows.Forms.CheckBox();
            this.buttonPatchMod = new System.Windows.Forms.Button();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.buttonRecoveryFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filePath
            // 
            this.filePath.Enabled = false;
            this.filePath.Location = new System.Drawing.Point(140, 18);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(752, 21);
            this.filePath.TabIndex = 0;
            // 
            // label_DCS_path
            // 
            this.label_DCS_path.AutoSize = true;
            this.label_DCS_path.Location = new System.Drawing.Point(56, 24);
            this.label_DCS_path.Name = "label_DCS_path";
            this.label_DCS_path.Size = new System.Drawing.Size(53, 12);
            this.label_DCS_path.TabIndex = 1;
            this.label_DCS_path.Text = "DCS 路径";
            // 
            // buttonSelectDcsPath
            // 
            this.buttonSelectDcsPath.Location = new System.Drawing.Point(915, 19);
            this.buttonSelectDcsPath.Name = "buttonSelectDcsPath";
            this.buttonSelectDcsPath.Size = new System.Drawing.Size(97, 23);
            this.buttonSelectDcsPath.TabIndex = 2;
            this.buttonSelectDcsPath.Text = "选择DCS.exe";
            this.buttonSelectDcsPath.UseVisualStyleBackColor = true;
            this.buttonSelectDcsPath.Click += new System.EventHandler(this.buttonSelectDCS);
            // 
            // LabelMods
            // 
            this.LabelMods.AutoSize = true;
            this.LabelMods.Location = new System.Drawing.Point(20, 69);
            this.LabelMods.Name = "LabelMods";
            this.LabelMods.Size = new System.Drawing.Size(89, 12);
            this.LabelMods.TabIndex = 4;
            this.LabelMods.Text = "已扫描到的机型";
            // 
            // listBoxMod
            // 
            this.listBoxMod.FormattingEnabled = true;
            this.listBoxMod.ItemHeight = 12;
            this.listBoxMod.Location = new System.Drawing.Point(140, 69);
            this.listBoxMod.Name = "listBoxMod";
            this.listBoxMod.Size = new System.Drawing.Size(350, 304);
            this.listBoxMod.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxFA18C);
            this.groupBox1.Controls.Add(this.checkBoxF16C);
            this.groupBox1.Controls.Add(this.checkBoxAV8B);
            this.groupBox1.Controls.Add(this.checkBoxAH64D);
            this.groupBox1.Controls.Add(this.checkBoxA10C2);
            this.groupBox1.Controls.Add(this.checkBoxA10C);
            this.groupBox1.Controls.Add(this.checkBoxALL);
            this.groupBox1.Location = new System.Drawing.Point(550, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 304);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择需要添加或取消仪表输出的机型";
            // 
            // checkBoxFA18C
            // 
            this.checkBoxFA18C.AutoSize = true;
            this.checkBoxFA18C.Enabled = false;
            this.checkBoxFA18C.Location = new System.Drawing.Point(169, 99);
            this.checkBoxFA18C.Name = "checkBoxFA18C";
            this.checkBoxFA18C.Size = new System.Drawing.Size(54, 16);
            this.checkBoxFA18C.TabIndex = 6;
            this.checkBoxFA18C.Text = "FA18C";
            this.checkBoxFA18C.UseVisualStyleBackColor = true;
            // 
            // checkBoxF16C
            // 
            this.checkBoxF16C.AutoSize = true;
            this.checkBoxF16C.Enabled = false;
            this.checkBoxF16C.Location = new System.Drawing.Point(7, 99);
            this.checkBoxF16C.Name = "checkBoxF16C";
            this.checkBoxF16C.Size = new System.Drawing.Size(48, 16);
            this.checkBoxF16C.TabIndex = 5;
            this.checkBoxF16C.Text = "F16C";
            this.checkBoxF16C.UseVisualStyleBackColor = true;
            // 
            // checkBoxAV8B
            // 
            this.checkBoxAV8B.AutoSize = true;
            this.checkBoxAV8B.Enabled = false;
            this.checkBoxAV8B.Location = new System.Drawing.Point(169, 76);
            this.checkBoxAV8B.Name = "checkBoxAV8B";
            this.checkBoxAV8B.Size = new System.Drawing.Size(48, 16);
            this.checkBoxAV8B.TabIndex = 4;
            this.checkBoxAV8B.Text = "AV8B";
            this.checkBoxAV8B.UseVisualStyleBackColor = true;
            // 
            // checkBoxAH64D
            // 
            this.checkBoxAH64D.AutoSize = true;
            this.checkBoxAH64D.Enabled = false;
            this.checkBoxAH64D.Location = new System.Drawing.Point(7, 76);
            this.checkBoxAH64D.Name = "checkBoxAH64D";
            this.checkBoxAH64D.Size = new System.Drawing.Size(54, 16);
            this.checkBoxAH64D.TabIndex = 3;
            this.checkBoxAH64D.Text = "AH64D";
            this.checkBoxAH64D.UseVisualStyleBackColor = true;
            // 
            // checkBoxA10C2
            // 
            this.checkBoxA10C2.AutoSize = true;
            this.checkBoxA10C2.Enabled = false;
            this.checkBoxA10C2.Location = new System.Drawing.Point(169, 52);
            this.checkBoxA10C2.Name = "checkBoxA10C2";
            this.checkBoxA10C2.Size = new System.Drawing.Size(54, 16);
            this.checkBoxA10C2.TabIndex = 2;
            this.checkBoxA10C2.Text = "A10C2";
            this.checkBoxA10C2.UseVisualStyleBackColor = true;
            // 
            // checkBoxA10C
            // 
            this.checkBoxA10C.AutoSize = true;
            this.checkBoxA10C.Enabled = false;
            this.checkBoxA10C.Location = new System.Drawing.Point(7, 54);
            this.checkBoxA10C.Name = "checkBoxA10C";
            this.checkBoxA10C.Size = new System.Drawing.Size(48, 16);
            this.checkBoxA10C.TabIndex = 1;
            this.checkBoxA10C.Text = "A10C";
            this.checkBoxA10C.UseVisualStyleBackColor = true;
            // 
            // checkBoxALL
            // 
            this.checkBoxALL.AutoSize = true;
            this.checkBoxALL.Location = new System.Drawing.Point(288, 282);
            this.checkBoxALL.Name = "checkBoxALL";
            this.checkBoxALL.Size = new System.Drawing.Size(48, 16);
            this.checkBoxALL.TabIndex = 0;
            this.checkBoxALL.Text = "全选";
            this.checkBoxALL.UseVisualStyleBackColor = true;
            this.checkBoxALL.CheckedChanged += new System.EventHandler(this.checkBoxALL_CheckedChanged);
            // 
            // buttonPatchMod
            // 
            this.buttonPatchMod.Location = new System.Drawing.Point(915, 301);
            this.buttonPatchMod.Name = "buttonPatchMod";
            this.buttonPatchMod.Size = new System.Drawing.Size(97, 23);
            this.buttonPatchMod.TabIndex = 7;
            this.buttonPatchMod.Text = "添加输出";
            this.buttonPatchMod.UseVisualStyleBackColor = true;
            this.buttonPatchMod.Click += new System.EventHandler(this.buttonPatch);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 12;
            this.listBoxOutput.Location = new System.Drawing.Point(140, 406);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(752, 232);
            this.listBoxOutput.TabIndex = 8;
            // 
            // buttonRecoveryFile
            // 
            this.buttonRecoveryFile.Location = new System.Drawing.Point(915, 344);
            this.buttonRecoveryFile.Name = "buttonRecoveryFile";
            this.buttonRecoveryFile.Size = new System.Drawing.Size(97, 23);
            this.buttonRecoveryFile.TabIndex = 9;
            this.buttonRecoveryFile.Text = "取消输出";
            this.buttonRecoveryFile.UseVisualStyleBackColor = true;
            this.buttonRecoveryFile.Click += new System.EventHandler(this.buttonRecoveryFile_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 691);
            this.Controls.Add(this.buttonRecoveryFile);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.buttonPatchMod);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxMod);
            this.Controls.Add(this.LabelMods);
            this.Controls.Add(this.buttonSelectDcsPath);
            this.Controls.Add(this.label_DCS_path);
            this.Controls.Add(this.filePath);
            this.Name = "MainWindow";
            this.Text = "DCS 显示器配置工具(by:4436/tracker)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Label label_DCS_path;
        private System.Windows.Forms.Button buttonSelectDcsPath;
        private System.Windows.Forms.Label LabelMods;
        private System.Windows.Forms.ListBox listBoxMod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxFA18C;
        private System.Windows.Forms.CheckBox checkBoxF16C;
        private System.Windows.Forms.CheckBox checkBoxAV8B;
        private System.Windows.Forms.CheckBox checkBoxAH64D;
        private System.Windows.Forms.CheckBox checkBoxA10C2;
        private System.Windows.Forms.CheckBox checkBoxA10C;
        private System.Windows.Forms.CheckBox checkBoxALL;
        private System.Windows.Forms.Button buttonPatchMod;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Button buttonRecoveryFile;
    }
}

