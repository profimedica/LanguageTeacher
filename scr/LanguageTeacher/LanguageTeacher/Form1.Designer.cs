namespace LanguageTeacher
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new LanguageTeacher.DataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.foreignDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nativeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Difficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxCurrentWord = new System.Windows.Forms.TextBox();
            this.listBoxOptions = new System.Windows.Forms.ListBox();
            this.labelAnsware = new System.Windows.Forms.Label();
            this.labelStatistics = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Words";
            this.bindingSource1.DataSource = this.dataSet1;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foreignDataGridViewTextBoxColumn,
            this.nativeDataGridViewTextBoxColumn,
            this.Difficulty,
            this.Class});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(443, 259);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.NewRowNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_NewRowNeeded);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            // 
            // foreignDataGridViewTextBoxColumn
            // 
            this.foreignDataGridViewTextBoxColumn.DataPropertyName = "Foreign";
            this.foreignDataGridViewTextBoxColumn.HeaderText = "Foreign";
            this.foreignDataGridViewTextBoxColumn.Name = "foreignDataGridViewTextBoxColumn";
            this.foreignDataGridViewTextBoxColumn.Width = 200;
            // 
            // nativeDataGridViewTextBoxColumn
            // 
            this.nativeDataGridViewTextBoxColumn.DataPropertyName = "Native";
            this.nativeDataGridViewTextBoxColumn.HeaderText = "Native";
            this.nativeDataGridViewTextBoxColumn.Name = "nativeDataGridViewTextBoxColumn";
            this.nativeDataGridViewTextBoxColumn.Width = 200;
            // 
            // Difficulty
            // 
            this.Difficulty.DataPropertyName = "Difficulty";
            this.Difficulty.HeaderText = "Dif";
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Width = 35;
            // 
            // textBoxCurrentWord
            // 
            this.textBoxCurrentWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrentWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentWord.Location = new System.Drawing.Point(3, 39);
            this.textBoxCurrentWord.Name = "textBoxCurrentWord";
            this.textBoxCurrentWord.Size = new System.Drawing.Size(653, 38);
            this.textBoxCurrentWord.TabIndex = 1;
            // 
            // listBoxOptions
            // 
            this.listBoxOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOptions.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listBoxOptions.FormattingEnabled = true;
            this.listBoxOptions.ItemHeight = 29;
            this.listBoxOptions.Location = new System.Drawing.Point(3, 113);
            this.listBoxOptions.Name = "listBoxOptions";
            this.listBoxOptions.Size = new System.Drawing.Size(653, 149);
            this.listBoxOptions.TabIndex = 2;
            this.listBoxOptions.SelectedIndexChanged += new System.EventHandler(this.listBoxOptions_SelectedIndexChanged);
            // 
            // labelAnsware
            // 
            this.labelAnsware.AutoSize = true;
            this.labelAnsware.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnsware.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelAnsware.Location = new System.Drawing.Point(3, 82);
            this.labelAnsware.Name = "labelAnsware";
            this.labelAnsware.Size = new System.Drawing.Size(283, 25);
            this.labelAnsware.TabIndex = 3;
            this.labelAnsware.Text = "select the corect translation:";
            // 
            // labelStatistics
            // 
            this.labelStatistics.AutoSize = true;
            this.labelStatistics.Location = new System.Drawing.Point(311, 12);
            this.labelStatistics.Name = "labelStatistics";
            this.labelStatistics.Size = new System.Drawing.Size(72, 17);
            this.labelStatistics.TabIndex = 4;
            this.labelStatistics.Text = "Statistics: ";
            // 
            // Class
            // 
            this.Class.DataPropertyName = "Class";
            this.Class.HeaderText = "Class";
            this.Class.Name = "Class";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(441, 83);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(215, 24);
            this.comboBoxClass.TabIndex = 5;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelStatistics);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxClass);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxCurrentWord);
            this.splitContainer1.Panel1.Controls.Add(this.listBoxOptions);
            this.splitContainer1.Panel1.Controls.Add(this.labelAnsware);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1112, 265);
            this.splitContainer1.SplitterDistance = 659;
            this.splitContainer1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 289);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Language Teacher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxCurrentWord;
        private System.Windows.Forms.ListBox listBoxOptions;
        private System.Windows.Forms.Label labelAnsware;
        private System.Windows.Forms.Label labelStatistics;
        private System.Windows.Forms.DataGridViewTextBoxColumn foreignDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nativeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Difficulty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

