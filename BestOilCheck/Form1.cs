using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOilCheck
{
    public partial class BestOilCheck : Form
    {
        public BestOilCheck()
        {
            InitializeComponent();
        }

        private void BestOilCheck_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop, false) as string[];

            foreach (var file in files)
            {
                MessageBox.Show(file);
                listBox1.Items.Add(file);
            }

            //string filee = e.Data.GetData(DataFormats.)

            //JsonConvert.DeserializeObject();
        }
    }
}
