namespace Manager
{
    partial class ViewOrders
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
            label1 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            button4 = new Button();
            dataGridView2 = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F);
            label1.Location = new Point(326, 9);
            label1.Name = "label1";
            label1.Size = new Size(396, 89);
            label1.TabIndex = 7;
            label1.Text = "View Orders";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 450);
            panel2.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(12, 410);
            button2.Name = "button2";
            button2.Size = new Size(75, 28);
            button2.TabIndex = 6;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDark;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(75, 28);
            button4.TabIndex = 5;
            button4.Text = "Log out";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(206, 101);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(582, 337);
            dataGridView2.TabIndex = 10;
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Name = "ViewOrders";
            Text = "ViewOrders";
            Load += ViewOrders_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button btnAddItems;
        private Button button2;
        private Button button4;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
    }
}