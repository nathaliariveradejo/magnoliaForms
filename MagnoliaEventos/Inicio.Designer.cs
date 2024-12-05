namespace MagnoliaEventos
{
    partial class Inicio
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
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnNextSesión = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FloralWhite;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtCorreo.Location = new System.Drawing.Point(519, 211);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(304, 29);
            this.txtCorreo.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FloralWhite;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtContraseña.Location = new System.Drawing.Point(519, 313);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '-';
            this.txtContraseña.Size = new System.Drawing.Size(304, 31);
            this.txtContraseña.TabIndex = 1;
            // 
            // btnNextSesión
            // 
            this.btnNextSesión.BackColor = System.Drawing.Color.Transparent;
            this.btnNextSesión.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextSesión.ForeColor = System.Drawing.Color.Transparent;
            this.btnNextSesión.Location = new System.Drawing.Point(593, 404);
            this.btnNextSesión.Name = "btnNextSesión";
            this.btnNextSesión.Size = new System.Drawing.Size(161, 59);
            this.btnNextSesión.TabIndex = 2;
            this.btnNextSesión.UseVisualStyleBackColor = false;
            this.btnNextSesión.Click += new System.EventHandler(this.btnNextSesión_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MagnoliaEventos.Properties.Resources.Log_in;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 586);
            this.Controls.Add(this.btnNextSesión);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCorreo);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnNextSesión;
    }
}