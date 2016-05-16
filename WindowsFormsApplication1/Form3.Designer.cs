namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Citizen = new System.Windows.Forms.TextBox();
            this.Arts = new System.Windows.Forms.TextBox();
            this.Athletic = new System.Windows.Forms.TextBox();
            this.Academic = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check for MYSQL DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Get Student Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Number - ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Citizenship";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Arts";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Athletic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Academic";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(14, 198);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(0, 13);
            this.Name.TabIndex = 9;
            // 
            // Citizen
            // 
            this.Citizen.Location = new System.Drawing.Point(109, 191);
            this.Citizen.Name = "Citizen";
            this.Citizen.Size = new System.Drawing.Size(56, 20);
            this.Citizen.TabIndex = 10;
            // 
            // Arts
            // 
            this.Arts.Location = new System.Drawing.Point(214, 191);
            this.Arts.Name = "Arts";
            this.Arts.Size = new System.Drawing.Size(56, 20);
            this.Arts.TabIndex = 11;
            // 
            // Athletic
            // 
            this.Athletic.Location = new System.Drawing.Point(304, 191);
            this.Athletic.Name = "Athletic";
            this.Athletic.Size = new System.Drawing.Size(56, 20);
            this.Athletic.TabIndex = 12;
            // 
            // Academic
            // 
            this.Academic.Location = new System.Drawing.Point(409, 192);
            this.Academic.Name = "Academic";
            this.Academic.Size = new System.Drawing.Size(56, 20);
            this.Academic.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Update Record";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 289);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Academic);
            this.Controls.Add(this.Athletic);
            this.Controls.Add(this.Arts);
            this.Controls.Add(this.Citizen);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name.Name = "Form3";
            this.Text = "Student Info";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox Citizen;
        private System.Windows.Forms.TextBox Arts;
        private System.Windows.Forms.TextBox Athletic;
        private System.Windows.Forms.TextBox Academic;
        private System.Windows.Forms.Button button3;
    }
}