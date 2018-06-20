namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbOperateNumEditing = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnbackspace = new System.Windows.Forms.Button();
            this.btnac = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.btnmutiplication = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnequal = new System.Windows.Forms.Button();
            this.tbOperateNumRecord = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbOperateNumEditing
            // 
            this.tbOperateNumEditing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOperateNumEditing.Location = new System.Drawing.Point(3, 22);
            this.tbOperateNumEditing.Name = "tbOperateNumEditing";
            this.tbOperateNumEditing.ReadOnly = true;
            this.tbOperateNumEditing.Size = new System.Drawing.Size(278, 14);
            this.tbOperateNumEditing.TabIndex = 0;
            this.tbOperateNumEditing.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndot);
            this.groupBox1.Controls.Add(this.btn0);
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.btn6);
            this.groupBox1.Controls.Add(this.btn5);
            this.groupBox1.Controls.Add(this.btn4);
            this.groupBox1.Controls.Add(this.btn9);
            this.groupBox1.Controls.Add(this.btn8);
            this.groupBox1.Controls.Add(this.btn7);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 209);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btndot
            // 
            this.btndot.Location = new System.Drawing.Point(114, 161);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(50, 41);
            this.btndot.TabIndex = 10;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = true;
            this.btndot.Click += new System.EventHandler(this.btndot_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn0.Location = new System.Drawing.Point(6, 161);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(105, 41);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(114, 114);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 41);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(60, 114);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 41);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn1.Location = new System.Drawing.Point(6, 114);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 41);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(114, 67);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 41);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(60, 67);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 41);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(6, 67);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 41);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(114, 20);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 41);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(60, 20);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 41);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(7, 20);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(49, 41);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn0_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnbackspace);
            this.groupBox2.Controls.Add(this.btnac);
            this.groupBox2.Controls.Add(this.btndivide);
            this.groupBox2.Controls.Add(this.btnmutiplication);
            this.groupBox2.Controls.Add(this.btnminus);
            this.groupBox2.Controls.Add(this.btnadd);
            this.groupBox2.Location = new System.Drawing.Point(191, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(105, 209);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnbackspace
            // 
            this.btnbackspace.Location = new System.Drawing.Point(55, 20);
            this.btnbackspace.Name = "btnbackspace";
            this.btnbackspace.Size = new System.Drawing.Size(42, 56);
            this.btnbackspace.TabIndex = 5;
            this.btnbackspace.Text = "←";
            this.btnbackspace.UseVisualStyleBackColor = true;
            this.btnbackspace.Click += new System.EventHandler(this.btnbackspace_Click);
            // 
            // btnac
            // 
            this.btnac.Location = new System.Drawing.Point(7, 20);
            this.btnac.Name = "btnac";
            this.btnac.Size = new System.Drawing.Size(42, 56);
            this.btnac.TabIndex = 4;
            this.btnac.Text = "AC";
            this.btnac.UseVisualStyleBackColor = true;
            this.btnac.Click += new System.EventHandler(this.btnac_Click);
            // 
            // btndivide
            // 
            this.btndivide.Location = new System.Drawing.Point(55, 146);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(42, 56);
            this.btndivide.TabIndex = 3;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = true;
            this.btndivide.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnmutiplication
            // 
            this.btnmutiplication.Location = new System.Drawing.Point(55, 83);
            this.btnmutiplication.Name = "btnmutiplication";
            this.btnmutiplication.Size = new System.Drawing.Size(42, 56);
            this.btnmutiplication.TabIndex = 2;
            this.btnmutiplication.Text = "*";
            this.btnmutiplication.UseVisualStyleBackColor = true;
            this.btnmutiplication.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(7, 146);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(42, 56);
            this.btnminus.TabIndex = 1;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(7, 83);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(42, 56);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnequal);
            this.groupBox3.Location = new System.Drawing.Point(12, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 68);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnequal
            // 
            this.btnequal.Location = new System.Drawing.Point(7, 17);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(269, 42);
            this.btnequal.TabIndex = 0;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = true;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // tbOperateNumRecord
            // 
            this.tbOperateNumRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOperateNumRecord.Location = new System.Drawing.Point(3, 3);
            this.tbOperateNumRecord.Name = "tbOperateNumRecord";
            this.tbOperateNumRecord.ReadOnly = true;
            this.tbOperateNumRecord.Size = new System.Drawing.Size(278, 14);
            this.tbOperateNumRecord.TabIndex = 5;
            this.tbOperateNumRecord.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.tbOperateNumEditing);
            this.panel1.Controls.Add(this.tbOperateNumRecord);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 54);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnequal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 342);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox tbOperateNumEditing;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btndot;
        public System.Windows.Forms.Button btn0;
        public System.Windows.Forms.Button btn3;
        public System.Windows.Forms.Button btn2;
        public System.Windows.Forms.Button btn1;
        public System.Windows.Forms.Button btn6;
        public System.Windows.Forms.Button btn5;
        public System.Windows.Forms.Button btn4;
        public System.Windows.Forms.Button btn9;
        public System.Windows.Forms.Button btn8;
        public System.Windows.Forms.Button btn7;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btndivide;
        public System.Windows.Forms.Button btnmutiplication;
        public System.Windows.Forms.Button btnminus;
        public System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button btnequal;
        public System.Windows.Forms.Button btnbackspace;
        public System.Windows.Forms.Button btnac;
        public System.Windows.Forms.TextBox tbOperateNumRecord;
        private System.Windows.Forms.Panel panel1;
    }
}

