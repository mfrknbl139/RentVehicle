﻿namespace RentVehicle
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(675, 479);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(140, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(535, 479);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(140, 479);
            panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 0, 2);
            tableLayoutPanel1.Controls.Add(button4, 0, 3);
            tableLayoutPanel1.Controls.Add(button5, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(140, 479);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(2, 2);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(136, 91);
            button1.TabIndex = 0;
            button1.Text = "Manage Vehicle";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(2, 97);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(136, 91);
            button2.TabIndex = 1;
            button2.Text = "Rent Vehicle";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(2, 192);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(136, 91);
            button3.TabIndex = 2;
            button3.Text = "List Users";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(2, 287);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(136, 91);
            button4.TabIndex = 3;
            button4.Text = "Settings";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(2, 382);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(136, 95);
            button5.TabIndex = 4;
            button5.Text = "Exit";
            button5.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 479);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Main";
            Text = "Main";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
