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
        private Logic logic = new Logic();
        
        public Form1()
        {
            InitializeComponent();
            logic.AddStudent("Иванов Иван Иванович", "ГФ3000", "Прикладная информатика");
            logic.AddStudent("Петров Пётр Петрович", "ГФ3000", "Прикладная информатика");
            logic.AddStudent("Шастун Антон Андреич", "ГФ3000", "Прикладная информатика");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAdd add = new FormAdd(logic);
            add.ShowDialog();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            FormRemove remove = new FormRemove(logic);
            remove.ShowDialog();
        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            FormTable table = new FormTable(logic);
            table.ShowDialog();
        }

        private void buttonGist_Click(object sender, EventArgs e)
        {
            FormGist gist = new FormGist(logic);
            gist.ShowDialog();
        }
    }
}
