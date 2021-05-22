using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WinDrawCore;

namespace WinDraw
{
    public partial class frmMain : Form
    {
        private List<Figure> figures;
        Graphics paper;

        public frmMain()
        {
            InitializeComponent();

            figures = new List<Figure>();
            paper = pnlDraw.CreateGraphics();

            // Data grid view setup
            dgvFigData.AllowUserToAddRows = false;
            dgvFigData.AllowUserToDeleteRows = false;
            dgvFigData.AllowUserToOrderColumns = false;
            dgvFigData.ColumnHeadersVisible = false;
            dgvFigData.RowHeadersVisible = false;
            dgvFigData.Columns.Add("Key", "Key");
            dgvFigData.Columns.Add("Value", "Value");
            dgvFigData.Columns[0].ReadOnly = true;
            dgvFigData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFigData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFigData.Columns[0].Resizable = DataGridViewTriState.False;
            dgvFigData.Columns[1].Resizable = DataGridViewTriState.False;
            //Change cell font
            foreach (DataGridViewColumn col in dgvFigData.Columns)
            {
                col.DefaultCellStyle.Font = lbFigures.Font;
            }

            // Figures ListBox Setup
            lbFigures.DataSource = FigureFab.InitFiguresData();
        }

        // fill DataGrid rows for data from selected figure 
        private void lbFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fig = lbFigures.SelectedItem as FiguresData;
            dgvFigData.Rows.Clear();
            foreach (var v in fig.Data)
            {
                dgvFigData.Rows.Add(v.Key, v.Value);
            }
        }

        // save data from DataGrid to dictionary
        private void dgvFigData_Leave(object sender, EventArgs e)
        {
            var fig = lbFigures.SelectedItem as FiguresData;
            foreach(DataGridViewRow row in dgvFigData.Rows)
            {
                var key = row.Cells[0].Value.ToString();
                var val = row.Cells[1].Value.ToString();
                try
                {
                    fig.Data[key] = int.Parse(val);
                }
                catch (Exception)
                { }
            }
        }

        private void btnLineColour_Click(object sender, EventArgs e)
        {
            if (dlgSetColour.ShowDialog(this) == DialogResult.OK)
            {
                btnLineColour.BackColor = dlgSetColour.Color;
            }
        }

        // Add new figure to figures collection and redraw window
        private void btdDraw_Click(object sender, EventArgs e)
        {
            var fig = FigureFab.Make(lbFigures.SelectedItem as FiguresData);

            if (fig != null)
            {
                var pen = new Pen(btnLineColour.BackColor, (int)edLineWidth.Value);
                fig.drawer = new WFDrawer(pen, paper);
                figures.Add(fig);
            }

            Redraw();
        }

        //Draw all figures from collection in window
        private void Redraw()
        {
            foreach(var f in figures)
            {
                f.Draw();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog(this) == DialogResult.OK)
            {
                string path = dlgSave.FileName;
                using (var sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    foreach (var fig in figures)
                        sw.WriteLine(fig);
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog(this) == DialogResult.OK)
            {
                string path = dlgOpen.FileName;
                using (var sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // ???
                    }
                }
            }
        }
    }
}
