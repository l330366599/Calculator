using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {


        public enum OperateProcess
        {
            LeftNum,
            RightNum,
            Result
        }

        public double leftNum = 0;      //第一操作数
        public double rightNum;          //第二操作数
        public double jsResult;          //结果值
        public string operateSign;          //运算符号
        public OperateProcess operateProcess = OperateProcess.LeftNum;    //检测是否为第一操作数

        public Form1()
        {
            InitializeComponent();
            ButtonAttribute.FoutAttribute(this);
        }

        private void btn0_Click(object sender, EventArgs e)
        {

            //所有的数字都调用该方法,具体思路如下
            Button b = (Button)sender;
            if (tbOperateNumEditing.Text != "0")
            {
                switch (operateProcess)
                {
                    //1.若正在编辑,则将后面输入的值累加到第一操作数后
                    case OperateProcess.LeftNum:
                        tbOperateNumEditing.Text += b.Text;
                        tbOperateNumRecord.Text += b.Text;
                        leftNum = double.Parse(tbOperateNumEditing.Text);
                        break;
                    //2.否则,将后面输入的值依序累加到第二操作数
                    case OperateProcess.RightNum:
                        tbOperateNumEditing.Text += b.Text;
                        tbOperateNumRecord.Text += b.Text;
                        rightNum = double.Parse(tbOperateNumEditing.Text);
                        break;
                    //3.若现在是点完=号出来结果了,这次再点击数字,应该是什么操作呢?
                    case OperateProcess.Result:
                        if (!string.IsNullOrEmpty(tbOperateNumRecord.Text))
                        {
                            tbOperateNumEditing.Text = b.Text;
                            tbOperateNumRecord.Text += b.Text;
                            rightNum = double.Parse(tbOperateNumEditing.Text);
                            operateProcess = OperateProcess.RightNum;
                        }
                        else
                        {
                            tbOperateNumEditing.Text = b.Text;
                            tbOperateNumRecord.Text += b.Text;
                            leftNum = double.Parse(tbOperateNumEditing.Text);
                            operateProcess = OperateProcess.LeftNum;
                        }

                        break;
                }
            }
            else
            {
                return;
            }
            
        }



        private void btnac_Click(object sender, EventArgs e)
        {
            tbOperateNumEditing.Text = "";
            tbOperateNumRecord.Text = "";
            leftNum = 0;
            rightNum = 0;
            jsResult = 0;
            operateProcess = OperateProcess.LeftNum;
        }
        private void btnbackspace_Click(object sender, EventArgs e)
        {
            //退格键的场景分析

            //首先先执行框中数据变更
            //
            if (!string.IsNullOrEmpty(this.tbOperateNumEditing.Text))
            //2.有值的情况下
            {
                //只有在有值并且在第一第二操作数编辑的情况下执行退格
                if (operateProcess != OperateProcess.Result)
                {
                    tbOperateNumEditing.Text = tbOperateNumEditing.Text.Remove(tbOperateNumEditing.Text.Length - 1);
                    tbOperateNumRecord.Text = tbOperateNumRecord.Text.Remove(tbOperateNumRecord.Text.Length - 1);
                }

                //tbOperateNumEditing.Text由于出现变更,赋值时需要小心在框中无值的情况
                switch (operateProcess)
                {
                    //2.1 当在第一操作数情况下
                    case OperateProcess.LeftNum:
                        leftNum = string.IsNullOrEmpty(this.tbOperateNumEditing.Text) ? 0 :
                            double.Parse(tbOperateNumEditing.Text);

                        break;
                    //2.2 当在第二操作数情况下
                    case OperateProcess.RightNum:
                        rightNum = string.IsNullOrEmpty(this.tbOperateNumEditing.Text) ? 0 :
                            double.Parse(tbOperateNumEditing.Text);
                        break;
                    //2.3 当在结果的情况下
                    case OperateProcess.Result:
                        break;

                }

            }
            else
            {
                //1.在运算框里没值的情况下

            }


        }
        private void btndot_Click(object sender, EventArgs e)
        {

            if (tbOperateNumEditing.Text == "")
            {
                tbOperateNumEditing.Text = "0.";
            }
            if (tbOperateNumEditing.Text == "-")
            {
                tbOperateNumEditing.Text = "-0.";
            }
            if (tbOperateNumEditing.Text.IndexOf(".") >= 0)
            {
                return;
            }
            else
            {
                tbOperateNumEditing.Text = tbOperateNumEditing.Text + ".";
                tbOperateNumRecord.Text = tbOperateNumRecord.Text + ".";
            }

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //1.计算器加载完后开始就点击(最开始点击)
            switch (operateProcess)
            {
                //2.输入完左操作数后点击
                case OperateProcess.LeftNum:
                    operateSign = ((Button)sender).Text;
                    tbOperateNumEditing.Text = "";
                    tbOperateNumRecord.Text += " " + ((Button)sender).Text + " ";
                    operateProcess = OperateProcess.RightNum;
                    rightNum = leftNum;
                    break;
                //3.输入完右操作数后点击
                case OperateProcess.RightNum:
                    if (!string.IsNullOrEmpty(tbOperateNumEditing.Text))
                    {
                        switch (operateSign)
                        {
                            case "+":
                                jsResult = leftNum + rightNum;
                                break;
                            case "-":
                                jsResult = leftNum - rightNum;
                                break;
                            case "*":
                                jsResult = leftNum * rightNum;
                                break;
                            case "/":
                                jsResult = leftNum / rightNum;
                                break;
                        }
                        tbOperateNumEditing.Text = jsResult.ToString();
                        operateProcess = OperateProcess.Result;
                        leftNum = jsResult;
                        rightNum = jsResult;
                        operateSign = ((Button)sender).Text;
                        tbOperateNumRecord.Text += " " + ((Button)sender).Text + " ";
                        break;
                    }
                    else
                    {
                        operateSign = ((Button)sender).Text;
                        tbOperateNumRecord.Text = tbOperateNumRecord.Text.Remove(tbOperateNumRecord.Text.Length - 3);
                        tbOperateNumRecord.Text += " " + ((Button)sender).Text + " ";
                        break;
                    }

                //4.多次重复点击
                case OperateProcess.Result:
                    operateSign = ((Button)sender).Text;
                    if (!string.IsNullOrEmpty(tbOperateNumRecord.Text))
                    {
                        tbOperateNumRecord.Text = tbOperateNumRecord.Text.Remove(tbOperateNumRecord.Text.Length - 3);
                        tbOperateNumRecord.Text += " " + ((Button)sender).Text + " ";
                    }
                    else
                    {
                        tbOperateNumRecord.Text = tbOperateNumEditing.Text;
                        tbOperateNumEditing.Text = "";
                        tbOperateNumRecord.Text += " " + ((Button)sender).Text + " ";
                        rightNum = leftNum;
                    }
                    break;
            }

        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            //通过开关进行判断;
            switch (operateProcess)
            {
                //1.检测为左操作数后清空文本框;
                case OperateProcess.LeftNum:
                    break;

                //2.检测为右操作数后的运算;
                case OperateProcess.RightNum:
                    switch (operateSign)
                    {
                        case "+":
                            jsResult = leftNum + rightNum;
                            break;
                        case "-":
                            jsResult = leftNum - rightNum;
                            break;
                        case "*":
                            jsResult = leftNum * rightNum;
                            break;
                        case "/":
                            jsResult = leftNum / rightNum;
                            break;
                    }
                    tbOperateNumEditing.Text = jsResult.ToString();
                    operateProcess = OperateProcess.Result;
                    leftNum = jsResult;
                    tbOperateNumRecord.Text = "";
                    break;
                //3.检测为结果操作数后的运算;
                case OperateProcess.Result:
                    switch (operateSign)
                    {
                        case "+":
                            jsResult += rightNum;
                            break;
                        case "-":
                            jsResult -= rightNum;
                            break;
                        case "*":
                            jsResult *= rightNum;
                            break;
                        case "/":
                            jsResult /= rightNum;
                            break;
                    }
                    tbOperateNumEditing.Text = jsResult.ToString();
                    operateProcess = OperateProcess.Result;
                    leftNum = jsResult;
                    tbOperateNumRecord.Text = "";
                    break;

            }

        }
        private string getBtnName(string keycode)
        {
            string btntype = "";

            switch (keycode)
            {
                case "Add":
                    btntype = "add";
                    break;
                case "Subtract":
                    btntype = "minus";
                    break;
                case "Multiply":
                    btntype = "mutiplication";
                    break;
                case "Divide":
                    btntype = "divide";
                    break;
                case "Oemplus":
                    btntype = "equal";
                    break;
                case "Decimal":
                    btntype = "dot";
                    break;
                case "Back":
                    btntype = "backspace";
                    break;
                case "Escape":
                    btntype = "ac";
                    break;
                default:
                    btntype = "";
                    break;

            }

            return !string.IsNullOrEmpty(btntype) ? "btn" + btntype : "";

        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                findBtnToClick("btnequal");
                return false;
            }

            return base.ProcessDialogKey(keyData);
        }

        private void findBtnToClick(string btnname)
        {
            if (!string.IsNullOrEmpty(btnname))
            {
                Control[] cols = this.Controls.Find(btnname, true);

                if (cols != null && cols.Length > 0)
                {
                    Button btn = ((Button)(cols[0]));
                    btn.Focus();
                    callButtonEvent(btn, "OnClick");
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string code = e.KeyCode.ToString();

            int currnum = 0;

            bool numparse = int.TryParse(code.Replace("D", "").Replace("NumPad", ""), out currnum);

            string btnname = "";
            //只处理数字按键

            btnname = (numparse) ? String.Format("btn{0}", currnum) : this.getBtnName(code);

            this.findBtnToClick(btnname);
        }
        private void callButtonEvent(Button btn, string EventName)
        {
            //建立一个类型      
            Type t = typeof(Button);
            //参数对象      
            object[] p = new object[1];
            //产生方法      
            MethodInfo m = t.GetMethod(EventName, BindingFlags.NonPublic | BindingFlags.Instance);
            //参数赋值。传入函数
            //获得参数资料  
            ParameterInfo[] para = m.GetParameters();
            //根据参数的名字，拿参数的空值。  
            p[0] = Type.GetType(para[0].ParameterType.BaseType.FullName).GetProperty("Empty");
            //调用      
            m.Invoke(btn, p);
            return;
        }


    }
}
