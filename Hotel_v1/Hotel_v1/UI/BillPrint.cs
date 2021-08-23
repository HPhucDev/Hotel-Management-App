using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Hotel_v1
{
    public partial class BillPrint : Form
    {
        public List<Menu> menu = new List<Menu>();
        public string room, checkin, checkout, numberday, totalpriceday, total;
        private void BillPrint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.P)
            {
                printButton_Click(sender, e);
            }
        }
        private void BillPrint_Load(object sender, EventArgs e)
        {
            roomLabel.Text = room;
            checkinLabel.Text = checkin;
            checkoutLabel.Text = checkout;
            numberdayLabel.Text = numberday;
            totalpricedayLabel.Text = totalpriceday;
            CultureInfo culture = new CultureInfo("vi-VN");
            int totalbill = int.Parse(total);
            totalTextBox.Text = totalbill.ToString("c", culture);
            float totalPrice = 0;
            lsvBill.GridLines = false;
            foreach (Menu item in menu)
            {
                ListViewItem lsvItem = new ListViewItem(item.ServiceName.ToString());

                lsvItem.SubItems.Add(item.Count.ToString());

                lsvItem.SubItems.Add(item.Price.ToString());

                lsvItem.SubItems.Add(item.TotalPrice.ToString());

                totalPrice += item.TotalPrice;

                lsvBill.Items.Add(lsvItem);
            }
            
        }
        public BillPrint()
        {
            InitializeComponent();
        }

        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height, panel1.CreateGraphics());
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
            doc.Print();
        }

    }
}
