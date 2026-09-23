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
            logic.AddStudent("Иванов Иван Иванович", "ПИ-21-1", "Прикладная информатика");
            logic.AddStudent("Петров Пётр Петрович", "ПИ-21-1", "Прикладная информатика");
            logic.AddStudent("Сидорова Анна Сергеевна", "ПИ-21-2", "Прикладная информатика");
            logic.AddStudent("Кузнецов Дмитрий Олегович", "ИС-22-1", "Информационные системы");
            logic.AddStudent("Смирнова Ольга Ивановна", "ИС-22-1", "Информационные системы");
            logic.AddStudent("Попов Алексей Николаевич", "МО-23-1", "Математическое обеспечение");
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
