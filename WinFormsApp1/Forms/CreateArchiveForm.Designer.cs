using System.Windows.Forms;
using WinFormsApp1.Forms;

namespace WinFormsApp1
{
    partial class ZipForm
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(487, 70);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(364, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 49);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 2;
            label1.Text = "Files:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 146);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 5;
            label2.Text = "Archive destination:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(364, 27);
            textBox2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(487, 167);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(50, 336);
            button3.Name = "button3";
            button3.Size = new Size(151, 29);
            button3.TabIndex = 6;
            button3.Text = "Create Archive";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 243);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 7;
            label3.Text = "Archive name: ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(50, 266);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(199, 27);
            textBox3.TabIndex = 8;
            // 
            // ZipForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 379);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "ZipForm";
            Text = "ZipForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        // private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Label label3;
        private TextBox textBox3;
    }
}