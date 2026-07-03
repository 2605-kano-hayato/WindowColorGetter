namespace WindowColorGetter
{
    partial class FrmWindowColorGetter
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartGetColorMode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxRGB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "「色取得開始」ボタン押下で、画面上を左クリックして色を取得するモードになります";
            // 
            // btnStartGetColorMode
            // 
            this.btnStartGetColorMode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStartGetColorMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGetColorMode.Font = new System.Drawing.Font("ＭＳ ゴシック", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnStartGetColorMode.Location = new System.Drawing.Point(25, 125);
            this.btnStartGetColorMode.Name = "btnStartGetColorMode";
            this.btnStartGetColorMode.Size = new System.Drawing.Size(100, 50);
            this.btnStartGetColorMode.TabIndex = 1;
            this.btnStartGetColorMode.TabStop = false;
            this.btnStartGetColorMode.Text = "色取得開始";
            this.btnStartGetColorMode.UseVisualStyleBackColor = false;
            this.btnStartGetColorMode.Click += new System.EventHandler(this.btnStartGetColorMode_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(25, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "R, B, G";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtboxRGB
            // 
            this.txtboxRGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxRGB.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtboxRGB.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtboxRGB.Location = new System.Drawing.Point(106, 272);
            this.txtboxRGB.Name = "txtboxRGB";
            this.txtboxRGB.ReadOnly = true;
            this.txtboxRGB.Size = new System.Drawing.Size(100, 26);
            this.txtboxRGB.TabIndex = 3;
            this.txtboxRGB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmWindowColorGetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.txtboxRGB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStartGetColorMode);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(525, 375);
            this.Name = "FrmWindowColorGetter";
            this.Text = "画面色取得";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartGetColorMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxRGB;
    }
}

