namespace DailyApp.Web
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
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.LabelTitleNewDaily = new System.Windows.Forms.Label();
            this.LabelDescriptionNewDaily = new System.Windows.Forms.Label();
            this.LabelIsDoneNewDaily = new System.Windows.Forms.Label();
            this.TbxDescriptionNewDaily = new System.Windows.Forms.RichTextBox();
            this.TbxTitleNewDaily = new System.Windows.Forms.TextBox();
            this.CbxIsDoneNewDaily = new System.Windows.Forms.CheckBox();
            this.ButtonNewDaily = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TbxDescriptionUpdateDaily = new System.Windows.Forms.RichTextBox();
            this.ButtonUpdateDaily = new System.Windows.Forms.Button();
            this.LabelTitleUpdateDaily = new System.Windows.Forms.Label();
            this.CbxIsDoneUpdateDaily = new System.Windows.Forms.CheckBox();
            this.LabelDescriptionUpdateDaily = new System.Windows.Forms.Label();
            this.TbxTitleUpdateDaily = new System.Windows.Forms.TextBox();
            this.LabelIsDoneUpdateDaily = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.TbxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvData
            // 
            this.DgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Location = new System.Drawing.Point(32, 34);
            this.DgvData.Name = "DgvData";
            this.DgvData.Size = new System.Drawing.Size(917, 218);
            this.DgvData.TabIndex = 0;
            this.DgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellClick);
            // 
            // LabelTitleNewDaily
            // 
            this.LabelTitleNewDaily.AutoSize = true;
            this.LabelTitleNewDaily.Location = new System.Drawing.Point(43, 16);
            this.LabelTitleNewDaily.Name = "LabelTitleNewDaily";
            this.LabelTitleNewDaily.Size = new System.Drawing.Size(30, 13);
            this.LabelTitleNewDaily.TabIndex = 1;
            this.LabelTitleNewDaily.Text = "Title:";
            // 
            // LabelDescriptionNewDaily
            // 
            this.LabelDescriptionNewDaily.AutoSize = true;
            this.LabelDescriptionNewDaily.Location = new System.Drawing.Point(43, 55);
            this.LabelDescriptionNewDaily.Name = "LabelDescriptionNewDaily";
            this.LabelDescriptionNewDaily.Size = new System.Drawing.Size(63, 13);
            this.LabelDescriptionNewDaily.TabIndex = 2;
            this.LabelDescriptionNewDaily.Text = "Description:";
            // 
            // LabelIsDoneNewDaily
            // 
            this.LabelIsDoneNewDaily.AutoSize = true;
            this.LabelIsDoneNewDaily.Location = new System.Drawing.Point(43, 194);
            this.LabelIsDoneNewDaily.Name = "LabelIsDoneNewDaily";
            this.LabelIsDoneNewDaily.Size = new System.Drawing.Size(47, 13);
            this.LabelIsDoneNewDaily.TabIndex = 3;
            this.LabelIsDoneNewDaily.Text = "Is Done:";
            // 
            // TbxDescriptionNewDaily
            // 
            this.TbxDescriptionNewDaily.Location = new System.Drawing.Point(124, 55);
            this.TbxDescriptionNewDaily.Name = "TbxDescriptionNewDaily";
            this.TbxDescriptionNewDaily.Size = new System.Drawing.Size(255, 115);
            this.TbxDescriptionNewDaily.TabIndex = 4;
            this.TbxDescriptionNewDaily.Text = "";
            // 
            // TbxTitleNewDaily
            // 
            this.TbxTitleNewDaily.Location = new System.Drawing.Point(124, 16);
            this.TbxTitleNewDaily.Name = "TbxTitleNewDaily";
            this.TbxTitleNewDaily.Size = new System.Drawing.Size(255, 20);
            this.TbxTitleNewDaily.TabIndex = 5;
            // 
            // CbxIsDoneNewDaily
            // 
            this.CbxIsDoneNewDaily.AutoSize = true;
            this.CbxIsDoneNewDaily.Location = new System.Drawing.Point(124, 194);
            this.CbxIsDoneNewDaily.Name = "CbxIsDoneNewDaily";
            this.CbxIsDoneNewDaily.Size = new System.Drawing.Size(61, 17);
            this.CbxIsDoneNewDaily.TabIndex = 6;
            this.CbxIsDoneNewDaily.Text = "I Done!";
            this.CbxIsDoneNewDaily.UseVisualStyleBackColor = true;
            // 
            // ButtonNewDaily
            // 
            this.ButtonNewDaily.Location = new System.Drawing.Point(171, 227);
            this.ButtonNewDaily.Name = "ButtonNewDaily";
            this.ButtonNewDaily.Size = new System.Drawing.Size(130, 23);
            this.ButtonNewDaily.TabIndex = 7;
            this.ButtonNewDaily.Text = "Send New Daily";
            this.ButtonNewDaily.UseVisualStyleBackColor = true;
            this.ButtonNewDaily.Click += new System.EventHandler(this.ButtonNewDaily_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbxDescriptionNewDaily);
            this.groupBox1.Controls.Add(this.ButtonNewDaily);
            this.groupBox1.Controls.Add(this.LabelTitleNewDaily);
            this.groupBox1.Controls.Add(this.CbxIsDoneNewDaily);
            this.groupBox1.Controls.Add(this.LabelDescriptionNewDaily);
            this.groupBox1.Controls.Add(this.TbxTitleNewDaily);
            this.groupBox1.Controls.Add(this.LabelIsDoneNewDaily);
            this.groupBox1.Location = new System.Drawing.Point(32, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 256);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Daily";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TbxDescriptionUpdateDaily);
            this.groupBox2.Controls.Add(this.ButtonUpdateDaily);
            this.groupBox2.Controls.Add(this.LabelTitleUpdateDaily);
            this.groupBox2.Controls.Add(this.CbxIsDoneUpdateDaily);
            this.groupBox2.Controls.Add(this.LabelDescriptionUpdateDaily);
            this.groupBox2.Controls.Add(this.TbxTitleUpdateDaily);
            this.groupBox2.Controls.Add(this.LabelIsDoneUpdateDaily);
            this.groupBox2.Location = new System.Drawing.Point(498, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 256);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Daily";
            // 
            // TbxDescriptionUpdateDaily
            // 
            this.TbxDescriptionUpdateDaily.Location = new System.Drawing.Point(124, 55);
            this.TbxDescriptionUpdateDaily.Name = "TbxDescriptionUpdateDaily";
            this.TbxDescriptionUpdateDaily.Size = new System.Drawing.Size(255, 115);
            this.TbxDescriptionUpdateDaily.TabIndex = 4;
            this.TbxDescriptionUpdateDaily.Text = "";
            // 
            // ButtonUpdateDaily
            // 
            this.ButtonUpdateDaily.Location = new System.Drawing.Point(171, 227);
            this.ButtonUpdateDaily.Name = "ButtonUpdateDaily";
            this.ButtonUpdateDaily.Size = new System.Drawing.Size(130, 23);
            this.ButtonUpdateDaily.TabIndex = 7;
            this.ButtonUpdateDaily.Text = "Update Daily";
            this.ButtonUpdateDaily.UseVisualStyleBackColor = true;
            this.ButtonUpdateDaily.Click += new System.EventHandler(this.ButtonUpdateDaily_Click);
            // 
            // LabelTitleUpdateDaily
            // 
            this.LabelTitleUpdateDaily.AutoSize = true;
            this.LabelTitleUpdateDaily.Location = new System.Drawing.Point(43, 16);
            this.LabelTitleUpdateDaily.Name = "LabelTitleUpdateDaily";
            this.LabelTitleUpdateDaily.Size = new System.Drawing.Size(30, 13);
            this.LabelTitleUpdateDaily.TabIndex = 1;
            this.LabelTitleUpdateDaily.Text = "Title:";
            // 
            // CbxIsDoneUpdateDaily
            // 
            this.CbxIsDoneUpdateDaily.AutoSize = true;
            this.CbxIsDoneUpdateDaily.Location = new System.Drawing.Point(124, 194);
            this.CbxIsDoneUpdateDaily.Name = "CbxIsDoneUpdateDaily";
            this.CbxIsDoneUpdateDaily.Size = new System.Drawing.Size(61, 17);
            this.CbxIsDoneUpdateDaily.TabIndex = 6;
            this.CbxIsDoneUpdateDaily.Text = "I Done!";
            this.CbxIsDoneUpdateDaily.UseVisualStyleBackColor = true;
            // 
            // LabelDescriptionUpdateDaily
            // 
            this.LabelDescriptionUpdateDaily.AutoSize = true;
            this.LabelDescriptionUpdateDaily.Location = new System.Drawing.Point(43, 55);
            this.LabelDescriptionUpdateDaily.Name = "LabelDescriptionUpdateDaily";
            this.LabelDescriptionUpdateDaily.Size = new System.Drawing.Size(63, 13);
            this.LabelDescriptionUpdateDaily.TabIndex = 2;
            this.LabelDescriptionUpdateDaily.Text = "Description:";
            // 
            // TbxTitleUpdateDaily
            // 
            this.TbxTitleUpdateDaily.Location = new System.Drawing.Point(124, 16);
            this.TbxTitleUpdateDaily.Name = "TbxTitleUpdateDaily";
            this.TbxTitleUpdateDaily.Size = new System.Drawing.Size(255, 20);
            this.TbxTitleUpdateDaily.TabIndex = 5;
            // 
            // LabelIsDoneUpdateDaily
            // 
            this.LabelIsDoneUpdateDaily.AutoSize = true;
            this.LabelIsDoneUpdateDaily.Location = new System.Drawing.Point(43, 194);
            this.LabelIsDoneUpdateDaily.Name = "LabelIsDoneUpdateDaily";
            this.LabelIsDoneUpdateDaily.Size = new System.Drawing.Size(47, 13);
            this.LabelIsDoneUpdateDaily.TabIndex = 3;
            this.LabelIsDoneUpdateDaily.Text = "Is Done:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(421, 534);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 23);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete Selected Daily";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Location = new System.Drawing.Point(748, 12);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(44, 13);
            this.LabelSearch.TabIndex = 11;
            this.LabelSearch.Text = "Search:";
            // 
            // TbxSearch
            // 
            this.TbxSearch.Location = new System.Drawing.Point(798, 9);
            this.TbxSearch.Name = "TbxSearch";
            this.TbxSearch.Size = new System.Drawing.Size(151, 20);
            this.TbxSearch.TabIndex = 12;
            this.TbxSearch.TextChanged += new System.EventHandler(this.TbxSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 569);
            this.Controls.Add(this.TbxSearch);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.Label LabelTitleNewDaily;
        private System.Windows.Forms.Label LabelDescriptionNewDaily;
        private System.Windows.Forms.Label LabelIsDoneNewDaily;
        private System.Windows.Forms.RichTextBox TbxDescriptionNewDaily;
        private System.Windows.Forms.TextBox TbxTitleNewDaily;
        private System.Windows.Forms.CheckBox CbxIsDoneNewDaily;
        private System.Windows.Forms.Button ButtonNewDaily;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox TbxDescriptionUpdateDaily;
        private System.Windows.Forms.Button ButtonUpdateDaily;
        private System.Windows.Forms.Label LabelTitleUpdateDaily;
        private System.Windows.Forms.CheckBox CbxIsDoneUpdateDaily;
        private System.Windows.Forms.Label LabelDescriptionUpdateDaily;
        private System.Windows.Forms.TextBox TbxTitleUpdateDaily;
        private System.Windows.Forms.Label LabelIsDoneUpdateDaily;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.TextBox TbxSearch;
    }
}

