namespace RentVehicle.UserControllers
{
    partial class UC_ListUsers
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

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            textBoxYear = new TextBox();
            textBoxModel = new TextBox();
            labelMake = new Label();
            labelModel = new Label();
            listBox1 = new ListBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 0;
            label1.Text = "List Users";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 43);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Location = new Point(3, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 625);
            panel1.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.11838F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.88162F));
            tableLayoutPanel3.Controls.Add(textBoxYear, 1, 1);
            tableLayoutPanel3.Controls.Add(textBoxModel, 1, 0);
            tableLayoutPanel3.Controls.Add(labelMake, 0, 0);
            tableLayoutPanel3.Controls.Add(labelModel, 0, 1);
            tableLayoutPanel3.Location = new Point(177, 10);
            tableLayoutPanel3.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(321, 117);
            tableLayoutPanel3.TabIndex = 15;
            // 
            // textBoxYear
            // 
            textBoxYear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxYear.Location = new Point(74, 61);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(244, 31);
            textBoxYear.TabIndex = 7;
            // 
            // textBoxModel
            // 
            textBoxModel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxModel.Location = new Point(74, 3);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(244, 31);
            textBoxModel.TabIndex = 6;
            // 
            // labelMake
            // 
            labelMake.AutoSize = true;
            labelMake.Location = new Point(3, 0);
            labelMake.Name = "labelMake";
            labelMake.Size = new Size(63, 25);
            labelMake.TabIndex = 9;
            labelMake.Text = "Name:";
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Location = new Point(3, 58);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(58, 25);
            labelModel.TabIndex = 10;
            labelModel.Text = "Email:";
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(4, 288);
            listBox1.Margin = new Padding(4, 5, 4, 5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(494, 229);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(button3, 0, 0);
            tableLayoutPanel2.Controls.Add(button4, 0, 1);
            tableLayoutPanel2.Controls.Add(button5, 0, 3);
            tableLayoutPanel2.Controls.Add(button6, 0, 4);
            tableLayoutPanel2.Controls.Add(button7, 0, 2);
            tableLayoutPanel2.Location = new Point(0, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(164, 257);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(158, 43);
            button3.TabIndex = 0;
            button3.Text = "List Users";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(3, 54);
            button4.Name = "button4";
            button4.Size = new Size(158, 43);
            button4.TabIndex = 1;
            button4.Text = "Add User";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(3, 156);
            button5.Name = "button5";
            button5.Size = new Size(158, 43);
            button5.TabIndex = 3;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(3, 207);
            button6.Name = "button6";
            button6.Size = new Size(158, 47);
            button6.TabIndex = 4;
            button6.Text = "Main Menu";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(3, 105);
            button7.Name = "button7";
            button7.Size = new Size(158, 43);
            button7.TabIndex = 2;
            button7.Text = "Delete User";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = true;
            // 
            // ListUsers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "ListUsers";
            Size = new Size(714, 667);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private ListBox listBox1;
        public TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox textBoxYear;
        private Label labelModel;
        private Label labelMake;
        private TextBox textBoxModel;
    }
}
