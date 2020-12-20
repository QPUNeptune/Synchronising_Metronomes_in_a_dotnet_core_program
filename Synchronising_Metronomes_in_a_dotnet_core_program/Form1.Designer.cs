
namespace Synchronising_Metronomes_in_a_dotnet_core_program
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.waveA = new System.Windows.Forms.TrackBar();
            this.waveB = new System.Windows.Forms.TrackBar();
            this.waveC = new System.Windows.Forms.TrackBar();
            this.waveANum = new System.Windows.Forms.NumericUpDown();
            this.waveBNum = new System.Windows.Forms.NumericUpDown();
            this.waveCNum = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.kSlide = new System.Windows.Forms.TrackBar();
            this.kNum = new System.Windows.Forms.NumericUpDown();
            this.kura_model = new System.Windows.Forms.RadioButton();
            this.parker_model = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.waveA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveANum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveBNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveCNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kNum)).BeginInit();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Enabled = false;
            this.formsPlot1.Location = new System.Drawing.Point(13, 271);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(1495, 404);
            this.formsPlot1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wave A Offset:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wave B Offset:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(14, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wave B Offset:";
            // 
            // waveA
            // 
            this.waveA.LargeChange = 314;
            this.waveA.Location = new System.Drawing.Point(194, 12);
            this.waveA.Maximum = 31415;
            this.waveA.Name = "waveA";
            this.waveA.Size = new System.Drawing.Size(113, 45);
            this.waveA.SmallChange = 31;
            this.waveA.TabIndex = 5;
            this.waveA.TickFrequency = 3141;
            this.waveA.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.waveA.Scroll += new System.EventHandler(this.waveA_Scroll);
            // 
            // waveB
            // 
            this.waveB.LargeChange = 314;
            this.waveB.Location = new System.Drawing.Point(194, 63);
            this.waveB.Maximum = 31415;
            this.waveB.Name = "waveB";
            this.waveB.Size = new System.Drawing.Size(113, 45);
            this.waveB.SmallChange = 31;
            this.waveB.TabIndex = 6;
            this.waveB.TickFrequency = 3141;
            this.waveB.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.waveB.Scroll += new System.EventHandler(this.waveB_Scroll);
            // 
            // waveC
            // 
            this.waveC.LargeChange = 314;
            this.waveC.Location = new System.Drawing.Point(194, 114);
            this.waveC.Maximum = 31415;
            this.waveC.Name = "waveC";
            this.waveC.Size = new System.Drawing.Size(113, 45);
            this.waveC.SmallChange = 31;
            this.waveC.TabIndex = 7;
            this.waveC.TickFrequency = 3141;
            this.waveC.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.waveC.Scroll += new System.EventHandler(this.waveC_Scroll);
            // 
            // waveANum
            // 
            this.waveANum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.waveANum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.waveANum.DecimalPlaces = 4;
            this.waveANum.ForeColor = System.Drawing.Color.White;
            this.waveANum.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            262144});
            this.waveANum.Location = new System.Drawing.Point(104, 26);
            this.waveANum.Maximum = new decimal(new int[] {
            31415,
            0,
            0,
            262144});
            this.waveANum.Name = "waveANum";
            this.waveANum.Size = new System.Drawing.Size(84, 19);
            this.waveANum.TabIndex = 8;
            this.waveANum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.waveANum.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.waveANum.ValueChanged += new System.EventHandler(this.waveANum_ValueChanged);
            // 
            // waveBNum
            // 
            this.waveBNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.waveBNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.waveBNum.DecimalPlaces = 4;
            this.waveBNum.ForeColor = System.Drawing.Color.White;
            this.waveBNum.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            262144});
            this.waveBNum.Location = new System.Drawing.Point(104, 77);
            this.waveBNum.Maximum = new decimal(new int[] {
            31415,
            0,
            0,
            262144});
            this.waveBNum.Name = "waveBNum";
            this.waveBNum.Size = new System.Drawing.Size(84, 19);
            this.waveBNum.TabIndex = 9;
            this.waveBNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.waveBNum.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.waveBNum.ValueChanged += new System.EventHandler(this.waveBNum_ValueChanged);
            // 
            // waveCNum
            // 
            this.waveCNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.waveCNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.waveCNum.DecimalPlaces = 4;
            this.waveCNum.ForeColor = System.Drawing.Color.White;
            this.waveCNum.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            262144});
            this.waveCNum.Location = new System.Drawing.Point(104, 128);
            this.waveCNum.Maximum = new decimal(new int[] {
            31415,
            0,
            0,
            262144});
            this.waveCNum.Name = "waveCNum";
            this.waveCNum.Size = new System.Drawing.Size(84, 19);
            this.waveCNum.TabIndex = 10;
            this.waveCNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.waveCNum.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.waveCNum.ValueChanged += new System.EventHandler(this.waveCNum_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(14, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "k:";
            // 
            // kSlide
            // 
            this.kSlide.LargeChange = 10;
            this.kSlide.Location = new System.Drawing.Point(194, 165);
            this.kSlide.Maximum = 1000;
            this.kSlide.Name = "kSlide";
            this.kSlide.Size = new System.Drawing.Size(113, 45);
            this.kSlide.TabIndex = 12;
            this.kSlide.TickFrequency = 100;
            this.kSlide.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.kSlide.Scroll += new System.EventHandler(this.kSlide_Scroll);
            // 
            // kNum
            // 
            this.kNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kNum.DecimalPlaces = 4;
            this.kNum.ForeColor = System.Drawing.Color.White;
            this.kNum.Increment = new decimal(new int[] {
            10,
            0,
            0,
            262144});
            this.kNum.Location = new System.Drawing.Point(104, 176);
            this.kNum.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.kNum.Name = "kNum";
            this.kNum.Size = new System.Drawing.Size(84, 19);
            this.kNum.TabIndex = 13;
            this.kNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kNum.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.kNum.ValueChanged += new System.EventHandler(this.kNum_ValueChanged);
            // 
            // kura_model
            // 
            this.kura_model.AutoSize = true;
            this.kura_model.Checked = true;
            this.kura_model.ForeColor = System.Drawing.Color.Gray;
            this.kura_model.Location = new System.Drawing.Point(13, 201);
            this.kura_model.Name = "kura_model";
            this.kura_model.Size = new System.Drawing.Size(115, 19);
            this.kura_model.TabIndex = 14;
            this.kura_model.TabStop = true;
            this.kura_model.Text = "Kuramoto Model";
            this.kura_model.UseVisualStyleBackColor = true;
            this.kura_model.CheckedChanged += new System.EventHandler(this.kura_model_CheckedChanged);
            // 
            // parker_model
            // 
            this.parker_model.AutoSize = true;
            this.parker_model.ForeColor = System.Drawing.Color.Gray;
            this.parker_model.Location = new System.Drawing.Point(13, 226);
            this.parker_model.Name = "parker_model";
            this.parker_model.Size = new System.Drawing.Size(151, 19);
            this.parker_model.TabIndex = 15;
            this.parker_model.Text = "Parker Kuramoto Model";
            this.parker_model.UseVisualStyleBackColor = true;
            this.parker_model.CheckedChanged += new System.EventHandler(this.parker_model_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1521, 687);
            this.Controls.Add(this.parker_model);
            this.Controls.Add(this.kura_model);
            this.Controls.Add(this.kNum);
            this.Controls.Add(this.kSlide);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.waveCNum);
            this.Controls.Add(this.waveBNum);
            this.Controls.Add(this.waveANum);
            this.Controls.Add(this.waveC);
            this.Controls.Add(this.waveB);
            this.Controls.Add(this.waveA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formsPlot1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kuramoto Model";
            ((System.ComponentModel.ISupportInitialize)(this.waveA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveANum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveBNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveCNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar waveA;
        private System.Windows.Forms.TrackBar waveB;
        private System.Windows.Forms.TrackBar waveC;
        private System.Windows.Forms.NumericUpDown waveANum;
        private System.Windows.Forms.NumericUpDown waveBNum;
        private System.Windows.Forms.NumericUpDown waveCNum;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar kSlide;
        private System.Windows.Forms.NumericUpDown kNum;
        private System.Windows.Forms.RadioButton kura_model;
        private System.Windows.Forms.RadioButton parker_model;
    }
}

