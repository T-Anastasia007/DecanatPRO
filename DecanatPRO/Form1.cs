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
        private Logic logic = new Logic(TypeofDB.Dapper);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Сначала выберите студента в таблице.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idText = dataGridView.CurrentRow.Cells[0].Value?.ToString();

            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("Не удалось прочитать ID выбранной строки.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ok = logic.DeleteStudent(id);

            if (!ok)
            {
                MessageBox.Show($"Студент с ID = {id} не найден.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Refresh();

        MessageBox.Show($"Студент с ID = {id} удалён.", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonGist_Click(object sender, EventArgs e)
        {
            FormGist gist = new FormGist(logic);
            gist.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string _name = name.Replace(" ", "");
            string spec = textBoxSpec.Text.Trim();
            string group = textBoxGroup.Text.Trim();
            string ename = logic.CheckOnDurak(_name, CheckMode.Letters);
            if (ename != null)
            {
                MessageBox.Show(ename, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string espec = logic.CheckOnDurak(spec, CheckMode.Specalnst);
            if (espec != null)
            {
                MessageBox.Show(espec, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string egroup = logic.CheckOnDurak(group, CheckMode.SpecChars);
            if (egroup != null)
            {
                MessageBox.Show(egroup, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            logic.AddStudent(name, group, spec);
            MessageBox.Show("Студент добавлен!", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Refresh();
        }
        private void Refresh() 
        {
            dataGridView.Rows.Clear();

            foreach (var row in logic.ShowTable())
            {
                dataGridView.Rows.Add(row);
            }
        }
    }
}
