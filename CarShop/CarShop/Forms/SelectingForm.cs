using System;
using System.Windows.Forms;

namespace CarShop
{
    public partial class SelectingForm : Form
    {

        public SelectingForm()
        {
            InitializeComponent();

            MakeBox.DataSource = MakeBuilder.Makes;

            MakeBox.Enabled = true;
            ModelBox.Enabled = true;
            EngineBox.Enabled = true;
            ColorBox.Enabled = true;

            // Defaults
            MakeBox.SelectedIndex = 0;
            ModelBox.SelectedIndex = 0;
            EngineBox.SelectedIndex = 0;
            ColorBox.SelectedIndex = 0;
        }

        private void MakeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var make = (Make) MakeBox.SelectedItem;

            ModelBox.Items.Clear();
            ModelBox.Items.AddRange(make.Models);
            ModelBox.SelectedIndex = 0;

            EngineBox.Items.Clear();
            EngineBox.Items.AddRange(make.Models[0].Engines);
            EngineBox.SelectedIndex = 0;

            ColorBox.Items.Clear();
            ColorBox.Items.AddRange(make.Models[0].Colors);
            ColorBox.SelectedIndex = 0;

            CarPictureBox.Image = make.Models[0].Colors[0].Img;
        }

        private void ModelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var model = (Make.Model) ModelBox.SelectedItem;

            EngineBox.Items.Clear();
            EngineBox.Items.AddRange(model.Engines);
            EngineBox.SelectedIndex = 0;

            ColorBox.Items.Clear();
            ColorBox.Items.AddRange(model.Colors);
            ColorBox.SelectedIndex = 0;

            CarPictureBox.Image = model.Colors[0].Img;
        }
        
        private void EngineBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var model = (Make.Model) ModelBox.SelectedItem;

            ColorBox.Items.Clear();
            ColorBox.Items.AddRange(model.Colors);
            ColorBox.SelectedIndex = 0;

            CarPictureBox.Image = model.Colors[0].Img;
        }

        private void ColorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var color = (Make.Model.Color) ColorBox.SelectedItem;

            CarPictureBox.Image = color.Img;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            var car = new Car(MakeBox.Text, ModelBox.Text, EngineBox.Text, ColorBox.Text);
            var addForm = new AddingForm(car);
            //addForm.FormClosed += (s, args) => this.Parent.Show();
            //this.Hide();
            //addForm.Show();

            addForm.ShowDialog();
        }
    }
}
