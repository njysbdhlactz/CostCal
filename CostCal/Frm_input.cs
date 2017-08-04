using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostCal
{
    public partial class Frm_input : Form
    {
        String incomeYear = "";
        public Frm_input(int i)
        {
            InitializeComponent();
            this.incomeYear = ""+i;
            Lb_remindYear.Text = this.incomeYear;
        }

        private void tB_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;

            if (null == tb)
            {
                e.Handled = true;
                return;
            }

            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == 46) //数字、Backspace、小数点  
            {
                var editText = (tb.Text);

                if (e.KeyChar != 8)
                {
                    var selStart = tb.SelectionStart;
                    var selLength = tb.SelectionLength;

                    if (selLength > 0) //存在选择的内容，进行替换。  
                    {
                        editText = editText.Remove(selStart, selLength);

                        tb.Text = editText;
                        tb.SelectionLength = 0;
                        tb.SelectionStart = selStart;
                    }

                    editText = editText.Insert(selStart, e.KeyChar.ToString());

                    try
                    {
                        //校验新数据是否合法。  
                        var newValue = double.Parse(editText);
                        e.Handled = !(newValue >= 0);
                    }
                    catch (Exception)
                    {
                        e.Handled = true;
                        return;
                    }
                    e.Handled = false;
                }
                else
                    e.Handled = false;
            }
            else
            {
                //正负数切换  
                if (e.KeyChar == 45)
                {
                    tb.Text = tb.Text.Contains("-") ? tb.Text.Replace("-", "") : tb.Text.Insert(0, "-");

                    tb.Select(tb.Text.Length, 0);
                }

                e.Handled = true;
            }  
        }

        private void Btn_sure_Click(object sender, EventArgs e)
        {
            Frm_main f1 = (Frm_main)this.Owner;//将本窗体的拥有者强制设为Form1类的实例f1
            f1.str = this.tB_year.Text.ToString();
            this.Close();
        }
        private void Btn_reset_Click(object sender, EventArgs e)
        {
            this.tB_year.Text = "";
        }

        private void tB_year_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键
            {
                this.Btn_sure_Click(sender, e);//触发button事件
            }
        }
    }
}
