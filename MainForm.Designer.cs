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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRunASM = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbErrors = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSaveFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CurrentFileName = new MaterialSkin.Controls.MaterialLabel();
            this.TextBoxEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridSourceCode = new System.Windows.Forms.DataGridView();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSTRUCTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxEditor)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSourceCode)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRunASM
            // 
            this.btnRunASM.Depth = 0;
            this.btnRunASM.Location = new System.Drawing.Point(730, 51);
            this.btnRunASM.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRunASM.Name = "btnRunASM";
            this.btnRunASM.Primary = true;
            this.btnRunASM.Size = new System.Drawing.Size(91, 32);
            this.btnRunASM.TabIndex = 9;
            this.btnRunASM.Text = "Run Asm";
            this.btnRunASM.UseVisualStyleBackColor = true;
            this.btnRunASM.Click += new System.EventHandler(this.Run_Click);
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
            this.materialTabControl.Location = new System.Drawing.Point(-2, 108);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(834, 433);
            this.materialTabControl.TabIndex = 3;
            this.materialTabControl.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(826, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Editor & Errors";
            // 
            // tbErrors
            // 
            this.tbErrors.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbErrors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbErrors.Location = new System.Drawing.Point(6, 19);
            this.tbErrors.Multiline = true;
            this.tbErrors.Name = "tbErrors";
            this.tbErrors.ReadOnly = true;
            this.tbErrors.Size = new System.Drawing.Size(795, 65);
            this.tbErrors.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Controls.Add(this.btnSaveFile);
            this.groupBox1.Controls.Add(this.CurrentFileName);
            this.groupBox1.Controls.Add(this.TextBoxEditor);
            this.groupBox1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 299);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Code";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Depth = 0;
            this.btnOpenFile.Location = new System.Drawing.Point(6, 19);
            this.btnOpenFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Primary = true;
            this.btnOpenFile.Size = new System.Drawing.Size(91, 32);
            this.btnOpenFile.TabIndex = 3;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Depth = 0;
            this.btnSaveFile.Location = new System.Drawing.Point(103, 19);
            this.btnSaveFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Primary = true;
            this.btnSaveFile.Size = new System.Drawing.Size(91, 32);
            this.btnSaveFile.TabIndex = 4;
            this.btnSaveFile.Text = "Save";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // CurrentFileName
            // 
            this.CurrentFileName.AutoSize = true;
            this.CurrentFileName.BackColor = System.Drawing.Color.Transparent;
            this.CurrentFileName.Depth = 0;
            this.CurrentFileName.Font = new System.Drawing.Font("Roboto", 11F);
            this.CurrentFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CurrentFileName.Location = new System.Drawing.Point(200, 25);
            this.CurrentFileName.MouseState = MaterialSkin.MouseState.HOVER;
            this.CurrentFileName.Name = "CurrentFileName";
            this.CurrentFileName.Size = new System.Drawing.Size(21, 19);
            this.CurrentFileName.TabIndex = 7;
            this.CurrentFileName.Text = "...";
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
            this.TextBoxEditor.Location = new System.Drawing.Point(6, 57);
            this.TextBoxEditor.Name = "TextBoxEditor";
            this.TextBoxEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.TextBoxEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.TextBoxEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("TextBoxEditor.ServiceColors")));
            this.TextBoxEditor.Size = new System.Drawing.Size(797, 236);
            this.TextBoxEditor.TabIndex = 10;
            this.TextBoxEditor.Zoom = 100;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridSourceCode);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(826, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SIC output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridSourceCode
            // 
            this.gridSourceCode.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridSourceCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSourceCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSourceCode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Line,
            this.CP,
            this.TAG,
            this.INSTRUCTION,
            this.ADDRESS,
            this.OBJ});
            this.gridSourceCode.Location = new System.Drawing.Point(10, 12);
            this.gridSourceCode.Name = "gridSourceCode";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSourceCode.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSourceCode.RowHeadersVisible = false;
            this.gridSourceCode.Size = new System.Drawing.Size(499, 389);
            this.gridSourceCode.TabIndex = 0;
            // 
            // Line
            // 
            this.Line.HeaderText = "Line";
            this.Line.Name = "Line";
            this.Line.Width = 32;
            // 
            // CP
            // 
            this.CP.HeaderText = "CP";
            this.CP.Name = "CP";
            this.CP.Width = 50;
            // 
            // TAG
            // 
            this.TAG.HeaderText = "TAG";
            this.TAG.Name = "TAG";
            // 
            // INSTRUCTION
            // 
            this.INSTRUCTION.HeaderText = "INSTRUCTION";
            this.INSTRUCTION.Name = "INSTRUCTION";
            // 
            // ADDRESS
            // 
            this.ADDRESS.HeaderText = "ADDRESS";
            this.ADDRESS.Name = "ADDRESS";
            // 
            // OBJ
            // 
            this.OBJ.HeaderText = "OBJ";
            this.OBJ.Name = "OBJ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbErrors);
            this.groupBox2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.groupBox2.Location = new System.Drawing.Point(10, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(807, 93);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Warnings & Errors";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(831, 547);
            this.Controls.Add(this.materialTabControl);
            this.Controls.Add(this.btnRunASM);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "MainForm";
            this.Text = "IDE for SIC STANDARD";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.materialTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxEditor)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSourceCode)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnRunASM;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private FastColoredTextBoxNS.FastColoredTextBox TextBoxEditor;
        private MaterialSkin.Controls.MaterialLabel CurrentFileName;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaveFile;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenFile;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbErrors;
        private System.Windows.Forms.DataGridView gridSourceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line;
        private System.Windows.Forms.DataGridViewTextBoxColumn CP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSTRUCTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBJ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

