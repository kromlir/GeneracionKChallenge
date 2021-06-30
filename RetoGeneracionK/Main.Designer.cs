namespace RetoGeneracionK
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPathDecrypt = new System.Windows.Forms.TextBox();
            this.buttonFileDecrypt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileDialogDecrypt = new System.Windows.Forms.OpenFileDialog();
            this.textBoxPathKey = new System.Windows.Forms.TextBox();
            this.buttonPathKey = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(279, 296);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(215, 55);
            this.buttonDecrypt.TabIndex = 0;
            this.buttonDecrypt.Text = "Desencriptar";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPathDecrypt);
            this.groupBox1.Controls.Add(this.buttonFileDecrypt);
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select File to Decrypt";
            // 
            // textBoxPathDecrypt
            // 
            this.textBoxPathDecrypt.Location = new System.Drawing.Point(6, 47);
            this.textBoxPathDecrypt.Name = "textBoxPathDecrypt";
            this.textBoxPathDecrypt.Size = new System.Drawing.Size(517, 20);
            this.textBoxPathDecrypt.TabIndex = 1;
            // 
            // buttonFileDecrypt
            // 
            this.buttonFileDecrypt.Location = new System.Drawing.Point(529, 34);
            this.buttonFileDecrypt.Name = "buttonFileDecrypt";
            this.buttonFileDecrypt.Size = new System.Drawing.Size(144, 44);
            this.buttonFileDecrypt.TabIndex = 0;
            this.buttonFileDecrypt.Text = "Select File";
            this.buttonFileDecrypt.UseVisualStyleBackColor = true;
            this.buttonFileDecrypt.Click += new System.EventHandler(this.buttonFileDecrypt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxPathKey);
            this.groupBox2.Controls.Add(this.buttonPathKey);
            this.groupBox2.Location = new System.Drawing.Point(35, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(715, 115);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select File With Key";
            // 
            // openFileDialogDecrypt
            // 
            this.openFileDialogDecrypt.FileName = "openFileDialogDecrypt";
            // 
            // textBoxPathKey
            // 
            this.textBoxPathKey.Location = new System.Drawing.Point(6, 56);
            this.textBoxPathKey.Name = "textBoxPathKey";
            this.textBoxPathKey.Size = new System.Drawing.Size(517, 20);
            this.textBoxPathKey.TabIndex = 3;
            // 
            // buttonPathKey
            // 
            this.buttonPathKey.Location = new System.Drawing.Point(529, 43);
            this.buttonPathKey.Name = "buttonPathKey";
            this.buttonPathKey.Size = new System.Drawing.Size(144, 44);
            this.buttonPathKey.TabIndex = 2;
            this.buttonPathKey.Text = "Select File";
            this.buttonPathKey.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDecrypt);
            this.Name = "Main";
            this.Text = "GenerationK";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFileDecrypt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialogDecrypt;
        private System.Windows.Forms.TextBox textBoxPathDecrypt;
        private System.Windows.Forms.TextBox textBoxPathKey;
        private System.Windows.Forms.Button buttonPathKey;
    }
}

