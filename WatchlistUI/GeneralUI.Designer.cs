
namespace WatchlistUI
{
    partial class GeneralUI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnOnWatch = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSortTitle = new System.Windows.Forms.Button();
            this.btnSortScore = new System.Windows.Forms.Button();
            this.btnSortDate = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitleFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScoreFilter = new System.Windows.Forms.TextBox();
            this.cmbScoreFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDateFilter = new System.Windows.Forms.ComboBox();
            this.txtDateFilter1 = new System.Windows.Forms.TextBox();
            this.txtDateFilter2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCategoryFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 298);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(487, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(505, 564);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(160, 56);
            this.btnRoll.TabIndex = 1;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnOnWatch
            // 
            this.btnOnWatch.Location = new System.Drawing.Point(12, 12);
            this.btnOnWatch.Name = "btnOnWatch";
            this.btnOnWatch.Size = new System.Drawing.Size(220, 52);
            this.btnOnWatch.TabIndex = 3;
            this.btnOnWatch.Text = "On Watch";
            this.btnOnWatch.UseVisualStyleBackColor = true;
            this.btnOnWatch.Click += new System.EventHandler(this.btnOnWatch_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.Location = new System.Drawing.Point(248, 12);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(241, 52);
            this.btnCompleted.TabIndex = 4;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.UseVisualStyleBackColor = true;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(505, 402);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(160, 56);
            this.btnTransfer.TabIndex = 5;
            this.btnTransfer.Text = "Transfer to Completed";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(495, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(170, 51);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(505, 298);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 46);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(505, 350);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(160, 46);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(505, 464);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 46);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSortTitle
            // 
            this.btnSortTitle.Location = new System.Drawing.Point(12, 246);
            this.btnSortTitle.Name = "btnSortTitle";
            this.btnSortTitle.Size = new System.Drawing.Size(82, 46);
            this.btnSortTitle.TabIndex = 10;
            this.btnSortTitle.Text = "Title";
            this.btnSortTitle.UseVisualStyleBackColor = true;
            this.btnSortTitle.Click += new System.EventHandler(this.btnSortTitle_Click);
            // 
            // btnSortScore
            // 
            this.btnSortScore.Location = new System.Drawing.Point(100, 246);
            this.btnSortScore.Name = "btnSortScore";
            this.btnSortScore.Size = new System.Drawing.Size(77, 46);
            this.btnSortScore.TabIndex = 11;
            this.btnSortScore.Text = "Score";
            this.btnSortScore.UseVisualStyleBackColor = true;
            this.btnSortScore.Click += new System.EventHandler(this.btnSortScore_Click);
            // 
            // btnSortDate
            // 
            this.btnSortDate.Location = new System.Drawing.Point(183, 246);
            this.btnSortDate.Name = "btnSortDate";
            this.btnSortDate.Size = new System.Drawing.Size(74, 46);
            this.btnSortDate.TabIndex = 12;
            this.btnSortDate.Text = "Date";
            this.btnSortDate.UseVisualStyleBackColor = true;
            this.btnSortDate.Click += new System.EventHandler(this.btnSortDate_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(557, 84);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(74, 46);
            this.btnFilter.TabIndex = 13;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCategoryFilter);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDateFilter2);
            this.groupBox1.Controls.Add(this.txtDateFilter1);
            this.groupBox1.Controls.Add(this.cmbDateFilter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbScoreFilter);
            this.groupBox1.Controls.Add(this.txtScoreFilter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTitleFilter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 142);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtering";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // txtTitleFilter
            // 
            this.txtTitleFilter.Location = new System.Drawing.Point(77, 31);
            this.txtTitleFilter.Name = "txtTitleFilter";
            this.txtTitleFilter.Size = new System.Drawing.Size(157, 20);
            this.txtTitleFilter.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score";
            // 
            // txtScoreFilter
            // 
            this.txtScoreFilter.Location = new System.Drawing.Point(134, 57);
            this.txtScoreFilter.Name = "txtScoreFilter";
            this.txtScoreFilter.Size = new System.Drawing.Size(100, 20);
            this.txtScoreFilter.TabIndex = 3;
            // 
            // cmbScoreFilter
            // 
            this.cmbScoreFilter.FormattingEnabled = true;
            this.cmbScoreFilter.Location = new System.Drawing.Point(77, 57);
            this.cmbScoreFilter.Name = "cmbScoreFilter";
            this.cmbScoreFilter.Size = new System.Drawing.Size(41, 21);
            this.cmbScoreFilter.TabIndex = 4;
            this.cmbScoreFilter.Text = ">";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // cmbDateFilter
            // 
            this.cmbDateFilter.FormattingEnabled = true;
            this.cmbDateFilter.Location = new System.Drawing.Point(77, 84);
            this.cmbDateFilter.Name = "cmbDateFilter";
            this.cmbDateFilter.Size = new System.Drawing.Size(41, 21);
            this.cmbDateFilter.TabIndex = 6;
            this.cmbDateFilter.Text = ">";
            // 
            // txtDateFilter1
            // 
            this.txtDateFilter1.Location = new System.Drawing.Point(134, 84);
            this.txtDateFilter1.Name = "txtDateFilter1";
            this.txtDateFilter1.Size = new System.Drawing.Size(100, 20);
            this.txtDateFilter1.TabIndex = 7;
            // 
            // txtDateFilter2
            // 
            this.txtDateFilter2.Location = new System.Drawing.Point(240, 84);
            this.txtDateFilter2.Name = "txtDateFilter2";
            this.txtDateFilter2.Size = new System.Drawing.Size(100, 20);
            this.txtDateFilter2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Category";
            // 
            // cmbCategoryFilter
            // 
            this.cmbCategoryFilter.FormattingEnabled = true;
            this.cmbCategoryFilter.Location = new System.Drawing.Point(77, 116);
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new System.Drawing.Size(157, 21);
            this.cmbCategoryFilter.TabIndex = 10;
            // 
            // GeneralUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 632);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSortDate);
            this.Controls.Add(this.btnSortScore);
            this.Controls.Add(this.btnSortTitle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.btnOnWatch);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GeneralUI";
            this.Text = "GeneralUI";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnOnWatch;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSortTitle;
        private System.Windows.Forms.Button btnSortScore;
        private System.Windows.Forms.Button btnSortDate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCategoryFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDateFilter2;
        private System.Windows.Forms.TextBox txtDateFilter1;
        private System.Windows.Forms.ComboBox cmbDateFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbScoreFilter;
        private System.Windows.Forms.TextBox txtScoreFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitleFilter;
        private System.Windows.Forms.Label label1;
    }
}