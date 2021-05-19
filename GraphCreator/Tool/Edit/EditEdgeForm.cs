using GraphCreator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphCreator.Tool.Edit
{
    public partial class EditEdgeForm : Form
    {
        Edge editEdge;
        public Edge EditEdge
        {
            get => editEdge;
            set
            {
                editEdge = value;
                Fill();
            }
        }

        public EditEdgeForm()
        {
            InitializeComponent();
        }

        private void InstallFormText()
        {
            string directionChar = editEdge.HasDirection ? ">" : "-";
            Text = string.Format("Ребро {0} --{1} {2}",
                editEdge.StartVertex.Index.ToString(),
                directionChar,
                editEdge.EndVertex.Index.ToString());
        }

        private void Fill()
        {
            InstallFormText();
            hasWeightFld.Checked = editEdge.HasWeight;
            weightFld.Enabled = editEdge.HasWeight;
            hasDirectionFld.Checked = editEdge.HasDirection;
            reverseBtn.Enabled = editEdge.HasDirection;

            lineColorBtn.BackColor = editEdge.Style.LineColor;
            textColorBtn.BackColor = editEdge.Style.TextColor;
            lineWidthLbl.SelectedIndex = editEdge.Style.LineWidth - 1;
        }

        private void hasWeightFld_Click(object sender, EventArgs e)
        {
            editEdge.HasWeight = hasWeightFld.Checked;
            weightFld.Enabled = hasWeightFld.Checked;
            if (hasWeightFld.Checked)
            {
                var rnd = new Random();
                weightFld.Value = rnd.Next(1, 30);
                editEdge.Weight = (int)weightFld.Value;
            }
        }

        private void weightFld_ValueChanged(object sender, EventArgs e)
        {
            editEdge.Weight = (int)weightFld.Value;
        }

        private void hasDirectionFld_Click(object sender, EventArgs e)
        {
            editEdge.HasDirection = hasDirectionFld.Checked;
            reverseBtn.Enabled = hasDirectionFld.Checked;
            InstallFormText();
        }

        private void reverseBtn_Click(object sender, EventArgs e)
        {
            editEdge.ReverseDirection();
            InstallFormText();
        }

        private void lineColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lineColorBtn.BackColor = colorDialog.Color;
                editEdge.Style.LineColor = colorDialog.Color;
            }
        }

        private void textColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textColorBtn.BackColor = colorDialog.Color;
                editEdge.Style.TextColor = colorDialog.Color;
            }
        }

        private void lineWidthLbl_SelectedIndexChanged(object sender, EventArgs e)
        {
            editEdge.Style.LineWidth = lineWidthLbl.SelectedIndex + 1;
        }
    }
}
