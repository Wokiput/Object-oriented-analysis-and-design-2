namespace builder
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cB_HouseType = new ComboBox();
            lbl_cmb_type = new Label();
            lbl_cmb_material = new Label();
            cB_WallMaterial = new ComboBox();
            lbl_nud_lenght = new Label();
            nUD_HouseLength = new NumericUpDown();
            lbl_nud_Height = new Label();
            nUD_HouseWidth = new NumericUpDown();
            btn_Build = new Button();
            rb_withBuilder = new RadioButton();
            rb_withoutBuilder = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)nUD_HouseLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD_HouseWidth).BeginInit();
            SuspendLayout();
            // 
            // cB_HouseType
            // 
            cB_HouseType.FormattingEnabled = true;
            cB_HouseType.Location = new Point(164, 16);
            cB_HouseType.Name = "cB_HouseType";
            cB_HouseType.Size = new Size(121, 23);
            cB_HouseType.TabIndex = 0;
            // 
            // lbl_cmb_type
            // 
            lbl_cmb_type.AutoSize = true;
            lbl_cmb_type.Location = new Point(21, 16);
            lbl_cmb_type.Name = "lbl_cmb_type";
            lbl_cmb_type.Size = new Size(59, 15);
            lbl_cmb_type.TabIndex = 1;
            lbl_cmb_type.Text = "Тип дома";
            // 
            // lbl_cmb_material
            // 
            lbl_cmb_material.AutoSize = true;
            lbl_cmb_material.Location = new Point(21, 62);
            lbl_cmb_material.Name = "lbl_cmb_material";
            lbl_cmb_material.Size = new Size(89, 15);
            lbl_cmb_material.TabIndex = 3;
            lbl_cmb_material.Text = "Материал стен";
            // 
            // cB_WallMaterial
            // 
            cB_WallMaterial.FormattingEnabled = true;
            cB_WallMaterial.Location = new Point(164, 62);
            cB_WallMaterial.Name = "cB_WallMaterial";
            cB_WallMaterial.Size = new Size(121, 23);
            cB_WallMaterial.TabIndex = 2;
            // 
            // lbl_nud_lenght
            // 
            lbl_nud_lenght.AutoSize = true;
            lbl_nud_lenght.Location = new Point(21, 109);
            lbl_nud_lenght.Name = "lbl_nud_lenght";
            lbl_nud_lenght.Size = new Size(73, 15);
            lbl_nud_lenght.TabIndex = 4;
            lbl_nud_lenght.Text = "Длина дома";
            // 
            // nUD_HouseLength
            // 
            nUD_HouseLength.Location = new Point(164, 109);
            nUD_HouseLength.Name = "nUD_HouseLength";
            nUD_HouseLength.Size = new Size(121, 23);
            nUD_HouseLength.TabIndex = 5;
            nUD_HouseLength.ValueChanged += nud_ValueChanged;
            // 
            // lbl_nud_Height
            // 
            lbl_nud_Height.AutoSize = true;
            lbl_nud_Height.Location = new Point(21, 153);
            lbl_nud_Height.Name = "lbl_nud_Height";
            lbl_nud_Height.Size = new Size(83, 15);
            lbl_nud_Height.TabIndex = 6;
            lbl_nud_Height.Text = "Ширина дома";
            // 
            // nUD_HouseWidth
            // 
            nUD_HouseWidth.Location = new Point(164, 153);
            nUD_HouseWidth.Name = "nUD_HouseWidth";
            nUD_HouseWidth.Size = new Size(121, 23);
            nUD_HouseWidth.TabIndex = 7;
            nUD_HouseWidth.ValueChanged += nud_ValueChanged;
            // 
            // btn_Build
            // 
            btn_Build.Location = new Point(210, 302);
            btn_Build.Name = "btn_Build";
            btn_Build.Size = new Size(75, 23);
            btn_Build.TabIndex = 10;
            btn_Build.Text = "Построить";
            btn_Build.UseVisualStyleBackColor = true;
            btn_Build.Click += btn_Build_Click;
            // 
            // rb_withBuilder
            // 
            rb_withBuilder.AutoSize = true;
            rb_withBuilder.Location = new Point(21, 202);
            rb_withBuilder.Name = "rb_withBuilder";
            rb_withBuilder.Size = new Size(97, 19);
            rb_withBuilder.TabIndex = 11;
            rb_withBuilder.TabStop = true;
            rb_withBuilder.Text = "С Паттерном";
            rb_withBuilder.UseVisualStyleBackColor = true;
            // 
            // rb_withoutBuilder
            // 
            rb_withoutBuilder.AutoSize = true;
            rb_withoutBuilder.Location = new Point(21, 227);
            rb_withoutBuilder.Name = "rb_withoutBuilder";
            rb_withoutBuilder.Size = new Size(97, 19);
            rb_withoutBuilder.TabIndex = 12;
            rb_withoutBuilder.TabStop = true;
            rb_withoutBuilder.Text = "Без Паттерна";
            rb_withoutBuilder.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 345);
            Controls.Add(rb_withoutBuilder);
            Controls.Add(rb_withBuilder);
            Controls.Add(btn_Build);
            Controls.Add(nUD_HouseWidth);
            Controls.Add(lbl_nud_Height);
            Controls.Add(nUD_HouseLength);
            Controls.Add(lbl_nud_lenght);
            Controls.Add(lbl_cmb_material);
            Controls.Add(cB_WallMaterial);
            Controls.Add(lbl_cmb_type);
            Controls.Add(cB_HouseType);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)nUD_HouseLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD_HouseWidth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cB_HouseType;
        private Label lbl_cmb_type;
        private Label lbl_cmb_material;
        private ComboBox cB_WallMaterial;
        private Label lbl_nud_lenght;
        private NumericUpDown nUD_HouseLength;
        private Label lbl_nud_Height;
        private NumericUpDown nUD_HouseWidth;
        private Button btn_Build;
        private RadioButton rb_withBuilder;
        private RadioButton rb_withoutBuilder;
    }
}
