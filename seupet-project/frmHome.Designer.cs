namespace seupet_project
{
    partial class frmHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.pnlCadastro = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSair = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCadastro = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlServico = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnFechar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnServico = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlCadastro.SuspendLayout();
            this.pnlServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.pnlCadastro.Controls.Add(this.btnSair);
            this.pnlCadastro.Controls.Add(this.guna2HtmlLabel1);
            this.pnlCadastro.Controls.Add(this.btnCadastro);
            this.pnlCadastro.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCadastro.Location = new System.Drawing.Point(0, 0);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(341, 450);
            this.pnlCadastro.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSair.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSair.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSair.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSair.FillColor = System.Drawing.Color.Transparent;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSair.Image = global::seupet_project.Properties.Resources.logout;
            this.btnSair.ImageOffset = new System.Drawing.Point(-5, 1);
            this.btnSair.Location = new System.Drawing.Point(12, 9);
            this.btnSair.Name = "btnSair";
            this.btnSair.PressedDepth = 5;
            this.btnSair.Size = new System.Drawing.Size(79, 37);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseTransparentBackground = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(97, 280);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(143, 32);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Área pet/tutor";
            // 
            // btnCadastro
            // 
            this.btnCadastro.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastro.HoverState.ImageSize = new System.Drawing.Size(138, 138);
            this.btnCadastro.Image = global::seupet_project.Properties.Resources.pet_tutor;
            this.btnCadastro.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCadastro.ImageRotate = 0F;
            this.btnCadastro.ImageSize = new System.Drawing.Size(128, 128);
            this.btnCadastro.Location = new System.Drawing.Point(75, 129);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.PressedState.ImageSize = new System.Drawing.Size(128, 128);
            this.btnCadastro.Size = new System.Drawing.Size(176, 152);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // pnlServico
            // 
            this.pnlServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlServico.Controls.Add(this.btnMinimizar);
            this.pnlServico.Controls.Add(this.guna2HtmlLabel2);
            this.pnlServico.Controls.Add(this.btnFechar);
            this.pnlServico.Controls.Add(this.btnServico);
            this.pnlServico.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlServico.Location = new System.Drawing.Point(340, 0);
            this.pnlServico.Name = "pnlServico";
            this.pnlServico.Size = new System.Drawing.Size(344, 450);
            this.pnlServico.TabIndex = 1;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::seupet_project.Properties.Resources.minimize_sign1;
            this.btnMinimizar.ImageRotate = 0F;
            this.btnMinimizar.Location = new System.Drawing.Point(281, 13);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 34;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(91, 280);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(189, 32);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Agenda de serviços";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = global::seupet_project.Properties.Resources.close1;
            this.btnFechar.ImageRotate = 0F;
            this.btnFechar.Location = new System.Drawing.Point(319, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(13, 13);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 33;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnServico
            // 
            this.btnServico.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServico.HoverState.ImageSize = new System.Drawing.Size(150, 150);
            this.btnServico.Image = global::seupet_project.Properties.Resources.clipboard;
            this.btnServico.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnServico.ImageRotate = 0F;
            this.btnServico.ImageSize = new System.Drawing.Size(140, 140);
            this.btnServico.Location = new System.Drawing.Point(91, 129);
            this.btnServico.Name = "btnServico";
            this.btnServico.PressedState.ImageSize = new System.Drawing.Size(140, 140);
            this.btnServico.Size = new System.Drawing.Size(176, 152);
            this.btnServico.TabIndex = 2;
            this.btnServico.Click += new System.EventHandler(this.btnServico_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 1D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.DragStartTransparencyValue = 1D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 1D;
            this.guna2DragControl1.DragStartTransparencyValue = 1D;
            this.guna2DragControl1.TargetControl = this.pnlServico;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.pnlServico);
            this.Controls.Add(this.pnlCadastro);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            this.pnlServico.ResumeLayout(false);
            this.pnlServico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCadastro;
        private Guna.UI2.WinForms.Guna2ImageButton btnCadastro;
        private Guna.UI2.WinForms.Guna2Panel pnlServico;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ImageButton btnServico;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2PictureBox btnMinimizar;
        private Guna.UI2.WinForms.Guna2PictureBox btnFechar;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btnSair;
    }
}