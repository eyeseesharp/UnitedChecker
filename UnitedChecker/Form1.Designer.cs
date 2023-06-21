namespace UnitedChecker
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.seat1F = new System.Windows.Forms.Label();
            this.seat1E = new System.Windows.Forms.Label();
            this.seat1A = new System.Windows.Forms.Label();
            this.seat1B = new System.Windows.Forms.Label();
            this.seat2F = new System.Windows.Forms.Label();
            this.seat3F = new System.Windows.Forms.Label();
            this.seat4F = new System.Windows.Forms.Label();
            this.seat2E = new System.Windows.Forms.Label();
            this.totalseatslbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.seat3E = new System.Windows.Forms.Label();
            this.seat4E = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.seat2B = new System.Windows.Forms.Label();
            this.seat2A = new System.Windows.Forms.Label();
            this.seat3B = new System.Windows.Forms.Label();
            this.seat3A = new System.Windows.Forms.Label();
            this.seat4A = new System.Windows.Forms.Label();
            this.seat4B = new System.Windows.Forms.Label();
            this.availableseatslbl = new System.Windows.Forms.Label();
            this.getprevdaybtn = new System.Windows.Forms.Button();
            this.getnextdaybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(317, 29);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(371, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Buisness";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "_________________________________________________________________________________" +
    "_______________________________________________________";
            // 
            // seat1F
            // 
            this.seat1F.AutoSize = true;
            this.seat1F.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seat1F.Location = new System.Drawing.Point(82, 102);
            this.seat1F.Name = "seat1F";
            this.seat1F.Size = new System.Drawing.Size(103, 37);
            this.seat1F.TabIndex = 4;
            this.seat1F.Text = "Seat 1F";
            this.seat1F.Click += new System.EventHandler(this.seat1F_Click);
            // 
            // seat1E
            // 
            this.seat1E.AutoSize = true;
            this.seat1E.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seat1E.Location = new System.Drawing.Point(82, 169);
            this.seat1E.Name = "seat1E";
            this.seat1E.Size = new System.Drawing.Size(104, 37);
            this.seat1E.TabIndex = 5;
            this.seat1E.Text = "Seat 1E";
            this.seat1E.Click += new System.EventHandler(this.seat1E_Click);
            // 
            // seat1A
            // 
            this.seat1A.AutoSize = true;
            this.seat1A.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seat1A.Location = new System.Drawing.Point(82, 325);
            this.seat1A.Name = "seat1A";
            this.seat1A.Size = new System.Drawing.Size(107, 37);
            this.seat1A.TabIndex = 6;
            this.seat1A.Text = "Seat 1A";
            this.seat1A.Click += new System.EventHandler(this.seat1A_Click);
            // 
            // seat1B
            // 
            this.seat1B.AutoSize = true;
            this.seat1B.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seat1B.Location = new System.Drawing.Point(82, 259);
            this.seat1B.Name = "seat1B";
            this.seat1B.Size = new System.Drawing.Size(105, 37);
            this.seat1B.TabIndex = 7;
            this.seat1B.Text = "Seat 1B";
            this.seat1B.Click += new System.EventHandler(this.seat1B_Click);
            // 
            // seat2F
            // 
            this.seat2F.AutoSize = true;
            this.seat2F.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seat2F.Location = new System.Drawing.Point(247, 102);
            this.seat2F.Name = "seat2F";
            this.seat2F.Size = new System.Drawing.Size(103, 37);
            this.seat2F.TabIndex = 8;
            this.seat2F.Text = "Seat 2F";
            this.seat2F.Click += new System.EventHandler(this.seat2F_Click);
            // 
            // seat3F
            // 
            this.seat3F.AutoSize = true;
            this.seat3F.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seat3F.Location = new System.Drawing.Point(434, 102);
            this.seat3F.Name = "seat3F";
            this.seat3F.Size = new System.Drawing.Size(103, 37);
            this.seat3F.TabIndex = 9;
            this.seat3F.Text = "Seat 3F";
            this.seat3F.Click += new System.EventHandler(this.seat3F_Click);
            // 
            // seat4F
            // 
            this.seat4F.AutoSize = true;
            this.seat4F.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seat4F.Location = new System.Drawing.Point(620, 102);
            this.seat4F.Name = "seat4F";
            this.seat4F.Size = new System.Drawing.Size(103, 37);
            this.seat4F.TabIndex = 10;
            this.seat4F.Text = "Seat 4F";
            this.seat4F.Click += new System.EventHandler(this.seat4F_Click);
            // 
            // seat2E
            // 
            this.seat2E.AutoSize = true;
            this.seat2E.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seat2E.Location = new System.Drawing.Point(247, 169);
            this.seat2E.Name = "seat2E";
            this.seat2E.Size = new System.Drawing.Size(104, 37);
            this.seat2E.TabIndex = 11;
            this.seat2E.Text = "Seat 2E";
            this.seat2E.Click += new System.EventHandler(this.seat2E_Click);
            // 
            // totalseatslbl
            // 
            this.totalseatslbl.AutoSize = true;
            this.totalseatslbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalseatslbl.Location = new System.Drawing.Point(619, 4);
            this.totalseatslbl.Name = "totalseatslbl";
            this.totalseatslbl.Size = new System.Drawing.Size(97, 37);
            this.totalseatslbl.TabIndex = 12;
            this.totalseatslbl.Text = "TOTAL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(687, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "_________________________________________________________________________________" +
    "_______________________________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(687, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "_________________________________________________________________________________" +
    "_______________________________________________________";
            // 
            // seat3E
            // 
            this.seat3E.AutoSize = true;
            this.seat3E.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seat3E.Location = new System.Drawing.Point(433, 169);
            this.seat3E.Name = "seat3E";
            this.seat3E.Size = new System.Drawing.Size(104, 37);
            this.seat3E.TabIndex = 15;
            this.seat3E.Text = "Seat 3E";
            this.seat3E.Click += new System.EventHandler(this.seat3E_Click);
            // 
            // seat4E
            // 
            this.seat4E.AutoSize = true;
            this.seat4E.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seat4E.Location = new System.Drawing.Point(619, 169);
            this.seat4E.Name = "seat4E";
            this.seat4E.Size = new System.Drawing.Size(104, 37);
            this.seat4E.TabIndex = 16;
            this.seat4E.Text = "Seat 4E";
            this.seat4E.Click += new System.EventHandler(this.seat4E_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 485);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(744, 305);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(333, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 37);
            this.label2.TabIndex = 18;
            this.label2.Text = "Response";
            // 
            // seat2B
            // 
            this.seat2B.AutoSize = true;
            this.seat2B.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seat2B.Location = new System.Drawing.Point(247, 259);
            this.seat2B.Name = "seat2B";
            this.seat2B.Size = new System.Drawing.Size(105, 37);
            this.seat2B.TabIndex = 19;
            this.seat2B.Text = "Seat 2B";
            this.seat2B.Click += new System.EventHandler(this.seat2B_Click);
            // 
            // seat2A
            // 
            this.seat2A.AutoSize = true;
            this.seat2A.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seat2A.Location = new System.Drawing.Point(245, 325);
            this.seat2A.Name = "seat2A";
            this.seat2A.Size = new System.Drawing.Size(107, 37);
            this.seat2A.TabIndex = 20;
            this.seat2A.Text = "Seat 2A";
            this.seat2A.Click += new System.EventHandler(this.seat2A_Click);
            // 
            // seat3B
            // 
            this.seat3B.AutoSize = true;
            this.seat3B.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seat3B.Location = new System.Drawing.Point(433, 259);
            this.seat3B.Name = "seat3B";
            this.seat3B.Size = new System.Drawing.Size(105, 37);
            this.seat3B.TabIndex = 21;
            this.seat3B.Text = "Seat 3B";
            this.seat3B.Click += new System.EventHandler(this.seat3B_Click);
            // 
            // seat3A
            // 
            this.seat3A.AutoSize = true;
            this.seat3A.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seat3A.Location = new System.Drawing.Point(432, 325);
            this.seat3A.Name = "seat3A";
            this.seat3A.Size = new System.Drawing.Size(107, 37);
            this.seat3A.TabIndex = 22;
            this.seat3A.Text = "Seat 3A";
            this.seat3A.Click += new System.EventHandler(this.seat3A_Click);
            // 
            // seat4A
            // 
            this.seat4A.AutoSize = true;
            this.seat4A.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seat4A.Location = new System.Drawing.Point(616, 325);
            this.seat4A.Name = "seat4A";
            this.seat4A.Size = new System.Drawing.Size(107, 37);
            this.seat4A.TabIndex = 23;
            this.seat4A.Text = "Seat 4A";
            this.seat4A.Click += new System.EventHandler(this.seat4A_Click);
            // 
            // seat4B
            // 
            this.seat4B.AutoSize = true;
            this.seat4B.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seat4B.Location = new System.Drawing.Point(619, 259);
            this.seat4B.Name = "seat4B";
            this.seat4B.Size = new System.Drawing.Size(105, 37);
            this.seat4B.TabIndex = 24;
            this.seat4B.Text = "Seat 4B";
            this.seat4B.Click += new System.EventHandler(this.seat4B_Click);
            // 
            // availableseatslbl
            // 
            this.availableseatslbl.AutoSize = true;
            this.availableseatslbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.availableseatslbl.Location = new System.Drawing.Point(620, 41);
            this.availableseatslbl.Name = "availableseatslbl";
            this.availableseatslbl.Size = new System.Drawing.Size(90, 37);
            this.availableseatslbl.TabIndex = 25;
            this.availableseatslbl.Text = "AVAIL:";
            // 
            // getprevdaybtn
            // 
            this.getprevdaybtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getprevdaybtn.Location = new System.Drawing.Point(34, 47);
            this.getprevdaybtn.Name = "getprevdaybtn";
            this.getprevdaybtn.Size = new System.Drawing.Size(166, 34);
            this.getprevdaybtn.TabIndex = 26;
            this.getprevdaybtn.Text = "Get Prev Day";
            this.getprevdaybtn.UseVisualStyleBackColor = true;
            this.getprevdaybtn.Click += new System.EventHandler(this.getprevdaybtn_Click);
            // 
            // getnextdaybtn
            // 
            this.getnextdaybtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getnextdaybtn.Location = new System.Drawing.Point(245, 47);
            this.getnextdaybtn.Name = "getnextdaybtn";
            this.getnextdaybtn.Size = new System.Drawing.Size(166, 34);
            this.getnextdaybtn.TabIndex = 27;
            this.getnextdaybtn.Text = "Get Next Day";
            this.getnextdaybtn.UseVisualStyleBackColor = true;
            this.getnextdaybtn.Click += new System.EventHandler(this.getnextdaybtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 802);
            this.Controls.Add(this.getnextdaybtn);
            this.Controls.Add(this.getprevdaybtn);
            this.Controls.Add(this.availableseatslbl);
            this.Controls.Add(this.seat4B);
            this.Controls.Add(this.seat4A);
            this.Controls.Add(this.seat3A);
            this.Controls.Add(this.seat3B);
            this.Controls.Add(this.seat2A);
            this.Controls.Add(this.seat2B);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.seat4E);
            this.Controls.Add(this.seat3E);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totalseatslbl);
            this.Controls.Add(this.seat2E);
            this.Controls.Add(this.seat4F);
            this.Controls.Add(this.seat3F);
            this.Controls.Add(this.seat2F);
            this.Controls.Add(this.seat1B);
            this.Controls.Add(this.seat1A);
            this.Controls.Add(this.seat1E);
            this.Controls.Add(this.seat1F);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label1;
        private Label seat1F;
        private Label seat1E;
        private Label seat1A;
        private Label seat1B;
        private Label seat2F;
        private Label seat3F;
        private Label seat4F;
        private Label seat2E;
        private Label totalseatslbl;
        private Label label7;
        private Label label8;
        private Label seat3E;
        private Label seat4E;
        private RichTextBox richTextBox1;
        private Label label2;
        private Label seat2B;
        private Label seat2A;
        private Label seat3B;
        private Label seat3A;
        private Label seat4A;
        private Label seat4B;
        private Label availableseatslbl;
        private Button getprevdaybtn;
        private Button getnextdaybtn;
    }
}