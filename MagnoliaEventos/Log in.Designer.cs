namespace MagnoliaEventos
{
    partial class Form1
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
            this.btnSesión = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSesión
            // 
            this.btnSesión.BackColor = System.Drawing.Color.Transparent;
            this.btnSesión.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSesión.ForeColor = System.Drawing.Color.Transparent;
            this.btnSesión.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSesión.Location = new System.Drawing.Point(830, 381);
            this.btnSesión.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSesión.Name = "btnSesión";
            this.btnSesión.Size = new System.Drawing.Size(356, 135);
            this.btnSesión.TabIndex = 0;
            this.btnSesión.UseVisualStyleBackColor = true;
            this.btnSesión.Click += new System.EventHandler(this.btnSesión_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MagnoliaEventos.Properties.Resources.Inicio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1516, 901);
            this.Controls.Add(this.btnSesión);
            this.ForeColor = System.Drawing.Color.Sienna;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSesión;
    }
}

