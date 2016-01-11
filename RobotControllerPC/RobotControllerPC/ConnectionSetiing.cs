using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RobotControllerPC
{
    public partial class ConnectionSetiing : Form
    {
        public ConnectionSetiing()
        {
            InitializeComponent();
        }
        public ConnectionData data;
        private void buttonOK_Click(object sender, EventArgs e)
        {
            data.addr = this.textBox1.Text;
            data.port = int.Parse(this.textBox2.Text);
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
