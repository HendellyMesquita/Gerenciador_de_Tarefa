using System;

namespace GerenciadorDeTarefa.UI
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
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling1 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTarefa));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.spellChecker1 = new DevExpress.XtraSpellChecker.SpellChecker(this.components);
            this.TbAnotacao = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nUpTamanho = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsArquivo = new System.Windows.Forms.ToolStripDropDownButton();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsNovo = new System.Windows.Forms.ToolStripButton();
            this.tsAbrir = new System.Windows.Forms.ToolStripButton();
            this.tsSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsNegrito = new System.Windows.Forms.ToolStripButton();
            this.tsItalico = new System.Windows.Forms.ToolStripButton();
            this.tsSublinhado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsCorTexto = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAlinhaEsquerda = new System.Windows.Forms.ToolStripButton();
            this.tsAlinhaCentro = new System.Windows.Forms.ToolStripButton();
            this.tsAlinhaDireita = new System.Windows.Forms.ToolStripButton();
            this.GerenteContainer = new System.Windows.Forms.SplitContainer();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.HorasContainer = new System.Windows.Forms.SplitContainer();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.lbHoraTrabalhada = new System.Windows.Forms.Label();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.lbSaida3 = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTarefa = new System.Windows.Forms.Label();
            this.lbSaida2 = new System.Windows.Forms.Label();
            this.separatorControl4 = new DevExpress.XtraEditors.SeparatorControl();
            this.lbEntrada = new System.Windows.Forms.Label();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.lbSaida1 = new System.Windows.Forms.Label();
            this.teIntervalo = new DevExpress.XtraEditors.TimeEdit();
            this.lbSaida = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lbEntrada3 = new System.Windows.Forms.Label();
            this.lbIntAlmoco = new System.Windows.Forms.Label();
            this.lbEntrada2 = new System.Windows.Forms.Label();
            this.lbEntrada1 = new System.Windows.Forms.Label();
            this.lbTotalHora = new System.Windows.Forms.Label();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.nUpTamanho)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GerenteContainer)).BeginInit();
            this.GerenteContainer.Panel1.SuspendLayout();
            this.GerenteContainer.Panel2.SuspendLayout();
            this.GerenteContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorasContainer)).BeginInit();
            this.HorasContainer.Panel1.SuspendLayout();
            this.HorasContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teIntervalo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // spellChecker1
            // 
            this.spellChecker1.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.spellChecker1.ParentContainer = null;
            // 
            // TbAnotacao
            // 
            this.TbAnotacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbAnotacao.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbAnotacao.Location = new System.Drawing.Point(3, 35);
            this.TbAnotacao.Name = "TbAnotacao";
            this.TbAnotacao.Size = new System.Drawing.Size(682, 376);
            this.spellChecker1.SetSpellCheckerOptions(this.TbAnotacao, optionsSpelling1);
            this.TbAnotacao.TabIndex = 72;
            this.TbAnotacao.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // nUpTamanho
            // 
            this.nUpTamanho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nUpTamanho.Location = new System.Drawing.Point(307, 7);
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
            this.nUpTamanho.Size = new System.Drawing.Size(63, 23);
            this.nUpTamanho.TabIndex = 71;
            this.nUpTamanho.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nUpTamanho.Click += new System.EventHandler(this.nUpTamanho_ValueChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsArquivo,
            this.toolStripSeparator4,
            this.tsNovo,
            this.tsAbrir,
            this.tsSalvar,
            this.toolStripSeparator3,
            this.tsNegrito,
            this.tsItalico,
            this.tsSublinhado,
            this.toolStripSeparator1,
            this.tsCorTexto,
            this.toolStripSeparator2,
            this.tsAlinhaEsquerda,
            this.tsAlinhaCentro,
            this.tsAlinhaDireita});
            this.toolStrip1.Location = new System.Drawing.Point(9, 6);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(295, 25);
            this.toolStrip1.TabIndex = 70;
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
            this.tsArquivo.Image = global::GerenciadorDeTarefa.UI.Properties.Resources.Gerenciamento;
            this.tsArquivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsArquivo.Name = "tsArquivo";
            this.tsArquivo.Size = new System.Drawing.Size(29, 22);
            this.tsArquivo.Text = "Arquivo";
            this.tsArquivo.ToolTipText = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.SalvarToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar Como";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.SalvarToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsNovo
            // 
            this.tsNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNovo.Image = global::GerenciadorDeTarefa.UI.Properties.Resources.novo_arquivo;
            this.tsNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNovo.Name = "tsNovo";
            this.tsNovo.Size = new System.Drawing.Size(23, 22);
            this.tsNovo.Text = "Novo";
            this.tsNovo.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // tsAbrir
            // 
            this.tsAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAbrir.Image = global::GerenciadorDeTarefa.UI.Properties.Resources.Arquivo;
            this.tsAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAbrir.Name = "tsAbrir";
            this.tsAbrir.Size = new System.Drawing.Size(23, 22);
            this.tsAbrir.Text = "Abrir";
            this.tsAbrir.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // tsSalvar
            // 
            this.tsSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSalvar.Image = global::GerenciadorDeTarefa.UI.Properties.Resources.salve_;
            this.tsSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSalvar.Name = "tsSalvar";
            this.tsSalvar.Size = new System.Drawing.Size(23, 22);
            this.tsSalvar.Text = "Salvar";
            this.tsSalvar.Click += new System.EventHandler(this.SalvarToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsNegrito
            // 
            this.tsNegrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNegrito.Image = global::GerenciadorDeTarefa.UI.Properties.Resources.Negrito;
            this.tsNegrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNegrito.Name = "tsNegrito";
            this.tsNegrito.Size = new System.Drawing.Size(23, 22);
            this.tsNegrito.Text = "Negrito";
            this.tsNegrito.ToolTipText = "Negrito";
            this.tsNegrito.Click += new System.EventHandler(this.tsNegrito_Click);
            // 
            // tsItalico
            // 
            this.tsItalico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsItalico.Image = global::GerenciadorDeTarefa.UI.Properties.Resources.Italico;
            this.tsItalico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsItalico.Name = "tsItalico";
            this.tsItalico.Size = new System.Drawing.Size(23, 22);
            this.tsItalico.Text = "Italico";
            this.tsItalico.Click += new System.EventHandler(this.tsItalico_Click);
            // 
            // tsSublinhado
            // 
            this.tsSublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSublinhado.Image = global::GerenciadorDeTarefa.UI.Properties.Resources.Sublinhado;
            this.tsSublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSublinhado.Name = "tsSublinhado";
            this.tsSublinhado.Size = new System.Drawing.Size(23, 22);
            this.tsSublinhado.Text = "Sublinhado";
            this.tsSublinhado.Click += new System.EventHandler(this.tsSublinhado_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsCorTexto
            // 
            this.tsCorTexto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCorTexto.Image = global::GerenciadorDeTarefa.UI.Properties.Resources.CorDaFonte;
            this.tsCorTexto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCorTexto.Name = "tsCorTexto";
            this.tsCorTexto.Size = new System.Drawing.Size(23, 22);
            this.tsCorTexto.Text = "Cor do Texto";
            this.tsCorTexto.Click += new System.EventHandler(this.TsCorTexto_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsAlinhaEsquerda
            // 
            this.tsAlinhaEsquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAlinhaEsquerda.Image = global::GerenciadorDeTarefa.UI.Properties.Resources.alinhar_a_esquerda;
            this.tsAlinhaEsquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAlinhaEsquerda.Name = "tsAlinhaEsquerda";
            this.tsAlinhaEsquerda.Size = new System.Drawing.Size(23, 22);
            this.tsAlinhaEsquerda.Text = "Alinhar à Esquerda";
            this.tsAlinhaEsquerda.Click += new System.EventHandler(this.tsAlinhaCentro_Click);
            // 
            // tsAlinhaCentro
            // 
            this.tsAlinhaCentro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAlinhaCentro.Image = global::GerenciadorDeTarefa.UI.Properties.Resources.alinhar_centro;
            this.tsAlinhaCentro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAlinhaCentro.Name = "tsAlinhaCentro";
            this.tsAlinhaCentro.Size = new System.Drawing.Size(23, 22);
            this.tsAlinhaCentro.Text = "Centralizar";
            this.tsAlinhaCentro.Click += new System.EventHandler(this.tsAlinhaCentro_Click);
            // 
            // tsAlinhaDireita
            // 
            this.tsAlinhaDireita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAlinhaDireita.Image = global::GerenciadorDeTarefa.UI.Properties.Resources.alinhar_a_esquerda;
            this.tsAlinhaDireita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAlinhaDireita.Name = "tsAlinhaDireita";
            this.tsAlinhaDireita.Size = new System.Drawing.Size(23, 22);
            this.tsAlinhaDireita.Text = "Alinhar à Direita";
            this.tsAlinhaDireita.Click += new System.EventHandler(this.tsAlinhaCentro_Click);
            // 
            // GerenteContainer
            // 
            this.GerenteContainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GerenteContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GerenteContainer.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.GerenteContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GerenteContainer.Location = new System.Drawing.Point(0, 0);
            this.GerenteContainer.Name = "GerenteContainer";
            // 
            // GerenteContainer.Panel1
            // 
            this.GerenteContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.GerenteContainer.Panel1.Controls.Add(this.splitter1);
            this.GerenteContainer.Panel1.Controls.Add(this.toolStrip1);
            this.GerenteContainer.Panel1.Controls.Add(this.nUpTamanho);
            this.GerenteContainer.Panel1.Controls.Add(this.TbAnotacao);
            this.GerenteContainer.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            // 
            // GerenteContainer.Panel2
            // 
            this.GerenteContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.GerenteContainer.Panel2.Controls.Add(this.HorasContainer);
            this.GerenteContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GerenteContainer.Size = new System.Drawing.Size(951, 416);
            this.GerenteContainer.SplitterDistance = 691;
            this.GerenteContainer.SplitterWidth = 3;
            this.GerenteContainer.TabIndex = 105;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(684, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 414);
            this.splitter1.TabIndex = 73;
            this.splitter1.TabStop = false;
            this.splitter1.DoubleClick += new System.EventHandler(this.splitter1_DoubleClick);
            // 
            // HorasContainer
            // 
            this.HorasContainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.HorasContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HorasContainer.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.HorasContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HorasContainer.Location = new System.Drawing.Point(0, 0);
            this.HorasContainer.Name = "HorasContainer";
            this.HorasContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // HorasContainer.Panel1
            // 
            this.HorasContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.HorasContainer.Panel1.Controls.Add(this.lbTitulo);
            this.HorasContainer.Panel1.Controls.Add(this.splitter2);
            this.HorasContainer.Panel1.Controls.Add(this.lbHoraTrabalhada);
            this.HorasContainer.Panel1.Controls.Add(this.separatorControl2);
            this.HorasContainer.Panel1.Controls.Add(this.lbSaida3);
            this.HorasContainer.Panel1.Controls.Add(this.separatorControl1);
            this.HorasContainer.Panel1.Controls.Add(this.lbTotal);
            this.HorasContainer.Panel1.Controls.Add(this.lbTarefa);
            this.HorasContainer.Panel1.Controls.Add(this.lbSaida2);
            this.HorasContainer.Panel1.Controls.Add(this.separatorControl4);
            this.HorasContainer.Panel1.Controls.Add(this.lbEntrada);
            this.HorasContainer.Panel1.Controls.Add(this.btnEntrada);
            this.HorasContainer.Panel1.Controls.Add(this.lbSaida1);
            this.HorasContainer.Panel1.Controls.Add(this.teIntervalo);
            this.HorasContainer.Panel1.Controls.Add(this.lbSaida);
            this.HorasContainer.Panel1.Controls.Add(this.btnEditar);
            this.HorasContainer.Panel1.Controls.Add(this.lbEntrada3);
            this.HorasContainer.Panel1.Controls.Add(this.lbIntAlmoco);
            this.HorasContainer.Panel1.Controls.Add(this.lbEntrada2);
            this.HorasContainer.Panel1.Controls.Add(this.lbEntrada1);
            this.HorasContainer.Panel1.Controls.Add(this.lbTotalHora);
            this.HorasContainer.Panel1.Controls.Add(this.separatorControl3);
            this.HorasContainer.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            // 
            // HorasContainer.Panel2
            // 
            this.HorasContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.HorasContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.HorasContainer.Size = new System.Drawing.Size(257, 416);
            this.HorasContainer.SplitterDistance = 283;
            this.HorasContainer.SplitterWidth = 3;
            this.HorasContainer.TabIndex = 0;
            this.HorasContainer.Panel2Collapsed = true;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo.Location = new System.Drawing.Point(10, 29);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(53, 19);
            this.lbTitulo.TabIndex = 118;
            this.lbTitulo.Text = "Tarefa:";
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 276);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(255, 5);
            this.splitter2.TabIndex = 126;
            this.splitter2.TabStop = false;
            this.splitter2.DoubleClick += new System.EventHandler(this.splitter2_DoubleClick);
            // 
            // lbHoraTrabalhada
            // 
            this.lbHoraTrabalhada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHoraTrabalhada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHoraTrabalhada.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbHoraTrabalhada.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbHoraTrabalhada.Location = new System.Drawing.Point(7, 7);
            this.lbHoraTrabalhada.Name = "lbHoraTrabalhada";
            this.lbHoraTrabalhada.Size = new System.Drawing.Size(241, 22);
            this.lbHoraTrabalhada.TabIndex = 108;
            this.lbHoraTrabalhada.Text = "Horas Trabalhadas";
            this.lbHoraTrabalhada.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // separatorControl2
            // 
            this.separatorControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl2.Location = new System.Drawing.Point(8, 111);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(240, 18);
            this.separatorControl2.TabIndex = 125;
            // 
            // lbSaida3
            // 
            this.lbSaida3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSaida3.AutoSize = true;
            this.lbSaida3.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbSaida3.Location = new System.Drawing.Point(182, 160);
            this.lbSaida3.Name = "lbSaida3";
            this.lbSaida3.Size = new System.Drawing.Size(45, 19);
            this.lbSaida3.TabIndex = 114;
            this.lbSaida3.Text = "00:00";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl1.Location = new System.Drawing.Point(8, 183);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(240, 18);
            this.separatorControl1.TabIndex = 124;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbTotal.Location = new System.Drawing.Point(163, 252);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(41, 18);
            this.lbTotal.TabIndex = 115;
            this.lbTotal.Text = "Total:";
            // 
            // lbTarefa
            // 
            this.lbTarefa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTarefa.Font = new System.Drawing.Font("Sylfaen", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbTarefa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTarefa.Location = new System.Drawing.Point(7, 48);
            this.lbTarefa.Name = "lbTarefa";
            this.lbTarefa.Size = new System.Drawing.Size(241, 60);
            this.lbTarefa.TabIndex = 120;
            this.lbTarefa.Text = resources.GetString("lbTarefa.Text");
            // 
            // lbSaida2
            // 
            this.lbSaida2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSaida2.AutoSize = true;
            this.lbSaida2.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbSaida2.Location = new System.Drawing.Point(133, 160);
            this.lbSaida2.Name = "lbSaida2";
            this.lbSaida2.Size = new System.Drawing.Size(45, 19);
            this.lbSaida2.TabIndex = 113;
            this.lbSaida2.Text = "00:00";
            // 
            // separatorControl4
            // 
            this.separatorControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl4.Location = new System.Drawing.Point(9, 232);
            this.separatorControl4.Name = "separatorControl4";
            this.separatorControl4.Size = new System.Drawing.Size(240, 18);
            this.separatorControl4.TabIndex = 123;
            // 
            // lbEntrada
            // 
            this.lbEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEntrada.AutoSize = true;
            this.lbEntrada.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbEntrada.Location = new System.Drawing.Point(19, 134);
            this.lbEntrada.Name = "lbEntrada";
            this.lbEntrada.Size = new System.Drawing.Size(61, 19);
            this.lbEntrada.TabIndex = 116;
            this.lbEntrada.Text = "Entrada:";
            // 
            // btnEntrada
            // 
            this.btnEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntrada.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEntrada.Location = new System.Drawing.Point(97, 204);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(62, 25);
            this.btnEntrada.TabIndex = 106;
            this.btnEntrada.Text = "Novo";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // lbSaida1
            // 
            this.lbSaida1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSaida1.AutoSize = true;
            this.lbSaida1.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbSaida1.Location = new System.Drawing.Point(84, 160);
            this.lbSaida1.Name = "lbSaida1";
            this.lbSaida1.Size = new System.Drawing.Size(45, 19);
            this.lbSaida1.TabIndex = 112;
            this.lbSaida1.Text = "00:00";
            // 
            // teIntervalo
            // 
            this.teIntervalo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teIntervalo.EditValue = DateTime.Today;
            this.teIntervalo.Location = new System.Drawing.Point(85, 251);
            this.teIntervalo.Name = "teIntervalo";
            this.teIntervalo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teIntervalo.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.teIntervalo.Size = new System.Drawing.Size(76, 20);
            this.teIntervalo.TabIndex = 122;
            this.teIntervalo.EditValueChanged += new System.EventHandler(this.teIntervalo_EditValueChanged);
            // 
            // lbSaida
            // 
            this.lbSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSaida.AutoSize = true;
            this.lbSaida.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbSaida.Location = new System.Drawing.Point(19, 160);
            this.lbSaida.Name = "lbSaida";
            this.lbSaida.Size = new System.Drawing.Size(45, 19);
            this.lbSaida.TabIndex = 117;
            this.lbSaida.Text = "Saida:";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(165, 204);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(62, 25);
            this.btnEditar.TabIndex = 107;
            this.btnEditar.Text = "Titulo";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lbEntrada3
            // 
            this.lbEntrada3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEntrada3.AutoSize = true;
            this.lbEntrada3.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbEntrada3.Location = new System.Drawing.Point(182, 133);
            this.lbEntrada3.Name = "lbEntrada3";
            this.lbEntrada3.Size = new System.Drawing.Size(45, 19);
            this.lbEntrada3.TabIndex = 111;
            this.lbEntrada3.Text = "00:00";
            // 
            // lbIntAlmoco
            // 
            this.lbIntAlmoco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIntAlmoco.AutoSize = true;
            this.lbIntAlmoco.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbIntAlmoco.Location = new System.Drawing.Point(18, 253);
            this.lbIntAlmoco.Name = "lbIntAlmoco";
            this.lbIntAlmoco.Size = new System.Drawing.Size(62, 18);
            this.lbIntAlmoco.TabIndex = 121;
            this.lbIntAlmoco.Text = "Intervalo:";
            // 
            // lbEntrada2
            // 
            this.lbEntrada2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEntrada2.AutoSize = true;
            this.lbEntrada2.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbEntrada2.Location = new System.Drawing.Point(133, 133);
            this.lbEntrada2.Name = "lbEntrada2";
            this.lbEntrada2.Size = new System.Drawing.Size(45, 19);
            this.lbEntrada2.TabIndex = 110;
            this.lbEntrada2.Text = "00:00";
            // 
            // lbEntrada1
            // 
            this.lbEntrada1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEntrada1.AutoSize = true;
            this.lbEntrada1.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbEntrada1.Location = new System.Drawing.Point(84, 133);
            this.lbEntrada1.Name = "lbEntrada1";
            this.lbEntrada1.Size = new System.Drawing.Size(45, 19);
            this.lbEntrada1.TabIndex = 109;
            this.lbEntrada1.Text = "00:00";
            // 
            // lbTotalHora
            // 
            this.lbTotalHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalHora.AutoSize = true;
            this.lbTotalHora.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbTotalHora.Location = new System.Drawing.Point(201, 252);
            this.lbTotalHora.Name = "lbTotalHora";
            this.lbTotalHora.Size = new System.Drawing.Size(40, 18);
            this.lbTotalHora.TabIndex = 119;
            this.lbTotalHora.Text = "00:00";
            // 
            // separatorControl3
            // 
            this.separatorControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl3.Location = new System.Drawing.Point(7, 274);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Size = new System.Drawing.Size(240, 18);
            this.separatorControl3.TabIndex = 127;
            // 
            // FormTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(951, 416);
            this.Controls.Add(this.GerenteContainer);
            this.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerente de Horas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTarefa_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nUpTamanho)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GerenteContainer.Panel1.ResumeLayout(false);
            this.GerenteContainer.Panel1.PerformLayout();
            this.GerenteContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GerenteContainer)).EndInit();
            this.GerenteContainer.ResumeLayout(false);
            this.HorasContainer.Panel1.ResumeLayout(false);
            this.HorasContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorasContainer)).EndInit();
            this.HorasContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teIntervalo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private DevExpress.XtraSpellChecker.SpellChecker spellChecker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox TbAnotacao;
        private System.Windows.Forms.NumericUpDown nUpTamanho;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsArquivo;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsNegrito;
        private System.Windows.Forms.ToolStripButton tsItalico;
        private System.Windows.Forms.ToolStripButton tsSublinhado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsCorTexto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsAlinhaEsquerda;
        private System.Windows.Forms.ToolStripButton tsAlinhaCentro;
        private System.Windows.Forms.ToolStripButton tsAlinhaDireita;
        private System.Windows.Forms.ToolStripButton tsNovo;
        private System.Windows.Forms.ToolStripButton tsAbrir;
        private System.Windows.Forms.ToolStripButton tsSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.SplitContainer GerenteContainer;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer HorasContainer;
        private System.Windows.Forms.Label lbHoraTrabalhada;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private System.Windows.Forms.Label lbSaida3;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTarefa;
        private System.Windows.Forms.Label lbSaida2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl4;
        private System.Windows.Forms.Label lbEntrada;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Label lbSaida1;
        private DevExpress.XtraEditors.TimeEdit teIntervalo;
        private System.Windows.Forms.Label lbSaida;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lbEntrada3;
        private System.Windows.Forms.Label lbIntAlmoco;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbEntrada2;
        private System.Windows.Forms.Label lbEntrada1;
        private System.Windows.Forms.Label lbTotalHora;
        private System.Windows.Forms.Splitter splitter2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
    }
}