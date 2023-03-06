namespace SystemProgramming_HW1
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
            panel2 = new Panel();
            button4 = new Button();
            listBox2 = new ListBox();
            panel3 = new Panel();
            panel4 = new Panel();
            button5 = new Button();
            listBox3 = new ListBox();
            panel5 = new Panel();
            panel6 = new Panel();
            RefReshBtn = new Button();
            textBox1 = new TextBox();
            EndBtn = new Button();
            StartBtn = new Button();
            listBox1 = new ListBox();
            panel1 = new Panel();
            button3 = new Button();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(listBox2);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(276, 3);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(285, 385);
            panel2.TabIndex = 2;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(3, 2);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(280, 27);
            button4.TabIndex = 2;
            button4.Text = "Process Name";
            button4.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(3, 37);
            listBox2.Margin = new Padding(3, 2, 3, 2);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(280, 349);
            listBox2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(326, 2);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(331, 387);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(button5);
            panel4.Controls.Add(listBox3);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(566, 3);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 384);
            panel4.TabIndex = 3;
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new Point(5, 4);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(264, 27);
            button5.TabIndex = 7;
            button5.Text = "Priority";
            button5.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(5, 36);
            listBox3.Margin = new Padding(3, 2, 3, 2);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(265, 349);
            listBox3.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Location = new Point(326, 2);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(331, 387);
            panel5.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.Controls.Add(RefReshBtn);
            panel6.Controls.Add(textBox1);
            panel6.Controls.Add(EndBtn);
            panel6.Controls.Add(StartBtn);
            panel6.Location = new Point(1, 392);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(835, 48);
            panel6.TabIndex = 4;
            // 
            // RefReshBtn
            // 
            RefReshBtn.Location = new Point(509, 6);
            RefReshBtn.Margin = new Padding(3, 2, 3, 2);
            RefReshBtn.Name = "RefReshBtn";
            RefReshBtn.Size = new Size(104, 29);
            RefReshBtn.TabIndex = 4;
            RefReshBtn.Text = "Refresh";
            RefReshBtn.UseVisualStyleBackColor = true;
            RefReshBtn.Click += RefReshBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 10);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 23);
            textBox1.TabIndex = 3;
            // 
            // EndBtn
            // 
            EndBtn.Location = new Point(387, 6);
            EndBtn.Margin = new Padding(3, 2, 3, 2);
            EndBtn.Name = "EndBtn";
            EndBtn.Size = new Size(104, 29);
            EndBtn.TabIndex = 2;
            EndBtn.Text = "End Process";
            EndBtn.UseVisualStyleBackColor = true;
            EndBtn.Click += EndBtn_Click;
            // 
            // StartBtn
            // 
            StartBtn.Location = new Point(262, 6);
            StartBtn.Margin = new Padding(3, 2, 3, 2);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(104, 29);
            StartBtn.TabIndex = 1;
            StartBtn.Text = "Start Process";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 36);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(265, 349);
            listBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 388);
            panel1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(3, 5);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(264, 27);
            button3.TabIndex = 1;
            button3.Text = "Process Id";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 427);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private TextBox textBox1;
        private Button EndBtn;
        private Button StartBtn;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox1;
        private Panel panel1;
        private Button button4;
        private Button button5;
        private Button button3;
        private Button RefReshBtn;
    }
}