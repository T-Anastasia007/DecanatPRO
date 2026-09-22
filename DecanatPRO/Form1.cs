using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecanatPRO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAdd add = new FormAdd();
            add.ShowDialog();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            FormRemove remove = new FormRemove();
            remove.ShowDialog();
        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            FormTable table = new FormTable();
            table.ShowDialog();
        }

        private void buttonGist_Click(object sender, EventArgs e)
        {
            FormGist gist = new FormGist();
            gist.ShowDialog();
        }
    }
}
