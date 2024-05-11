using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentVehicle.UserControllers
{
    public partial class RentSpecificVehicle : UserControl
    {
        public RentSpecificVehicle()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 0;
            label1.Text = "RentSpecificVehicle";
            // 
            // RentSpecificVehicle
            // 
            Controls.Add(label1);
            Name = "RentSpecificVehicle";
            Size = new Size(800, 800);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
    }
}
