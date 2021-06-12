namespace ProyectoFinal_Instagram
{
    partial class SesionAbierta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ImgPerfil = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstSeguidos = new System.Windows.Forms.ListView();
            this.lstSeguidores = new System.Windows.Forms.ListView();
            this.txtUsuarioBuscado = new System.Windows.Forms.TextBox();
            this.lblSeguidores = new System.Windows.Forms.Label();
            this.lblSeguidos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombreUsua = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCumpleAnios = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSeguir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPerfil)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 604);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.btnSeguir);
            this.panel2.Controls.Add(this.btnRegresar);
            this.panel2.Controls.Add(this.lblCumpleAnios);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.lblNombreUsua);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblSeguidos);
            this.panel2.Controls.Add(this.lblSeguidores);
            this.panel2.Controls.Add(this.ImgPerfil);
            this.panel2.Location = new System.Drawing.Point(403, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 292);
            this.panel2.TabIndex = 1;
            // 
            // ImgPerfil
            // 
            this.ImgPerfil.Location = new System.Drawing.Point(494, 3);
            this.ImgPerfil.Name = "ImgPerfil";
            this.ImgPerfil.Size = new System.Drawing.Size(211, 288);
            this.ImgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgPerfil.TabIndex = 0;
            this.ImgPerfil.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lstSeguidos);
            this.panel3.Controls.Add(this.lstSeguidores);
            this.panel3.Location = new System.Drawing.Point(403, 307);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 354);
            this.panel3.TabIndex = 2;
            // 
            // lstSeguidos
            // 
            this.lstSeguidos.HideSelection = false;
            this.lstSeguidos.Location = new System.Drawing.Point(367, 7);
            this.lstSeguidos.Name = "lstSeguidos";
            this.lstSeguidos.Size = new System.Drawing.Size(338, 324);
            this.lstSeguidos.TabIndex = 1;
            this.lstSeguidos.UseCompatibleStateImageBehavior = false;
            // 
            // lstSeguidores
            // 
            this.lstSeguidores.HideSelection = false;
            this.lstSeguidores.Location = new System.Drawing.Point(6, 7);
            this.lstSeguidores.Name = "lstSeguidores";
            this.lstSeguidores.Size = new System.Drawing.Size(360, 324);
            this.lstSeguidores.TabIndex = 0;
            this.lstSeguidores.UseCompatibleStateImageBehavior = false;
            // 
            // txtUsuarioBuscado
            // 
            this.txtUsuarioBuscado.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioBuscado.Location = new System.Drawing.Point(7, 12);
            this.txtUsuarioBuscado.Multiline = true;
            this.txtUsuarioBuscado.Name = "txtUsuarioBuscado";
            this.txtUsuarioBuscado.Size = new System.Drawing.Size(389, 45);
            this.txtUsuarioBuscado.TabIndex = 3;
            this.txtUsuarioBuscado.TextChanged += new System.EventHandler(this.txtUsuarioBuscado_TextChanged);
            this.txtUsuarioBuscado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txtUsuarioBuscado.Leave += new System.EventHandler(this.txtUsuarioBuscado_Leave);
            // 
            // lblSeguidores
            // 
            this.lblSeguidores.AutoSize = true;
            this.lblSeguidores.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguidores.Location = new System.Drawing.Point(60, 57);
            this.lblSeguidores.Name = "lblSeguidores";
            this.lblSeguidores.Size = new System.Drawing.Size(34, 32);
            this.lblSeguidores.TabIndex = 1;
            this.lblSeguidores.Text = "A";
            this.lblSeguidores.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblSeguidos
            // 
            this.lblSeguidos.AutoSize = true;
            this.lblSeguidos.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguidos.Location = new System.Drawing.Point(191, 57);
            this.lblSeguidos.Name = "lblSeguidos";
            this.lblSeguidos.Size = new System.Drawing.Size(34, 32);
            this.lblSeguidos.TabIndex = 2;
            this.lblSeguidos.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "SEGUIDORES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "SEGUIDOS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNombreUsua
            // 
            this.lblNombreUsua.AutoSize = true;
            this.lblNombreUsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsua.Location = new System.Drawing.Point(309, 13);
            this.lblNombreUsua.Name = "lblNombreUsua";
            this.lblNombreUsua.Size = new System.Drawing.Size(116, 25);
            this.lblNombreUsua.TabIndex = 5;
            this.lblNombreUsua.Text = "EMA_TOT";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(31, 127);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(163, 33);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Juan Perez";
            // 
            // lblCumpleAnios
            // 
            this.lblCumpleAnios.AutoSize = true;
            this.lblCumpleAnios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCumpleAnios.Location = new System.Drawing.Point(33, 177);
            this.lblCumpleAnios.Name = "lblCumpleAnios";
            this.lblCumpleAnios.Size = new System.Drawing.Size(110, 23);
            this.lblCumpleAnios.TabIndex = 7;
            this.lblCumpleAnios.Text = "20/12/2000";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(293, 237);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(190, 42);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Visible = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSeguir
            // 
            this.btnSeguir.Location = new System.Drawing.Point(293, 47);
            this.btnSeguir.Name = "btnSeguir";
            this.btnSeguir.Size = new System.Drawing.Size(190, 42);
            this.btnSeguir.TabIndex = 9;
            this.btnSeguir.Text = "SEGUIR";
            this.btnSeguir.UseVisualStyleBackColor = true;
            this.btnSeguir.Visible = false;
            this.btnSeguir.Click += new System.EventHandler(this.btnSeguir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(23, 237);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(190, 42);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "OPCIONES";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // SesionAbierta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 667);
            this.Controls.Add(this.txtUsuarioBuscado);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SesionAbierta";
            this.Text = "SesionAbierta";
            this.Load += new System.EventHandler(this.SesionAbierta_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPerfil)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ImgPerfil;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lstSeguidos;
        private System.Windows.Forms.ListView lstSeguidores;
        private System.Windows.Forms.TextBox txtUsuarioBuscado;
        private System.Windows.Forms.Button btnSeguir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblCumpleAnios;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreUsua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSeguidos;
        private System.Windows.Forms.Label lblSeguidores;
        private System.Windows.Forms.Button btnCerrar;
    }
}