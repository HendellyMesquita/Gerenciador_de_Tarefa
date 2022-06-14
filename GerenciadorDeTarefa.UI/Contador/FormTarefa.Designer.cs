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
            this.Marcador1 = new System.Windows.Forms.Label();
            this.Marcador3 = new System.Windows.Forms.Label();
            this.Marcador2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teIntervalo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrada
            // 
            this.btnEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEntrada.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEntrada.Location = new System.Drawing.Point(12, 238);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(53, 25);
            this.btnEntrada.TabIndex = 0;
            this.btnEntrada.Text = "Novo";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(70, 238);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(53, 25);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Titulo";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lbHoraTrabalhada
            // 
            this.lbHoraTrabalhada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHoraTrabalhada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHoraTrabalhada.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbHoraTrabalhada.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbHoraTrabalhada.Location = new System.Drawing.Point(12, 5);
            this.lbHoraTrabalhada.Name = "lbHoraTrabalhada";
            this.lbHoraTrabalhada.Size = new System.Drawing.Size(208, 22);
            this.lbHoraTrabalhada.TabIndex = 3;
            this.lbHoraTrabalhada.Text = "Horas Trabalhadas";
            this.lbHoraTrabalhada.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbEntrada1
            // 
            this.lbEntrada1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEntrada1.AutoSize = true;
            this.lbEntrada1.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbEntrada1.Location = new System.Drawing.Point(77, 128);
            this.lbEntrada1.Name = "lbEntrada1";
            this.lbEntrada1.Size = new System.Drawing.Size(45, 19);
            this.lbEntrada1.TabIndex = 5;
            this.lbEntrada1.Text = "00:00";
            // 
            // lbEntrada2
            // 
            this.lbEntrada2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEntrada2.AutoSize = true;
            this.lbEntrada2.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbEntrada2.Location = new System.Drawing.Point(126, 128);
            this.lbEntrada2.Name = "lbEntrada2";
            this.lbEntrada2.Size = new System.Drawing.Size(45, 19);
            this.lbEntrada2.TabIndex = 6;
            this.lbEntrada2.Text = "00:00";
            // 
            // lbEntrada3
            // 
            this.lbEntrada3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEntrada3.AutoSize = true;
            this.lbEntrada3.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbEntrada3.Location = new System.Drawing.Point(175, 128);
            this.lbEntrada3.Name = "lbEntrada3";
            this.lbEntrada3.Size = new System.Drawing.Size(45, 19);
            this.lbEntrada3.TabIndex = 7;
            this.lbEntrada3.Text = "00:00";
            // 
            // lbSaida1
            // 
            this.lbSaida1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSaida1.AutoSize = true;
            this.lbSaida1.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbSaida1.Location = new System.Drawing.Point(77, 176);
            this.lbSaida1.Name = "lbSaida1";
            this.lbSaida1.Size = new System.Drawing.Size(45, 19);
            this.lbSaida1.TabIndex = 8;
            this.lbSaida1.Text = "00:00";
            // 
            // lbSaida2
            // 
            this.lbSaida2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSaida2.AutoSize = true;
            this.lbSaida2.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbSaida2.Location = new System.Drawing.Point(126, 176);
            this.lbSaida2.Name = "lbSaida2";
            this.lbSaida2.Size = new System.Drawing.Size(45, 19);
            this.lbSaida2.TabIndex = 9;
            this.lbSaida2.Text = "00:00";
            // 
            // lbSaida3
            // 
            this.lbSaida3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSaida3.AutoSize = true;
            this.lbSaida3.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbSaida3.Location = new System.Drawing.Point(175, 176);
            this.lbSaida3.Name = "lbSaida3";
            this.lbSaida3.Size = new System.Drawing.Size(45, 19);
            this.lbSaida3.TabIndex = 10;
            this.lbSaida3.Text = "00:00";
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbTotal.Location = new System.Drawing.Point(143, 287);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(46, 14);
            this.lbTotal.TabIndex = 11;
            this.lbTotal.Text = "TOTAL:";
            // 
            // lbEntrada
            // 
            this.lbEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEntrada.AutoSize = true;
            this.lbEntrada.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbEntrada.Location = new System.Drawing.Point(12, 128);
            this.lbEntrada.Name = "lbEntrada";
            this.lbEntrada.Size = new System.Drawing.Size(61, 19);
            this.lbEntrada.TabIndex = 15;
            this.lbEntrada.Text = "Entrada:";
            // 
            // lbSaida
            // 
            this.lbSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSaida.AutoSize = true;
            this.lbSaida.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbSaida.Location = new System.Drawing.Point(12, 176);
            this.lbSaida.Name = "lbSaida";
            this.lbSaida.Size = new System.Drawing.Size(45, 19);
            this.lbSaida.TabIndex = 16;
            this.lbSaida.Text = "Saida:";
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo.Location = new System.Drawing.Point(12, 45);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(53, 19);
            this.lbTitulo.TabIndex = 17;
            this.lbTitulo.Text = "Tarefa:";
            // 
            // lbTotalHora
            // 
            this.lbTotalHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTotalHora.AutoSize = true;
            this.lbTotalHora.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbTotalHora.Location = new System.Drawing.Point(186, 286);
            this.lbTotalHora.Name = "lbTotalHora";
            this.lbTotalHora.Size = new System.Drawing.Size(34, 16);
            this.lbTotalHora.TabIndex = 18;
            this.lbTotalHora.Text = "00:00";
            // 
            // lbTarefa
            // 
            this.lbTarefa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTarefa.Font = new System.Drawing.Font("Sylfaen", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbTarefa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTarefa.Location = new System.Drawing.Point(71, 45);
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
            this.lbIntAlmoco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbIntAlmoco.AutoSize = true;
            this.lbIntAlmoco.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbIntAlmoco.Location = new System.Drawing.Point(12, 286);
            this.lbIntAlmoco.Name = "lbIntAlmoco";
            this.lbIntAlmoco.Size = new System.Drawing.Size(62, 18);
            this.lbIntAlmoco.TabIndex = 26;
            this.lbIntAlmoco.Text = "Intervalo:";
            // 
            // teIntervalo
            // 
            this.teIntervalo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.teIntervalo.EditValue = new System.DateTime(2022, 6, 14, 0, 0, 0, 0);
            this.teIntervalo.Location = new System.Drawing.Point(74, 284);
            this.teIntervalo.Name = "teIntervalo";
            this.teIntervalo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teIntervalo.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.teIntervalo.Size = new System.Drawing.Size(67, 20);
            this.teIntervalo.TabIndex = 28;
            this.teIntervalo.EditValueChanged += new System.EventHandler(this.teIntervalo_EditValueChanged);
            // 
            // Marcador1
            // 
            this.Marcador1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Marcador1.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Marcador1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Marcador1.Location = new System.Drawing.Point(1, 102);
            this.Marcador1.Name = "Marcador1";
            this.Marcador1.Size = new System.Drawing.Size(229, 16);
            this.Marcador1.TabIndex = 30;
            this.Marcador1.Text = resources.GetString("Marcador1.Text");
            this.Marcador1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Marcador3
            // 
            this.Marcador3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Marcador3.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Marcador3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Marcador3.Location = new System.Drawing.Point(1, 265);
            this.Marcador3.Name = "Marcador3";
            this.Marcador3.Size = new System.Drawing.Size(229, 16);
            this.Marcador3.TabIndex = 29;
            this.Marcador3.Text = resources.GetString("Marcador3.Text");
            this.Marcador3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Marcador2
            // 
            this.Marcador2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Marcador2.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Marcador2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Marcador2.Location = new System.Drawing.Point(1, 208);
            this.Marcador2.Name = "Marcador2";
            this.Marcador2.Size = new System.Drawing.Size(229, 16);
            this.Marcador2.TabIndex = 31;
            this.Marcador2.Text = resources.GetString("Marcador2.Text");
            this.Marcador2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(232, 311);
            this.Controls.Add(this.Marcador2);
            this.Controls.Add(this.Marcador1);
            this.Controls.Add(this.Marcador3);
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
            this.MaximizeBox = false;
            this.Name = "FormTarefa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerente de Horas";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTarefa_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.teIntervalo.Properties)).EndInit();
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
        private System.Windows.Forms.Label Marcador1;
        private System.Windows.Forms.Label Marcador3;
        private System.Windows.Forms.Label Marcador2;
    }
}