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
    public partial class FormTable : Form
    {
        private Logic _logic; 
        public FormTable(Logic logic)
        {
            InitializeComponent();
            _logic = logic;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormTable_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            foreach (var row in _logic.ShowTable())
            {
                dataGridView.Rows.Add(row);
            }
        }
    }
}
