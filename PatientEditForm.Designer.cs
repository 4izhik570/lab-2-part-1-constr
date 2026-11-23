namespace Lab2_EF
{
    partial class PatientEditForm
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
            txtSnils = new TextBox();
            txtFio = new TextBox();
            txtPol = new TextBox();
            txtHouse = new TextBox();
            dtpBirth = new DateTimePicker();
            cmbStreet = new ComboBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtPolis = new TextBox();
            txtCard = new TextBox();
            txtWorkplace = new TextBox();
            txtFlat = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // txtSnils
            // 
            txtSnils.Location = new Point(23, 33);
            txtSnils.Name = "txtSnils";
            txtSnils.Size = new Size(125, 27);
            txtSnils.TabIndex = 0;
            // 
            // txtFio
            // 
            txtFio.Location = new Point(191, 33);
            txtFio.Name = "txtFio";
            txtFio.Size = new Size(125, 27);
            txtFio.TabIndex = 1;
            // 
            // txtPol
            // 
            txtPol.Location = new Point(352, 33);
            txtPol.Name = "txtPol";
            txtPol.Size = new Size(125, 27);
            txtPol.TabIndex = 2;
            // 
            // txtHouse
            // 
            txtHouse.Location = new Point(23, 227);
            txtHouse.Name = "txtHouse";
            txtHouse.Size = new Size(125, 27);
            txtHouse.TabIndex = 3;
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(502, 33);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(165, 27);
            dtpBirth.TabIndex = 4;
            // 
            // cmbStreet
            // 
            cmbStreet.FormattingEnabled = true;
            cmbStreet.Location = new Point(23, 130);
            cmbStreet.Name = "cmbStreet";
            cmbStreet.Size = new Size(151, 28);
            cmbStreet.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(23, 286);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 63);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 7;
            label1.Text = "СНИЛС";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 65);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 8;
            label2.Text = "ФИО";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 63);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 9;
            label3.Text = "пол";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 257);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 10;
            label4.Text = "дом";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 172);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 11;
            label5.Text = "улица";
            // 
            // txtPolis
            // 
            txtPolis.Location = new Point(338, 131);
            txtPolis.Name = "txtPolis";
            txtPolis.Size = new Size(125, 27);
            txtPolis.TabIndex = 12;
            // 
            // txtCard
            // 
            txtCard.Location = new Point(516, 131);
            txtCard.Name = "txtCard";
            txtCard.Size = new Size(125, 27);
            txtCard.TabIndex = 13;
            // 
            // txtWorkplace
            // 
            txtWorkplace.Location = new Point(191, 131);
            txtWorkplace.Name = "txtWorkplace";
            txtWorkplace.Size = new Size(125, 27);
            txtWorkplace.TabIndex = 14;
            // 
            // txtFlat
            // 
            txtFlat.Location = new Point(191, 227);
            txtFlat.Name = "txtFlat";
            txtFlat.Size = new Size(125, 27);
            txtFlat.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(363, 172);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 16;
            label6.Text = "полис";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(531, 161);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 17;
            label7.Text = "номер карты";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(223, 172);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 18;
            label8.Text = "работа";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(223, 257);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 19;
            label9.Text = "квартира";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(527, 65);
            label10.Name = "label10";
            label10.Size = new Size(114, 20);
            label10.TabIndex = 20;
            label10.Text = "дата рождения";
            // 
            // PatientEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 333);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtFlat);
            Controls.Add(txtWorkplace);
            Controls.Add(txtCard);
            Controls.Add(txtPolis);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(cmbStreet);
            Controls.Add(dtpBirth);
            Controls.Add(txtHouse);
            Controls.Add(txtPol);
            Controls.Add(txtFio);
            Controls.Add(txtSnils);
            Name = "PatientEditForm";
            Text = "PatientEditForm";
            Load += PatientEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSnils;
        private TextBox txtFio;
        private TextBox txtPol;
        private TextBox txtHouse;
        private DateTimePicker dtpBirth;
        private ComboBox cmbStreet;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtPolis;
        private TextBox txtCard;
        private TextBox txtWorkplace;
        private TextBox txtFlat;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}