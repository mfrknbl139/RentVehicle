namespace RentVehicle.UserControllers
{
    partial class ManageVehicle
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            listBox1 = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button3 = new Button();
            textBoxMake = new TextBox();
            textBoxModel = new TextBox();
            textBoxYear = new TextBox();
            textBoxRentalPrice = new TextBox();
            labelMake = new Label();
            labelModel = new Label();
            labelYear = new Label();
            labelRentalPrice = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 0;
            label1.Text = "ManageVehicle";
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(textBoxMake);
            panel1.Controls.Add(textBoxModel);
            panel1.Controls.Add(textBoxYear);
            panel1.Controls.Add(textBoxRentalPrice);
            panel1.Controls.Add(labelMake);
            panel1.Controls.Add(labelModel);
            panel1.Controls.Add(labelYear);
            panel1.Controls.Add(labelRentalPrice);
            panel1.Location = new Point(3, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 760);
            panel1.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(27, 249);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(535, 179);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 0, 1);
            tableLayoutPanel1.Controls.Add(button4, 0, 3);
            tableLayoutPanel1.Controls.Add(button5, 0, 4);
            tableLayoutPanel1.Controls.Add(button3, 0, 2);
            tableLayoutPanel1.Location = new Point(27, 29);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(228, 191);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(162, 32);
            button1.TabIndex = 0;
            button1.Text = "Add Vehicle";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 41);
            button2.Name = "button2";
            button2.Size = new Size(162, 32);
            button2.TabIndex = 1;
            button2.Text = "Update Vehicle";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(3, 117);
            button4.Name = "button4";
            button4.Size = new Size(112, 32);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(3, 155);
            button5.Name = "button5";
            button5.Size = new Size(162, 33);
            button5.TabIndex = 4;
            button5.Text = "Main Menu";
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 79);
            button3.Name = "button3";
            button3.Size = new Size(162, 32);
            button3.TabIndex = 2;
            button3.Text = "Remove Vehicle";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBoxMake
            // 
            textBoxMake.Location = new Point(382, 29);
            textBoxMake.Name = "textBoxMake";
            textBoxMake.Size = new Size(180, 31);
            textBoxMake.TabIndex = 5;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(382, 66);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(180, 31);
            textBoxModel.TabIndex = 6;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(382, 103);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(180, 31);
            textBoxYear.TabIndex = 7;
            // 
            // textBoxRentalPrice
            // 
            textBoxRentalPrice.Location = new Point(382, 140);
            textBoxRentalPrice.Name = "textBoxRentalPrice";
            textBoxRentalPrice.Size = new Size(180, 31);
            textBoxRentalPrice.TabIndex = 8;
            // 
            // labelMake
            // 
            labelMake.AutoSize = true;
            labelMake.Location = new Point(277, 32);
            labelMake.Name = "labelMake";
            labelMake.Size = new Size(59, 25);
            labelMake.TabIndex = 9;
            labelMake.Text = "Make:";
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Location = new Point(277, 69);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(67, 25);
            labelModel.TabIndex = 10;
            labelModel.Text = "Model:";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(277, 106);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(48, 25);
            labelYear.TabIndex = 11;
            labelYear.Text = "Year:";
            // 
            // labelRentalPrice
            // 
            labelRentalPrice.AutoSize = true;
            labelRentalPrice.Location = new Point(277, 143);
            labelRentalPrice.Name = "labelRentalPrice";
            labelRentalPrice.Size = new Size(106, 25);
            labelRentalPrice.TabIndex = 12;
            labelRentalPrice.Text = "Rental Price:";
            // 
            // ManageVehicle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "ManageVehicle";
            Size = new Size(800, 800);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button button3;
        private Button button4;
        private Button button5;
        private ListBox listBox1;
        private TextBox textBoxMake;
        private TextBox textBoxModel;
        private TextBox textBoxYear;
        private TextBox textBoxRentalPrice;
        private Label labelMake;
        private Label labelModel;
        private Label labelYear;
        private Label labelRentalPrice;
    }
}
