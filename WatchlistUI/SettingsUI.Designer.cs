
namespace WatchlistUI
{
    partial class SettingsUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.btnExport1 = new System.Windows.Forms.Button();
            this.btnImport1 = new System.Windows.Forms.Button();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtCategory1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDefault = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnExport2 = new System.Windows.Forms.Button();
            this.btnImport2 = new System.Windows.Forms.Button();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtCategory2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete3 = new System.Windows.Forms.Button();
            this.btnExport3 = new System.Windows.Forms.Button();
            this.btnImport3 = new System.Windows.Forms.Button();
            this.txtName3 = new System.Windows.Forms.TextBox();
            this.txtCategory3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete1);
            this.groupBox1.Controls.Add(this.btnExport1);
            this.groupBox1.Controls.Add(this.btnImport1);
            this.groupBox1.Controls.Add(this.txtName1);
            this.groupBox1.Controls.Add(this.txtCategory1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List #1";
            // 
            // btnDelete1
            // 
            this.btnDelete1.Location = new System.Drawing.Point(278, 80);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(100, 40);
            this.btnDelete1.TabIndex = 11;
            this.btnDelete1.Text = "Delete All";
            this.btnDelete1.UseVisualStyleBackColor = true;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // btnExport1
            // 
            this.btnExport1.Location = new System.Drawing.Point(172, 80);
            this.btnExport1.Name = "btnExport1";
            this.btnExport1.Size = new System.Drawing.Size(100, 40);
            this.btnExport1.TabIndex = 10;
            this.btnExport1.Text = "Export";
            this.btnExport1.UseVisualStyleBackColor = true;
            this.btnExport1.Click += new System.EventHandler(this.btnExport1_Click);
            // 
            // btnImport1
            // 
            this.btnImport1.Location = new System.Drawing.Point(66, 80);
            this.btnImport1.Name = "btnImport1";
            this.btnImport1.Size = new System.Drawing.Size(100, 40);
            this.btnImport1.TabIndex = 9;
            this.btnImport1.Text = "Import";
            this.btnImport1.UseVisualStyleBackColor = true;
            this.btnImport1.Click += new System.EventHandler(this.btnImport1_Click);
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(66, 28);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(312, 20);
            this.txtName1.TabIndex = 3;
            // 
            // txtCategory1
            // 
            this.txtCategory1.Location = new System.Drawing.Point(66, 54);
            this.txtCategory1.Name = "txtCategory1";
            this.txtCategory1.Size = new System.Drawing.Size(312, 20);
            this.txtCategory1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categories";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Default List";
            // 
            // cmbDefault
            // 
            this.cmbDefault.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDefault.FormattingEnabled = true;
            this.cmbDefault.Location = new System.Drawing.Point(78, 443);
            this.cmbDefault.Name = "cmbDefault";
            this.cmbDefault.Size = new System.Drawing.Size(312, 21);
            this.cmbDefault.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(184, 489);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(290, 489);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox2.Controls.Add(this.btnDelete2);
            this.groupBox2.Controls.Add(this.btnExport2);
            this.groupBox2.Controls.Add(this.btnImport2);
            this.groupBox2.Controls.Add(this.txtName2);
            this.groupBox2.Controls.Add(this.txtCategory2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 130);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List #2";
            // 
            // btnDelete2
            // 
            this.btnDelete2.Location = new System.Drawing.Point(278, 80);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(100, 40);
            this.btnDelete2.TabIndex = 11;
            this.btnDelete2.Text = "Delete All";
            this.btnDelete2.UseVisualStyleBackColor = true;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // btnExport2
            // 
            this.btnExport2.Location = new System.Drawing.Point(172, 80);
            this.btnExport2.Name = "btnExport2";
            this.btnExport2.Size = new System.Drawing.Size(100, 40);
            this.btnExport2.TabIndex = 10;
            this.btnExport2.Text = "Export";
            this.btnExport2.UseVisualStyleBackColor = true;
            this.btnExport2.Click += new System.EventHandler(this.btnExport2_Click);
            // 
            // btnImport2
            // 
            this.btnImport2.Location = new System.Drawing.Point(66, 80);
            this.btnImport2.Name = "btnImport2";
            this.btnImport2.Size = new System.Drawing.Size(100, 40);
            this.btnImport2.TabIndex = 9;
            this.btnImport2.Text = "Import";
            this.btnImport2.UseVisualStyleBackColor = true;
            this.btnImport2.Click += new System.EventHandler(this.btnImport2_Click);
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(66, 28);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(312, 20);
            this.txtName2.TabIndex = 3;
            // 
            // txtCategory2
            // 
            this.txtCategory2.Location = new System.Drawing.Point(66, 54);
            this.txtCategory2.Name = "txtCategory2";
            this.txtCategory2.Size = new System.Drawing.Size(312, 20);
            this.txtCategory2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Categories";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelete3);
            this.groupBox3.Controls.Add(this.btnExport3);
            this.groupBox3.Controls.Add(this.btnImport3);
            this.groupBox3.Controls.Add(this.txtName3);
            this.groupBox3.Controls.Add(this.txtCategory3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 130);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List #3";
            // 
            // btnDelete3
            // 
            this.btnDelete3.Location = new System.Drawing.Point(278, 80);
            this.btnDelete3.Name = "btnDelete3";
            this.btnDelete3.Size = new System.Drawing.Size(100, 40);
            this.btnDelete3.TabIndex = 11;
            this.btnDelete3.Text = "Delete All";
            this.btnDelete3.UseVisualStyleBackColor = true;
            this.btnDelete3.Click += new System.EventHandler(this.btnDelete3_Click);
            // 
            // btnExport3
            // 
            this.btnExport3.Location = new System.Drawing.Point(172, 80);
            this.btnExport3.Name = "btnExport3";
            this.btnExport3.Size = new System.Drawing.Size(100, 40);
            this.btnExport3.TabIndex = 10;
            this.btnExport3.Text = "Export";
            this.btnExport3.UseVisualStyleBackColor = true;
            this.btnExport3.Click += new System.EventHandler(this.btnExport3_Click);
            // 
            // btnImport3
            // 
            this.btnImport3.Location = new System.Drawing.Point(66, 80);
            this.btnImport3.Name = "btnImport3";
            this.btnImport3.Size = new System.Drawing.Size(100, 40);
            this.btnImport3.TabIndex = 9;
            this.btnImport3.Text = "Import";
            this.btnImport3.UseVisualStyleBackColor = true;
            this.btnImport3.Click += new System.EventHandler(this.btnImport3_Click);
            // 
            // txtName3
            // 
            this.txtName3.Location = new System.Drawing.Point(66, 28);
            this.txtName3.Name = "txtName3";
            this.txtName3.Size = new System.Drawing.Size(312, 20);
            this.txtName3.TabIndex = 3;
            // 
            // txtCategory3
            // 
            this.txtCategory3.Location = new System.Drawing.Point(66, 54);
            this.txtCategory3.Name = "txtCategory3";
            this.txtCategory3.Size = new System.Drawing.Size(312, 20);
            this.txtCategory3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Categories";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name";
            // 
            // SettingsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(424, 541);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbDefault);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingsUI";
            this.Text = "SettingsUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtCategory1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDefault;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Button btnExport1;
        private System.Windows.Forms.Button btnImport1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnExport2;
        private System.Windows.Forms.Button btnImport2;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox txtCategory2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelete3;
        private System.Windows.Forms.Button btnExport3;
        private System.Windows.Forms.Button btnImport3;
        private System.Windows.Forms.TextBox txtName3;
        private System.Windows.Forms.TextBox txtCategory3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}