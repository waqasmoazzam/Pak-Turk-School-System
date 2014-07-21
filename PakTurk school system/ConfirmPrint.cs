using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;

using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PakTurk_school_system
{
    public partial class ConfirmPrint : Form
    {
        
        Registration reg;
        PrintDocument pd = new PrintDocument();
        Bitmap memoryImage;
        public ConfirmPrint(Registration r)
        {
            InitializeComponent();
            reg = r;
            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            reg.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            
            
            this.btnBack.Visible = false;
            this.btnPrint.Visible = false;
            
                        
            PrintPreviewDialog dlgPrintPreview = new PrintPreviewDialog();
            
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            
            memoryImage = new Bitmap(s.Width, s.Height);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
                 
            dlgPrintPreview.Document = pd;
            dlgPrintPreview.ShowDialog();

            this.btnBack.Visible = true;
            this.btnPrint.Visible = true;
            
            

        }

        private void printDocument1_PrintPage(System.Object sender,
           System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle r = new Rectangle();
            r.Height = memoryImage.Height;
            r.Width = memoryImage.Width;
            r.X = 30;
            r.Y = -10;
            r.Offset(0, -27);
            e.Graphics.DrawImage(memoryImage, r);

        }
        

        private void ConfirmPrint_Load(object sender, EventArgs e)
        {

        }

    }
}
