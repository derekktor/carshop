
namespace CarShop
{
    partial class SelectingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlTable = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MakeBox = new System.Windows.Forms.ComboBox();
            this.ColorBox = new System.Windows.Forms.ComboBox();
            this.EngineBox = new System.Windows.Forms.ComboBox();
            this.ModelBox = new System.Windows.Forms.ComboBox();
            this.CarPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonsTable = new System.Windows.Forms.TableLayoutPanel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.controlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarPictureBox)).BeginInit();
            this.buttonsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlTable
            // 
            this.controlTable.ColumnCount = 3;
            this.controlTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.controlTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.controlTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.controlTable.Controls.Add(this.label1, 0, 0);
            this.controlTable.Controls.Add(this.label4, 0, 3);
            this.controlTable.Controls.Add(this.label2, 0, 1);
            this.controlTable.Controls.Add(this.label3, 0, 2);
            this.controlTable.Controls.Add(this.MakeBox, 1, 0);
            this.controlTable.Controls.Add(this.ColorBox, 1, 3);
            this.controlTable.Controls.Add(this.EngineBox, 1, 2);
            this.controlTable.Controls.Add(this.ModelBox, 1, 1);
            this.controlTable.Controls.Add(this.CarPictureBox, 2, 0);
            this.controlTable.Location = new System.Drawing.Point(12, 12);
            this.controlTable.Name = "controlTable";
            this.controlTable.RowCount = 4;
            this.controlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.controlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.controlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.controlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.controlTable.Size = new System.Drawing.Size(698, 216);
            this.controlTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Make:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Color:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Engine:";
            // 
            // MakeBox
            // 
            this.MakeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MakeBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeBox.FormattingEnabled = true;
            this.MakeBox.Location = new System.Drawing.Point(72, 11);
            this.MakeBox.Name = "MakeBox";
            this.MakeBox.Size = new System.Drawing.Size(203, 31);
            this.MakeBox.TabIndex = 5;
            this.MakeBox.SelectedIndexChanged += new System.EventHandler(this.MakeBox_SelectedIndexChanged);
            // 
            // ColorBox
            // 
            this.ColorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorBox.FormattingEnabled = true;
            this.ColorBox.Location = new System.Drawing.Point(72, 173);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(203, 31);
            this.ColorBox.TabIndex = 8;
            this.ColorBox.SelectedIndexChanged += new System.EventHandler(this.ColorBox_SelectedIndexChanged);
            // 
            // EngineBox
            // 
            this.EngineBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EngineBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngineBox.FormattingEnabled = true;
            this.EngineBox.Location = new System.Drawing.Point(72, 119);
            this.EngineBox.Name = "EngineBox";
            this.EngineBox.Size = new System.Drawing.Size(203, 31);
            this.EngineBox.TabIndex = 7;
            this.EngineBox.SelectedIndexChanged += new System.EventHandler(this.EngineBox_SelectedIndexChanged);
            // 
            // ModelBox
            // 
            this.ModelBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBox.FormattingEnabled = true;
            this.ModelBox.Location = new System.Drawing.Point(72, 65);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(203, 31);
            this.ModelBox.TabIndex = 6;
            this.ModelBox.SelectedIndexChanged += new System.EventHandler(this.ModelBox_SelectedIndexChanged);
            // 
            // CarPictureBox
            // 
            this.CarPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarPictureBox.Image = global::CarShop.Properties.Resources.tX_white;
            this.CarPictureBox.Location = new System.Drawing.Point(281, 3);
            this.CarPictureBox.Name = "CarPictureBox";
            this.controlTable.SetRowSpan(this.CarPictureBox, 4);
            this.CarPictureBox.Size = new System.Drawing.Size(414, 210);
            this.CarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CarPictureBox.TabIndex = 9;
            this.CarPictureBox.TabStop = false;
            // 
            // buttonsTable
            // 
            this.buttonsTable.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonsTable.AutoSize = true;
            this.buttonsTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonsTable.ColumnCount = 2;
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.Controls.Add(this.CancelBtn, 1, 0);
            this.buttonsTable.Controls.Add(this.SelectBtn, 0, 0);
            this.buttonsTable.Location = new System.Drawing.Point(293, 241);
            this.buttonsTable.Name = "buttonsTable";
            this.buttonsTable.RowCount = 1;
            this.buttonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.Size = new System.Drawing.Size(150, 39);
            this.buttonsTable.TabIndex = 0;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelBtn.AutoSize = true;
            this.CancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(78, 3);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(69, 33);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SelectBtn
            // 
            this.SelectBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectBtn.AutoSize = true;
            this.SelectBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SelectBtn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectBtn.Location = new System.Drawing.Point(6, 3);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(62, 33);
            this.SelectBtn.TabIndex = 0;
            this.SelectBtn.Text = "Select";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // SelectingForm
            // 
            this.AcceptButton = this.SelectBtn;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(723, 292);
            this.Controls.Add(this.buttonsTable);
            this.Controls.Add(this.controlTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select a car";
            this.controlTable.ResumeLayout(false);
            this.controlTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarPictureBox)).EndInit();
            this.buttonsTable.ResumeLayout(false);
            this.buttonsTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TableLayoutPanel controlTable;
        private System.Windows.Forms.TableLayoutPanel buttonsTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MakeBox;
        private System.Windows.Forms.ComboBox ColorBox;
        private System.Windows.Forms.ComboBox EngineBox;
        private System.Windows.Forms.ComboBox ModelBox;
        private System.Windows.Forms.PictureBox CarPictureBox;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SelectBtn;
        #endregion

        //private System.Windows.Forms.PictureBox CarPictureBox;
        //private System.Windows.Forms.ComboBox ModelBox;
        //private System.Windows.Forms.ComboBox EngineBox;
        //private System.Windows.Forms.ComboBox ColorBox;
        //private System.Windows.Forms.ComboBox MakeBox;

        //private System.Windows.Forms.Label label4;
        //private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        //private System.Windows.Forms.Button CancelBtn;
        //private System.Windows.Forms.Button SelectBtn;
    }
}