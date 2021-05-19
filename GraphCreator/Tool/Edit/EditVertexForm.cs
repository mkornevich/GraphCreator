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
    public partial class EditVertexForm : Form
    {
        Vertex editVertex;
        public Vertex EditVertex {
            get => editVertex;
            set{
                editVertex = value;
                Fill();
            }
        }

        public Project Project { get; set; }

        public EditVertexForm()
        {
            InitializeComponent();
        }

        private void InstallFormText()
        {
            Text = string.Format("Вершина {0}", editVertex.Index);
        }

        private void Fill()
        {
            InstallFormText();
            indexFld.Value = editVertex.Index;
            errorLbl.Visible = false;

            lineColorBtn.BackColor = editVertex.Style.LineColor;
            textColorBtn.BackColor = editVertex.Style.TextColor;
            lineWidthLbl.SelectedIndex = editVertex.Style.LineWidth - 1;
        }

        private void lineColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lineColorBtn.BackColor = colorDialog.Color;
                editVertex.Style.LineColor = colorDialog.Color;
            }
        }

        private void textColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textColorBtn.BackColor = colorDialog.Color;
                editVertex.Style.TextColor = colorDialog.Color;
            }
        }

        private void lineWidthLbl_SelectedIndexChanged(object sender, EventArgs e)
        {
            editVertex.Style.LineWidth = lineWidthLbl.SelectedIndex + 1;
        }

        private void indexFld_ValueChanged(object sender, EventArgs e)
        {
            int newIndex = (int)indexFld.Value;

            if (Project.Vertexes.Exists(vertex => vertex.Index == newIndex))
            {
                errorLbl.Visible = true;
            } else
            {
                errorLbl.Visible = false;
                editVertex.Index = newIndex;
            }
        }
    }
}
