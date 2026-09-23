using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DecanatPRO
{
    public partial class FormGist : Form
    {
        private Logic _logic;
        public FormGist(Logic logic)
        {
            InitializeComponent();
            _logic = logic;
            chart1.Palette = ChartColorPalette.Excel;
            chart1.Titles.Add("Кол-во студентов по настям");
            var hist = _logic.ShowHistogram();
            foreach (var a in hist)
            {
                Series series = chart1.Series.Add(a.Key);
                series.Points.Add(a.Value);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormGist_Load(object sender, EventArgs e)
        {
           
        }
    }
}
