namespace WindowsForms_Create_Read_Write_Delete_a_Text_File
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.btn_clr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create a text file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "Write Text";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(420, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 24);
            this.button3.TabIndex = 2;
            this.button3.Text = "Read Text";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(609, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 24);
            this.button4.TabIndex = 3;
            this.button4.Text = "Delete file";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(93, 144);
            this.txt_data.Multiline = true;
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(628, 286);
            this.txt_data.TabIndex = 4;
            // 
            // btn_clr
            // 
            this.btn_clr.Location = new System.Drawing.Point(611, 436);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(110, 24);
            this.btn_clr.TabIndex = 5;
            this.btn_clr.Text = "Clear Text";
            this.btn_clr.UseVisualStyleBackColor = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 478);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.Button btn_clr;
    }
}

