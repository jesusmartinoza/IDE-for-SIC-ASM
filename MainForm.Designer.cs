﻿namespace IDE_for_SIC_ASM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRunASM = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbErrors = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSaveFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CurrentFileName = new MaterialSkin.Controls.MaterialLabel();
            this.TextBoxEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progSize = new System.Windows.Forms.Label();
            this.tabsimGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gridSourceCode = new System.Windows.Forms.DataGridView();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSTRUCTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.objFileTextBox = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbNumLoops = new System.Windows.Forms.TextBox();
            this.btnRunEffect = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbEffects = new System.Windows.Forms.Label();
            this.btnOpenFrom = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnOpenObj = new MaterialSkin.Controls.MaterialRaisedButton();
            this.gridRegisters = new System.Windows.Forms.DataGridView();
            this.Register = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridMapMemory = new System.Windows.Forms.DataGridView();
            this.addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colum0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.materialTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxEditor)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabsimGrid)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSourceCode)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegisters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMapMemory)).BeginInit();
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
            // materialTabControl1
            // 
            this.materialTabControl1.BaseTabControl = this.materialTabControl;
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-2, 62);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.Size = new System.Drawing.Size(834, 40);
            this.materialTabControl1.TabIndex = 4;
            this.materialTabControl1.Text = "materialTabSelector1";
            // 
            // materialTabControl
            // 
            this.materialTabControl.Controls.Add(this.tabPage1);
            this.materialTabControl.Controls.Add(this.tabPage2);
            this.materialTabControl.Controls.Add(this.tabPage3);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Location = new System.Drawing.Point(-2, 108);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(834, 446);
            this.materialTabControl.TabIndex = 3;
            this.materialTabControl.TabStop = false;
            this.materialTabControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AutoRun);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(826, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Editor & Errors";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbErrors);
            this.groupBox2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.groupBox2.Location = new System.Drawing.Point(14, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(803, 93);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Warnings & Errors";
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
            this.groupBox1.Location = new System.Drawing.Point(14, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 299);
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
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(826, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SIC output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.progSize);
            this.groupBox6.Controls.Add(this.tabsimGrid);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox6.Location = new System.Drawing.Point(560, 7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(257, 279);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "TABSIM & Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(50, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Program Size:";
            // 
            // progSize
            // 
            this.progSize.AutoSize = true;
            this.progSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.progSize.ForeColor = System.Drawing.SystemColors.Control;
            this.progSize.Location = new System.Drawing.Point(172, 247);
            this.progSize.Name = "progSize";
            this.progSize.Size = new System.Drawing.Size(20, 17);
            this.progSize.TabIndex = 3;
            this.progSize.Text = "...";
            // 
            // tabsimGrid
            // 
            this.tabsimGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.tabsimGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabsimGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabsimGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabsimGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.tabsimGrid.Location = new System.Drawing.Point(49, 20);
            this.tabsimGrid.Name = "tabsimGrid";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabsimGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabsimGrid.RowHeadersVisible = false;
            this.tabsimGrid.Size = new System.Drawing.Size(153, 205);
            this.tabsimGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Symbol";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Adrs";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.gridSourceCode);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(16, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(524, 282);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parsed Code";
            // 
            // gridSourceCode
            // 
            this.gridSourceCode.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.gridSourceCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSourceCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSourceCode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Line,
            this.CP,
            this.TAG,
            this.INSTRUCTION,
            this.ADDRESS,
            this.OBJ});
            this.gridSourceCode.Location = new System.Drawing.Point(6, 19);
            this.gridSourceCode.Name = "gridSourceCode";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSourceCode.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridSourceCode.RowHeadersVisible = false;
            this.gridSourceCode.Size = new System.Drawing.Size(506, 257);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.objFileTextBox);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(14, 292);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(803, 132);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "OBJ File";
            // 
            // objFileTextBox
            // 
            this.objFileTextBox.BackColor = System.Drawing.Color.DimGray;
            this.objFileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.objFileTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.objFileTextBox.Location = new System.Drawing.Point(6, 20);
            this.objFileTextBox.Name = "objFileTextBox";
            this.objFileTextBox.Size = new System.Drawing.Size(788, 104);
            this.objFileTextBox.TabIndex = 5;
            this.objFileTextBox.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.tbNumLoops);
            this.tabPage3.Controls.Add(this.btnRunEffect);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.btnOpenFrom);
            this.tabPage3.Controls.Add(this.btnOpenObj);
            this.tabPage3.Controls.Add(this.gridRegisters);
            this.tabPage3.Controls.Add(this.gridMapMemory);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(826, 420);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Map Memory";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbNumLoops
            // 
            this.tbNumLoops.Location = new System.Drawing.Point(678, 340);
            this.tbNumLoops.Name = "tbNumLoops";
            this.tbNumLoops.Size = new System.Drawing.Size(110, 20);
            this.tbNumLoops.TabIndex = 16;
            // 
            // btnRunEffect
            // 
            this.btnRunEffect.Depth = 0;
            this.btnRunEffect.Location = new System.Drawing.Point(687, 366);
            this.btnRunEffect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRunEffect.Name = "btnRunEffect";
            this.btnRunEffect.Primary = true;
            this.btnRunEffect.Size = new System.Drawing.Size(91, 32);
            this.btnRunEffect.TabIndex = 15;
            this.btnRunEffect.Text = "Run";
            this.btnRunEffect.UseVisualStyleBackColor = true;
            this.btnRunEffect.Click += new System.EventHandler(this.btnRunEffect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.groupBox3.Location = new System.Drawing.Point(10, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(639, 182);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Effects Viewer";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tbEffects);
            this.panel1.Location = new System.Drawing.Point(7, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 157);
            this.panel1.TabIndex = 0;
            // 
            // tbEffects
            // 
            this.tbEffects.AutoSize = true;
            this.tbEffects.Location = new System.Drawing.Point(27, 20);
            this.tbEffects.Name = "tbEffects";
            this.tbEffects.Size = new System.Drawing.Size(0, 13);
            this.tbEffects.TabIndex = 0;
            // 
            // btnOpenFrom
            // 
            this.btnOpenFrom.Depth = 0;
            this.btnOpenFrom.Location = new System.Drawing.Point(687, 260);
            this.btnOpenFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenFrom.Name = "btnOpenFrom";
            this.btnOpenFrom.Primary = true;
            this.btnOpenFrom.Size = new System.Drawing.Size(91, 32);
            this.btnOpenFrom.TabIndex = 6;
            this.btnOpenFrom.Text = "Open From OBJ";
            this.btnOpenFrom.UseVisualStyleBackColor = true;
            this.btnOpenFrom.Click += new System.EventHandler(this.btnOpenFrom_Click);
            // 
            // btnOpenObj
            // 
            this.btnOpenObj.Depth = 0;
            this.btnOpenObj.Location = new System.Drawing.Point(687, 222);
            this.btnOpenObj.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenObj.Name = "btnOpenObj";
            this.btnOpenObj.Primary = true;
            this.btnOpenObj.Size = new System.Drawing.Size(91, 32);
            this.btnOpenObj.TabIndex = 5;
            this.btnOpenObj.Text = "Charge OBJ";
            this.btnOpenObj.UseVisualStyleBackColor = true;
            this.btnOpenObj.Click += new System.EventHandler(this.BtnOpenObj_Click);
            // 
            // gridRegisters
            // 
            this.gridRegisters.AllowUserToAddRows = false;
            this.gridRegisters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRegisters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Register,
            this.Value});
            this.gridRegisters.Location = new System.Drawing.Point(664, 12);
            this.gridRegisters.Name = "gridRegisters";
            this.gridRegisters.RowHeadersVisible = false;
            this.gridRegisters.Size = new System.Drawing.Size(141, 188);
            this.gridRegisters.TabIndex = 1;
            // 
            // Register
            // 
            this.Register.HeaderText = "Reg";
            this.Register.Name = "Register";
            this.Register.Width = 35;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // gridMapMemory
            // 
            this.gridMapMemory.AllowUserToAddRows = false;
            this.gridMapMemory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMapMemory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addr,
            this.Colum0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.gridMapMemory.Location = new System.Drawing.Point(10, 12);
            this.gridMapMemory.Name = "gridMapMemory";
            this.gridMapMemory.RowHeadersVisible = false;
            this.gridMapMemory.Size = new System.Drawing.Size(627, 188);
            this.gridMapMemory.TabIndex = 0;
            // 
            // addr
            // 
            this.addr.HeaderText = "Address";
            this.addr.MinimumWidth = 60;
            this.addr.Name = "addr";
            this.addr.Width = 60;
            // 
            // Colum0
            // 
            this.Colum0.HeaderText = "0";
            this.Colum0.Name = "Colum0";
            this.Colum0.Width = 35;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 35;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "2";
            this.Column2.Name = "Column2";
            this.Column2.Width = 35;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "3";
            this.Column3.Name = "Column3";
            this.Column3.Width = 35;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "4";
            this.Column4.Name = "Column4";
            this.Column4.Width = 35;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "5";
            this.Column5.Name = "Column5";
            this.Column5.Width = 35;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "6";
            this.Column6.Name = "Column6";
            this.Column6.Width = 35;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "7";
            this.Column7.Name = "Column7";
            this.Column7.Width = 35;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "8";
            this.Column8.Name = "Column8";
            this.Column8.Width = 35;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "9";
            this.Column9.Name = "Column9";
            this.Column9.Width = 35;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "A";
            this.Column10.Name = "Column10";
            this.Column10.Width = 35;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "B";
            this.Column11.Name = "Column11";
            this.Column11.Width = 35;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "C";
            this.Column12.Name = "Column12";
            this.Column12.Width = 35;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "D";
            this.Column13.Name = "Column13";
            this.Column13.Width = 35;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "E";
            this.Column14.Name = "Column14";
            this.Column14.Width = 35;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "F";
            this.Column15.Name = "Column15";
            this.Column15.Width = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(669, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Number of lines to execute:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(831, 547);
            this.Controls.Add(this.materialTabControl);
            this.Controls.Add(this.btnRunASM);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "MainForm";
            this.Text = "IDE for SIC STANDARD";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.materialTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxEditor)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabsimGrid)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSourceCode)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegisters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMapMemory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnRunASM;
        private MaterialSkin.Controls.MaterialTabSelector materialTabControl1;
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
        private System.Windows.Forms.DataGridView tabsimGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label progSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox objFileTextBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView gridMapMemory;
        private System.Windows.Forms.DataGridView gridRegisters;
        private System.Windows.Forms.DataGridViewTextBoxColumn Register;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colum0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenObj;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenFrom;
        private MaterialSkin.Controls.MaterialRaisedButton btnRunEffect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbNumLoops;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tbEffects;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label2;
    }
}

