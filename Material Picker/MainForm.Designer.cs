namespace Material_Picker
{
    partial class MainForm
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
            this.split = new System.Windows.Forms.SplitContainer();
            this.box = new System.Windows.Forms.PictureBox();
            this.colorPickButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.colorPreview = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.R = new System.Windows.Forms.NumericUpDown();
            this.RGBGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.V = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.H = new System.Windows.Forms.NumericUpDown();
            this.isNot = new System.Windows.Forms.CheckBox();
            this.overwrite = new System.Windows.Forms.Button();
            this.backColorPreview = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R)).BeginInit();
            this.RGBGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.V)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H)).BeginInit();
            this.SuspendLayout();
            // 
            // split
            // 
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.split.Location = new System.Drawing.Point(0, 0);
            this.split.Name = "split";
            // 
            // split.Panel1
            // 
            this.split.Panel1.Controls.Add(this.panel1);
            // 
            // split.Panel2
            // 
            this.split.Panel2.Controls.Add(this.box);
            this.split.Size = new System.Drawing.Size(800, 551);
            this.split.SplitterDistance = 187;
            this.split.TabIndex = 0;
            // 
            // box
            // 
            this.box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box.Location = new System.Drawing.Point(0, 0);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(609, 551);
            this.box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box.TabIndex = 0;
            this.box.TabStop = false;
            this.box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.box_MouseClick);
            // 
            // colorPickButton
            // 
            this.colorPickButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPickButton.Location = new System.Drawing.Point(13, 12);
            this.colorPickButton.Name = "colorPickButton";
            this.colorPickButton.Size = new System.Drawing.Size(159, 23);
            this.colorPickButton.TabIndex = 0;
            this.colorPickButton.Text = "Color Picker";
            this.colorPickButton.UseVisualStyleBackColor = true;
            this.colorPickButton.Click += new System.EventHandler(this.colorPickButton_Click);
            // 
            // colorPreview
            // 
            this.colorPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPreview.Location = new System.Drawing.Point(13, 41);
            this.colorPreview.Name = "colorPreview";
            this.colorPreview.Size = new System.Drawing.Size(159, 84);
            this.colorPreview.TabIndex = 1;
            this.colorPreview.UseVisualStyleBackColor = true;
            this.colorPreview.BackColorChanged += new System.EventHandler(this.ValueChanged);
            this.colorPreview.Click += new System.EventHandler(this.colorPreview_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.backColorPreview);
            this.panel1.Controls.Add(this.overwrite);
            this.panel1.Controls.Add(this.isNot);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.RGBGroup);
            this.panel1.Controls.Add(this.colorPreview);
            this.panel1.Controls.Add(this.colorPickButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel1.Size = new System.Drawing.Size(187, 551);
            this.panel1.TabIndex = 3;
            // 
            // R
            // 
            this.R.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.R.Location = new System.Drawing.Point(25, 18);
            this.R.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(115, 19);
            this.R.TabIndex = 2;
            this.R.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.R.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // RGBGroup
            // 
            this.RGBGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RGBGroup.Controls.Add(this.label3);
            this.RGBGroup.Controls.Add(this.B);
            this.RGBGroup.Controls.Add(this.label2);
            this.RGBGroup.Controls.Add(this.G);
            this.RGBGroup.Controls.Add(this.label1);
            this.RGBGroup.Controls.Add(this.R);
            this.RGBGroup.Location = new System.Drawing.Point(13, 131);
            this.RGBGroup.Name = "RGBGroup";
            this.RGBGroup.Size = new System.Drawing.Size(159, 104);
            this.RGBGroup.TabIndex = 3;
            this.RGBGroup.TabStop = false;
            this.RGBGroup.Text = "RGB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "G";
            // 
            // G
            // 
            this.G.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.G.Location = new System.Drawing.Point(25, 43);
            this.G.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(115, 19);
            this.G.TabIndex = 4;
            this.G.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.G.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "B";
            // 
            // B
            // 
            this.B.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B.Location = new System.Drawing.Point(25, 68);
            this.B.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(115, 19);
            this.B.TabIndex = 6;
            this.B.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.B.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.V);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.S);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.H);
            this.groupBox1.Location = new System.Drawing.Point(13, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 104);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HSV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "V";
            // 
            // V
            // 
            this.V.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.V.Location = new System.Drawing.Point(25, 68);
            this.V.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(115, 19);
            this.V.TabIndex = 6;
            this.V.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.V.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "S";
            // 
            // S
            // 
            this.S.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.S.Location = new System.Drawing.Point(25, 43);
            this.S.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(115, 19);
            this.S.TabIndex = 4;
            this.S.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.S.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "H";
            // 
            // H
            // 
            this.H.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.H.Location = new System.Drawing.Point(25, 18);
            this.H.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(115, 19);
            this.H.TabIndex = 2;
            this.H.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.H.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // isNot
            // 
            this.isNot.AutoSize = true;
            this.isNot.Location = new System.Drawing.Point(11, 351);
            this.isNot.Name = "isNot";
            this.isNot.Size = new System.Drawing.Size(47, 16);
            this.isNot.TabIndex = 5;
            this.isNot.Text = "NOT";
            this.isNot.UseVisualStyleBackColor = true;
            this.isNot.CheckedChanged += new System.EventHandler(this.ValueChanged);
            // 
            // overwrite
            // 
            this.overwrite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.overwrite.Location = new System.Drawing.Point(13, 373);
            this.overwrite.Name = "overwrite";
            this.overwrite.Size = new System.Drawing.Size(159, 23);
            this.overwrite.TabIndex = 6;
            this.overwrite.Text = "Picture Overwrite";
            this.overwrite.UseVisualStyleBackColor = true;
            this.overwrite.Click += new System.EventHandler(this.overwrite_Click);
            // 
            // backColorPreview
            // 
            this.backColorPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backColorPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backColorPreview.Location = new System.Drawing.Point(13, 402);
            this.backColorPreview.Name = "backColorPreview";
            this.backColorPreview.Size = new System.Drawing.Size(159, 84);
            this.backColorPreview.TabIndex = 7;
            this.backColorPreview.UseVisualStyleBackColor = true;
            this.backColorPreview.BackColorChanged += new System.EventHandler(this.ValueChanged);
            this.backColorPreview.Click += new System.EventHandler(this.backColorPreview_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(13, 492);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(159, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.split);
            this.Name = "MainForm";
            this.Text = "Material Picker";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R)).EndInit();
            this.RGBGroup.ResumeLayout(false);
            this.RGBGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.V)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer split;
        private System.Windows.Forms.Button colorPickButton;
        private System.Windows.Forms.PictureBox box;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button colorPreview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox RGBGroup;
        private System.Windows.Forms.NumericUpDown R;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown G;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown V;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown S;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown H;
        private System.Windows.Forms.CheckBox isNot;
        private System.Windows.Forms.Button overwrite;
        private System.Windows.Forms.Button backColorPreview;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

