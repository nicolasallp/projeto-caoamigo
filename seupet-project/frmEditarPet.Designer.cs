namespace seupet_project
{
    partial class frmEditarPet
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbTutor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbPorte = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAdicionar = new Guna.UI2.WinForms.Guna2Button();
            this.txtRaca = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNomePet = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFechar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 1D;
            this.guna2BorderlessForm1.DragStartTransparencyValue = 1D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(40, 349);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(44, 23);
            this.guna2HtmlLabel1.TabIndex = 49;
            this.guna2HtmlLabel1.Text = "Tutor";
            // 
            // cmbTutor
            // 
            this.cmbTutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTutor.BackColor = System.Drawing.Color.Transparent;
            this.cmbTutor.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmbTutor.DisplayMember = "fdsfsdf";
            this.cmbTutor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTutor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmbTutor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmbTutor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbTutor.ForeColor = System.Drawing.Color.Black;
            this.cmbTutor.ItemHeight = 30;
            this.cmbTutor.Location = new System.Drawing.Point(40, 378);
            this.cmbTutor.Name = "cmbTutor";
            this.cmbTutor.Size = new System.Drawing.Size(388, 36);
            this.cmbTutor.TabIndex = 48;
            this.cmbTutor.Tag = "";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(79, 282);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(44, 23);
            this.guna2HtmlLabel2.TabIndex = 47;
            this.guna2HtmlLabel2.Text = "Porte";
            // 
            // cmbPorte
            // 
            this.cmbPorte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPorte.BackColor = System.Drawing.Color.Transparent;
            this.cmbPorte.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmbPorte.DisplayMember = "fdsfsdf";
            this.cmbPorte.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPorte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPorte.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmbPorte.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmbPorte.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbPorte.ForeColor = System.Drawing.Color.Black;
            this.cmbPorte.ItemHeight = 30;
            this.cmbPorte.Items.AddRange(new object[] {
            "Pequeno",
            "Médio",
            "Grande"});
            this.cmbPorte.Location = new System.Drawing.Point(78, 306);
            this.cmbPorte.Name = "cmbPorte";
            this.cmbPorte.Size = new System.Drawing.Size(317, 36);
            this.cmbPorte.TabIndex = 46;
            this.cmbPorte.Tag = "";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicionar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnAdicionar.BorderRadius = 10;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdicionar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdicionar.FillColor = System.Drawing.Color.White;
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnAdicionar.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdicionar.Location = new System.Drawing.Point(144, 449);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.PressedDepth = 10;
            this.btnAdicionar.Size = new System.Drawing.Size(180, 45);
            this.btnAdicionar.TabIndex = 45;
            this.btnAdicionar.Text = "Editar pet";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtRaca
            // 
            this.txtRaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRaca.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtRaca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRaca.DefaultText = "";
            this.txtRaca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRaca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRaca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRaca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRaca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtRaca.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRaca.ForeColor = System.Drawing.Color.Black;
            this.txtRaca.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtRaca.Location = new System.Drawing.Point(79, 224);
            this.txtRaca.Margin = new System.Windows.Forms.Padding(5);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.PasswordChar = '\0';
            this.txtRaca.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtRaca.PlaceholderText = "Raça";
            this.txtRaca.SelectedText = "";
            this.txtRaca.Size = new System.Drawing.Size(317, 47);
            this.txtRaca.TabIndex = 44;
            // 
            // txtNomePet
            // 
            this.txtNomePet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomePet.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtNomePet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomePet.DefaultText = "";
            this.txtNomePet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomePet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomePet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomePet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomePet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtNomePet.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNomePet.ForeColor = System.Drawing.Color.Black;
            this.txtNomePet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtNomePet.Location = new System.Drawing.Point(79, 159);
            this.txtNomePet.Margin = new System.Windows.Forms.Padding(5);
            this.txtNomePet.Name = "txtNomePet";
            this.txtNomePet.PasswordChar = '\0';
            this.txtNomePet.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtNomePet.PlaceholderText = "Nome do pet";
            this.txtNomePet.SelectedText = "";
            this.txtNomePet.Size = new System.Drawing.Size(317, 47);
            this.txtNomePet.TabIndex = 43;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = global::seupet_project.Properties.Resources.close_white;
            this.btnFechar.ImageRotate = 0F;
            this.btnFechar.Location = new System.Drawing.Point(424, 13);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(20, 20);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 50;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2PictureBox1.Image = global::seupet_project.Properties.Resources.update;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(194, 44);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(80, 80);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 42;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmEditarPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(459, 525);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.cmbTutor);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.cmbPorte);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtRaca);
            this.Controls.Add(this.txtNomePet);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Pet | Cão Amigo";
            this.Load += new System.EventHandler(this.frmEditarPet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTutor;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPorte;
        private Guna.UI2.WinForms.Guna2Button btnAdicionar;
        private Guna.UI2.WinForms.Guna2TextBox txtRaca;
        private Guna.UI2.WinForms.Guna2TextBox txtNomePet;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox btnFechar;
    }
}