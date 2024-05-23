namespace Lab_15
{
    partial class fMain
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbX1min = new TextBox();
            tbX2min = new TextBox();
            tbX1max = new TextBox();
            tbX2max = new TextBox();
            tbDx1 = new TextBox();
            tbDx2 = new TextBox();
            gv = new DataGridView();
            bCalc = new Button();
            bClear = new Button();
            bExit = new Button();
            ((System.ComponentModel.ISupportInitialize)gv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 39);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "X1 min";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 95);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "X2 min";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 39);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "X1 max";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 95);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "X2 max";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(423, 39);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 4;
            label5.Text = "dx 1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(423, 95);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 5;
            label6.Text = "dx 2";
            // 
            // tbX1min
            // 
            tbX1min.Location = new Point(104, 36);
            tbX1min.Name = "tbX1min";
            tbX1min.Size = new Size(79, 23);
            tbX1min.TabIndex = 6;
            // 
            // tbX2min
            // 
            tbX2min.Location = new Point(104, 92);
            tbX2min.Name = "tbX2min";
            tbX2min.Size = new Size(79, 23);
            tbX2min.TabIndex = 7;
            // 
            // tbX1max
            // 
            tbX1max.Location = new Point(296, 36);
            tbX1max.Name = "tbX1max";
            tbX1max.Size = new Size(82, 23);
            tbX1max.TabIndex = 8;
            // 
            // tbX2max
            // 
            tbX2max.Location = new Point(296, 92);
            tbX2max.Name = "tbX2max";
            tbX2max.Size = new Size(82, 23);
            tbX2max.TabIndex = 9;
            // 
            // tbDx1
            // 
            tbDx1.Location = new Point(470, 36);
            tbDx1.Name = "tbDx1";
            tbDx1.Size = new Size(93, 23);
            tbDx1.TabIndex = 10;
            // 
            // tbDx2
            // 
            tbDx2.Location = new Point(470, 92);
            tbDx2.Name = "tbDx2";
            tbDx2.Size = new Size(93, 23);
            tbDx2.TabIndex = 11;
            // 
            // gv
            // 
            gv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv.Location = new Point(47, 142);
            gv.Name = "gv";
            gv.Size = new Size(519, 273);
            gv.TabIndex = 12;
            // 
            // bCalc
            // 
            bCalc.Location = new Point(609, 142);
            bCalc.Name = "bCalc";
            bCalc.Size = new Size(103, 31);
            bCalc.TabIndex = 13;
            bCalc.Text = "Calculate";
            bCalc.UseVisualStyleBackColor = true;
            bCalc.Click += bCalc_Click;
            // 
            // bClear
            // 
            bClear.Location = new Point(609, 179);
            bClear.Name = "bClear";
            bClear.Size = new Size(103, 26);
            bClear.TabIndex = 14;
            bClear.Text = "Clear";
            bClear.UseVisualStyleBackColor = true;
            bClear.Click += bClear_Click;
            // 
            // bExit
            // 
            bExit.Location = new Point(609, 389);
            bExit.Name = "bExit";
            bExit.Size = new Size(103, 26);
            bExit.TabIndex = 15;
            bExit.Text = "Exit";
            bExit.UseVisualStyleBackColor = true;
            bExit.Click += bExit_Click;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 450);
            Controls.Add(bExit);
            Controls.Add(bClear);
            Controls.Add(bCalc);
            Controls.Add(gv);
            Controls.Add(tbDx2);
            Controls.Add(tbDx1);
            Controls.Add(tbX2max);
            Controls.Add(tbX1max);
            Controls.Add(tbX2min);
            Controls.Add(tbX1min);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab 15";
            ((System.ComponentModel.ISupportInitialize)gv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbX1min;
        private TextBox tbX2min;
        private TextBox tbX1max;
        private TextBox tbX2max;
        private TextBox tbDx1;
        private TextBox tbDx2;
        private DataGridView gv;
        private Button bCalc;
        private Button bClear;
        private Button bExit;
    }
}
