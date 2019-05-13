using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtakuNaming
{
    public partial class Form1 : Form
    {
        string MonName;
        string DayName;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.rbtm1.Checked)
            {
                MonName = "달";
            }
            else if (this.rbtm2.Checked)
            {
                MonName = "사랑";
            }
            else if (this.rbtm3.Checked)
            {
                MonName = "하늘";
            }
            else if (this.rbtm4.Checked)
            {
                MonName = "물";
            }
            else if (this.rbtm5.Checked)
            {
                MonName = "꽃";
            }
            else if (this.rbtm6.Checked)
            {
                MonName = "우주";
            }
            else if (this.rbtm7.Checked)
            {
                MonName = "태양";
            }
            else if (this.rbtm8.Checked)
            {
                MonName = "별";
            }
            else if (this.rbtm9.Checked)
            {
                MonName = "숲";
            }
            else if (this.rbtm10.Checked)
            {
                MonName = "그림자";
            }
            else if (this.rbtm11.Checked)
            {
                MonName = "천국";
            }
            else if (this.rbtm12.Checked)
            {
                MonName = "눈";
            }

            if (this.rbtd1.Checked)
            {
                this.DayName = "파편";
            }
            else if (this.rbtd2.Checked)
            {
                this.DayName = "천사";
            }
            else if (this.rbtd3.Checked)
            {
                this.DayName = "눈물";
            }
            else if (this.rbtd4.Checked)
            {
                this.DayName = "증거";
            }
            else if (this.rbtd5.Checked)
            {
                this.DayName = "꿈";
            }
            else if (this.rbtd6.Checked)
            {
                this.DayName = "마음";
            }
            else if (this.rbtd7.Checked)
            {
                this.DayName = "물방울";
            }
            else if (this.rbtd8.Checked)
            {
                this.DayName = "요정";
            }
            else if (this.rbtd9.Checked)
            {
                this.DayName = "음악";
            }
            else if (this.rbtd10.Checked)
            {
                this.DayName = "빛";
            }
            else if (this.rbtd11.Checked)
            {
                this.DayName = "상어";
            }
            else if (this.rbtd12.Checked)
            {
                this.DayName = "결정";
            }
            else if (this.rbtd13.Checked)
            {
                this.DayName = "속삭임";
            }
            else if (this.rbtd14.Checked)
            {
                this.DayName = "신탁";
            }
            else if (this.rbtd15.Checked)
            {
                this.DayName = "주문";
            }
            else if (this.rbtd16.Checked)
            {
                this.DayName = "사기꾼";
            }
            else if (this.rbtd17.Checked)
            {
                this.DayName = "기도";
            }
            else if (this.rbtd18.Checked)
            {
                this.DayName = "고양이";
            }
            else if (this.rbtd19.Checked)
            {
                this.DayName = "안내자";
            }
            else if (this.rbtd20.Checked)
            {
                this.DayName = "파곰";
            }
            else if (this.rbtd21.Checked)
            {
                this.DayName = "보호자";
            }
            else if (this.rbtd22.Checked)
            {
                this.DayName = "마법";
            }
            else if (this.rbtd23.Checked)
            {
                this.DayName = "보물";
            }
            else if (this.rbtd24.Checked)
            {
                this.DayName = "영혼";
            }
            else if (this.rbtd25.Checked)
            {
                this.DayName = "여괴";
            }
            else if (this.rbtd26.Checked)
            {
                this.DayName = "여우";
            }
            else if (this.rbtd27.Checked)
            {
                this.DayName = "늑대";
            }
            else if (this.rbtd28.Checked)
            {
                this.DayName = "날개";
            }
            else if (this.rbtd29.Checked)
            {
                this.DayName = "서눔ㄹ";
            }
            else if (this.rbtd30.Checked)
            {
                this.DayName = "괴도";
            }
            else if (this.rbtd31.Checked)
            {
                this.DayName = "지배자";
            }

            if (this.DayName == null || this.DayName == "")
            {
                MessageBox.Show(
                    "태어난 날짜를 선택해 주세요", "신탁",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if ((
                    this.rbtm4.Checked ||
                    this.rbtm6.Checked ||
                    this.rbtm8.Checked ||
                    this.rbtm10.Checked ||
                    this.rbtm12.Checked)
                     &&
                     (this.rbtd31.Checked))
                {
                    MessageBox.Show(
                   "해당 날짜에 태어난사람은 없습니다!", "신탁",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show(
                    "당신의 이름은\n["
                    + this.MonName + "의 " + this.DayName
                    + "] 입니다!!", "신탁",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
