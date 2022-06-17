using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CarShop
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            var selectForm = new SelectingForm();
            //selectForm.FormClosed += (s, args) => this.Show();
            //this.Hide();
            //selectForm.Show();

            selectForm.ShowDialog();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var addForm = new AddingForm();
            //addForm.FormClosed += (s, args) => this.Show();
            //this.Hide();
            //addForm.Show();

            addForm.ShowDialog();
        }

        private void ReserveBtn_Click(object sender, EventArgs e)
        {
            var reserveForm = new ReservingForm();
            //reserveForm.FormClosed += (s, args) => this.Show();
            //this.Hide();
            //reserveForm.Show();

            reserveForm.ShowDialog();
        }
    }
}
