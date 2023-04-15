namespace Binary_Search_Tree
{
    partial class ABB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.SplitContainer();
            this.PicboxTree = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnInOrden = new System.Windows.Forms.RadioButton();
            this.BtnRestoreView = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.rbtnPostorder = new System.Windows.Forms.RadioButton();
            this.BtnRecorrido = new System.Windows.Forms.Button();
            this.rbtnPreorder = new System.Windows.Forms.RadioButton();
            this.pnlControles = new System.Windows.Forms.SplitContainer();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dtgTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.nudSearchId = new System.Windows.Forms.NumericUpDown();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).BeginInit();
            this.pnlContainer.Panel1.SuspendLayout();
            this.pnlContainer.Panel2.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicboxTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControles)).BeginInit();
            this.pnlControles.Panel1.SuspendLayout();
            this.pnlControles.Panel2.SuspendLayout();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTable)).BeginInit();
            this.pnlBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSearchId)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.pnlContainer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30);
            this.panel1.Size = new System.Drawing.Size(1477, 819);
            this.panel1.TabIndex = 144;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(30, 30);
            this.pnlContainer.Name = "pnlContainer";
            // 
            // pnlContainer.Panel1
            // 
            this.pnlContainer.Panel1.Controls.Add(this.pnlControles);
            // 
            // pnlContainer.Panel2
            // 
            this.pnlContainer.Panel2.Controls.Add(this.rbtnPreorder);
            this.pnlContainer.Panel2.Controls.Add(this.BtnRecorrido);
            this.pnlContainer.Panel2.Controls.Add(this.rbtnPostorder);
            this.pnlContainer.Panel2.Controls.Add(this.label13);
            this.pnlContainer.Panel2.Controls.Add(this.BtnRestoreView);
            this.pnlContainer.Panel2.Controls.Add(this.rbtnInOrden);
            this.pnlContainer.Panel2.Controls.Add(this.label1);
            this.pnlContainer.Panel2.Controls.Add(this.PicboxTree);
            this.pnlContainer.Size = new System.Drawing.Size(1417, 759);
            this.pnlContainer.SplitterDistance = 777;
            this.pnlContainer.TabIndex = 192;
            // 
            // PicboxTree
            // 
            this.PicboxTree.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.PicboxTree.Location = new System.Drawing.Point(1, 150);
            this.PicboxTree.Name = "PicboxTree";
            this.PicboxTree.Size = new System.Drawing.Size(628, 604);
            this.PicboxTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicboxTree.TabIndex = 0;
            this.PicboxTree.TabStop = false;
            this.PicboxTree.Click += new System.EventHandler(this.PicboxTree_Click);
            this.PicboxTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicboxTree_MouseDown);
            this.PicboxTree.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicboxTree_MouseMove);
            this.PicboxTree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicboxTree_MouseUp);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(148)))), ((int)(((byte)(162)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 147);
            this.label1.TabIndex = 192;
            // 
            // rbtnInOrden
            // 
            this.rbtnInOrden.AutoSize = true;
            this.rbtnInOrden.BackColor = System.Drawing.Color.Transparent;
            this.rbtnInOrden.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.rbtnInOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.rbtnInOrden.Location = new System.Drawing.Point(20, 115);
            this.rbtnInOrden.Name = "rbtnInOrden";
            this.rbtnInOrden.Size = new System.Drawing.Size(77, 24);
            this.rbtnInOrden.TabIndex = 14;
            this.rbtnInOrden.Text = "Inorder";
            this.rbtnInOrden.UseVisualStyleBackColor = false;
            this.rbtnInOrden.CheckedChanged += new System.EventHandler(this.RbtnInOrden_CheckedChanged);
            // 
            // BtnRestoreView
            // 
            this.BtnRestoreView.AutoSize = true;
            this.BtnRestoreView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BtnRestoreView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestoreView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BtnRestoreView.FlatAppearance.BorderSize = 0;
            this.BtnRestoreView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(74)))));
            this.BtnRestoreView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(74)))));
            this.BtnRestoreView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRestoreView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestoreView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.BtnRestoreView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnRestoreView.Location = new System.Drawing.Point(162, 106);
            this.BtnRestoreView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnRestoreView.Name = "BtnRestoreView";
            this.BtnRestoreView.Size = new System.Drawing.Size(127, 33);
            this.BtnRestoreView.TabIndex = 189;
            this.BtnRestoreView.Text = "Center view";
            this.BtnRestoreView.UseVisualStyleBackColor = false;
            this.BtnRestoreView.Click += new System.EventHandler(this.BtnRestoreView_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(148)))), ((int)(((byte)(162)))));
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(16, 33);
            this.label13.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 19);
            this.label13.TabIndex = 191;
            this.label13.Text = "Traversal";
            // 
            // rbtnPostorder
            // 
            this.rbtnPostorder.AutoSize = true;
            this.rbtnPostorder.BackColor = System.Drawing.Color.Transparent;
            this.rbtnPostorder.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.rbtnPostorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.rbtnPostorder.Location = new System.Drawing.Point(20, 85);
            this.rbtnPostorder.Name = "rbtnPostorder";
            this.rbtnPostorder.Size = new System.Drawing.Size(92, 24);
            this.rbtnPostorder.TabIndex = 13;
            this.rbtnPostorder.Text = "Postorder";
            this.rbtnPostorder.UseVisualStyleBackColor = false;
            this.rbtnPostorder.CheckedChanged += new System.EventHandler(this.RbtnPostOrden_CheckedChanged);
            // 
            // BtnRecorrido
            // 
            this.BtnRecorrido.AutoSize = true;
            this.BtnRecorrido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(129)))), ((int)(((byte)(172)))));
            this.BtnRecorrido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRecorrido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BtnRecorrido.FlatAppearance.BorderSize = 0;
            this.BtnRecorrido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.BtnRecorrido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.BtnRecorrido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecorrido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecorrido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.BtnRecorrido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnRecorrido.Location = new System.Drawing.Point(162, 39);
            this.BtnRecorrido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnRecorrido.Name = "BtnRecorrido";
            this.BtnRecorrido.Size = new System.Drawing.Size(125, 33);
            this.BtnRecorrido.TabIndex = 190;
            this.BtnRecorrido.Text = "View traversal";
            this.BtnRecorrido.UseVisualStyleBackColor = false;
            this.BtnRecorrido.Click += new System.EventHandler(this.BtnRecorrido_Click);
            // 
            // rbtnPreorder
            // 
            this.rbtnPreorder.AutoSize = true;
            this.rbtnPreorder.BackColor = System.Drawing.Color.Transparent;
            this.rbtnPreorder.Checked = true;
            this.rbtnPreorder.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.rbtnPreorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.rbtnPreorder.Location = new System.Drawing.Point(20, 55);
            this.rbtnPreorder.Name = "rbtnPreorder";
            this.rbtnPreorder.Size = new System.Drawing.Size(87, 24);
            this.rbtnPreorder.TabIndex = 12;
            this.rbtnPreorder.TabStop = true;
            this.rbtnPreorder.Text = "Preorder";
            this.rbtnPreorder.UseVisualStyleBackColor = false;
            this.rbtnPreorder.CheckedChanged += new System.EventHandler(this.RbtnPreOrden_CheckedChanged);
            // 
            // pnlControles
            // 
            this.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControles.Location = new System.Drawing.Point(0, 0);
            this.pnlControles.Name = "pnlControles";
            // 
            // pnlControles.Panel1
            // 
            this.pnlControles.Panel1.AutoScroll = true;
            this.pnlControles.Panel1.Controls.Add(this.pnlBuscar);
            this.pnlControles.Panel1.Controls.Add(this.pnlData);
            this.pnlControles.Panel1.Padding = new System.Windows.Forms.Padding(30);
            // 
            // pnlControles.Panel2
            // 
            this.pnlControles.Panel2.Controls.Add(this.label9);
            this.pnlControles.Panel2.Controls.Add(this.btnAdd);
            this.pnlControles.Panel2.Controls.Add(this.nudId);
            this.pnlControles.Panel2.Controls.Add(this.btnPop);
            this.pnlControles.Panel2.Controls.Add(this.btnRandom);
            this.pnlControles.Panel2.Controls.Add(this.label3);
            this.pnlControles.Panel2.Controls.Add(this.btnClear);
            this.pnlControles.Panel2.Padding = new System.Windows.Forms.Padding(30, 35, 30, 30);
            this.pnlControles.Size = new System.Drawing.Size(777, 759);
            this.pnlControles.SplitterDistance = 259;
            this.pnlControles.TabIndex = 192;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(97)))), ((int)(((byte)(106)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(87)))), ((int)(((byte)(95)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.btnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClear.Location = new System.Drawing.Point(278, 176);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(159, 33);
            this.btnClear.TabIndex = 163;
            this.btnClear.Text = "Clear nodes";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(148)))), ((int)(((byte)(162)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(141, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 19);
            this.label3.TabIndex = 158;
            this.label3.Text = "Id";
            // 
            // btnRandom
            // 
            this.btnRandom.AutoSize = true;
            this.btnRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(129)))), ((int)(((byte)(172)))));
            this.btnRandom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRandom.FlatAppearance.BorderSize = 0;
            this.btnRandom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.btnRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.btnRandom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRandom.Location = new System.Drawing.Point(68, 243);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(159, 33);
            this.btnRandom.TabIndex = 17;
            this.btnRandom.Text = "Generate nodes";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // btnPop
            // 
            this.btnPop.AutoSize = true;
            this.btnPop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(97)))), ((int)(((byte)(106)))));
            this.btnPop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPop.FlatAppearance.BorderSize = 0;
            this.btnPop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.btnPop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPop.Location = new System.Drawing.Point(278, 243);
            this.btnPop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(159, 33);
            this.btnPop.TabIndex = 186;
            this.btnPop.Text = "Remove";
            this.btnPop.UseVisualStyleBackColor = false;
            this.btnPop.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // nudId
            // 
            this.nudId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.nudId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.nudId.Location = new System.Drawing.Point(172, 113);
            this.nudId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudId.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(159, 25);
            this.nudId.TabIndex = 1;
            this.nudId.Tag = "";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(129)))), ((int)(((byte)(172)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(68, 176);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 33);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(30, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(452, 30);
            this.label9.TabIndex = 188;
            this.label9.Text = "Binary Search Tree";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlData
            // 
            this.pnlData.AutoScroll = true;
            this.pnlData.Controls.Add(this.dtgTable);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(30, 30);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(197, 697);
            this.pnlData.TabIndex = 192;
            // 
            // dtgTable
            // 
            this.dtgTable.AllowUserToAddRows = false;
            this.dtgTable.AllowUserToDeleteRows = false;
            this.dtgTable.AllowUserToResizeColumns = false;
            this.dtgTable.AllowUserToResizeRows = false;
            this.dtgTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.dtgTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(148)))), ((int)(((byte)(162)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgTable.EnableHeadersVisualStyles = false;
            this.dtgTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.dtgTable.Location = new System.Drawing.Point(0, 0);
            this.dtgTable.Margin = new System.Windows.Forms.Padding(20, 21, 20, 21);
            this.dtgTable.MultiSelect = false;
            this.dtgTable.Name = "dtgTable";
            this.dtgTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgTable.RowHeadersVisible = false;
            this.dtgTable.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            this.dtgTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTable.ShowCellErrors = false;
            this.dtgTable.ShowCellToolTips = false;
            this.dtgTable.ShowEditingIcon = false;
            this.dtgTable.ShowRowErrors = false;
            this.dtgTable.Size = new System.Drawing.Size(197, 697);
            this.dtgTable.TabIndex = 148;
            this.dtgTable.SelectionChanged += new System.EventHandler(this.DtgTable_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.Controls.Add(this.btnSearch);
            this.pnlBuscar.Controls.Add(this.nudSearchId);
            this.pnlBuscar.Location = new System.Drawing.Point(18, 714);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(216, 26);
            this.pnlBuscar.TabIndex = 192;
            // 
            // nudSearchId
            // 
            this.nudSearchId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.nudSearchId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudSearchId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudSearchId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSearchId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.nudSearchId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nudSearchId.Location = new System.Drawing.Point(0, 0);
            this.nudSearchId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSearchId.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudSearchId.Name = "nudSearchId";
            this.nudSearchId.Size = new System.Drawing.Size(216, 25);
            this.nudSearchId.TabIndex = 188;
            this.nudSearchId.Tag = "";
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(74)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(74)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(57, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(159, 26);
            this.btnSearch.TabIndex = 188;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1477, 819);
            this.panelContainer.TabIndex = 153;
            // 
            // ABB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1477, 819);
            this.Controls.Add(this.panelContainer);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ABB";
            this.Text = "ABB";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.pnlContainer.Panel1.ResumeLayout(false);
            this.pnlContainer.Panel2.ResumeLayout(false);
            this.pnlContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicboxTree)).EndInit();
            this.pnlControles.Panel1.ResumeLayout(false);
            this.pnlControles.Panel2.ResumeLayout(false);
            this.pnlControles.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControles)).EndInit();
            this.pnlControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTable)).EndInit();
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSearchId)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer pnlContainer;
        private System.Windows.Forms.SplitContainer pnlControles;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.NumericUpDown nudSearchId;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dtgTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudId;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rbtnPreorder;
        private System.Windows.Forms.Button BtnRecorrido;
        private System.Windows.Forms.RadioButton rbtnPostorder;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnRestoreView;
        private System.Windows.Forms.RadioButton rbtnInOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicboxTree;
        private System.Windows.Forms.Panel panelContainer;
    }
}

