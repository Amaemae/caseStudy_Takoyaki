using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caseStudy
{
    public partial class UC_items : UserControl
    {
        public Image itemImage
        {
            get { return imgItem.Image; }
            set { imgItem.Image = value; }
        }

        public string itemName
        {
            
            get { return ItemName.Text; }
            set { ItemName.Text = value; }
        }

        public string itemPrice
        {
            get { return ItemPrice.Text; }
            set { ItemPrice.Text = value; }
        }

        public UC_items()
        {
            InitializeComponent();
        }
    }
}
