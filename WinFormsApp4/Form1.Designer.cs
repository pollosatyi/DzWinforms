﻿namespace WinFormsApp4
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
            components = new System.ComponentModel.Container();
            splitter1 = new Splitter();
            splitContainer1 = new SplitContainer();
            bStop = new Button();
            bStart = new Button();
            numDensity = new NumericUpDown();
            label2 = new Label();
            numResolution = new NumericUpDown();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDensity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numResolution).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Margin = new Padding(4, 5, 4, 5);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 1488);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(4, 0);
            splitContainer1.Margin = new Padding(4, 5, 4, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(bStop);
            splitContainer1.Panel1.Controls.Add(bStart);
            splitContainer1.Panel1.Controls.Add(numDensity);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(numResolution);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Size = new Size(2133, 1488);
            splitContainer1.SplitterDistance = 346;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 1;
            // 
            // bStop
            // 
            bStop.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            bStop.Location = new Point(24, 300);
            bStop.Margin = new Padding(4, 5, 4, 5);
            bStop.Name = "bStop";
            bStop.Size = new Size(170, 75);
            bStop.TabIndex = 5;
            bStop.Text = "Stop";
            bStop.UseVisualStyleBackColor = true;
            bStop.Click += bStop_Click;
            // 
            // bStart
            // 
            bStart.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            bStart.Location = new Point(23, 218);
            bStart.Margin = new Padding(4, 5, 4, 5);
            bStart.Name = "bStart";
            bStart.Size = new Size(171, 72);
            bStart.TabIndex = 4;
            bStart.Text = "Start";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;
            // 
            // numDensity
            // 
            numDensity.Location = new Point(23, 153);
            numDensity.Margin = new Padding(4, 5, 4, 5);
            numDensity.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numDensity.Name = "numDensity";
            numDensity.Size = new Size(171, 31);
            numDensity.TabIndex = 3;
            numDensity.TextAlign = HorizontalAlignment.Right;
            numDensity.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(23, 123);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 2;
            label2.Text = "Density";
            // 
            // numResolution
            // 
            numResolution.Location = new Point(23, 58);
            numResolution.Margin = new Padding(4, 5, 4, 5);
            numResolution.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numResolution.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numResolution.Name = "numResolution";
            numResolution.Size = new Size(171, 31);
            numResolution.TabIndex = 1;
            numResolution.TextAlign = HorizontalAlignment.Right;
            numResolution.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(23, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 28);
            label1.TabIndex = 0;
            label1.Text = "Resolution";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1777, 1484);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // timer1
            // 
            timer1.Interval = 40;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2137, 1488);
            Controls.Add(splitContainer1);
            Controls.Add(splitter1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numDensity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numResolution).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Splitter splitter1;
        private SplitContainer splitContainer1;
        private NumericUpDown numResolution;
        private Label label1;
        private PictureBox pictureBox1;
        private Button bStop;
        private Button bStart;
        private NumericUpDown numDensity;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}
