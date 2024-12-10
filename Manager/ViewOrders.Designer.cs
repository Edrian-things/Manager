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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            button2 = new Button();
            button4 = new Button();
            btnAddItems = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F);
            label1.Location = new Point(279, 9);
            label1.Name = "label1";
            label1.Size = new Size(396, 89);
            label1.TabIndex = 7;
            label1.Text = "View Orders";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(230, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(558, 334);
            dataGridView1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnAddItems);
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
            // btnAddItems
            // 
            btnAddItems.FlatStyle = FlatStyle.Flat;
            btnAddItems.Location = new Point(22, 254);
            btnAddItems.Name = "btnAddItems";
            btnAddItems.Size = new Size(165, 27);
            btnAddItems.TabIndex = 2;
            btnAddItems.Text = "Add Items";
            btnAddItems.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(22, 205);
            button3.Name = "button3";
            button3.Size = new Size(165, 33);
            button3.TabIndex = 3;
            button3.Text = "View Inventory";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "ViewOrders";
            Text = "ViewOrders";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
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
        private Button button3;
    }
}