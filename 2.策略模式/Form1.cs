using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 策略模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total = 0.0d;
        private void btnOK_Click(object sender, EventArgs e)
        {
            double totalPrices = 0d;
            #region 简单工厂的客户端代码,须知道（抽象类和工厂类）
            //CashSuper super = CashFactory.CreateCashAccept(cbxType.SelectedItem.ToString());

            //totalPrices = super.acceptCash(Convert.ToDouble(txtPrice.Text))
            //    * Convert.ToDouble(txtNum.Text);
            //total = total + totalPrices;
            //lbxList.Items.Add("单价：" + txtPrice.Text + " 数量：" + txtNum.Text
            //    + " " + cbxType.SelectedItem + " 合计: " + totalPrices.ToString());
            //lbResult.Text = total.ToString();
            #endregion

            #region 只有策略模式的客户端代码，须知道（策略类和各子类）
            //CashContext cc = null;
            //switch (cbxType.SelectedItem.ToString())
            //{
            //    case "正常收费":
            //        cc = new CashContext(new CashNormal());
            //        break;
            //    case "满300返100":
            //        cc = new CashContext(new CashReturn("300", "100"));
            //        break;
            //    case "打8折":
            //        cc = new CashContext(new CashRebate("0.8"));
            //        break;
            //    default: break;
            //}
            //totalPrices = cc.GetResult(Convert.ToDouble(txtPrice.Text))
            //    * Convert.ToDouble(txtNum.Text);
            //total = total + totalPrices;
            //lbxList.Items.Add("单价：" + txtPrice.Text + " 数量：" + txtNum.Text
            //    + " " + cbxType.SelectedItem + " 合计: " + totalPrices.ToString());
            //lbResult.Text = total.ToString();

            #endregion

            #region 策略模式和简单工厂模式结合 只需知道策略类

            CashContext csuper = new CashContext(cbxType.SelectedItem.ToString());
            totalPrices = csuper.GetResult(Convert.ToDouble(txtPrice.Text))
                * Convert.ToDouble(txtNum.Text);
            total = total + totalPrices;
            lbxList.Items.Add("单价：" + txtPrice.Text + " 数量：" + txtNum.Text
                + " " + cbxType.SelectedItem + " 合计: " + totalPrices.ToString());
            lbResult.Text = total.ToString();

            #endregion
        }
    }
}
