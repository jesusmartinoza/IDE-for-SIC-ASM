namespace IDE_for_SIC_ASM
{
    partial class MainForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OpenFile = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 132);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(627, 212);
            this.textBox1.TabIndex = 1;
            // 
            // OpenFile
            // 
            this.OpenFile.AutoSize = true;
            this.OpenFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenFile.Depth = 0;
            this.OpenFile.Location = new System.Drawing.Point(13, 77);
            this.OpenFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OpenFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Primary = false;
            this.OpenFile.Size = new System.Drawing.Size(78, 36);
            this.OpenFile.TabIndex = 2;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 356);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.textBox1);
            this.Name = "MainForm";
            this.Text = "IDE for SIC STANDARD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialFlatButton OpenFile;
    }
}

