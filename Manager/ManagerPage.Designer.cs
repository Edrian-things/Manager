namespace Manager
{
    partial class ManagerPage
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
            button4 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button3 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDark;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(75, 28);
            button4.TabIndex = 4;
            button4.Text = "Log out";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(132, 160);
            label1.Name = "label1";
            label1.Size = new Size(312, 89);
            label1.TabIndex = 5;
            label1.Text = "Welcome";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(196, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(559, 444);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 444);
            panel2.TabIndex = 7;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(25, 191);
            button3.Name = "button3";
            button3.Size = new Size(165, 33);
            button3.TabIndex = 3;
            button3.Text = "View Inventory";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(25, 135);
            button1.Name = "button1";
            button1.Size = new Size(165, 30);
            button1.TabIndex = 1;
            button1.Text = "View Orders";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ManagerPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 444);
            Controls.Add(button4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ManagerPage";
            Text = "ManagerPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private Button btnAddItems;
        private Button button1;
    }
}