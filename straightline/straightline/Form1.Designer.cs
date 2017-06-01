namespace straightline
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clbExpression = new System.Windows.Forms.CheckedListBox();
            this.StraightLinehand = new System.Windows.Forms.Button();
            this.btnCoordinatehand = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHandenter = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHandy = new System.Windows.Forms.TextBox();
            this.tbHandx = new System.Windows.Forms.TextBox();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRandom = new System.Windows.Forms.TextBox();
            this.cbHandbook = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(13, 17);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(400, 400);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBroad_Paint);
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelClick_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 11);
            this.label2.TabIndex = 1;
            this.label2.Text = "大間隔:10單位";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 11);
            this.label1.TabIndex = 0;
            this.label1.Text = "小間隔:5單位";
            // 
            // clbExpression
            // 
            this.clbExpression.CheckOnClick = true;
            this.clbExpression.FormattingEnabled = true;
            this.clbExpression.Location = new System.Drawing.Point(2, 42);
            this.clbExpression.Name = "clbExpression";
            this.clbExpression.Size = new System.Drawing.Size(170, 174);
            this.clbExpression.TabIndex = 1;
            // 
            // StraightLinehand
            // 
            this.StraightLinehand.Location = new System.Drawing.Point(16, 21);
            this.StraightLinehand.Name = "StraightLinehand";
            this.StraightLinehand.Size = new System.Drawing.Size(62, 34);
            this.StraightLinehand.TabIndex = 2;
            this.StraightLinehand.Text = "直線計算";
            this.StraightLinehand.UseVisualStyleBackColor = true;
            this.StraightLinehand.Click += new System.EventHandler(this.btnStraightLine_Click);
            // 
            // btnCoordinatehand
            // 
            this.btnCoordinatehand.Location = new System.Drawing.Point(16, 67);
            this.btnCoordinatehand.Name = "btnCoordinatehand";
            this.btnCoordinatehand.Size = new System.Drawing.Size(62, 34);
            this.btnCoordinatehand.TabIndex = 4;
            this.btnCoordinatehand.Text = "極座標";
            this.btnCoordinatehand.UseVisualStyleBackColor = true;
            this.btnCoordinatehand.Click += new System.EventHandler(this.btnCoordinate_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(2, 238);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(170, 160);
            this.listBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.clbExpression);
            this.groupBox1.Controls.Add(this.listBox);
            this.groupBox1.Location = new System.Drawing.Point(419, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 404);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "輸出顯示";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "各項數據";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "座標顯示";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHandenter);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbHandy);
            this.groupBox2.Controls.Add(this.tbHandx);
            this.groupBox2.Location = new System.Drawing.Point(606, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 96);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "手動輸入";
            // 
            // btnHandenter
            // 
            this.btnHandenter.Location = new System.Drawing.Point(102, 33);
            this.btnHandenter.Name = "btnHandenter";
            this.btnHandenter.Size = new System.Drawing.Size(52, 40);
            this.btnHandenter.TabIndex = 7;
            this.btnHandenter.Text = "輸入";
            this.btnHandenter.UseVisualStyleBackColor = true;
            this.btnHandenter.Click += new System.EventHandler(this.btnHandenter_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "Y座標";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "X座標";
            // 
            // tbHandy
            // 
            this.tbHandy.Location = new System.Drawing.Point(7, 62);
            this.tbHandy.Name = "tbHandy";
            this.tbHandy.Size = new System.Drawing.Size(36, 22);
            this.tbHandy.TabIndex = 1;
            this.tbHandy.Text = "0";
            // 
            // tbHandx
            // 
            this.tbHandx.Location = new System.Drawing.Point(7, 22);
            this.tbHandx.Name = "tbHandx";
            this.tbHandx.Size = new System.Drawing.Size(36, 22);
            this.tbHandx.TabIndex = 0;
            this.tbHandx.Text = "0";
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(92, 21);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(62, 34);
            this.btnStatistics.TabIndex = 9;
            this.btnStatistics.Text = "迴歸演算";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(92, 67);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 34);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRandom);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbRandom);
            this.groupBox3.Location = new System.Drawing.Point(606, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 70);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "自動輸入";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(102, 14);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(52, 41);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "產生";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "座標數";
            // 
            // tbRandom
            // 
            this.tbRandom.Location = new System.Drawing.Point(9, 25);
            this.tbRandom.Name = "tbRandom";
            this.tbRandom.Size = new System.Drawing.Size(36, 22);
            this.tbRandom.TabIndex = 0;
            this.tbRandom.Text = "0";
            // 
            // cbHandbook
            // 
            this.cbHandbook.FormattingEnabled = true;
            this.cbHandbook.Items.AddRange(new object[] {
            "座標點輸入說明",
            "直線計算說明",
            "極座標轉換說明",
            "迴歸分析說明"});
            this.cbHandbook.Location = new System.Drawing.Point(606, 349);
            this.cbHandbook.Name = "cbHandbook";
            this.cbHandbook.Size = new System.Drawing.Size(171, 20);
            this.cbHandbook.TabIndex = 8;
            this.cbHandbook.Text = "座標點輸入說明";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(611, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "使用說明";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.btnStatistics);
            this.groupBox4.Controls.Add(this.btnCoordinatehand);
            this.groupBox4.Controls.Add(this.StraightLinehand);
            this.groupBox4.Location = new System.Drawing.Point(606, 211);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 107);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "計算顯示";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(708, 380);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(71, 37);
            this.btnView.TabIndex = 11;
            this.btnView.Text = "選擇觀看";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 429);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbHandbook);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.CheckedListBox clbExpression;
        private System.Windows.Forms.Button StraightLinehand;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCoordinatehand;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHandenter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHandy;
        private System.Windows.Forms.TextBox tbHandx;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRandom;
        private System.Windows.Forms.ComboBox cbHandbook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnView;
    }
}

