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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Run = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbErrors = new System.Windows.Forms.TextBox();
            this.TextBoxEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.CurrentFileName = new MaterialSkin.Controls.MaterialLabel();
            this.btnSaveFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnOpenFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxEditor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Run
            // 
            this.Run.Depth = 0;
            this.Run.Location = new System.Drawing.Point(730, 51);
            this.Run.MouseState = MaterialSkin.MouseState.HOVER;
            this.Run.Name = "Run";
            this.Run.Primary = true;
            this.Run.Size = new System.Drawing.Size(91, 32);
            this.Run.TabIndex = 9;
            this.Run.Text = "Run Asm";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-2, 62);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(834, 40);
            this.materialTabSelector1.TabIndex = 4;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl
            // 
            this.materialTabControl.Controls.Add(this.tabPage1);
            this.materialTabControl.Controls.Add(this.tabPage2);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Location = new System.Drawing.Point(3, 0);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(820, 446);
            this.materialTabControl.TabIndex = 3;
            this.materialTabControl.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BackgroundImage = global::IDE_for_SIC_ASM.Properties.Resources.FondoBack;
            this.tabPage1.Controls.Add(this.tbErrors);
            this.tabPage1.Controls.Add(this.TextBoxEditor);
            this.tabPage1.Controls.Add(this.CurrentFileName);
            this.tabPage1.Controls.Add(this.btnSaveFile);
            this.tabPage1.Controls.Add(this.btnOpenFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(812, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Editor & Errors";
            // 
            // tbErrors
            // 
            this.tbErrors.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbErrors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbErrors.Location = new System.Drawing.Point(6, 296);
            this.tbErrors.Multiline = true;
            this.tbErrors.Name = "tbErrors";
            this.tbErrors.ReadOnly = true;
            this.tbErrors.Size = new System.Drawing.Size(800, 119);
            this.tbErrors.TabIndex = 11;
            // 
            // TextBoxEditor
            // 
            this.TextBoxEditor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.TextBoxEditor.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.TextBoxEditor.BackBrush = null;
            this.TextBoxEditor.BackColor = System.Drawing.Color.DarkGray;
            this.TextBoxEditor.CharHeight = 14;
            this.TextBoxEditor.CharWidth = 8;
            this.TextBoxEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextBoxEditor.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TextBoxEditor.IndentBackColor = System.Drawing.Color.DimGray;
            this.TextBoxEditor.IsReplaceMode = false;
            this.TextBoxEditor.LineNumberColor = System.Drawing.Color.MintCream;
            this.TextBoxEditor.Location = new System.Drawing.Point(6, 44);
            this.TextBoxEditor.Name = "TextBoxEditor";
            this.TextBoxEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.TextBoxEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.TextBoxEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("TextBoxEditor.ServiceColors")));
            this.TextBoxEditor.Size = new System.Drawing.Size(799, 245);
            this.TextBoxEditor.TabIndex = 10;
            this.TextBoxEditor.Zoom = 100;
            // 
            // CurrentFileName
            // 
            this.CurrentFileName.AutoSize = true;
            this.CurrentFileName.BackColor = System.Drawing.Color.Transparent;
            this.CurrentFileName.Depth = 0;
            this.CurrentFileName.Font = new System.Drawing.Font("Roboto", 11F);
            this.CurrentFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CurrentFileName.Location = new System.Drawing.Point(210, 15);
            this.CurrentFileName.MouseState = MaterialSkin.MouseState.HOVER;
            this.CurrentFileName.Name = "CurrentFileName";
            this.CurrentFileName.Size = new System.Drawing.Size(21, 19);
            this.CurrentFileName.TabIndex = 7;
            this.CurrentFileName.Text = "...";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Depth = 0;
            this.btnSaveFile.Location = new System.Drawing.Point(102, 6);
            this.btnSaveFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Primary = true;
            this.btnSaveFile.Size = new System.Drawing.Size(91, 32);
            this.btnSaveFile.TabIndex = 4;
            this.btnSaveFile.Text = "Save";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Depth = 0;
            this.btnOpenFile.Location = new System.Drawing.Point(5, 6);
            this.btnOpenFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Primary = true;
            this.btnOpenFile.Size = new System.Drawing.Size(91, 32);
            this.btnOpenFile.TabIndex = 3;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(812, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SIC output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialTabControl);
            this.panel1.Location = new System.Drawing.Point(-2, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 446);
            this.panel1.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(831, 547);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "IDE for SIC STANDARD";
            this.materialTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxEditor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton Run;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private FastColoredTextBoxNS.FastColoredTextBox TextBoxEditor;
        private MaterialSkin.Controls.MaterialLabel CurrentFileName;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaveFile;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenFile;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbErrors;
    }
}

