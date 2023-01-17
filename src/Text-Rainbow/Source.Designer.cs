namespace Text_Rainbow
{
    partial class Source
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.HTMLCodeTextBox = new System.Windows.Forms.TextBox();
            this.numericUpDownBlue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.HTMLCodeLabel = new System.Windows.Forms.Label();
            this.ColorTimer = new System.Windows.Forms.Timer(this.components);
            this.ColorSet = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.Location = new System.Drawing.Point(726, 346);
            this.numericUpDownGreen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.Size = new System.Drawing.Size(60, 25);
            this.numericUpDownGreen.TabIndex = 25;
            this.numericUpDownGreen.Visible = false;
            this.numericUpDownGreen.ValueChanged += new System.EventHandler(this.numericUpDownGreen_ValueChanged);
            // 
            // HTMLCodeTextBox
            // 
            this.HTMLCodeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.HTMLCodeTextBox.Location = new System.Drawing.Point(726, 412);
            this.HTMLCodeTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.HTMLCodeTextBox.Name = "HTMLCodeTextBox";
            this.HTMLCodeTextBox.Size = new System.Drawing.Size(60, 25);
            this.HTMLCodeTextBox.TabIndex = 27;
            this.HTMLCodeTextBox.Visible = false;
            this.HTMLCodeTextBox.TextChanged += new System.EventHandler(this.HTMLCodeTextBox_TextChanged);
            // 
            // numericUpDownBlue
            // 
            this.numericUpDownBlue.Location = new System.Drawing.Point(726, 379);
            this.numericUpDownBlue.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numericUpDownBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlue.Name = "numericUpDownBlue";
            this.numericUpDownBlue.Size = new System.Drawing.Size(60, 25);
            this.numericUpDownBlue.TabIndex = 26;
            this.numericUpDownBlue.Visible = false;
            this.numericUpDownBlue.ValueChanged += new System.EventHandler(this.numericUpDownBlue_ValueChanged);
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.Location = new System.Drawing.Point(726, 313);
            this.numericUpDownRed.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.Size = new System.Drawing.Size(60, 25);
            this.numericUpDownRed.TabIndex = 24;
            this.numericUpDownRed.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.Visible = false;
            this.numericUpDownRed.ValueChanged += new System.EventHandler(this.numericUpDownRed_ValueChanged);
            // 
            // HTMLCodeLabel
            // 
            this.HTMLCodeLabel.AutoSize = true;
            this.HTMLCodeLabel.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HTMLCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HTMLCodeLabel.Location = new System.Drawing.Point(171, 132);
            this.HTMLCodeLabel.Name = "HTMLCodeLabel";
            this.HTMLCodeLabel.Size = new System.Drawing.Size(221, 46);
            this.HTMLCodeLabel.TabIndex = 23;
            this.HTMLCodeLabel.Text = "#000000";
            this.HTMLCodeLabel.Click += new System.EventHandler(this.HTMLCodeLabel_Click);
            // 
            // ColorTimer
            // 
            this.ColorTimer.Enabled = true;
            this.ColorTimer.Interval = 1;
            this.ColorTimer.Tick += new System.EventHandler(this.ColorTimer_Tick);
            // 
            // ColorSet
            // 
            this.ColorSet.Enabled = true;
            this.ColorSet.Interval = 1;
            this.ColorSet.Tick += new System.EventHandler(this.ColorSet_Tick);
            // 
            // Source
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(561, 328);
            this.Controls.Add(this.numericUpDownGreen);
            this.Controls.Add(this.HTMLCodeTextBox);
            this.Controls.Add(this.numericUpDownBlue);
            this.Controls.Add(this.numericUpDownRed);
            this.Controls.Add(this.HTMLCodeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Source";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Rainbow   |   Pop-Apple";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownGreen;
        private System.Windows.Forms.TextBox HTMLCodeTextBox;
        private System.Windows.Forms.NumericUpDown numericUpDownBlue;
        private System.Windows.Forms.NumericUpDown numericUpDownRed;
        private System.Windows.Forms.Label HTMLCodeLabel;
        private System.Windows.Forms.Timer ColorTimer;
        private System.Windows.Forms.Timer ColorSet;
    }
}

