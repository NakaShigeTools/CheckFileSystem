using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ファイルシステムをチェックする
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ドライブの情報を取得する
            var drives = System.IO.DriveInfo.GetDrives();
                        
            string driveInfo = "ドライブ数 : " + drives.Length.ToString() + "\n";
            foreach (var drive in drives)
            {
                try
                {
                    driveInfo += drive.Name; // ドライブ名
                    driveInfo += " : " + drive.DriveFormat; // フォーマット         
                }
                catch (Exception ex)
                {
                    driveInfo += " : Error : " + ex.Message;
                }
                finally
                {
                    driveInfo += "\n";
                }
            }

            if (!string.IsNullOrEmpty(driveInfo))
                MessageBox.Show(driveInfo);
            else
                MessageBox.Show("None");
        }
    }
}
