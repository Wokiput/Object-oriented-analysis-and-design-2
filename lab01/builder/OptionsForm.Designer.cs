namespace builder
{
    partial class OptionsForm
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
            panel_Pool = new Panel();
            nUD_PoolWidth = new NumericUpDown();
            lbl_PoolWidth = new Label();
            nUD_PoolLength = new NumericUpDown();
            lbl_PoolLength = new Label();
            panel_Garage = new Panel();
            nUD_GarageWidth = new NumericUpDown();
            lbl_GarageWidth = new Label();
            nUD_GarageLength = new NumericUpDown();
            lbl_GarageLength = new Label();
            lbl_GardenType = new Label();
            panel_Garden = new Panel();
            cB_GardenType = new ComboBox();
            cB_StatueType = new ComboBox();
            lbl_StatueType = new Label();
            panel_Statue = new Panel();
            btn_Ok = new Button();
            panel_Pool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_PoolWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD_PoolLength).BeginInit();
            panel_Garage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_GarageWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD_GarageLength).BeginInit();
            panel_Garden.SuspendLayout();
            panel_Statue.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Pool
            // 
            panel_Pool.Controls.Add(nUD_PoolWidth);
            panel_Pool.Controls.Add(lbl_PoolWidth);
            panel_Pool.Controls.Add(nUD_PoolLength);
            panel_Pool.Controls.Add(lbl_PoolLength);
            panel_Pool.Location = new Point(12, 12);
            panel_Pool.Name = "panel_Pool";
            panel_Pool.Size = new Size(264, 80);
            panel_Pool.TabIndex = 0;
            // 
            // nUD_PoolWidth
            // 
            nUD_PoolWidth.DecimalPlaces = 1;
            nUD_PoolWidth.Location = new Point(131, 44);
            nUD_PoolWidth.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nUD_PoolWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUD_PoolWidth.Name = "nUD_PoolWidth";
            nUD_PoolWidth.Size = new Size(54, 23);
            nUD_PoolWidth.TabIndex = 3;
            nUD_PoolWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbl_PoolWidth
            // 
            lbl_PoolWidth.AutoSize = true;
            lbl_PoolWidth.Location = new Point(16, 44);
            lbl_PoolWidth.Name = "lbl_PoolWidth";
            lbl_PoolWidth.Size = new Size(106, 15);
            lbl_PoolWidth.TabIndex = 2;
            lbl_PoolWidth.Text = "Ширина бассейна";
            // 
            // nUD_PoolLength
            // 
            nUD_PoolLength.DecimalPlaces = 1;
            nUD_PoolLength.Location = new Point(131, 11);
            nUD_PoolLength.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nUD_PoolLength.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUD_PoolLength.Name = "nUD_PoolLength";
            nUD_PoolLength.Size = new Size(54, 23);
            nUD_PoolLength.TabIndex = 1;
            nUD_PoolLength.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbl_PoolLength
            // 
            lbl_PoolLength.AutoSize = true;
            lbl_PoolLength.Location = new Point(16, 11);
            lbl_PoolLength.Name = "lbl_PoolLength";
            lbl_PoolLength.Size = new Size(96, 15);
            lbl_PoolLength.TabIndex = 0;
            lbl_PoolLength.Text = "Длина бассейна";
            // 
            // panel_Garage
            // 
            panel_Garage.Controls.Add(nUD_GarageWidth);
            panel_Garage.Controls.Add(lbl_GarageWidth);
            panel_Garage.Controls.Add(nUD_GarageLength);
            panel_Garage.Controls.Add(lbl_GarageLength);
            panel_Garage.Location = new Point(12, 146);
            panel_Garage.Name = "panel_Garage";
            panel_Garage.Size = new Size(264, 80);
            panel_Garage.TabIndex = 1;
            // 
            // nUD_GarageWidth
            // 
            nUD_GarageWidth.DecimalPlaces = 1;
            nUD_GarageWidth.Location = new Point(131, 44);
            nUD_GarageWidth.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nUD_GarageWidth.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nUD_GarageWidth.Name = "nUD_GarageWidth";
            nUD_GarageWidth.Size = new Size(54, 23);
            nUD_GarageWidth.TabIndex = 3;
            nUD_GarageWidth.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // lbl_GarageWidth
            // 
            lbl_GarageWidth.AutoSize = true;
            lbl_GarageWidth.Location = new Point(16, 44);
            lbl_GarageWidth.Name = "lbl_GarageWidth";
            lbl_GarageWidth.Size = new Size(94, 15);
            lbl_GarageWidth.TabIndex = 2;
            lbl_GarageWidth.Text = "Ширина гаража";
            // 
            // nUD_GarageLength
            // 
            nUD_GarageLength.DecimalPlaces = 1;
            nUD_GarageLength.Location = new Point(131, 11);
            nUD_GarageLength.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            nUD_GarageLength.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            nUD_GarageLength.Name = "nUD_GarageLength";
            nUD_GarageLength.Size = new Size(54, 23);
            nUD_GarageLength.TabIndex = 1;
            nUD_GarageLength.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lbl_GarageLength
            // 
            lbl_GarageLength.AutoSize = true;
            lbl_GarageLength.Location = new Point(16, 11);
            lbl_GarageLength.Name = "lbl_GarageLength";
            lbl_GarageLength.Size = new Size(84, 15);
            lbl_GarageLength.TabIndex = 0;
            lbl_GarageLength.Text = "Длина гаража";
            // 
            // lbl_GardenType
            // 
            lbl_GardenType.AutoSize = true;
            lbl_GardenType.Location = new Point(16, 11);
            lbl_GardenType.Name = "lbl_GardenType";
            lbl_GardenType.Size = new Size(55, 15);
            lbl_GardenType.TabIndex = 0;
            lbl_GardenType.Text = "Тип сада";
            // 
            // panel_Garden
            // 
            panel_Garden.Controls.Add(cB_GardenType);
            panel_Garden.Controls.Add(lbl_GardenType);
            panel_Garden.Location = new Point(12, 98);
            panel_Garden.Name = "panel_Garden";
            panel_Garden.Size = new Size(264, 42);
            panel_Garden.TabIndex = 2;
            // 
            // cB_GardenType
            // 
            cB_GardenType.FormattingEnabled = true;
            cB_GardenType.Items.AddRange(new object[] { "Цветочный", "Кустовой", "Деревовый" });
            cB_GardenType.Location = new Point(131, 8);
            cB_GardenType.Name = "cB_GardenType";
            cB_GardenType.Size = new Size(121, 23);
            cB_GardenType.TabIndex = 1;
            // 
            // cB_StatueType
            // 
            cB_StatueType.FormattingEnabled = true;
            cB_StatueType.Items.AddRange(new object[] { "С позолотой", "Бронзовая", "Гипсовая" });
            cB_StatueType.Location = new Point(131, 8);
            cB_StatueType.Name = "cB_StatueType";
            cB_StatueType.Size = new Size(121, 23);
            cB_StatueType.TabIndex = 1;
            // 
            // lbl_StatueType
            // 
            lbl_StatueType.AutoSize = true;
            lbl_StatueType.Location = new Point(16, 11);
            lbl_StatueType.Name = "lbl_StatueType";
            lbl_StatueType.Size = new Size(66, 15);
            lbl_StatueType.TabIndex = 0;
            lbl_StatueType.Text = "Тип статуи";
            // 
            // panel_Statue
            // 
            panel_Statue.Controls.Add(cB_StatueType);
            panel_Statue.Controls.Add(lbl_StatueType);
            panel_Statue.Location = new Point(12, 232);
            panel_Statue.Name = "panel_Statue";
            panel_Statue.Size = new Size(264, 42);
            panel_Statue.TabIndex = 3;
            // 
            // btn_Ok
            // 
            btn_Ok.Location = new Point(201, 291);
            btn_Ok.Name = "btn_Ok";
            btn_Ok.Size = new Size(75, 23);
            btn_Ok.TabIndex = 4;
            btn_Ok.Text = "OK";
            btn_Ok.UseVisualStyleBackColor = true;
            btn_Ok.Click += btn_Ok_Click;
            // 
            // OptionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 322);
            Controls.Add(btn_Ok);
            Controls.Add(panel_Statue);
            Controls.Add(panel_Garden);
            Controls.Add(panel_Garage);
            Controls.Add(panel_Pool);
            Name = "OptionsForm";
            Text = "OptionsForm";
            panel_Pool.ResumeLayout(false);
            panel_Pool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_PoolWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD_PoolLength).EndInit();
            panel_Garage.ResumeLayout(false);
            panel_Garage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_GarageWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD_GarageLength).EndInit();
            panel_Garden.ResumeLayout(false);
            panel_Garden.PerformLayout();
            panel_Statue.ResumeLayout(false);
            panel_Statue.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Pool;
        private Label lbl_PoolLength;
        private NumericUpDown nUD_PoolLength;
        private NumericUpDown nUD_PoolWidth;
        private Label lbl_PoolWidth;
        private Panel panel_Garage;
        private NumericUpDown nUD_GarageWidth;
        private Label lbl_GarageWidth;
        private NumericUpDown nUD_GarageLength;
        private Label lbl_GarageLength;
        private Label lbl_GardenType;
        private Panel panel_Garden;
        private ComboBox cB_GardenType;
        private ComboBox cB_StatueType;
        private Label lbl_StatueType;
        private Panel panel_Statue;
        private Button btn_Ok;
    }
}