using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhostWriter
{
    public partial class frmGhostWriter : Form
    {
        Stopwatch _timer = new Stopwatch();
        TimeSpan _allowedTime = new TimeSpan(0, 0, 30);
        public frmGhostWriter()
        {
            InitializeComponent();
            _timer.Start();
            tmrElapsedTime.Start();
        }

        private void mnuClear_Click(object sender, EventArgs e)
        {
            deleteFirstLine();
        }

        private void deleteFirstLine()
        {
            string[] lines = TemporaryText.Lines;
            TemporaryText.Lines = lines.Skip<string>(1).ToArray();
            TemporaryText.SelectionStart = TemporaryText.TextLength;
            TemporaryText.ScrollToCaret();
        }

        private void mnuClearAllText_Click(object sender, EventArgs e)
        {
            TemporaryText.Lines = new string[0];
        }

        private void TemporaryText_TextChanged(object sender, EventArgs e)
        {
            if (TemporaryText.Lines.Length > 3)
                deleteFirstLine();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
       {
            Close();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOptions optionsForm = new frmOptions();
            optionsForm.ShowDialog();
        }
    }
}
