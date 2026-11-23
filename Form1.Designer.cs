namespace Lab2_EF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPatients = new DataGridView();
            dgvProcResult = new DataGridView();
            btnSearchProc = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            txtSearchFio = new TextBox();
            txtFilter = new TextBox();
            dgvLinq = new DataGridView();
            btnFilterLinq = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProcResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLinq).BeginInit();
            SuspendLayout();
            // 
            // dgvPatients
            // 
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Location = new Point(23, 193);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.Size = new Size(348, 245);
            dgvPatients.TabIndex = 0;
            // 
            // dgvProcResult
            // 
            dgvProcResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProcResult.Location = new Point(399, 193);
            dgvProcResult.Name = "dgvProcResult";
            dgvProcResult.RowHeadersWidth = 51;
            dgvProcResult.Size = new Size(378, 245);
            dgvProcResult.TabIndex = 1;
            // 
            // btnSearchProc
            // 
            btnSearchProc.Location = new Point(442, 130);
            btnSearchProc.Name = "btnSearchProc";
            btnSearchProc.Size = new Size(298, 29);
            btnSearchProc.TabIndex = 2;
            btnSearchProc.Text = "Найти по части ФИО";
            btnSearchProc.UseVisualStyleBackColor = true;
            btnSearchProc.Click += btnSearchProc_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(23, 130);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(145, 130);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Изменить";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(277, 130);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearchFio
            // 
            txtSearchFio.Location = new Point(442, 87);
            txtSearchFio.Name = "txtSearchFio";
            txtSearchFio.Size = new Size(298, 27);
            txtSearchFio.TabIndex = 6;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(863, 87);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(307, 27);
            txtFilter.TabIndex = 7;
            // 
            // dgvLinq
            // 
            dgvLinq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLinq.Location = new Point(809, 193);
            dgvLinq.Name = "dgvLinq";
            dgvLinq.RowHeadersWidth = 51;
            dgvLinq.Size = new Size(397, 245);
            dgvLinq.TabIndex = 8;
            // 
            // btnFilterLinq
            // 
            btnFilterLinq.Location = new Point(863, 126);
            btnFilterLinq.Name = "btnFilterLinq";
            btnFilterLinq.Size = new Size(307, 29);
            btnFilterLinq.TabIndex = 9;
            btnFilterLinq.Text = "Список пациентов";
            btnFilterLinq.UseVisualStyleBackColor = true;
            btnFilterLinq.Click += btnFilterLinq_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 450);
            Controls.Add(btnFilterLinq);
            Controls.Add(dgvLinq);
            Controls.Add(txtFilter);
            Controls.Add(txtSearchFio);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnSearchProc);
            Controls.Add(dgvProcResult);
            Controls.Add(dgvPatients);
            Name = "Form1";
            Text = "Пациент";
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProcResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLinq).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPatients;
        private DataGridView dgvProcResult;
        private Button btnSearchProc;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox txtSearchFio;
        private TextBox txtFilter;
        private DataGridView dgvLinq;
        private Button btnFilterLinq;
    }
}
