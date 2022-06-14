namespace GerenciadorDeTarefa.UI.Contador
{
    partial class FormTarefa
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

        //#region Windows Form Designer generated code

        ///// <summary>
        ///// Required method for Designer support - do not modify
        ///// the contents of this method with the code editor.
        ///// </summary>
        //private void InitializeComponent()
        //{
        //    this.components = new System.ComponentModel.Container();
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(800, 450);
        //}

        //#endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTarefa));
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lbHoraTrabalhada = new System.Windows.Forms.Label();
            this.lbEntrada1 = new System.Windows.Forms.Label();
            this.lbEntrada2 = new System.Windows.Forms.Label();
            this.lbEntrada3 = new System.Windows.Forms.Label();
            this.lbSaida1 = new System.Windows.Forms.Label();
            this.lbSaida2 = new System.Windows.Forms.Label();
            this.lbSaida3 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbEntrada = new System.Windows.Forms.Label();
            this.lbSaida = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbTotalHora = new System.Windows.Forms.Label();
            this.lbTarefa = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbIntAlmoco = new System.Windows.Forms.Label();
            this.teIntervalo = new DevExpress.XtraEditors.TimeEdit();
            this.separatorControl4 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl5 = new DevExpress.XtraEditors.SeparatorControl();
            this.TbAnotacao = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsArquivo = new System.Windows.Forms.ToolStripDropDownButton();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNegrito = new System.Windows.Forms.ToolStripButton();
            this.tsItalico = new System.Windows.Forms.ToolStripButton();
            this.tsSublinhado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsCorTexto = new System.Windows.Forms.ToolStripButton();
            this.nUpTamanho = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.teIntervalo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl5)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpTamanho)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrada
            // 
            this.btnEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntrada.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEntrada.Location = new System.Drawing.Point(590, 226);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(53, 25);
            this.btnEntrada.TabIndex = 0;
            this.btnEntrada.Text = "Novo";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(649, 226);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(53, 25);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Titulo";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lbHoraTrabalhada
            // 
            this.lbHoraTrabalhada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHoraTrabalhada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHoraTrabalhada.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbHoraTrabalhada.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbHoraTrabalhada.Location = new System.Drawing.Point(494, 9);
            this.lbHoraTrabalhada.Name = "lbHoraTrabalhada";
            this.lbHoraTrabalhada.Size = new System.Drawing.Size(208, 22);
            this.lbHoraTrabalhada.TabIndex = 3;
            this.lbHoraTrabalhada.Text = "Horas Trabalhadas";
            this.lbHoraTrabalhada.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbEntrada1
            // 
            this.lbEntrada1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEntrada1.AutoSize = true;
            this.lbEntrada1.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbEntrada1.Location = new System.Drawing.Point(559, 132);
            this.lbEntrada1.Name = "lbEntrada1";
            this.lbEntrada1.Size = new System.Drawing.Size(45, 19);
            this.lbEntrada1.TabIndex = 5;
            this.lbEntrada1.Text = "00:00";
            // 
            // lbEntrada2
            // 
            this.lbEntrada2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEntrada2.AutoSize = true;
            this.lbEntrada2.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbEntrada2.Location = new System.Drawing.Point(608, 132);
            this.lbEntrada2.Name = "lbEntrada2";
            this.lbEntrada2.Size = new System.Drawing.Size(45, 19);
            this.lbEntrada2.TabIndex = 6;
            this.lbEntrada2.Text = "00:00";
            // 
            // lbEntrada3
            // 
            this.lbEntrada3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEntrada3.AutoSize = true;
            this.lbEntrada3.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbEntrada3.Location = new System.Drawing.Point(657, 132);
            this.lbEntrada3.Name = "lbEntrada3";
            this.lbEntrada3.Size = new System.Drawing.Size(45, 19);
            this.lbEntrada3.TabIndex = 7;
            this.lbEntrada3.Text = "00:00";
            // 
            // lbSaida1
            // 
            this.lbSaida1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSaida1.AutoSize = true;
            this.lbSaida1.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbSaida1.Location = new System.Drawing.Point(559, 180);
            this.lbSaida1.Name = "lbSaida1";
            this.lbSaida1.Size = new System.Drawing.Size(45, 19);
            this.lbSaida1.TabIndex = 8;
            this.lbSaida1.Text = "00:00";
            // 
            // lbSaida2
            // 
            this.lbSaida2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSaida2.AutoSize = true;
            this.lbSaida2.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbSaida2.Location = new System.Drawing.Point(608, 180);
            this.lbSaida2.Name = "lbSaida2";
            this.lbSaida2.Size = new System.Drawing.Size(45, 19);
            this.lbSaida2.TabIndex = 9;
            this.lbSaida2.Text = "00:00";
            // 
            // lbSaida3
            // 
            this.lbSaida3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSaida3.AutoSize = true;
            this.lbSaida3.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbSaida3.Location = new System.Drawing.Point(657, 180);
            this.lbSaida3.Name = "lbSaida3";
            this.lbSaida3.Size = new System.Drawing.Size(45, 19);
            this.lbSaida3.TabIndex = 10;
            this.lbSaida3.Text = "00:00";
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbTotal.Location = new System.Drawing.Point(625, 275);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(46, 14);
            this.lbTotal.TabIndex = 11;
            this.lbTotal.Text = "TOTAL:";
            // 
            // lbEntrada
            // 
            this.lbEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEntrada.AutoSize = true;
            this.lbEntrada.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbEntrada.Location = new System.Drawing.Point(494, 132);
            this.lbEntrada.Name = "lbEntrada";
            this.lbEntrada.Size = new System.Drawing.Size(61, 19);
            this.lbEntrada.TabIndex = 15;
            this.lbEntrada.Text = "Entrada:";
            // 
            // lbSaida
            // 
            this.lbSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSaida.AutoSize = true;
            this.lbSaida.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbSaida.Location = new System.Drawing.Point(494, 180);
            this.lbSaida.Name = "lbSaida";
            this.lbSaida.Size = new System.Drawing.Size(45, 19);
            this.lbSaida.TabIndex = 16;
            this.lbSaida.Text = "Saida:";
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo.Location = new System.Drawing.Point(494, 49);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(53, 19);
            this.lbTitulo.TabIndex = 17;
            this.lbTitulo.Text = "Tarefa:";
            // 
            // lbTotalHora
            // 
            this.lbTotalHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalHora.AutoSize = true;
            this.lbTotalHora.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbTotalHora.Location = new System.Drawing.Point(668, 274);
            this.lbTotalHora.Name = "lbTotalHora";
            this.lbTotalHora.Size = new System.Drawing.Size(34, 16);
            this.lbTotalHora.TabIndex = 18;
            this.lbTotalHora.Text = "00:00";
            // 
            // lbTarefa
            // 
            this.lbTarefa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTarefa.Font = new System.Drawing.Font("Sylfaen", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbTarefa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTarefa.Location = new System.Drawing.Point(553, 49);
            this.lbTarefa.Name = "lbTarefa";
            this.lbTarefa.Size = new System.Drawing.Size(149, 54);
            this.lbTarefa.TabIndex = 19;
            this.lbTarefa.Text = "________________________________________________________";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbIntAlmoco
            // 
            this.lbIntAlmoco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIntAlmoco.AutoSize = true;
            this.lbIntAlmoco.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbIntAlmoco.Location = new System.Drawing.Point(494, 274);
            this.lbIntAlmoco.Name = "lbIntAlmoco";
            this.lbIntAlmoco.Size = new System.Drawing.Size(62, 18);
            this.lbIntAlmoco.TabIndex = 26;
            this.lbIntAlmoco.Text = "Intervalo:";
            // 
            // teIntervalo
            // 
            this.teIntervalo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teIntervalo.EditValue = new System.DateTime(2022, 6, 14, 0, 0, 0, 0);
            this.teIntervalo.Location = new System.Drawing.Point(556, 272);
            this.teIntervalo.Name = "teIntervalo";
            this.teIntervalo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teIntervalo.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.teIntervalo.Size = new System.Drawing.Size(67, 20);
            this.teIntervalo.TabIndex = 28;
            this.teIntervalo.EditValueChanged += new System.EventHandler(this.teIntervalo_EditValueChanged);
            // 
            // separatorControl4
            // 
            this.separatorControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl4.Location = new System.Drawing.Point(484, 251);
            this.separatorControl4.Name = "separatorControl4";
            this.separatorControl4.Size = new System.Drawing.Size(229, 18);
            this.separatorControl4.TabIndex = 35;
            // 
            // separatorControl3
            // 
            this.separatorControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl3.Location = new System.Drawing.Point(481, 299);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Size = new System.Drawing.Size(232, 18);
            this.separatorControl3.TabIndex = 36;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl1.Location = new System.Drawing.Point(484, 106);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(229, 18);
            this.separatorControl1.TabIndex = 37;
            // 
            // separatorControl2
            // 
            this.separatorControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl2.Location = new System.Drawing.Point(484, 202);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(229, 18);
            this.separatorControl2.TabIndex = 38;
            // 
            // separatorControl5
            // 
            this.separatorControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl5.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.separatorControl5.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl5.Location = new System.Drawing.Point(469, 2);
            this.separatorControl5.Name = "separatorControl5";
            this.separatorControl5.Size = new System.Drawing.Size(19, 320);
            this.separatorControl5.TabIndex = 39;
            // 
            // TbAnotacao
            // 
            this.TbAnotacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbAnotacao.Location = new System.Drawing.Point(2, 30);
            this.TbAnotacao.Multiline = true;
            this.TbAnotacao.Name = "TbAnotacao";
            this.TbAnotacao.Size = new System.Drawing.Size(463, 290);
            this.TbAnotacao.TabIndex = 40;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsArquivo,
            this.tsNegrito,
            this.tsItalico,
            this.tsSublinhado,
            this.toolStripSeparator1,
            this.tsCorTexto});
            this.toolStrip1.Location = new System.Drawing.Point(0, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(139, 25);
            this.toolStrip1.TabIndex = 41;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsArquivo
            // 
            this.tsArquivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.salvarComoToolStripMenuItem});
            this.tsArquivo.Image = ((System.Drawing.Image)(resources.GetObject("tsArquivo.Image")));
            this.tsArquivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsArquivo.Name = "tsArquivo";
            this.tsArquivo.Size = new System.Drawing.Size(29, 22);
            this.tsArquivo.Text = "toolStripDropDownButton1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.SalvarToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar Como";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.SalvarComoToolStripMenuItem_Click);
            // 
            // tsNegrito
            // 
            this.tsNegrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNegrito.Image = ((System.Drawing.Image)(resources.GetObject("tsNegrito.Image")));
            this.tsNegrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNegrito.Name = "tsNegrito";
            this.tsNegrito.Size = new System.Drawing.Size(23, 22);
            this.tsNegrito.Text = "toolStripButton1";
            this.tsNegrito.Click += new System.EventHandler(this.TsNegrito_Click);
            // 
            // tsItalico
            // 
            this.tsItalico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsItalico.Image = ((System.Drawing.Image)(resources.GetObject("tsItalico.Image")));
            this.tsItalico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsItalico.Name = "tsItalico";
            this.tsItalico.Size = new System.Drawing.Size(23, 22);
            this.tsItalico.Text = "toolStripButton2";
            this.tsItalico.Click += new System.EventHandler(this.TsItalico_Click);
            // 
            // tsSublinhado
            // 
            this.tsSublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSublinhado.Image = ((System.Drawing.Image)(resources.GetObject("tsSublinhado.Image")));
            this.tsSublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSublinhado.Name = "tsSublinhado";
            this.tsSublinhado.Size = new System.Drawing.Size(23, 22);
            this.tsSublinhado.Text = "toolStripButton3";
            this.tsSublinhado.Click += new System.EventHandler(this.TsSublinhado_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsCorTexto
            // 
            this.tsCorTexto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCorTexto.Image = ((System.Drawing.Image)(resources.GetObject("tsCorTexto.Image")));
            this.tsCorTexto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCorTexto.Name = "tsCorTexto";
            this.tsCorTexto.Size = new System.Drawing.Size(23, 22);
            this.tsCorTexto.Text = "toolStripButton4";
            this.tsCorTexto.Click += new System.EventHandler(this.TsCorTexto_Click);
            // 
            // nUpTamanho
            // 
            this.nUpTamanho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nUpTamanho.Location = new System.Drawing.Point(142, 4);
            this.nUpTamanho.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.nUpTamanho.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUpTamanho.Name = "nUpTamanho";
            this.nUpTamanho.Size = new System.Drawing.Size(48, 23);
            this.nUpTamanho.TabIndex = 42;
            this.nUpTamanho.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(714, 322);
            this.Controls.Add(this.nUpTamanho);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.TbAnotacao);
            this.Controls.Add(this.separatorControl5);
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.separatorControl3);
            this.Controls.Add(this.separatorControl4);
            this.Controls.Add(this.teIntervalo);
            this.Controls.Add(this.lbIntAlmoco);
            this.Controls.Add(this.lbTarefa);
            this.Controls.Add(this.lbTotalHora);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.lbSaida);
            this.Controls.Add(this.lbEntrada);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbSaida3);
            this.Controls.Add(this.lbSaida2);
            this.Controls.Add(this.lbSaida1);
            this.Controls.Add(this.lbEntrada3);
            this.Controls.Add(this.lbEntrada2);
            this.Controls.Add(this.lbEntrada1);
            this.Controls.Add(this.lbHoraTrabalhada);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEntrada);
            this.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormTarefa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerente de Horas";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTarefa_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.teIntervalo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl5)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpTamanho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lbHoraTrabalhada;
        private System.Windows.Forms.Label lbEntrada1;
        private System.Windows.Forms.Label lbEntrada2;
        private System.Windows.Forms.Label lbEntrada3;
        private System.Windows.Forms.Label lbSaida1;
        private System.Windows.Forms.Label lbSaida2;
        private System.Windows.Forms.Label lbSaida3;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbEntrada;
        private System.Windows.Forms.Label lbSaida;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbTotalHora;
        private System.Windows.Forms.Label lbTarefa;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbIntAlmoco;
        private DevExpress.XtraEditors.TimeEdit teIntervalo;
        private DevExpress.XtraEditors.SeparatorControl separatorControl4;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl5;
        private System.Windows.Forms.TextBox TbAnotacao;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsArquivo;
     
        private System.Windows.Forms.ToolStripButton tsNegrito;
        private System.Windows.Forms.ToolStripButton tsItalico;
        private System.Windows.Forms.ToolStripButton tsSublinhado;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsCorTexto;
        private System.Windows.Forms.NumericUpDown nUpTamanho;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
    }
}