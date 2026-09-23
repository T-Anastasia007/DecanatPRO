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
    public partial class FormAdd : Form
    {
        private Logic _logic;

        public FormAdd(Logic logic)
        {
            InitializeComponent();
            _logic = logic;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string spec = textBoxSpec.Text.Trim();
            string group = textBoxGroup.Text.Trim();

            // Проверки
            string errName = _logic.CheckOnDurak(name, CheckMode.Specalnst);
            if (errName != null)
            {
                MessageBox.Show(errName, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string errSpec = _logic.CheckOnDurak(spec, CheckMode.Specalnst);
            if (errSpec != null)
            {
                MessageBox.Show(errSpec, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string errGroup = _logic.CheckOnDurak(group, CheckMode.SpecChars);
            if (errGroup != null)
            {
                MessageBox.Show(errGroup, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _logic.AddStudent(name, group, spec);

            MessageBox.Show("Студент добавлен!", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
