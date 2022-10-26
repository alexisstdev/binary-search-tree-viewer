using Svg;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Arbol_Binario_Busqueda
{
    public partial class ABB : Form
    {
        private ArbolBB<AccesorioNadador> arbol = new();
        private bool dragging;
        private int xPos;
        private int yPos;

        public ABB()
        {
            InitializeComponent();
        }

        public void ActualizarArbol()
        {
            PicboxTree.Image = null;
            PicboxTree.SizeMode = PictureBoxSizeMode.AutoSize;

            arbol.CrearArchivoDot();

            /* using (StreamReader sr = new StreamReader("Figura/Figura.svg"))
             {
                 string svg = sr.ReadToEnd();
                 using (StreamWriter sw = new StreamWriter("Figura/Figura.svg"))
                 {
                     svg.
                     sw.Write(svg);
                 }
             }*/

            var arbolSvg = SvgDocument.Open<SvgDocument>("Figura/Figura.svg", null);
            try
            {
                PicboxTree.Image = arbolSvg.Draw();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            PicboxTree.Refresh();
        }

        private void ActualizarTabla()
        {
            dtgTabla.Rows.Clear();

            foreach (var accesorio in rbtnPreOrden.Checked ? arbol.PreOrden() : rbtnPostOrden.Checked ? arbol.PostOrden() : arbol.InOrden())
            {
                dtgTabla.Rows.Add(
                    accesorio.Nombre,
                    accesorio.Id,
                    accesorio.Categoria,
                    accesorio.Precio.ToString("C"),
                    accesorio.Stock,
                    accesorio.Ajustable ? "Si" : "No",
                    accesorio.Talla,
                    accesorio.Material,
                    accesorio.FechaCompra.ToShortDateString());
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos(pnlAccesoryData)) return;

            string material = null;
            if (rbtnlicra.Checked) material = rbtnlicra.Text;
            if (rbtnPlastico.Checked) material = rbtnPlastico.Text;
            if (rbtnAlgodon.Checked) material = rbtnAlgodon.Text;

            AccesorioNadador accesorio = new AccesorioNadador
            {
                Nombre = txtNombre.Text,
                Id = (int)nudId.Value,
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

            ResetControls(pnlAccesoryData);
            ActualizarTabla();
            ActualizarArbol();
            MessageBox.Show($"El accesorio con ID {accesorio} Ha sido agregado correctamente", "Inserción exitosa");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"¿Seguro que desea vaciar el arbol? Esta acción eliminará todos los elementos.", "Vaciar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No) return;
            try
            {
                arbol.Vaciar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ActualizarTabla();
            ActualizarArbol();
            ResetControls(pnlAccesoryData);
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            var arbolSvg = SvgDocument.Open<SvgDocument>("Figura/Figura.svg", null);
            try
            {
                PicboxTree.Image = arbolSvg.Draw();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            PicboxTree.Refresh();
            //ActualizarArbol();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            /*if (dtgTabla.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = dtgTabla.Rows[dtgTabla.SelectedCells[0].RowIndex];
                AccesorioNadador accesory = new AccesorioNadador
                {
                    Id = (int)selectedRow.Cells["Id"].Value,
                };
                DialogResult dialogResult = MessageBox.Show($"Seguro que desea eliminar el accesorio con Id: {accesory.Id}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No) return;

                accesory = arbol.Eliminar(accesory);
                MessageBox.Show($"El accesorio{accesory}Ha sido eliminado", "Eliminación confirmada");
            }
            UpdateDataGrid();*/
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
            for (int i = 0; i < 20; i++)
            {
                cbxCategoria.SelectedIndex = random.Next(0, 4);
                cbxTalla.SelectedIndex = random.Next(0, 4);
                int num = random.Next(1, 4);
                string material = null;
                if (num == 1) material = rbtnPlastico.Text;
                if (num == 2) material = rbtnlicra.Text;
                if (num == 3) material = rbtnAlgodon.Text;

                AccesorioNadador accesorio = new AccesorioNadador
                {
                    Nombre = nombresAccesorios[random.Next(nombresAccesorios.Length)],
                    Id = random.Next(1, 10000),
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
                    MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                ResetControls(pnlAccesoryData);
            }
            ActualizarArbol();
            ActualizarTabla();
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
            nudId.Value = accesorio.Id;
            cbxCategoria.Text = accesorio.Categoria.ToString();
            nudPrecio.Value = (decimal)accesorio.Precio;
            dtpFechaCompra.Value = accesorio.FechaCompra;
            nudStock.Value = accesorio.Stock;
            chbxAjustable.Checked = accesorio.Ajustable;
            cbxTalla.Text = accesorio.Talla;

            picImagen.ImageLocation = accesorio.RutaImagen;
            picImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagen.Refresh();

            if (accesorio.Material == "Licra") rbtnlicra.Checked = true;
            if (accesorio.Material == "Plástico") rbtnPlastico.Checked = true;
            if (accesorio.Material == "Algodón") rbtnAlgodon.Checked = true;

            return accesorio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void DtgTabla_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgTabla.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = dtgTabla.Rows[dtgTabla.SelectedCells[0].RowIndex];
                AccesorioNadador accesorio = new()
                {
                    Id = (int)selectedRow.Cells["Id"].Value,
                };
                Buscar(accesorio);
            }
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

        private void RbtnPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void RbtnPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void ResetControls(Panel pnlData)
        {
            foreach (Control control in pnlData.Controls)
            {
                NumericUpDown nud = control as NumericUpDown;
                if (control is TextBox || control is ComboBox) control.Text = null;
                if (control is NumericUpDown) nud.Value = 0;
                picImagen.ImageLocation = null;
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

        private void BtnRestoreView_Click(object sender, EventArgs e)
        {
            PicboxTree.Location = new Point(0, 0);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            AccesorioNadador accesorio = new()
            {
                Id = (int)nudSearchId.Value
            };
            accesorio = Buscar(accesorio);
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

        private void PicboxTree_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            MessageBox.Show(string.Format("X: {0} Y: {1}", (me.X * .75) - 4, (me.Y * .75) - 656));
        }
    }
}