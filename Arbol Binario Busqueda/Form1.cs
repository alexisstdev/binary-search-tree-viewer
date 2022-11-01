using Aspose.Svg;
using Svg;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_Binario_Busqueda
{
    public partial class ABB : Form
    {
        private ArbolBB<AccesorioNadador> arbol = new();
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

        public void ActualizarControles()
        {
            arbol.CrearArchivoDot();
            svgTree = SvgDocument.Open<SvgDocument>("Dibujo/Figura.svg", null);
            document = new SVGDocument("Dibujo/Figura.svg");

            svgNodes = document.DocumentElement.GetElementsByClassName("node");

            CentralizarArbolSvg();
            PicboxTree.Image = svgTree.Draw();
            PicboxTree.Refresh();

            ActualizarTabla();
        }

        public void CentralizarArbolSvg()
        {
            PicboxTree.Left = (PicboxTree.Parent.Width - PicboxTree.Width) / 2;
            PicboxTree.Top = (PicboxTree.Parent.Height - PicboxTree.Height) / 2;
        }

        private void ActualizarTabla()
        {
            dtgTabla.Rows.Clear();

            foreach (AccesorioNadador accesorio in rbtnPreOrden.Checked ? arbol.PreOrden() : rbtnPostOrden.Checked ? arbol.PostOrden() : arbol.InOrden())
            {
                dtgTabla.Rows.Add(accesorio.Nombre, accesorio.Id, accesorio.Categoria, accesorio.Precio.ToString("C"), accesorio.Stock, accesorio.Ajustable, accesorio.Talla, accesorio.Material, accesorio.FechaCompra.ToShortDateString());
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos(pnlDatos)) return;

            string material = null;
            if (rbtnlicra.Checked) material = rbtnlicra.Text;
            if (rbtnPlastico.Checked) material = rbtnPlastico.Text;
            if (rbtnAlgodon.Checked) material = rbtnAlgodon.Text;

            AccesorioNadador accesorio = new()
            {
                Nombre = txtNombre.Text,
                Id = nudId.Value.ToString(),
                Categoria = char.Parse(cbxCategoria.Text),
                FechaCompra = dtpFechaCompra.Value,
                Precio = (double)nudPrecio.Value,
                Stock = (int)nudStock.Value,
                Ajustable = chbxAjustable.Checked,
                Talla = cbxTalla.Text,
                Material = material,
                RutaImagen = picImagen.ImageLocation,
            };
            try
            {
                arbol.Agregar(accesorio);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            ReiniciarControles(pnlDatos);
            ActualizarControles();
            MessageBox.Show($"El accesorio con ID {accesorio} Ha sido agregado correctamente", "Inserción exitosa");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"¿Seguro que desea vaciar el arbol? Esta acción eliminará todos los elementos.", "Vaciar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No) return;

            arbol.Vaciar();

            ActualizarControles();
            PicboxTree.Image = null;
            ReiniciarControles(pnlControles.Panel1);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            if (arbol.Vacio) return;

            var arbolSvg = SvgDocument.Open<SvgDocument>("Dibujo/Figura.svg", null);
            document = new SVGDocument("Dibujo/Figura.svg");

            PicboxTree.Image = arbolSvg.Draw();
            PicboxTree.Refresh();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgTabla.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = dtgTabla.Rows[dtgTabla.SelectedCells[0].RowIndex];
                AccesorioNadador accesorio = new()
                {
                    Id = selectedRow.Cells["Id"].Value.ToString(),
                };
                DialogResult dialogResult = MessageBox.Show($"Seguro que desea eliminar el accesorio con Id: {accesorio}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No) return;

                arbol.Eliminar(accesorio);
                MessageBox.Show($"El accesorio {accesorio} Ha sido eliminado", "Eliminación confirmada");
            }
            ActualizarControles();
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            Random random = new();
            string[] nombresAccesorios = { "Googgles", "Traje de baño", "Respirador", "Pelota de playa", "Aletas", "Bikini", "Salvavidas", "Traje de buzo" };

            txtNombre.Text = nombresAccesorios[random.Next(nombresAccesorios.Length)];
            nudId.Value = random.Next(1, 10000);
            cbxCategoria.Text = "A";
            chbxAjustable.Checked = random.NextDouble() >= 0.5;
            nudPrecio.Value = (decimal)random.NextDouble() * 1000;
            nudStock.Value = random.Next(1, 300);
            cbxTalla.Text = "M";
            picImagen.ImageLocation = $"../../Public/Images/accesory ({random.Next(1, 17)}).jpg";
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            Random random = new();
            string[] nombresAccesorios = { "Googgles", "Traje de baño", "Respirador", "Pelota de playa", "Aletas", "Bikini", "Salvavidas", "Traje de buzo" };
            for (int i = 0; i < 10; i++)
            {
                cbxCategoria.SelectedIndex = random.Next(0, 4);
                cbxTalla.SelectedIndex = random.Next(0, 4);
                int num = random.Next(1, 4);
                string material = null;
                if (num == 1) material = rbtnPlastico.Text;
                if (num == 2) material = rbtnlicra.Text;
                if (num == 3) material = rbtnAlgodon.Text;

                AccesorioNadador accesorio = new()
                {
                    Nombre = nombresAccesorios[random.Next(nombresAccesorios.Length)],
                    Id = random.Next(1, 10000).ToString(),
                    Categoria = char.Parse(cbxCategoria.Text),
                    Ajustable = random.NextDouble() >= 0.5,
                    FechaCompra = dtpFechaCompra.Value.AddDays(random.Next(999)),
                    Precio = random.NextDouble() * 1000,
                    Stock = random.Next(1, 300),
                    Talla = cbxTalla.Text,
                    Material = material,
                    RutaImagen = $"../../Public/Images/accesory ({random.Next(1, 17)}).jpg",
                };

                try
                {
                    arbol.Agregar(accesorio);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    continue;
                }

                ReiniciarControles(pnlControles.Panel1);
            }
            ActualizarControles();
        }

        private void BtnRestoreView_Click(object sender, EventArgs e)
        {
            CentralizarArbolSvg();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            AccesorioNadador accesorio;
            accesorio = Buscar(new() { Id = nudSearchId.Value.ToString() });

            if (accesorio == null)
            {
                MessageBox.Show("El accesorio no se encuentra en el arbol", "Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            dtgTabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow row in dtgTabla.Rows)
            {
                if (row.Cells["Id"].Value.ToString() == accesorio.Id.ToString())
                {
                    row.Selected = true;
                    break;
                }
            }
            MessageBox.Show($"Accesorio {accesorio} encontrado. Nombre: {accesorio.Nombre}");
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog myFile = new()
            {
                Title = "Seleccione la imagen que desea cargar",
                Filter = "Archivos JPEG (*.jpg) | *.jpg"
            };
            if (myFile.ShowDialog() != DialogResult.OK) return;
            picImagen.ImageLocation = myFile.FileName;
            picImagen.Refresh();
        }

        private AccesorioNadador Buscar(AccesorioNadador accesorio)
        {
            accesorio = arbol.Buscar(accesorio);
            if (accesorio == null) return default;

            txtNombre.Text = accesorio.Nombre;
            nudId.Value = decimal.Parse(accesorio.Id);
            cbxCategoria.Text = accesorio.Categoria.ToString();
            nudPrecio.Value = (decimal)accesorio.Precio;
            dtpFechaCompra.Value = accesorio.FechaCompra;
            nudStock.Value = accesorio.Stock;
            chbxAjustable.Checked = accesorio.Ajustable;
            cbxTalla.Text = accesorio.Talla;

            picImagen.ImageLocation = accesorio.RutaImagen;
            picImagen.Refresh();

            if (accesorio.Material == "Licra") rbtnlicra.Checked = true;
            if (accesorio.Material == "Plástico") rbtnPlastico.Checked = true;
            if (accesorio.Material == "Algodón") rbtnAlgodon.Checked = true;

            return accesorio;
        }

        private void DtgTabla_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgTabla.SelectedCells.Count <= 0) return;
            DataGridViewRow selectedRow = dtgTabla.Rows[dtgTabla.SelectedCells[0].RowIndex];
            AccesorioNadador accesorio = Buscar(new() { Id = selectedRow.Cells["Id"].Value.ToString() });

            foreach (SVGGElement element in svgNodes)
            {
                var childrens = svgTree.GetElementById(element.Id).Children;
                var elipse = childrens.GetSvgElementOf<SvgEllipse>();
                if (element.Id == accesorio.Id.ToString())
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
            if (arbol.Vacio) return;

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
                    Buscar(new AccesorioNadador { Id = element.Id });
                    dtgTabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    foreach (DataGridViewRow row in dtgTabla.Rows)
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
            ActualizarTabla();
        }

        private void RbtnPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void RbtnPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void ReiniciarControles(Panel pnlData)
        {
            foreach (Control control in pnlData.Controls)
            {
                NumericUpDown nud = control as NumericUpDown;
                if (control is TextBox || control is ComboBox) control.Text = "";
                if (control is NumericUpDown) nud.Value = 0;
                picImagen.ImageLocation = "";
            }
        }

        private bool ValidarDatos(Panel pnlData)
        {
            foreach (Control control in pnlData.Controls)
            {
                NumericUpDown nud = control as NumericUpDown;
                if (control.Text.Trim() == "")
                {
                    if (control is PictureBox) continue;
                    if (control is Panel) continue;
                    MessageBox.Show("Todos los campos son requeridos");
                    return false;
                }
                if (control is NumericUpDown && nud.Value <= 0)
                {
                    MessageBox.Show("Favor de verificar los campos numéricos");
                    return false;
                }
                if (picImagen.ImageLocation == null)
                {
                    MessageBox.Show("Favor de seleccionar una imagen del accesorio");
                    return false;
                }
            }
            return true;
        }

        private bool enEjecucion;

        private async void BtnRecorrido_Click(object sender, EventArgs e)
        {
            if (enEjecucion) return;

            foreach (DataGridViewRow row in dtgTabla.Rows)
            {
                enEjecucion = true;
                row.Selected = true;
                await Task.Delay(800);
            }
            enEjecucion = false;
        }
    }
}