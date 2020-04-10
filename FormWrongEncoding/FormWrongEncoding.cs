using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WrongEncoding
{
    public partial class FormWrongEncoding : Form
    {
        public FormWrongEncoding()
        {
            InitializeComponent();
        }
        private void FormWrongEncoding_Load(object sender, EventArgs e)
        {
            Encoding EncodingGBK = Encoding.GetEncoding("GBK");
            Encoding EncodingGB18030 = Encoding.GetEncoding("GB18030");
            Encoding EncodingGB2312 = Encoding.GetEncoding("GB2312");
            //Encoding EncodingHZ = Encoding.GetEncoding("HZ");
            Encoding EncodingUnicode = Encoding.GetEncoding(Encoding.Unicode.HeaderName);
            if (comboBoxSourceText.Items.Count == 0)
            {
                comboBoxSourceText.Items.Add(@"1:4011662645:admin:DESKTOP-CI5KJK9:2147484046:6��1��123");
                comboBoxSourceText.Items.Add(@"\\");
                comboBoxSourceText.Items.Add("我是中国人");
                comboBoxSourceText.SelectedIndex = 0;
            }
            if (comboBoxSourceEncoding.Items.Count == 0)
            {
                comboBoxSourceEncoding.Items.Add(Encoding.UTF8.HeaderName);
                //comboBoxSourceEncoding.Items.Add(Encoding.GetEncoding("GBK").HeaderName);
                comboBoxSourceEncoding.Items.Add(Encoding.Unicode.HeaderName);
                comboBoxSourceEncoding.SelectedIndex = 0;
            }
            if (comboBoxTargetEncoding.Items.Count == 0)
            {
                //comboBoxTargetEncoding.Items.Add(Encoding.GetEncoding("GBK").HeaderName);
                comboBoxTargetEncoding.Items.Add(Encoding.UTF8.HeaderName);
                comboBoxTargetEncoding.Items.Add(Encoding.Unicode.HeaderName);
                comboBoxTargetEncoding.SelectedIndex = 0;
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach (var eachvar1 in comboBoxSourceEncoding.Items)
            {
                foreach (var eachvar1W in comboBoxSourceEncoding.Items)
                {
                    foreach (var eachvar2 in comboBoxTargetEncoding.Items)
                    {
                        foreach (var eachvar2W in comboBoxTargetEncoding.Items)
                        {
                            index++;

                            if (index == 1) comboBox1.Text = ConvertEncodingTo(comboBoxSourceText.Text, eachvar1.ToString(), eachvar1W.ToString(), eachvar2.ToString(), eachvar2W.ToString());
                            if (index == 2) comboBox2.Text = ConvertEncodingTo(comboBoxSourceText.Text, eachvar1.ToString(), eachvar1W.ToString(), eachvar2.ToString(), eachvar2W.ToString());
                            if (index == 3) comboBox3.Text = ConvertEncodingTo(comboBoxSourceText.Text, eachvar1.ToString(), eachvar1W.ToString(), eachvar2.ToString(), eachvar2W.ToString());
                            if (index == 4) comboBox4.Text = ConvertEncodingTo(comboBoxSourceText.Text, eachvar1.ToString(), eachvar1W.ToString(), eachvar2.ToString(), eachvar2W.ToString());

                            if (index == 5) comboBox5.Text = ConvertEncodingTo(comboBoxSourceText.Text, eachvar1.ToString(), eachvar1W.ToString(), eachvar2.ToString(), eachvar2W.ToString());
                            if (index == 6) comboBox6.Text = ConvertEncodingTo(comboBoxSourceText.Text, eachvar1.ToString(), eachvar1W.ToString(), eachvar2.ToString(), eachvar2W.ToString());
                            if (index == 7) comboBox7.Text = ConvertEncodingTo(comboBoxSourceText.Text, eachvar1.ToString(), eachvar1W.ToString(), eachvar2.ToString(), eachvar2W.ToString());
                            if (index == 8) comboBox8.Text = ConvertEncodingTo(comboBoxSourceText.Text, eachvar1.ToString(), eachvar1W.ToString(), eachvar2.ToString(), eachvar2W.ToString());

                            if (index == 9) comboBox9.Text = ConvertEncodingTo(comboBoxSourceText.Text, eachvar1.ToString(), eachvar1W.ToString(), eachvar2.ToString(), eachvar2W.ToString());
                            if (index == 10) comboBox10.Text = ConvertEncodingTo(comboBoxSourceText.Text, eachvar1.ToString(), eachvar1W.ToString(), eachvar2.ToString(), eachvar2W.ToString());
                            if (index == 11) comboBox11.Text = ConvertEncodingTo(comboBoxSourceText.Text, eachvar1.ToString(), eachvar1W.ToString(), eachvar2.ToString(), eachvar2W.ToString());
                            if (index == 12) comboBox12.Text = ConvertEncodingTo(comboBoxSourceText.Text, eachvar1.ToString(), eachvar1W.ToString(), eachvar2.ToString(), eachvar2W.ToString());

                            if (index == 13) comboBox13.Text = ConvertEncodingTo(comboBoxSourceText.Text, eachvar1.ToString(), eachvar1W.ToString(), eachvar2.ToString(), eachvar2W.ToString());
                            if (index == 14) comboBox14.Text = ConvertEncodingTo(comboBoxSourceText.Text, eachvar1.ToString(), eachvar1W.ToString(), eachvar2.ToString(), eachvar2W.ToString());
                            if (index == 15) comboBox15.Text = ConvertEncodingTo(comboBoxSourceText.Text, eachvar1.ToString(), eachvar1W.ToString(), eachvar2.ToString(), eachvar2W.ToString());
                            if (index == 16) comboBox16.Text = ConvertEncodingTo(comboBoxSourceText.Text, eachvar1.ToString(), eachvar1W.ToString(), eachvar2.ToString(), eachvar2W.ToString());



                            if (index == 1) label1.Text = eachvar1.ToString() + " - " + eachvar1W.ToString() + " - " + eachvar2.ToString() + " - " + eachvar2W.ToString();
                            if (index == 2) label2.Text = eachvar1.ToString() + " - " + eachvar1W.ToString() + " - " + eachvar2.ToString() + " - " + eachvar2W.ToString();
                            if (index == 3) label3.Text = eachvar1.ToString() + " - " + eachvar1W.ToString() + " - " + eachvar2.ToString() + " - " + eachvar2W.ToString();
                            if (index == 4) label4.Text = eachvar1.ToString() + " - " + eachvar1W.ToString() + " - " + eachvar2.ToString() + " - " + eachvar2W.ToString();
                            if (index == 5) label5.Text = eachvar1.ToString() + " - " + eachvar1W.ToString() + " - " + eachvar2.ToString() + " - " + eachvar2W.ToString();
                            if (index == 6) label6.Text = eachvar1.ToString() + " - " + eachvar1W.ToString() + " - " + eachvar2.ToString() + " - " + eachvar2W.ToString();
                            if (index == 7) label7.Text = eachvar1.ToString() + " - " + eachvar1W.ToString() + " - " + eachvar2.ToString() + " - " + eachvar2W.ToString();
                            if (index == 8) label8.Text = eachvar1.ToString() + " - " + eachvar1W.ToString() + " - " + eachvar2.ToString() + " - " + eachvar2W.ToString();

                            if (index == 9) label9.Text = eachvar1.ToString() + " - " + eachvar1W.ToString() + " - " + eachvar2.ToString() + " - " + eachvar2W.ToString();
                            if (index == 10) label10.Text = eachvar1.ToString() + " - " + eachvar1W.ToString() + " - " + eachvar2.ToString() + " - " + eachvar2W.ToString();
                            if (index == 11) label11.Text = eachvar1.ToString() + " - " + eachvar1W.ToString() + " - " + eachvar2.ToString() + " - " + eachvar2W.ToString();
                            if (index == 12) label12.Text = eachvar1.ToString() + " - " + eachvar1W.ToString() + " - " + eachvar2.ToString() + " - " + eachvar2W.ToString();
                            if (index == 13) label13.Text = eachvar1.ToString() + " - " + eachvar1W.ToString() + " - " + eachvar2.ToString() + " - " + eachvar2W.ToString();
                            if (index == 14) label14.Text = eachvar1.ToString() + " - " + eachvar1W.ToString() + " - " + eachvar2.ToString() + " - " + eachvar2W.ToString();
                            if (index == 15) label15.Text = eachvar1.ToString() + " - " + eachvar1W.ToString() + " - " + eachvar2.ToString() + " - " + eachvar2W.ToString();
                            if (index == 16) label16.Text = eachvar1.ToString() + " - " + eachvar2.ToString() + " - " + eachvar2.ToString() + " - " + eachvar2.ToString();
                        }
                    }
                }
            }
        }
        public static string ConvertEncodingTo(string text, string sourceCode, string targetCode)
        {
            byte[] sourceBytes = Encoding.GetEncoding(sourceCode).GetBytes(text);
            byte[] targetBytes = Encoding.Convert(Encoding.GetEncoding(sourceCode), Encoding.GetEncoding(targetCode), sourceBytes);
            return Encoding.GetEncoding(targetCode).GetString(targetBytes);
        }
        public static string ConvertEncodingTo(string text, string sourceCode, string sourceCodeWrong, string targetCode, string targetCodeWrong)
        {
            byte[] sourceBytes = Encoding.GetEncoding(sourceCode).GetBytes(text);
            byte[] targetBytes = Encoding.Convert(Encoding.GetEncoding(sourceCodeWrong), Encoding.GetEncoding(targetCode), sourceBytes);
            return Encoding.GetEncoding(targetCodeWrong).GetString(targetBytes);
        }
    }
}
