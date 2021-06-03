
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
            this.cmbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDateFilterMax = new System.Windows.Forms.TextBox();
            this.txtDateFilterMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScoreFilterMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitleFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCurrentList = new System.Windows.Forms.ComboBox();
            this.txtScoreFilterMax = new System.Windows.Forms.TextBox();
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
            this.btnOnWatch.Location = new System.Drawing.Point(310, 12);
            this.btnOnWatch.Name = "btnOnWatch";
            this.btnOnWatch.Size = new System.Drawing.Size(85, 52);
            this.btnOnWatch.TabIndex = 3;
            this.btnOnWatch.Text = "On Watch";
            this.btnOnWatch.UseVisualStyleBackColor = true;
            this.btnOnWatch.Click += new System.EventHandler(this.btnOnWatch_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.Location = new System.Drawing.Point(401, 12);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(88, 52);
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
            this.groupBox1.Controls.Add(this.txtScoreFilterMax);
            this.groupBox1.Controls.Add(this.cmbCategoryFilter);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDateFilterMax);
            this.groupBox1.Controls.Add(this.txtDateFilterMin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtScoreFilterMin);
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
            // cmbCategoryFilter
            // 
            this.cmbCategoryFilter.FormattingEnabled = true;
            this.cmbCategoryFilter.Location = new System.Drawing.Point(77, 116);
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new System.Drawing.Size(157, 21);
            this.cmbCategoryFilter.TabIndex = 10;
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
            // txtDateFilterMax
            // 
            this.txtDateFilterMax.Location = new System.Drawing.Point(183, 87);
            this.txtDateFilterMax.Name = "txtDateFilterMax";
            this.txtDateFilterMax.Size = new System.Drawing.Size(100, 20);
            this.txtDateFilterMax.TabIndex = 8;
            // 
            // txtDateFilterMin
            // 
            this.txtDateFilterMin.Location = new System.Drawing.Point(77, 87);
            this.txtDateFilterMin.Name = "txtDateFilterMin";
            this.txtDateFilterMin.Size = new System.Drawing.Size(100, 20);
            this.txtDateFilterMin.TabIndex = 7;
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
            // txtScoreFilterMin
            // 
            this.txtScoreFilterMin.Location = new System.Drawing.Point(77, 61);
            this.txtScoreFilterMin.Name = "txtScoreFilterMin";
            this.txtScoreFilterMin.Size = new System.Drawing.Size(100, 20);
            this.txtScoreFilterMin.TabIndex = 3;
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
            // txtTitleFilter
            // 
            this.txtTitleFilter.Location = new System.Drawing.Point(77, 31);
            this.txtTitleFilter.Name = "txtTitleFilter";
            this.txtTitleFilter.Size = new System.Drawing.Size(157, 20);
            this.txtTitleFilter.TabIndex = 1;
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
            // cmbCurrentList
            // 
            this.cmbCurrentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbCurrentList.FormattingEnabled = true;
            this.cmbCurrentList.Location = new System.Drawing.Point(23, 19);
            this.cmbCurrentList.Name = "cmbCurrentList";
            this.cmbCurrentList.Size = new System.Drawing.Size(245, 33);
            this.cmbCurrentList.TabIndex = 15;
            // 
            // txtScoreFilterMax
            // 
            this.txtScoreFilterMax.Location = new System.Drawing.Point(183, 62);
            this.txtScoreFilterMax.Name = "txtScoreFilterMax";
            this.txtScoreFilterMax.Size = new System.Drawing.Size(100, 20);
            this.txtScoreFilterMax.TabIndex = 14;
            // 
            // GeneralUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(672, 632);
            this.Controls.Add(this.cmbCurrentList);
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
        private System.Windows.Forms.TextBox txtDateFilterMax;
        private System.Windows.Forms.TextBox txtDateFilterMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScoreFilterMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitleFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCurrentList;
        private System.Windows.Forms.TextBox txtScoreFilterMax;
    }
}