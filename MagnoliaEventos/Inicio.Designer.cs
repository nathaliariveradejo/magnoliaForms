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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnNextSesión = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FloralWhite;
            this.txtCorreo.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtCorreo.Location = new System.Drawing.Point(692, 259);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(404, 36);
            this.txtCorreo.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FloralWhite;
            this.txtContraseña.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtContraseña.Location = new System.Drawing.Point(692, 385);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '-';
            this.txtContraseña.Size = new System.Drawing.Size(404, 39);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.Visible = false;
            // 
            // btnNextSesión
            // 
            this.btnNextSesión.BackColor = System.Drawing.Color.Transparent;
            this.btnNextSesión.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextSesión.ForeColor = System.Drawing.Color.Transparent;
            this.btnNextSesión.Location = new System.Drawing.Point(790, 497);
            this.btnNextSesión.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextSesión.Name = "btnNextSesión";
            this.btnNextSesión.Size = new System.Drawing.Size(214, 73);
            this.btnNextSesión.TabIndex = 2;
            this.btnNextSesión.Text = "i";
            this.btnNextSesión.UseVisualStyleBackColor = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.btnNextSesión);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCorreo);
            this.Margin = new System.Windows.Forms.Padding(4);
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