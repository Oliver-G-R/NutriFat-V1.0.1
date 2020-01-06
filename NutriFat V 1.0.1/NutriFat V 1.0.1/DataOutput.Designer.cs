namespace NutriFat_V_1._0._1
{
    partial class DataOutput
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label_imc = new System.Windows.Forms.Label();
            this.Progressbar_IMC = new AltoControls.CircularPB();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btn_getOut = new System.Windows.Forms.PictureBox();
            this.btn_Minimize = new System.Windows.Forms.PictureBox();
            this.label_peso_can = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.ProgresBar_Min = new AltoControls.CircularPB();
            this.ProgresBar_Max = new AltoControls.CircularPB();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_getOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Light", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "Calculo de peso ideal.";
            // 
            // label_imc
            // 
            this.label_imc.AutoSize = true;
            this.label_imc.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_imc.Location = new System.Drawing.Point(148, 252);
            this.label_imc.Name = "label_imc";
            this.label_imc.Size = new System.Drawing.Size(46, 25);
            this.label_imc.TabIndex = 15;
            this.label_imc.Text = "IMC";
            // 
            // Progressbar_IMC
            // 
            this.Progressbar_IMC.AllowText = true;
            this.Progressbar_IMC.AutomaticFontCalculation = true;
            this.Progressbar_IMC.BackColor = System.Drawing.Color.Transparent;
            this.Progressbar_IMC.Location = new System.Drawing.Point(111, 139);
            this.Progressbar_IMC.MaxValue = 100;
            this.Progressbar_IMC.MinimumSize = new System.Drawing.Size(60, 60);
            this.Progressbar_IMC.MinValue = 0;
            this.Progressbar_IMC.Name = "Progressbar_IMC";
            this.Progressbar_IMC.ProgressColor = System.Drawing.Color.IndianRed;
            this.Progressbar_IMC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Progressbar_IMC.Size = new System.Drawing.Size(110, 110);
            this.Progressbar_IMC.Stroke = 10;
            this.Progressbar_IMC.TabIndex = 17;
            this.Progressbar_IMC.Text = "circularPB1";
            this.Progressbar_IMC.Transparency = true;
            this.Progressbar_IMC.Value = 0;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(87)))), ((int)(((byte)(212)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-5, 71);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(639, 10);
            this.bunifuSeparator1.TabIndex = 18;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btn_getOut
            // 
            this.btn_getOut.Image = global::NutriFat_V_1._0._1.Properties.Resources.icons8_delete_sign_50px;
            this.btn_getOut.Location = new System.Drawing.Point(562, 12);
            this.btn_getOut.Name = "btn_getOut";
            this.btn_getOut.Size = new System.Drawing.Size(16, 16);
            this.btn_getOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_getOut.TabIndex = 19;
            this.btn_getOut.TabStop = false;
            this.btn_getOut.Click += new System.EventHandler(this.btn_getOut_Click);
            this.btn_getOut.MouseEnter += new System.EventHandler(this.btn_getOut_MouseEnter);
            this.btn_getOut.MouseLeave += new System.EventHandler(this.btn_getOut_MouseLeave);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Image = global::NutriFat_V_1._0._1.Properties.Resources.icons8_minus_math_16px;
            this.btn_Minimize.Location = new System.Drawing.Point(540, 12);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(16, 16);
            this.btn_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Minimize.TabIndex = 20;
            this.btn_Minimize.TabStop = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            this.btn_Minimize.MouseEnter += new System.EventHandler(this.btn_Minimize_MouseEnter);
            this.btn_Minimize.MouseLeave += new System.EventHandler(this.btn_Minimize_MouseLeave);
            // 
            // label_peso_can
            // 
            this.label_peso_can.AutoSize = true;
            this.label_peso_can.Font = new System.Drawing.Font("Yu Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_peso_can.Location = new System.Drawing.Point(344, 176);
            this.label_peso_can.Name = "label_peso_can";
            this.label_peso_can.Size = new System.Drawing.Size(66, 30);
            this.label_peso_can.TabIndex = 21;
            this.label_peso_can.Text = "Peso";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(101)))), ((int)(((byte)(209)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(-35, 87);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(639, 10);
            this.bunifuSeparator2.TabIndex = 22;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // ProgresBar_Min
            // 
            this.ProgresBar_Min.AllowText = true;
            this.ProgresBar_Min.AutomaticFontCalculation = true;
            this.ProgresBar_Min.BackColor = System.Drawing.Color.Transparent;
            this.ProgresBar_Min.Location = new System.Drawing.Point(111, 426);
            this.ProgresBar_Min.MaxValue = 100;
            this.ProgresBar_Min.MinimumSize = new System.Drawing.Size(60, 60);
            this.ProgresBar_Min.MinValue = 0;
            this.ProgresBar_Min.Name = "ProgresBar_Min";
            this.ProgresBar_Min.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.ProgresBar_Min.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProgresBar_Min.Size = new System.Drawing.Size(110, 110);
            this.ProgresBar_Min.Stroke = 10;
            this.ProgresBar_Min.TabIndex = 23;
            this.ProgresBar_Min.Text = "circularPB1";
            this.ProgresBar_Min.Transparency = true;
            this.ProgresBar_Min.Value = 0;
            // 
            // ProgresBar_Max
            // 
            this.ProgresBar_Max.AllowText = true;
            this.ProgresBar_Max.AutomaticFontCalculation = true;
            this.ProgresBar_Max.BackColor = System.Drawing.Color.Transparent;
            this.ProgresBar_Max.Location = new System.Drawing.Point(111, 296);
            this.ProgresBar_Max.MaxValue = 100;
            this.ProgresBar_Max.MinimumSize = new System.Drawing.Size(60, 60);
            this.ProgresBar_Max.MinValue = 0;
            this.ProgresBar_Max.Name = "ProgresBar_Max";
            this.ProgresBar_Max.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(136)))), ((int)(((byte)(42)))));
            this.ProgresBar_Max.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProgresBar_Max.Size = new System.Drawing.Size(110, 110);
            this.ProgresBar_Max.Stroke = 10;
            this.ProgresBar_Max.TabIndex = 24;
            this.ProgresBar_Max.Text = "circularPB2";
            this.ProgresBar_Max.Transparency = true;
            this.ProgresBar_Max.Value = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Yu Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(344, 460);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(92, 30);
            this.bunifuCustomLabel1.TabIndex = 25;
            this.bunifuCustomLabel1.Text = "Minimo";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Yu Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(344, 326);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(97, 30);
            this.bunifuCustomLabel2.TabIndex = 26;
            this.bunifuCustomLabel2.Text = "Maximo";
            // 
            // DataOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(590, 573);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.ProgresBar_Max);
            this.Controls.Add(this.ProgresBar_Min);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.label_peso_can);
            this.Controls.Add(this.btn_Minimize);
            this.Controls.Add(this.btn_getOut);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.Progressbar_IMC);
            this.Controls.Add(this.label_imc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataOutput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DataOutput";
            this.Load += new System.EventHandler(this.DataOutput_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataOutput_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btn_getOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_imc;
        private AltoControls.CircularPB Progressbar_IMC;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.PictureBox btn_getOut;
        private System.Windows.Forms.PictureBox btn_Minimize;
        private Bunifu.Framework.UI.BunifuCustomLabel label_peso_can;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private AltoControls.CircularPB ProgresBar_Max;
        private AltoControls.CircularPB ProgresBar_Min;
    }
}