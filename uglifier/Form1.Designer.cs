namespace uglifier
{
    partial class Form1
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
            this.RightPanel = new System.Windows.Forms.Panel();
            this.DragDropLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RunBtn = new System.Windows.Forms.Button();
            this.IndentationGroup = new System.Windows.Forms.GroupBox();
            this.RandomIndentationOption = new System.Windows.Forms.RadioButton();
            this.NoIndentationOption = new System.Windows.Forms.RadioButton();
            this.LineNumberSpaceInvertedOption = new System.Windows.Forms.RadioButton();
            this.LineNumberSpaceOption = new System.Windows.Forms.RadioButton();
            this.CasingGroup = new System.Windows.Forms.GroupBox();
            this.AllLowerCaseOption = new System.Windows.Forms.RadioButton();
            this.RandomCaseOption = new System.Windows.Forms.RadioButton();
            this.InverseCaseOption = new System.Windows.Forms.RadioButton();
            this.UpperSnakeCaseOption = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.IndentationGroup.SuspendLayout();
            this.CasingGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightPanel
            // 
            this.RightPanel.AllowDrop = true;
            this.RightPanel.Controls.Add(this.DragDropLabel);
            this.RightPanel.Controls.Add(this.panel1);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(0, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(800, 450);
            this.RightPanel.TabIndex = 3;
            // 
            // DragDropLabel
            // 
            this.DragDropLabel.AllowDrop = true;
            this.DragDropLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DragDropLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DragDropLabel.Location = new System.Drawing.Point(400, 0);
            this.DragDropLabel.Name = "DragDropLabel";
            this.DragDropLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DragDropLabel.Size = new System.Drawing.Size(400, 450);
            this.DragDropLabel.TabIndex = 9;
            this.DragDropLabel.Text = "Drag C# file here";
            this.DragDropLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DragDropLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.label1_DragDrop);
            this.DragDropLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.label1_DragEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RunBtn);
            this.panel1.Controls.Add(this.IndentationGroup);
            this.panel1.Controls.Add(this.CasingGroup);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 450);
            this.panel1.TabIndex = 7;
            // 
            // RunBtn
            // 
            this.RunBtn.BackColor = System.Drawing.Color.Red;
            this.RunBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RunBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunBtn.ForeColor = System.Drawing.Color.White;
            this.RunBtn.Location = new System.Drawing.Point(84, 367);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(225, 39);
            this.RunBtn.TabIndex = 4;
            this.RunBtn.Text = "1 ticket to hell please";
            this.RunBtn.UseVisualStyleBackColor = false;
            this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // IndentationGroup
            // 
            this.IndentationGroup.Controls.Add(this.RandomIndentationOption);
            this.IndentationGroup.Controls.Add(this.NoIndentationOption);
            this.IndentationGroup.Controls.Add(this.LineNumberSpaceInvertedOption);
            this.IndentationGroup.Controls.Add(this.LineNumberSpaceOption);
            this.IndentationGroup.Location = new System.Drawing.Point(85, 226);
            this.IndentationGroup.Name = "IndentationGroup";
            this.IndentationGroup.Size = new System.Drawing.Size(224, 117);
            this.IndentationGroup.TabIndex = 3;
            this.IndentationGroup.TabStop = false;
            this.IndentationGroup.Text = "Indentation";
            // 
            // RandomIndentationOption
            // 
            this.RandomIndentationOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.RandomIndentationOption.Location = new System.Drawing.Point(3, 88);
            this.RandomIndentationOption.Name = "RandomIndentationOption";
            this.RandomIndentationOption.Size = new System.Drawing.Size(218, 24);
            this.RandomIndentationOption.TabIndex = 5;
            this.RandomIndentationOption.TabStop = true;
            this.RandomIndentationOption.Text = "Random indentation";
            this.RandomIndentationOption.UseVisualStyleBackColor = true;
            // 
            // NoIndentationOption
            // 
            this.NoIndentationOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.NoIndentationOption.Location = new System.Drawing.Point(3, 64);
            this.NoIndentationOption.Name = "NoIndentationOption";
            this.NoIndentationOption.Size = new System.Drawing.Size(218, 24);
            this.NoIndentationOption.TabIndex = 4;
            this.NoIndentationOption.TabStop = true;
            this.NoIndentationOption.Text = "No indentation";
            this.NoIndentationOption.UseVisualStyleBackColor = true;
            // 
            // LineNumberSpaceInvertedOption
            // 
            this.LineNumberSpaceInvertedOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.LineNumberSpaceInvertedOption.Location = new System.Drawing.Point(3, 40);
            this.LineNumberSpaceInvertedOption.Name = "LineNumberSpaceInvertedOption";
            this.LineNumberSpaceInvertedOption.Size = new System.Drawing.Size(218, 24);
            this.LineNumberSpaceInvertedOption.TabIndex = 3;
            this.LineNumberSpaceInvertedOption.TabStop = true;
            this.LineNumberSpaceInvertedOption.Text = "lineNumber amout of spaces inverted";
            this.LineNumberSpaceInvertedOption.UseVisualStyleBackColor = true;
            // 
            // LineNumberSpaceOption
            // 
            this.LineNumberSpaceOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.LineNumberSpaceOption.Location = new System.Drawing.Point(3, 16);
            this.LineNumberSpaceOption.Name = "LineNumberSpaceOption";
            this.LineNumberSpaceOption.Size = new System.Drawing.Size(218, 24);
            this.LineNumberSpaceOption.TabIndex = 2;
            this.LineNumberSpaceOption.TabStop = true;
            this.LineNumberSpaceOption.Text = "lineNumber amout of spaces";
            this.LineNumberSpaceOption.UseVisualStyleBackColor = true;
            // 
            // CasingGroup
            // 
            this.CasingGroup.Controls.Add(this.AllLowerCaseOption);
            this.CasingGroup.Controls.Add(this.RandomCaseOption);
            this.CasingGroup.Controls.Add(this.InverseCaseOption);
            this.CasingGroup.Controls.Add(this.UpperSnakeCaseOption);
            this.CasingGroup.Location = new System.Drawing.Point(84, 103);
            this.CasingGroup.Name = "CasingGroup";
            this.CasingGroup.Size = new System.Drawing.Size(187, 117);
            this.CasingGroup.TabIndex = 3;
            this.CasingGroup.TabStop = false;
            this.CasingGroup.Text = "Casing";
            this.CasingGroup.Visible = false;
            // 
            // AllLowerCaseOption
            // 
            this.AllLowerCaseOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.AllLowerCaseOption.Location = new System.Drawing.Point(3, 88);
            this.AllLowerCaseOption.Name = "AllLowerCaseOption";
            this.AllLowerCaseOption.Size = new System.Drawing.Size(181, 24);
            this.AllLowerCaseOption.TabIndex = 5;
            this.AllLowerCaseOption.TabStop = true;
            this.AllLowerCaseOption.Text = "alllowercase";
            this.AllLowerCaseOption.UseVisualStyleBackColor = true;
            // 
            // RandomCaseOption
            // 
            this.RandomCaseOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.RandomCaseOption.Location = new System.Drawing.Point(3, 64);
            this.RandomCaseOption.Name = "RandomCaseOption";
            this.RandomCaseOption.Size = new System.Drawing.Size(181, 24);
            this.RandomCaseOption.TabIndex = 4;
            this.RandomCaseOption.TabStop = true;
            this.RandomCaseOption.Text = "RaNDomCaSe";
            this.RandomCaseOption.UseVisualStyleBackColor = true;
            // 
            // InverseCaseOption
            // 
            this.InverseCaseOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.InverseCaseOption.Location = new System.Drawing.Point(3, 40);
            this.InverseCaseOption.Name = "InverseCaseOption";
            this.InverseCaseOption.Size = new System.Drawing.Size(181, 24);
            this.InverseCaseOption.TabIndex = 3;
            this.InverseCaseOption.TabStop = true;
            this.InverseCaseOption.Text = "iNVERSE cASE";
            this.InverseCaseOption.UseVisualStyleBackColor = true;
            // 
            // UpperSnakeCaseOption
            // 
            this.UpperSnakeCaseOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperSnakeCaseOption.Location = new System.Drawing.Point(3, 16);
            this.UpperSnakeCaseOption.Name = "UpperSnakeCaseOption";
            this.UpperSnakeCaseOption.Size = new System.Drawing.Size(181, 24);
            this.UpperSnakeCaseOption.TabIndex = 2;
            this.UpperSnakeCaseOption.TabStop = true;
            this.UpperSnakeCaseOption.Text = "UPPER_SNAKE";
            this.UpperSnakeCaseOption.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(85, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prefix";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RightPanel);
            this.Name = "Form1";
            this.Text = "Uglifier";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.RightPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.IndentationGroup.ResumeLayout(false);
            this.CasingGroup.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label DragDropLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.GroupBox IndentationGroup;
        private System.Windows.Forms.RadioButton RandomIndentationOption;
        private System.Windows.Forms.RadioButton NoIndentationOption;
        private System.Windows.Forms.RadioButton LineNumberSpaceInvertedOption;
        private System.Windows.Forms.RadioButton LineNumberSpaceOption;
        private System.Windows.Forms.GroupBox CasingGroup;
        private System.Windows.Forms.RadioButton AllLowerCaseOption;
        private System.Windows.Forms.RadioButton RandomCaseOption;
        private System.Windows.Forms.RadioButton InverseCaseOption;
        private System.Windows.Forms.RadioButton UpperSnakeCaseOption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel RightPanel;
        #endregion
    }
}