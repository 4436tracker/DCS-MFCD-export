using System;
using System.IO;
using System.Windows.Forms;

namespace DCS显示器设置
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void buttonSelectDCS(object sender, EventArgs e)
        {
            // 选择DCS主程序以定位需要修改的文件
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "请选择DCS主程序";
            openFileDialog.Filter = "DCS.exe|DCS.exe";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = openFileDialog.FileName.Replace("bin\\DCS.exe", "");
            }
            else
            {
                return;
            }

            // 输出扫描到的机模
            DirectoryInfo directoryInfo = new DirectoryInfo(filePath.Text + "Mods\\aircraft");
            DirectoryInfo[] dirs = directoryInfo.GetDirectories();
            listBoxMod.Items.Clear();
            foreach (DirectoryInfo dir in dirs)
            {
                listBoxMod.Items.Add(dir.Name);
                switch(dir.Name)
                {
                    case "A-10C":
                        checkBoxA10C.Checked = true;
                        checkBoxA10C.Enabled = true;
                        break;
                    case "A-10C_2":
                        checkBoxA10C2.Checked = true;
                        checkBoxA10C2.Enabled = true;
                        break;
                    case "AH-64D":
                        checkBoxAH64D.Checked = true;
                        checkBoxAH64D.Enabled = true;
                        break;
                    case "AV8BNA":
                        checkBoxAV8B.Checked = true;
                        checkBoxAV8B.Enabled = true;
                        break;
                    case "F-16C":
                        checkBoxF16C.Checked = true;
                        checkBoxF16C.Enabled = true;
                        break;
                    case "FA-18C":
                        checkBoxFA18C.Checked = true;
                        checkBoxFA18C.Enabled = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void checkBoxALL_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxALL.Checked)
            {
                if (checkBoxA10C.Enabled) checkBoxA10C.Checked = true;
                if (checkBoxA10C2.Enabled) checkBoxA10C2.Checked = true;
                if (checkBoxAH64D.Enabled) checkBoxAH64D.Checked = true;
                if (checkBoxAV8B.Enabled) checkBoxAV8B.Checked = true;
                if (checkBoxF16C.Enabled) checkBoxF16C.Checked = true;
                if (checkBoxFA18C.Enabled) checkBoxFA18C.Checked = true;
            }else if(!checkBoxALL.Checked)
            {
                if (checkBoxA10C.Enabled) checkBoxA10C.Checked = false;
                if (checkBoxA10C2.Enabled) checkBoxA10C2.Checked = false;
                if (checkBoxAH64D.Enabled) checkBoxAH64D.Checked = false;
                if (checkBoxAV8B.Enabled) checkBoxAV8B.Checked = false;
                if (checkBoxF16C.Enabled) checkBoxF16C.Checked = false;
                if (checkBoxFA18C.Enabled) checkBoxFA18C.Checked = false;
            }
        }

        private void buttonPatch(object sender, EventArgs e)
        {
            Aircraft aircraft = new Aircraft(filePath.Text + "Mods\\aircraft\\", listBoxOutput);

            listBoxOutput.Items.Clear();

            if (checkBoxA10C.Checked) aircraft.setA10C();
            if (checkBoxA10C2.Checked) aircraft.setA10C2();
            if (checkBoxAH64D.Checked) aircraft.setAH64D();
            if (checkBoxAV8B.Checked) aircraft.setAV8B();
            if (checkBoxF16C.Checked) aircraft.setF16C();
            if (checkBoxFA18C.Checked) aircraft.setFA18C();
        }

        private void buttonRecoveryFile_Click(object sender, EventArgs e)
        {
            Aircraft aircraft = new Aircraft(filePath.Text + "Mods\\aircraft\\", listBoxOutput);

            listBoxOutput.Items.Clear();
            if (checkBoxA10C.Checked) aircraft.recoveryA10C();
            if (checkBoxA10C2.Checked) aircraft.recoveryA10C2();
            if (checkBoxAH64D.Checked) aircraft.recoveryAH64D();
            if (checkBoxAV8B.Checked) aircraft.recoveryAV8B();
            if (checkBoxF16C.Checked) aircraft.recoveryF16C();
            if (checkBoxFA18C.Checked) aircraft.recoveryFA18C();
        }
    }
}
