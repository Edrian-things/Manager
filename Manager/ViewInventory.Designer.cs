namespace Manager
{
    partial class ViewInventory
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
            panel2 = new Panel();
            button2 = new Button();
            button4 = new Button();
            btnAddItems = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(btnAddItems);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 450);
            panel2.TabIndex = 10;
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
            btnAddItems.Location = new Point(22, 253);
            btnAddItems.Name = "btnAddItems";
            btnAddItems.Size = new Size(165, 27);
            btnAddItems.TabIndex = 2;
            btnAddItems.Text = "Add Items";
            btnAddItems.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F);
            label1.Location = new Point(344, 9);
            label1.Name = "label1";
            label1.Size = new Size(316, 89);
            label1.TabIndex = 8;
            label1.Text = "Inventory";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(215, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(558, 334);
            dataGridView1.TabIndex = 11;
            // 
            // ViewInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "ViewInventory";
            Text = "ViewInventory";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button button2;
        private Button button4;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnAddItems;
    }
}