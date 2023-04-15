using Aspose.Svg;
using Svg;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Search_Tree
{
    public partial class ABB : Form
    {
        private BinarySearchTree<Object> tree = new();
        private SVGDocument document = null;
        private Aspose.Svg.Collections.HTMLCollection svgNodes;
        private SvgDocument svgTree = null;
        private bool dragging;
        private int xPos;
        private int yPos;

        public ABB()
        {
            try
            {
                svgTree = SvgDocument.Open<SvgDocument>("Dibujo/Figura.svg", null);
                document = new SVGDocument("Dibujo/Figura.svg");
                svgNodes = document.DocumentElement.GetElementsByClassName("node");

                foreach (SVGGElement element in svgNodes)
                {
                    SvgElementCollection childrens = svgTree.GetElementById(element.Id).Children;
                    childrens.GetSvgElementOf<SvgEllipse>();
                    Aspose.Svg.DataTypes.SVGRect nodeBox = element.GetBBox();
                }
            }
            catch (Exception)
            {
            }
            InitializeComponent();
        }

        public void UpdateFields()
        {
            tree.CreateDotFile();
            svgTree = SvgDocument.Open<SvgDocument>("Dibujo/Figura.svg", null);
            document = new SVGDocument("Dibujo/Figura.svg");

            svgNodes = document.DocumentElement.GetElementsByClassName("node");

            CenterTreeView();
            PicboxTree.Image = svgTree.Draw();
            PicboxTree.Refresh();

            UpdateTable();
        }

        public void CenterTreeView()
        {
            PicboxTree.Left = (PicboxTree.Parent.Width - PicboxTree.Width) / 2;
            PicboxTree.Top = (PicboxTree.Parent.Height - PicboxTree.Height) / 2;
        }

        private void UpdateTable()
        {
            dtgTable.Rows.Clear();

            foreach (Object obj in rbtnPreorder.Checked ? tree.Preorder() : rbtnPostorder.Checked ? tree.Postorder() : tree.Inorder())
            {
                dtgTable.Rows.Add(obj.Id);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields(pnlControles.Panel1)) return;

            Object obj = new()
            {
                Id = nudId.Value.ToString(),
            };
            try
            {
                tree.Add(obj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            ResetFields(pnlData);
            UpdateFields();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure that you want to clear the tree? This action will remove all the nodes.", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No) return;

            tree.Clear();

            UpdateFields();
            PicboxTree.Image = null;
            ResetFields(pnlControles.Panel1);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (dtgTable.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = dtgTable.Rows[dtgTable.SelectedCells[0].RowIndex];
                Object obj = new()
                {
                    Id = selectedRow.Cells["Id"].Value.ToString(),
                };
                DialogResult dialogResult = MessageBox.Show($"Remove element {obj}?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No) return;

                tree.Remove(obj);
            }
            UpdateFields();
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            Random random = new();
            for (int i = 0; i < 10; i++)
            {
                Object obj = new()
                {
                    Id = random.Next(1, 10000).ToString(),
                };

                try
                {
                    tree.Add(obj);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    continue;
                }

                ResetFields(pnlControles.Panel1);
            }
            UpdateFields();
        }

        private void BtnRestoreView_Click(object sender, EventArgs e)
        {
            CenterTreeView();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Object obj;
            obj = Search(new() { Id = nudSearchId.Value.ToString() });

            if (obj == null)
            {
                MessageBox.Show("The element is not in the tree", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            dtgTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow row in dtgTable.Rows)
            {
                if (row.Cells["Id"].Value.ToString() == obj.Id.ToString())
                {
                    row.Selected = true;
                    break;
                }
            }
            MessageBox.Show($"Element {obj} found.");
        }

        private Object Search(Object obj)
        {
            obj = tree.Search(obj);
            if (obj == null) return default;

            nudId.Value = decimal.Parse(obj.Id);
            return obj;
        }

        private void DtgTable_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgTable.SelectedCells.Count <= 0) return;
            DataGridViewRow selectedRow = dtgTable.Rows[dtgTable.SelectedCells[0].RowIndex];
            Object obj = Search(new() { Id = selectedRow.Cells["Id"].Value.ToString() });

            foreach (SVGGElement element in svgNodes)
            {
                var childrens = svgTree.GetElementById(element.Id).Children;
                var elipse = childrens.GetSvgElementOf<SvgEllipse>();
                if (element.Id == obj.Id.ToString())
                {
                    elipse.Fill = new SvgColourServer(Color.FromArgb(94, 129, 172));
                }
                else
                {
                    elipse.Fill = new SvgColourServer(Color.Transparent);
                }
            }

            PicboxTree.Image = svgTree.Draw();
            PicboxTree.Refresh();
        }

        private void PicboxTree_Click(object sender, EventArgs e)
        {
            if (tree.Empty) return;

            MouseEventArgs me = (MouseEventArgs)e;
            double cx = me.X * .75 - 3;
            double cy = me.Y * .75 - (svgTree.Height - 4) * .75;

            foreach (SVGGElement element in svgNodes)
            {
                SvgElementCollection childrens = svgTree.GetElementById(element.Id).Children;
                SvgEllipse elipse = childrens.GetSvgElementOf<SvgEllipse>();

                Aspose.Svg.DataTypes.SVGRect nodeBox = element.GetBBox();
                if (cx > nodeBox.X && cx < nodeBox.X + nodeBox.Width && cy > nodeBox.Y && cy < nodeBox.Y + nodeBox.Height)
                {
                    elipse.Fill = new SvgColourServer(Color.FromArgb(94, 129, 172));
                    Search(new Object { Id = element.Id });
                    dtgTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    foreach (DataGridViewRow row in dtgTable.Rows)
                    {
                        if (row.Cells["Id"].Value.ToString() == element.Id.ToString())
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                    break;
                }
                else
                {
                    elipse.Fill = new SvgColourServer(Color.Transparent);
                }
            }

            PicboxTree.Image = svgTree.Draw();
            PicboxTree.Refresh();
        }

        private void PicboxTree_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                xPos = e.X;
                yPos = e.Y;
            }
        }

        private void PicboxTree_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging && sender is Control c)
            {
                c.Top = e.Y + c.Top - yPos;
                c.Left = e.X + +c.Left - xPos;
            }
        }

        private void PicboxTree_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void RbtnInOrden_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void RbtnPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void RbtnPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void ResetFields(Panel pnlData)
        {
            foreach (Control control in pnlData.Controls)
            {
                NumericUpDown nud = control as NumericUpDown;
                if (control is TextBox || control is ComboBox) control.Text = "";
                if (control is NumericUpDown) nud.Value = 0;
            }
        }

        private bool ValidateFields(Panel pnlData)
        {
            foreach (Control control in pnlData.Controls)
            {
                NumericUpDown nud = control as NumericUpDown;
                if (control.Text.Trim() == "")
                {
                    if (control is PictureBox) continue;
                    if (control is Panel) continue;
                    MessageBox.Show("All fields are required");
                    return false;
                }
                if (control is NumericUpDown && nud.Value <= 0)
                {
                    MessageBox.Show("Verify numeric fields");
                    return false;
                }
            }
            return true;
        }

        private bool isExecuting;

        private async void BtnRecorrido_Click(object sender, EventArgs e)
        {
            if (isExecuting) return;

            foreach (DataGridViewRow row in dtgTable.Rows)
            {
                isExecuting = true;
                row.Selected = true;
                await Task.Delay(800);
            }
            isExecuting = false;
        }
    }
}