namespace WinFormsMethods
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            btnBMI = new Button();
            lblReslt = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(249, 43);
            label1.Name = "label1";
            label1.Size = new Size(191, 26);
            label1.TabIndex = 0;
            label1.Text = "โปรแกมคำนวณ BMI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(124, 219);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 1;
            label2.Text = "ส่วนสูง(cm)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Leelawadee UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(123, 280);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 2;
            label3.Text = "น้ำหนัก(kg)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 107);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 3;
            label4.Text = "ชื่อ-นามสกุล";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(179, 161);
            label5.Name = "label5";
            label5.Size = new Size(41, 25);
            label5.TabIndex = 4;
            label5.Text = "อายุ";
            label5.Click += label5_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(249, 104);
            txtName.Name = "txtName";
            txtName.Size = new Size(241, 32);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(249, 158);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(150, 32);
            txtAge.TabIndex = 2;
            txtAge.TextAlign = HorizontalAlignment.Right;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(249, 219);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(150, 32);
            txtHeight.TabIndex = 3;
            txtHeight.TextAlign = HorizontalAlignment.Right;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(249, 277);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(150, 32);
            txtWeight.TabIndex = 4;
            txtWeight.TextAlign = HorizontalAlignment.Right;
            // 
            // btnBMI
            // 
            btnBMI.Location = new Point(505, 107);
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(155, 95);
            btnBMI.TabIndex = 5;
            btnBMI.Text = "ค่า BMI";
            btnBMI.UseVisualStyleBackColor = true;
            btnBMI.Click += btnBMI_Click;
            // 
            // lblReslt
            // 
            lblReslt.BackColor = Color.MediumSeaGreen;
            lblReslt.ForeColor = Color.Black;
            lblReslt.Location = new Point(12, 337);
            lblReslt.Name = "lblReslt";
            lblReslt.Size = new Size(707, 242);
            lblReslt.TabIndex = 10;
            lblReslt.Text = "---";
            lblReslt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(505, 219);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(155, 63);
            btnClear.TabIndex = 11;
            btnClear.Text = "เริ่มใหม่";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 588);
            Controls.Add(btnClear);
            Controls.Add(lblReslt);
            Controls.Add(btnBMI);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Leelawadee UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Button btnBMI;
        private Label lblReslt;
        private Button btnClear;
    }
}
