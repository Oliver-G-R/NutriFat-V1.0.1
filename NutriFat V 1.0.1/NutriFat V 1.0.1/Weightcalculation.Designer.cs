namespace NutriFat_V_1._0._1
{
    partial class t
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
            this.components = new System.ComponentModel.Container();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_hombre = new System.Windows.Forms.RadioButton();
            this.radioButton_mujer = new System.Windows.Forms.RadioButton();
            this.Btn_Calculate = new AltoControls.AltoButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Textbox_Altura = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Textbox_Peso = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label_veri_altura = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(493, 383);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(2, 20);
            this.textBox9.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Light", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Calcula tu peso ideal.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_hombre);
            this.groupBox1.Controls.Add(this.radioButton_mujer);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(186, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo.";
            // 
            // radioButton_hombre
            // 
            this.radioButton_hombre.AutoSize = true;
            this.radioButton_hombre.Checked = true;
            this.radioButton_hombre.Location = new System.Drawing.Point(43, 42);
            this.radioButton_hombre.Name = "radioButton_hombre";
            this.radioButton_hombre.Size = new System.Drawing.Size(62, 17);
            this.radioButton_hombre.TabIndex = 2;
            this.radioButton_hombre.TabStop = true;
            this.radioButton_hombre.Text = "Hombre";
            this.radioButton_hombre.UseVisualStyleBackColor = true;
            // 
            // radioButton_mujer
            // 
            this.radioButton_mujer.AutoSize = true;
            this.radioButton_mujer.Location = new System.Drawing.Point(525, 42);
            this.radioButton_mujer.Name = "radioButton_mujer";
            this.radioButton_mujer.Size = new System.Drawing.Size(51, 17);
            this.radioButton_mujer.TabIndex = 1;
            this.radioButton_mujer.Text = "Mujer";
            this.radioButton_mujer.UseVisualStyleBackColor = true;
            // 
            // Btn_Calculate
            // 
            this.Btn_Calculate.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(73)))), ((int)(((byte)(208)))));
            this.Btn_Calculate.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(73)))), ((int)(((byte)(208)))));
            this.Btn_Calculate.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Calculate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Calculate.Font = new System.Drawing.Font("Yu Gothic UI Light", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Calculate.ForeColor = System.Drawing.Color.White;
            this.Btn_Calculate.Inactive1 = System.Drawing.Color.SlateBlue;
            this.Btn_Calculate.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(101)))), ((int)(((byte)(209)))));
            this.Btn_Calculate.Location = new System.Drawing.Point(349, 365);
            this.Btn_Calculate.Name = "Btn_Calculate";
            this.Btn_Calculate.Radius = 10;
            this.Btn_Calculate.Size = new System.Drawing.Size(281, 38);
            this.Btn_Calculate.Stroke = false;
            this.Btn_Calculate.StrokeColor = System.Drawing.Color.Gray;
            this.Btn_Calculate.TabIndex = 17;
            this.Btn_Calculate.Text = "Calcular";
            this.Btn_Calculate.Transparency = false;
            this.Btn_Calculate.Click += new System.EventHandler(this.Btn_Calculate_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Textbox_Altura
            // 
            this.Textbox_Altura.BorderColorFocused = System.Drawing.Color.Blue;
            this.Textbox_Altura.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textbox_Altura.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Textbox_Altura.BorderThickness = 3;
            this.Textbox_Altura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_Altura.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_Altura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textbox_Altura.isPassword = false;
            this.Textbox_Altura.Location = new System.Drawing.Point(186, 232);
            this.Textbox_Altura.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_Altura.Name = "Textbox_Altura";
            this.Textbox_Altura.Size = new System.Drawing.Size(245, 44);
            this.Textbox_Altura.TabIndex = 18;
            this.Textbox_Altura.Text = "0";
            this.Textbox_Altura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_Altura.Enter += new System.EventHandler(this.Textbox_Altura_Enter);
            this.Textbox_Altura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_Altura_KeyPress);
            this.Textbox_Altura.Leave += new System.EventHandler(this.Textbox_Altura_Leave);
            // 
            // Textbox_Peso
            // 
            this.Textbox_Peso.BorderColorFocused = System.Drawing.Color.Blue;
            this.Textbox_Peso.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textbox_Peso.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Textbox_Peso.BorderThickness = 3;
            this.Textbox_Peso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_Peso.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_Peso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textbox_Peso.isPassword = false;
            this.Textbox_Peso.Location = new System.Drawing.Point(569, 232);
            this.Textbox_Peso.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_Peso.Name = "Textbox_Peso";
            this.Textbox_Peso.Size = new System.Drawing.Size(245, 44);
            this.Textbox_Peso.TabIndex = 19;
            this.Textbox_Peso.Text = "0";
            this.Textbox_Peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_Peso.Enter += new System.EventHandler(this.Textbox_Peso_Enter);
            this.Textbox_Peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_Peso_KeyPress);
            this.Textbox_Peso.Leave += new System.EventHandler(this.Textbox_Peso_Leave);
            // 
            // label_veri_altura
            // 
            this.label_veri_altura.AutoSize = true;
            this.label_veri_altura.BackColor = System.Drawing.Color.Transparent;
            this.label_veri_altura.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_veri_altura.Location = new System.Drawing.Point(182, 207);
            this.label_veri_altura.Name = "label_veri_altura";
            this.label_veri_altura.Size = new System.Drawing.Size(91, 21);
            this.label_veri_altura.TabIndex = 20;
            this.label_veri_altura.Text = "Altura(Cm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(565, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Peso(Kgr)";
            // 
            // t
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(974, 675);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_veri_altura);
            this.Controls.Add(this.Textbox_Peso);
            this.Controls.Add(this.Textbox_Altura);
            this.Controls.Add(this.Btn_Calculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "t";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weightcalculation";
            this.Load += new System.EventHandler(this.Weightcalculation_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Weightcalculation_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_mujer;
        private System.Windows.Forms.RadioButton radioButton_hombre;
        private AltoControls.AltoButton Btn_Calculate;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMetroTextbox Textbox_Altura;
        private Bunifu.Framework.UI.BunifuMetroTextbox Textbox_Peso;
        private System.Windows.Forms.Label label_veri_altura;
        private System.Windows.Forms.Label label2;
    }
}