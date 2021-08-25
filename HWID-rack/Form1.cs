using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWID_rack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string hwid;

        private void button1_Click(object sender, EventArgs e)
        {
            hwid = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
            var web = new WebClient();
            string[] hwid1 = web.DownloadString("링크 & link").Split('\n'); 
            if (hwid1.Contains(hwid))
            {
                MessageBox.Show("nice to meet you!");
            }
            else
            {
                MessageBox.Show("Error", "don't match!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
