namespace MakineDinamigiOdev
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
            this.screen = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.calculateAngelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.engineAngle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.R1_L = new System.Windows.Forms.TextBox();
            this.R1_Q = new System.Windows.Forms.TextBox();
            this.R2_L = new System.Windows.Forms.TextBox();
            this.R2_Q = new System.Windows.Forms.TextBox();
            this.R3_L = new System.Windows.Forms.TextBox();
            this.R3_Q = new System.Windows.Forms.TextBox();
            this.R4_L = new System.Windows.Forms.TextBox();
            this.R4_Q = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.A_X = new System.Windows.Forms.TextBox();
            this.A_Y = new System.Windows.Forms.TextBox();
            this.B_X = new System.Windows.Forms.TextBox();
            this.B_Y = new System.Windows.Forms.TextBox();
            this.C_X = new System.Windows.Forms.TextBox();
            this.C_Y = new System.Windows.Forms.TextBox();
            this.D_Y = new System.Windows.Forms.TextBox();
            this.D_X = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.screen.Location = new System.Drawing.Point(12, 12);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(666, 452);
            this.screen.TabIndex = 0;
            this.screen.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startButton.Location = new System.Drawing.Point(684, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(174, 68);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Çalıştır";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Red;
            this.stopButton.Location = new System.Drawing.Point(684, 86);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(174, 68);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Durdur";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // calculateAngelButton
            // 
            this.calculateAngelButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calculateAngelButton.Location = new System.Drawing.Point(684, 160);
            this.calculateAngelButton.Name = "calculateAngelButton";
            this.calculateAngelButton.Size = new System.Drawing.Size(174, 68);
            this.calculateAngelButton.TabIndex = 3;
            this.calculateAngelButton.Text = "Belli Bir Açıda Çalıştır";
            this.calculateAngelButton.UseVisualStyleBackColor = false;
            this.calculateAngelButton.Click += new System.EventHandler(this.calculateAngelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(684, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Motor Açısı";
            // 
            // engineAngle
            // 
            this.engineAngle.Location = new System.Drawing.Point(758, 247);
            this.engineAngle.Name = "engineAngle";
            this.engineAngle.Size = new System.Drawing.Size(100, 23);
            this.engineAngle.TabIndex = 5;
            this.engineAngle.Text = "60";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(724, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "L";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Q";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "R1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "R2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "R3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "R4";
            // 
            // R1_L
            // 
            this.R1_L.Location = new System.Drawing.Point(34, 48);
            this.R1_L.Name = "R1_L";
            this.R1_L.Size = new System.Drawing.Size(60, 23);
            this.R1_L.TabIndex = 13;
            // 
            // R1_Q
            // 
            this.R1_Q.Location = new System.Drawing.Point(100, 48);
            this.R1_Q.Name = "R1_Q";
            this.R1_Q.Size = new System.Drawing.Size(60, 23);
            this.R1_Q.TabIndex = 14;
            // 
            // R2_L
            // 
            this.R2_L.Location = new System.Drawing.Point(34, 77);
            this.R2_L.Name = "R2_L";
            this.R2_L.Size = new System.Drawing.Size(60, 23);
            this.R2_L.TabIndex = 15;
            // 
            // R2_Q
            // 
            this.R2_Q.Location = new System.Drawing.Point(100, 77);
            this.R2_Q.Name = "R2_Q";
            this.R2_Q.Size = new System.Drawing.Size(60, 23);
            this.R2_Q.TabIndex = 16;
            // 
            // R3_L
            // 
            this.R3_L.Location = new System.Drawing.Point(34, 106);
            this.R3_L.Name = "R3_L";
            this.R3_L.Size = new System.Drawing.Size(60, 23);
            this.R3_L.TabIndex = 17;
            // 
            // R3_Q
            // 
            this.R3_Q.Location = new System.Drawing.Point(100, 106);
            this.R3_Q.Name = "R3_Q";
            this.R3_Q.Size = new System.Drawing.Size(60, 23);
            this.R3_Q.TabIndex = 18;
            // 
            // R4_L
            // 
            this.R4_L.Location = new System.Drawing.Point(34, 135);
            this.R4_L.Name = "R4_L";
            this.R4_L.Size = new System.Drawing.Size(60, 23);
            this.R4_L.TabIndex = 19;
            // 
            // R4_Q
            // 
            this.R4_Q.Location = new System.Drawing.Point(100, 135);
            this.R4_Q.Name = "R4_Q";
            this.R4_Q.Size = new System.Drawing.Size(60, 23);
            this.R4_Q.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(684, 481);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Mafsal Konum Tablosu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(729, 512);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "X";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(802, 512);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(684, 542);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "A";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(684, 571);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 15);
            this.label13.TabIndex = 25;
            this.label13.Text = "B";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(684, 600);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 15);
            this.label14.TabIndex = 26;
            this.label14.Text = "C";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(684, 629);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 15);
            this.label15.TabIndex = 27;
            this.label15.Text = "D";
            // 
            // A_X
            // 
            this.A_X.Location = new System.Drawing.Point(710, 539);
            this.A_X.Name = "A_X";
            this.A_X.Size = new System.Drawing.Size(60, 23);
            this.A_X.TabIndex = 28;
            // 
            // A_Y
            // 
            this.A_Y.Location = new System.Drawing.Point(776, 539);
            this.A_Y.Name = "A_Y";
            this.A_Y.Size = new System.Drawing.Size(60, 23);
            this.A_Y.TabIndex = 29;
            // 
            // B_X
            // 
            this.B_X.Location = new System.Drawing.Point(710, 568);
            this.B_X.Name = "B_X";
            this.B_X.Size = new System.Drawing.Size(60, 23);
            this.B_X.TabIndex = 30;
            // 
            // B_Y
            // 
            this.B_Y.Location = new System.Drawing.Point(776, 568);
            this.B_Y.Name = "B_Y";
            this.B_Y.Size = new System.Drawing.Size(60, 23);
            this.B_Y.TabIndex = 31;
            // 
            // C_X
            // 
            this.C_X.Location = new System.Drawing.Point(710, 597);
            this.C_X.Name = "C_X";
            this.C_X.Size = new System.Drawing.Size(60, 23);
            this.C_X.TabIndex = 32;
            // 
            // C_Y
            // 
            this.C_Y.Location = new System.Drawing.Point(776, 597);
            this.C_Y.Name = "C_Y";
            this.C_Y.Size = new System.Drawing.Size(60, 23);
            this.C_Y.TabIndex = 33;
            // 
            // D_Y
            // 
            this.D_Y.Location = new System.Drawing.Point(776, 626);
            this.D_Y.Name = "D_Y";
            this.D_Y.Size = new System.Drawing.Size(60, 23);
            this.D_Y.TabIndex = 34;
            // 
            // D_X
            // 
            this.D_X.Location = new System.Drawing.Point(710, 626);
            this.D_X.Name = "D_X";
            this.D_X.Size = new System.Drawing.Size(60, 23);
            this.D_X.TabIndex = 35;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.R1_L);
            this.groupBox1.Controls.Add(this.R1_Q);
            this.groupBox1.Controls.Add(this.R2_L);
            this.groupBox1.Controls.Add(this.R2_Q);
            this.groupBox1.Controls.Add(this.R3_L);
            this.groupBox1.Controls.Add(this.R3_Q);
            this.groupBox1.Controls.Add(this.R4_L);
            this.groupBox1.Controls.Add(this.R4_Q);
            this.groupBox1.Location = new System.Drawing.Point(684, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 188);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vektörel Konum Tablosu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 685);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.D_X);
            this.Controls.Add(this.D_Y);
            this.Controls.Add(this.C_Y);
            this.Controls.Add(this.C_X);
            this.Controls.Add(this.B_Y);
            this.Controls.Add(this.B_X);
            this.Controls.Add(this.A_Y);
            this.Controls.Add(this.A_X);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.engineAngle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateAngelButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.screen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.screen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox screen;
        private Button startButton;
        private Button stopButton;
        private Button calculateAngelButton;
        private Label label1;
        private TextBox engineAngle;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox R1_L;
        private TextBox R1_Q;
        private TextBox R2_L;
        private TextBox R2_Q;
        private TextBox R3_L;
        private TextBox R3_Q;
        private TextBox R4_L;
        private TextBox R4_Q;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox A_X;
        private TextBox A_Y;
        private TextBox B_X;
        private TextBox B_Y;
        private TextBox C_X;
        private TextBox C_Y;
        private TextBox D_Y;
        private TextBox D_X;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox1;
    }
}