namespace CostCal
{
    partial class Frm_input
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
            this.label31 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_year = new System.Windows.Forms.TextBox();
            this.Btn_sure = new System.Windows.Forms.Button();
            this.Btn_reset = new System.Windows.Forms.Button();
            this.Lb_remindYear = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label31.Location = new System.Drawing.Point(61, 20);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(89, 20);
            this.label31.TabIndex = 0;
            this.label31.Text = "请输入第";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(42, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "注意：只允许输入数字，以正负表示收支";
            // 
            // tB_year
            // 
            this.tB_year.Location = new System.Drawing.Point(88, 95);
            this.tB_year.MaxLength = 15;
            this.tB_year.Name = "tB_year";
            this.tB_year.Size = new System.Drawing.Size(165, 25);
            this.tB_year.TabIndex = 2;
            this.tB_year.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_year_KeyDown);
            this.tB_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_year_KeyPress);
            // 
            // Btn_sure
            // 
            this.Btn_sure.Location = new System.Drawing.Point(256, 148);
            this.Btn_sure.Name = "Btn_sure";
            this.Btn_sure.Size = new System.Drawing.Size(75, 32);
            this.Btn_sure.TabIndex = 3;
            this.Btn_sure.Text = "确定";
            this.Btn_sure.UseVisualStyleBackColor = true;
            this.Btn_sure.Click += new System.EventHandler(this.Btn_sure_Click);
            // 
            // Btn_reset
            // 
            this.Btn_reset.Location = new System.Drawing.Point(31, 148);
            this.Btn_reset.Name = "Btn_reset";
            this.Btn_reset.Size = new System.Drawing.Size(75, 32);
            this.Btn_reset.TabIndex = 4;
            this.Btn_reset.Text = "重置";
            this.Btn_reset.UseVisualStyleBackColor = true;
            this.Btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // Lb_remindYear
            // 
            this.Lb_remindYear.AutoSize = true;
            this.Lb_remindYear.Font = new System.Drawing.Font("宋体", 12F);
            this.Lb_remindYear.Location = new System.Drawing.Point(150, 20);
            this.Lb_remindYear.Name = "Lb_remindYear";
            this.Lb_remindYear.Size = new System.Drawing.Size(19, 20);
            this.Lb_remindYear.TabIndex = 5;
            this.Lb_remindYear.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(169, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "年的收支数据:";
            // 
            // Frm_input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 192);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lb_remindYear);
            this.Controls.Add(this.Btn_reset);
            this.Controls.Add(this.Btn_sure);
            this.Controls.Add(this.tB_year);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label31);
            this.Name = "Frm_input";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_year;
        private System.Windows.Forms.Button Btn_sure;
        private System.Windows.Forms.Button Btn_reset;
        private System.Windows.Forms.Label Lb_remindYear;
        private System.Windows.Forms.Label label3;
    }
}