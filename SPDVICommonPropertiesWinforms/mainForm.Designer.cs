namespace SPDVICommonPropertiesWinforms
{
    partial class mainForm
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
            this.targetButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.CenterButton = new System.Windows.Forms.Button();
            this.enabledButton = new System.Windows.Forms.Button();
            this.visibleButton = new System.Windows.Forms.Button();
            this.formBorderStyleLabel = new System.Windows.Forms.Label();
            this.comboBoxBorderStyle = new System.Windows.Forms.ComboBox();
            this.formSizeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetButton
            // 
            this.targetButton.Location = new System.Drawing.Point(0, 0);
            this.targetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.targetButton.Name = "targetButton";
            this.targetButton.Size = new System.Drawing.Size(100, 100);
            this.targetButton.TabIndex = 0;
            this.targetButton.TabStop = false;
            this.targetButton.Text = "    Target           X = 0       Y = 0";
            this.targetButton.UseVisualStyleBackColor = true;
            this.targetButton.LocationChanged += new System.EventHandler(this.targetButton_LocationChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.botButton);
            this.groupBox1.Controls.Add(this.rightButton);
            this.groupBox1.Controls.Add(this.leftButton);
            this.groupBox1.Controls.Add(this.upButton);
            this.groupBox1.Controls.Add(this.CenterButton);
            this.groupBox1.Controls.Add(this.enabledButton);
            this.groupBox1.Controls.Add(this.visibleButton);
            this.groupBox1.Controls.Add(this.formBorderStyleLabel);
            this.groupBox1.Controls.Add(this.comboBoxBorderStyle);
            this.groupBox1.Location = new System.Drawing.Point(571, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(200, 500);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // botButton
            // 
            this.botButton.Location = new System.Drawing.Point(61, 421);
            this.botButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botButton.Name = "botButton";
            this.botButton.Size = new System.Drawing.Size(63, 28);
            this.botButton.TabIndex = 8;
            this.botButton.Text = "v";
            this.botButton.UseVisualStyleBackColor = true;
            this.botButton.Click += new System.EventHandler(this.botButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(115, 385);
            this.rightButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(63, 28);
            this.rightButton.TabIndex = 7;
            this.rightButton.Text = ">";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(16, 385);
            this.leftButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(63, 28);
            this.leftButton.TabIndex = 6;
            this.leftButton.Text = "<";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(61, 350);
            this.upButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(63, 28);
            this.upButton.TabIndex = 5;
            this.upButton.Text = "^";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // CenterButton
            // 
            this.CenterButton.Location = new System.Drawing.Point(16, 257);
            this.CenterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CenterButton.Name = "CenterButton";
            this.CenterButton.Size = new System.Drawing.Size(161, 28);
            this.CenterButton.TabIndex = 4;
            this.CenterButton.Text = "Center Target";
            this.CenterButton.UseVisualStyleBackColor = true;
            this.CenterButton.Click += new System.EventHandler(this.CenterButton_Click);
            // 
            // enabledButton
            // 
            this.enabledButton.Location = new System.Drawing.Point(16, 194);
            this.enabledButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enabledButton.Name = "enabledButton";
            this.enabledButton.Size = new System.Drawing.Size(161, 28);
            this.enabledButton.TabIndex = 3;
            this.enabledButton.Text = "Enabled = True";
            this.enabledButton.UseVisualStyleBackColor = true;
            this.enabledButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // visibleButton
            // 
            this.visibleButton.Location = new System.Drawing.Point(16, 128);
            this.visibleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.visibleButton.Name = "visibleButton";
            this.visibleButton.Size = new System.Drawing.Size(161, 28);
            this.visibleButton.TabIndex = 2;
            this.visibleButton.Text = "Visible = True";
            this.visibleButton.UseVisualStyleBackColor = true;
            this.visibleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // formBorderStyleLabel
            // 
            this.formBorderStyleLabel.AutoSize = true;
            this.formBorderStyleLabel.Location = new System.Drawing.Point(12, 39);
            this.formBorderStyleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formBorderStyleLabel.Name = "formBorderStyleLabel";
            this.formBorderStyleLabel.Size = new System.Drawing.Size(114, 17);
            this.formBorderStyleLabel.TabIndex = 4;
            this.formBorderStyleLabel.Text = "FormBorderStyle";
            // 
            // comboBoxBorderStyle
            // 
            this.comboBoxBorderStyle.FormattingEnabled = true;
            this.comboBoxBorderStyle.Items.AddRange(new object[] {
            "None",
            "FixedSingle",
            "Fixed3D",
            "FixedDialog",
            "Sizable",
            "FixedToolWindow",
            "SizableToolWindow"});
            this.comboBoxBorderStyle.Location = new System.Drawing.Point(16, 59);
            this.comboBoxBorderStyle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxBorderStyle.Name = "comboBoxBorderStyle";
            this.comboBoxBorderStyle.Size = new System.Drawing.Size(160, 24);
            this.comboBoxBorderStyle.TabIndex = 1;
            this.comboBoxBorderStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxBorderStyle_SelectedIndexChanged);
            // 
            // formSizeLabel
            // 
            this.formSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.formSizeLabel.AutoSize = true;
            this.formSizeLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.formSizeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formSizeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.formSizeLabel.Location = new System.Drawing.Point(20, 530);
            this.formSizeLabel.Name = "formSizeLabel";
            this.formSizeLabel.Size = new System.Drawing.Size(81, 19);
            this.formSizeLabel.TabIndex = 2;
            this.formSizeLabel.Text = "Form Size: ";
            this.formSizeLabel.Click += new System.EventHandler(this.formSizeLabel_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 553);
            this.Controls.Add(this.formSizeLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.targetButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainForm";
            this.Text = "(0, 0) Winforms Components - Common Controls";
            this.MaximumSizeChanged += new System.EventHandler(this.mainForm_MaximumSizeChanged);
            this.MinimumSizeChanged += new System.EventHandler(this.mainForm_MinimumSizeChanged);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LocationChanged += new System.EventHandler(this.mainForm_LocationChanged);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button targetButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label formSizeLabel;
        private System.Windows.Forms.Button botButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button CenterButton;
        private System.Windows.Forms.Button enabledButton;
        private System.Windows.Forms.Button visibleButton;
        private System.Windows.Forms.Label formBorderStyleLabel;
        private System.Windows.Forms.ComboBox comboBoxBorderStyle;
    }
}

