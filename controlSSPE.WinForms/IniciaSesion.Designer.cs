namespace controlSSPE.Formas
{
    partial class frmIniciaSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIniciaSesion));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtUsuario = new wmgCMS.WaterMarkTextBox();
            this.txtContraseña = new wmgCMS.WaterMarkTextBox();
            this.btnIniciaSesion = new System.Windows.Forms.Button();
            this.imgssp = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgssp)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(422, 206);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.imgssp, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 44);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(416, 117);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.txtUsuario, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtContraseña, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnIniciaSesion, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(127, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(202, 111);
            this.tableLayoutPanel3.TabIndex = 0;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtUsuario.Location = new System.Drawing.Point(3, 3);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(196, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtUsuario.WaterMarkText = "Usuario";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtContraseña.Location = new System.Drawing.Point(3, 40);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(196, 20);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtContraseña.WaterMarkText = "Contraseña";
            // 
            // btnIniciaSesion
            // 
            this.btnIniciaSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIniciaSesion.Location = new System.Drawing.Point(3, 77);
            this.btnIniciaSesion.Name = "btnIniciaSesion";
            this.btnIniciaSesion.Size = new System.Drawing.Size(196, 31);
            this.btnIniciaSesion.TabIndex = 2;
            this.btnIniciaSesion.Text = "Iniciar Sesion";
            this.btnIniciaSesion.UseVisualStyleBackColor = true;
            this.btnIniciaSesion.Click += new System.EventHandler(this.btnIniciaSesion_Click);
            // 
            // imgssp
            // 
            this.imgssp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgssp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgssp.BackgroundImage")));
            this.imgssp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgssp.Image = ((System.Drawing.Image)(resources.GetObject("imgssp.Image")));
            this.imgssp.Location = new System.Drawing.Point(23, 20);
            this.imgssp.Name = "imgssp";
            this.imgssp.Size = new System.Drawing.Size(77, 77);
            this.imgssp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgssp.TabIndex = 1;
            this.imgssp.TabStop = false;
            // 
            // frmIniciaSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 206);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmIniciaSesion";
            this.Text = "IniciaSesion";
            this.Load += new System.EventHandler(this.IniciaSesion_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgssp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private wmgCMS.WaterMarkTextBox txtUsuario;
        private wmgCMS.WaterMarkTextBox txtContraseña;
        private System.Windows.Forms.Button btnIniciaSesion;
        private System.Windows.Forms.PictureBox imgssp;
    }
}