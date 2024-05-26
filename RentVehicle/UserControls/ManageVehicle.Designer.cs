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
            components = new System.ComponentModel.Container();
            labelRentalPrice = new Label();
            labelYear = new Label();
            labelModel = new Label();
            labelMake = new Label();
            textBoxRentalPrice = new TextBox();
            textBoxYear = new TextBox();
            textBoxModel = new TextBox();
            textBoxMake = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            label2 = new Label();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            VehicleType = new ComboBox();
            vehicleBindingSource = new BindingSource(components);
            bikeBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vehicleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bikeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // labelRentalPrice
            // 
            labelRentalPrice.AutoSize = true;
            labelRentalPrice.Location = new Point(2, 90);
            labelRentalPrice.Margin = new Padding(2, 0, 2, 0);
            labelRentalPrice.Name = "labelRentalPrice";
            labelRentalPrice.Size = new Size(72, 15);
            labelRentalPrice.TabIndex = 12;
            labelRentalPrice.Text = "Rental Price:";
            labelRentalPrice.Click += labelRentalPrice_Click;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(2, 60);
            labelYear.Margin = new Padding(2, 0, 2, 0);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(32, 15);
            labelYear.TabIndex = 11;
            labelYear.Text = "Year:";
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Location = new Point(2, 30);
            labelModel.Margin = new Padding(2, 0, 2, 0);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(44, 15);
            labelModel.TabIndex = 10;
            labelModel.Text = "Model:";
            // 
            // labelMake
            // 
            labelMake.AutoSize = true;
            labelMake.Location = new Point(2, 0);
            labelMake.Margin = new Padding(2, 0, 2, 0);
            labelMake.Name = "labelMake";
            labelMake.Size = new Size(39, 15);
            labelMake.TabIndex = 9;
            labelMake.Text = "Make:";
            labelMake.Click += labelMake_Click;
            // 
            // textBoxRentalPrice
            // 
            textBoxRentalPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxRentalPrice.Location = new Point(79, 92);
            textBoxRentalPrice.Margin = new Padding(2);
            textBoxRentalPrice.Name = "textBoxRentalPrice";
            textBoxRentalPrice.Size = new Size(144, 23);
            textBoxRentalPrice.TabIndex = 8;
            // 
            // textBoxYear
            // 
            textBoxYear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxYear.Location = new Point(79, 62);
            textBoxYear.Margin = new Padding(2);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(144, 23);
            textBoxYear.TabIndex = 7;
            // 
            // textBoxModel
            // 
            textBoxModel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxModel.Location = new Point(79, 32);
            textBoxModel.Margin = new Padding(2);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(144, 23);
            textBoxModel.TabIndex = 6;
            // 
            // textBoxMake
            // 
            textBoxMake.Dock = DockStyle.Fill;
            textBoxMake.Location = new Point(79, 2);
            textBoxMake.Margin = new Padding(2);
            textBoxMake.Name = "textBoxMake";
            textBoxMake.Size = new Size(144, 23);
            textBoxMake.TabIndex = 5;
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
            tableLayoutPanel1.Location = new Point(19, 28);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(115, 154);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(2, 2);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(111, 26);
            button1.TabIndex = 0;
            button1.Text = "Add Vehicle";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(2, 32);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(111, 26);
            button2.TabIndex = 1;
            button2.Text = "Update Vehicle";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(2, 92);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(111, 26);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(2, 122);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(111, 30);
            button5.TabIndex = 4;
            button5.Text = "Main Menu";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(2, 62);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(111, 26);
            button3.TabIndex = 2;
            button3.Text = "Remove Vehicle";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(16, 218);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(347, 139);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 13;
            label2.Text = "Manage Vehicle";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 400);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.5F));
            tableLayoutPanel2.Controls.Add(label1, 0, 4);
            tableLayoutPanel2.Controls.Add(textBoxYear, 1, 2);
            tableLayoutPanel2.Controls.Add(labelModel, 0, 1);
            tableLayoutPanel2.Controls.Add(labelMake, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxMake, 1, 0);
            tableLayoutPanel2.Controls.Add(textBoxRentalPrice, 1, 3);
            tableLayoutPanel2.Controls.Add(labelYear, 0, 2);
            tableLayoutPanel2.Controls.Add(textBoxModel, 1, 1);
            tableLayoutPanel2.Controls.Add(labelRentalPrice, 0, 3);
            tableLayoutPanel2.Controls.Add(VehicleType, 1, 4);
            tableLayoutPanel2.Location = new Point(141, 30);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(225, 150);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 120);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 16;
            label1.Text = "Type";
            // 
            // VehicleType
            // 
            VehicleType.DataSource = vehicleBindingSource;
            VehicleType.DisplayMember = "Type";
            VehicleType.FormattingEnabled = true;
            VehicleType.Location = new Point(80, 123);
            VehicleType.Name = "VehicleType";
            VehicleType.Size = new Size(142, 23);
            VehicleType.TabIndex = 15;
            VehicleType.ValueMember = "Type";
            VehicleType.SelectedIndexChanged += VehicleType_SelectedIndexChanged;
            // 
            // vehicleBindingSource
            // 
            vehicleBindingSource.DataSource = typeof(Classes.Vehicle);
            // 
            // bikeBindingSource
            // 
            bikeBindingSource.DataSource = typeof(Classes.Bike);
            // 
            // ManageVehicle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "ManageVehicle";
            Size = new Size(500, 400);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)vehicleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bikeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelRentalPrice;
        private Label labelYear;
        private Label labelModel;
        private Label labelMake;
        private TextBox textBoxRentalPrice;
        private TextBox textBoxYear;
        private TextBox textBoxModel;
        private TextBox textBoxMake;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button3;
        private ListBox listBox1;
        private Label label2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private ComboBox VehicleType;
        private BindingSource bikeBindingSource;
        private BindingSource vehicleBindingSource;
    }
}
