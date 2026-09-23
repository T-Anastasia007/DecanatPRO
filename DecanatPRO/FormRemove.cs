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
    public partial class FormRemove : Form
    {
        private Logic _logic;
        public FormRemove(Logic logic)
        {
            InitializeComponent();
            _logic = logic;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void FormRemove_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            foreach (var row in _logic.ShowTable())
            {
                dataGridView.Rows.Add(row);
            }
        }

        private void textBoxIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxIndex.Text.Trim(), out int id))
            {
                MessageBox.Show("Введите корректный ID (число).", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ok = _logic.DeleteStudent(id);

            if (!ok)
            {
                MessageBox.Show($"Студент с ID = {id} не найден.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Обновить таблицу
            dataGridView.Rows.Clear();
            foreach (var row in _logic.ShowTable())
                dataGridView.Rows.Add(row);

            textBoxIndex.Clear();
            MessageBox.Show($"Студент с ID = {id} удалён.", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
