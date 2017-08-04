namespace CostCal
{
    partial class Frm_main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_main));
            this.Tx_year = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_save = new System.Windows.Forms.Button();
            this.Tb_InternalReturnRate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Tb_PresentValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Tb_ReturnRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Tb_payBackTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Tb_profits = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_WorkOut = new System.Windows.Forms.Button();
            this.Lb_showData = new System.Windows.Forms.Label();
            this.Btn_clean = new System.Windows.Forms.Button();
            this.Btn_years = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_set = new System.Windows.Forms.ToolStripMenuItem();
            this.Pl_set = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tx_PreRate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tx_year)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Pl_set.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tx_PreRate)).BeginInit();
            this.SuspendLayout();
            // 
            // Tx_year
            // 
            this.Tx_year.Location = new System.Drawing.Point(131, 61);
            this.Tx_year.Name = "Tx_year";
            this.Tx_year.Size = new System.Drawing.Size(51, 27);
            this.Tx_year.TabIndex = 0;
            this.Tx_year.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tx_year_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(29, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "项目周期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "年";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_save);
            this.groupBox1.Controls.Add(this.Tb_InternalReturnRate);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Tb_PresentValue);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Tb_ReturnRate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Tb_payBackTime);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Tb_profits);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(297, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 461);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "项目收益";
            // 
            // Btn_save
            // 
            this.Btn_save.Location = new System.Drawing.Point(90, 424);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(142, 29);
            this.Btn_save.TabIndex = 14;
            this.Btn_save.Text = "保存数据";
            this.Btn_save.UseVisualStyleBackColor = true;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // Tb_InternalReturnRate
            // 
            this.Tb_InternalReturnRate.Location = new System.Drawing.Point(151, 337);
            this.Tb_InternalReturnRate.Name = "Tb_InternalReturnRate";
            this.Tb_InternalReturnRate.ReadOnly = true;
            this.Tb_InternalReturnRate.Size = new System.Drawing.Size(150, 27);
            this.Tb_InternalReturnRate.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 342);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "内部回报率：";
            // 
            // Tb_PresentValue
            // 
            this.Tb_PresentValue.Location = new System.Drawing.Point(151, 262);
            this.Tb_PresentValue.Name = "Tb_PresentValue";
            this.Tb_PresentValue.ReadOnly = true;
            this.Tb_PresentValue.Size = new System.Drawing.Size(150, 27);
            this.Tb_PresentValue.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "净现值：";
            // 
            // Tb_ReturnRate
            // 
            this.Tb_ReturnRate.Location = new System.Drawing.Point(151, 189);
            this.Tb_ReturnRate.Name = "Tb_ReturnRate";
            this.Tb_ReturnRate.ReadOnly = true;
            this.Tb_ReturnRate.Size = new System.Drawing.Size(150, 27);
            this.Tb_ReturnRate.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "投资回报率：";
            // 
            // Tb_payBackTime
            // 
            this.Tb_payBackTime.Location = new System.Drawing.Point(151, 123);
            this.Tb_payBackTime.Name = "Tb_payBackTime";
            this.Tb_payBackTime.ReadOnly = true;
            this.Tb_payBackTime.Size = new System.Drawing.Size(150, 27);
            this.Tb_payBackTime.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "回收期(年)：";
            // 
            // Tb_profits
            // 
            this.Tb_profits.Location = new System.Drawing.Point(151, 61);
            this.Tb_profits.Name = "Tb_profits";
            this.Tb_profits.ReadOnly = true;
            this.Tb_profits.Size = new System.Drawing.Size(150, 27);
            this.Tb_profits.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "净利润(元)：";
            // 
            // Btn_WorkOut
            // 
            this.Btn_WorkOut.Location = new System.Drawing.Point(210, 459);
            this.Btn_WorkOut.Name = "Btn_WorkOut";
            this.Btn_WorkOut.Size = new System.Drawing.Size(75, 35);
            this.Btn_WorkOut.TabIndex = 5;
            this.Btn_WorkOut.Text = "计算";
            this.Btn_WorkOut.UseVisualStyleBackColor = true;
            this.Btn_WorkOut.Click += new System.EventHandler(this.Btn_WorkOut_Click);
            // 
            // Lb_showData
            // 
            this.Lb_showData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lb_showData.Location = new System.Drawing.Point(15, 128);
            this.Lb_showData.Name = "Lb_showData";
            this.Lb_showData.Size = new System.Drawing.Size(276, 314);
            this.Lb_showData.TabIndex = 6;
            // 
            // Btn_clean
            // 
            this.Btn_clean.Location = new System.Drawing.Point(18, 459);
            this.Btn_clean.Name = "Btn_clean";
            this.Btn_clean.Size = new System.Drawing.Size(75, 35);
            this.Btn_clean.TabIndex = 7;
            this.Btn_clean.Text = "清除";
            this.Btn_clean.UseVisualStyleBackColor = true;
            this.Btn_clean.Click += new System.EventHandler(this.Btn_clean_Click);
            // 
            // Btn_years
            // 
            this.Btn_years.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_years.Location = new System.Drawing.Point(231, 93);
            this.Btn_years.Name = "Btn_years";
            this.Btn_years.Size = new System.Drawing.Size(54, 23);
            this.Btn_years.TabIndex = 8;
            this.Btn_years.Text = "确定";
            this.Btn_years.UseVisualStyleBackColor = true;
            this.Btn_years.Click += new System.EventHandler(this.Btn_years_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_set});
            this.menuStrip1.Location = new System.Drawing.Point(548, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(72, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_set
            // 
            this.Menu_set.Name = "Menu_set";
            this.Menu_set.Size = new System.Drawing.Size(51, 24);
            this.Menu_set.Text = "设置";
            this.Menu_set.Click += new System.EventHandler(this.Menu_set_Click);
            // 
            // Pl_set
            // 
            this.Pl_set.Controls.Add(this.label5);
            this.Pl_set.Controls.Add(this.label4);
            this.Pl_set.Controls.Add(this.Tx_PreRate);
            this.Pl_set.Controls.Add(this.pictureBox1);
            this.Pl_set.Location = new System.Drawing.Point(131, 133);
            this.Pl_set.Name = "Pl_set";
            this.Pl_set.Size = new System.Drawing.Size(274, 144);
            this.Pl_set.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(217, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Tx_PreRate
            // 
            this.Tx_PreRate.Location = new System.Drawing.Point(111, 83);
            this.Tx_PreRate.Name = "Tx_PreRate";
            this.Tx_PreRate.Size = new System.Drawing.Size(49, 27);
            this.Tx_PreRate.TabIndex = 1;
            this.Tx_PreRate.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Tx_PreRate.ValueChanged += new System.EventHandler(this.Tx_PreRate_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "设置贴现率：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(170, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "%";
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 510);
            this.Controls.Add(this.Pl_set);
            this.Controls.Add(this.Btn_years);
            this.Controls.Add(this.Btn_clean);
            this.Controls.Add(this.Lb_showData);
            this.Controls.Add(this.Btn_WorkOut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tx_year);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "项目成本计算工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Tx_year)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Pl_set.ResumeLayout(false);
            this.Pl_set.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tx_PreRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Tx_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Tb_profits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb_InternalReturnRate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Tb_PresentValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Tb_ReturnRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tb_payBackTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_WorkOut;
        private System.Windows.Forms.Label Lb_showData;
        private System.Windows.Forms.Button Btn_clean;
        private System.Windows.Forms.Button Btn_years;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_set;
        private System.Windows.Forms.Panel Pl_set;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Tx_PreRate;
        private System.Windows.Forms.Label label5;
    }
}

