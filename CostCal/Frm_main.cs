using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
namespace CostCal
{
    public partial class Frm_main : Form
    {

        ArrayList income = new ArrayList();//定义动态数组，用于保存每一年的收支数据
        String show = "";//定义输出的收支数据字符串
        int years = 0;//项目周期年份
        public  string str;//public类型的实例字段,用于传值
        double presentRate = 0.1;//贴现率，默认为0.1
        public Frm_main()
        {
            InitializeComponent();
            this.Pl_set.Hide();
            Tx_PreRate.Value = 10;
        }

        private void Btn_years_Click(object sender, EventArgs e)
        {//获取数据，通过自定义弹出框
            years = Decimal.ToInt32(this.Tx_year.Value);
            for (int i = 0; i <= years; i++)
            {
                Frm_input frm = new Frm_input(i);
                frm.ShowDialog(this);//这个this必不可少（将窗体显示为具有指定所有者：窗体frm的所有者是frm_main类当前的对象）
                income.Add(str);
                show = show + "第" + i + "年的收支情况：" + (String)income[i] + "\r\n";
                this.Lb_showData.Text = show;
                    
             }
            //转移焦点到计算按钮上
            this.Btn_WorkOut.Focus();
         }

        private void Btn_clean_Click(object sender, EventArgs e)
        {//清空数据
            this.Lb_showData.Text = "";
            this.Tx_year.Value = 0;
            this.Tb_InternalReturnRate.Text = "";
            this.Tb_payBackTime.Text = "";
            this.Tb_PresentValue.Text = "";
            this.Tb_profits.Text = "";
            this.Tb_ReturnRate.Text = "";
            this.income.Clear();//清空数组
            show = "";
            //转移焦点到项目周期输入框上
            this.Tx_year.Focus();
        }

        private void Tx_year_KeyDown(object sender, KeyEventArgs e)
        {//为项目周期输入框添加回车事件
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键
            {
                this.Btn_years_Click(sender, e);//触发button事件
            }
        }

        private void Btn_WorkOut_Click(object sender, EventArgs e)
        {
            //计算净利润profits
            Tb_profits.Text = "" + profits();
            //计算回收期payBackTime
            Tb_payBackTime.Text =payBackTime();
            //计算投资回报率ReturnRate
            Tb_ReturnRate.Text = ReturnRate();
            //计算净现值PresentValue
            Tb_PresentValue.Text = ""+PresentValue();
            //内部回报率InternalReturnRate
            Tb_InternalReturnRate.Text = InternalReturnRate();
        }
        //计算净利润profits
        /*
         * 计算器核心代码
         */
        private double profits()
        {
            double sum = 0;
            for (int i = 0; i < this.income.Count; i++)
            {
                sum = sum + Convert.ToDouble(this.income[i]);
            }
            return sum;
        
        }
        private String payBackTime()
        {  //计算回收期payBackTime
            String time = "";
            double sum = 0;
            for (int i = 0; i < this.income.Count; i++)
            {
                sum = sum + Convert.ToDouble(this.income[i]);
                if(sum>=0)
                {
                    time = "第"+i+"年";
                    break;
                }
            }
            return time;
        }
        private String ReturnRate()
        {
            //计算投资回报率ReturnRate
            /*
             * 平均年利润与总投资的比例
             */
            String reRate="";
            double aver = profits()/(income.Count-1);
            double investment = 0;
            for (int i = 0; i < this.income.Count; i++)
            {
                if (Convert.ToDouble(this.income[i]) <= 0)
                {
                    investment = investment + Convert.ToDouble(this.income[i]);
                }
            }
            investment=investment*(-1);
            double rate = aver / investment*100;
            reRate = String.Format("{0:F}", rate) + "%";//保留2位小数
            return reRate;

        }
        //计算净现值PresentValue
        /*
         * 净现值=第t年的值/（（1+r）的t次方）贴现率需要给定
         */
        private double PresentValue()
        {//计算净现值PresentValue
            double value = 0;
           // double presentRate = 0.1F;//默认值设置为0.1
            //1.计算每一年的贴现因子，放在动态数组中
            ArrayList rValues = new ArrayList();

            
            rValues.Add(1);//初始贴现因子为1
            double x = 1 / (1 + presentRate);
            for (int i = 1; i < this.income.Count; i++)
            {
                
                double y = x;
                //乘方
                for (int j = 1; j < i; j++)
                {
                    y = y * x;
                }
                rValues.Add(y);
            }
            //2.用每一年的收支乘以每一年的值，放在净现值数组中
            ArrayList cashByY = new ArrayList();//定义动态数组，用于保存每一年的净现值数据
            for (int i = 0; i < this.income.Count; i++)
            {
                double mul = 0;
                mul = Convert.ToDouble(income[i]) * Convert.ToDouble(rValues[i]);
                cashByY.Add(mul);
            }
            //加和
            for (int i = 0; i < cashByY.Count; i++)
            {
                value=value+Convert.ToDouble(cashByY[i]);
            }
            return value;
        }
        
        private String InternalReturnRate()
        {//内部回报率InternalReturnRate
            double rate = 0;
            double presentV = 0;
            this.presentRate = 0;
            for (int i = 0; i < 1000; i++)
            {
                presentV = PresentValue();
                if (presentV >= 0)
                {
                    rate = this.presentRate;
                    break;
                }
                this.presentRate = this.presentRate+0.001;
            }
            double v = Decimal.ToDouble(Tx_PreRate.Value) * 0.01;
            this.presentRate = v;
            
            return rate + "%";
 
        }
        
        private void Btn_save_Click(object sender, EventArgs e)
        {//保存数据到文本文件

            SaveFileDialog sf = new SaveFileDialog();
            //设置文件保存类型
            sf.Filter = "txt文件|*.txt|所有文件|*.*";
            //如果用户没有输入扩展名，自动追加后缀
            sf.AddExtension = true;
            //设置标题
            sf.Title = "文件保存";
            //如果用户点击了保存按钮
            if (sf.ShowDialog() == DialogResult.OK)
            {
                //实例化一个文件流--->与写入文件相关联
                FileStream fs = new FileStream(sf.FileName, FileMode.Create);
                //实例化一个StreamWriter-->与fs相关联
                StreamWriter sw = new StreamWriter(fs);
                //开始写入
                sw.Write("***************项目收支数据********************\r\n");
                sw.Write(show + "\n");
                sw.Write("***************项目收益数据********************\r\n");
                sw.Write("净利润:" + Tb_profits.Text + "\r\n");
                sw.Write("回收期:" + Tb_payBackTime.Text + "\r\n");
                sw.Write("投资回报率:" + Tb_ReturnRate.Text + "\r\n");
                sw.Write("净现值:" + Tb_PresentValue.Text + "\r\n");
                sw.Write("内部回报率" + Tb_InternalReturnRate.Text + "\r\n");
                //清空缓冲区
                sw.Flush();
                //关闭流
                sw.Close();
                fs.Close();
            }
            DialogResult TS = MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK);
        }

        private void Frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult TS = MessageBox.Show("退出可能造成未保存数据的丢失，是否退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (TS == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true; 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Pl_set.Hide();
        }

        private void Menu_set_Click(object sender, EventArgs e)
        {
            this.Pl_set.Show();
        }

        private void Tx_PreRate_ValueChanged(object sender, EventArgs e)
        {
            double v = Decimal.ToDouble(Tx_PreRate.Value)*0.01;
            this.presentRate = v;
        }
    }
}
