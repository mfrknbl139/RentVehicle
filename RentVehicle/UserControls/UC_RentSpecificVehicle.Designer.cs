namespace RentVehicle.UserControllers
{
    partial class UC_RentSpecificVehicle
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            listBox1 = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 15);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 0;
            label1.Text = "RentSpecificVehicle";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(3, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 613);
            panel1.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(136, 14);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(433, 404);
            listBox1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button2, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 0, 2);
            tableLayoutPanel1.Controls.Add(button4, 0, 0);
            tableLayoutPanel1.Controls.Add(button5, 0, 4);
            tableLayoutPanel1.Controls.Add(button1, 0, 3);
            tableLayoutPanel1.Location = new Point(3, 14);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(115, 328);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(3, 68);
            button2.Name = "button2";
            button2.Size = new Size(109, 59);
            button2.TabIndex = 1;
            button2.Text = "Book Vehicle";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(3, 133);
            button3.Name = "button3";
            button3.Size = new Size(109, 59);
            button3.TabIndex = 2;
            button3.Text = "Calculate Cost";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(109, 59);
            button4.TabIndex = 3;
            button4.Text = "List Vehicle";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.Location = new Point(3, 263);
            button5.Name = "button5";
            button5.Size = new Size(109, 62);
            button5.TabIndex = 4;
            button5.Text = "Main Menu";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(3, 198);
            button1.Name = "button1";
            button1.Size = new Size(109, 59);
            button1.TabIndex = 0;
            button1.Text = "Check Availability";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // RentSpecificVehicle
            // 
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "RentSpecificVehicle";
            Size = new Size(714, 667);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button3;
        private ListBox listBox1;
    }
}
