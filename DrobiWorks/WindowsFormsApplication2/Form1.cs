using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public int A1;
        public float B1;
        public int A2;
        public float B2;
        public int n;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // +
        {
            Fraction f1 = new Fraction(A1 = Convert.ToInt32(textBox1.Text), B1 = Convert.ToSingle(textBox2.Text));
            Fraction f2 = new Fraction(A2 = Convert.ToInt32(textBox4.Text), B2 = Convert.ToSingle(textBox5.Text));
            Fraction f3 = f1 + f2;
            label3.Text = "Ответ при сложении: " + Convert.ToString(f3);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // -
        {
            Fraction f1 = new Fraction(A1 = Convert.ToInt32(textBox1.Text), B1 = Convert.ToSingle(textBox2.Text));
            Fraction f2 = new Fraction(A2 = Convert.ToInt32(textBox4.Text), B2 = Convert.ToSingle(textBox5.Text));
            Fraction f3 = f1 - f2;
            label3.Text = "Ответпри вычитании: " + Convert.ToString(f3);
        }

        private void button3_Click(object sender, EventArgs e) // *
        {
            Fraction f1 = new Fraction(A1 = Convert.ToInt32(textBox1.Text), B1 = Convert.ToSingle(textBox2.Text));
            Fraction f2 = new Fraction(A2 = Convert.ToInt32(textBox4.Text), B2 = Convert.ToSingle(textBox5.Text));
            Fraction f3 = f1 * f2;
            label3.Text = "Ответ при умножении: " + Convert.ToString(f3);
        }

        private void button4_Click(object sender, EventArgs e) // /
        {
            Fraction f1 = new Fraction(A1 = Convert.ToInt32(textBox1.Text), B1 = Convert.ToSingle(textBox2.Text));
            Fraction f2 = new Fraction(A2 = Convert.ToInt32(textBox4.Text), B2 = Convert.ToSingle(textBox5.Text));
            Fraction f3 = f1 / f2;
            label3.Text = "Ответ при делении: " + Convert.ToString(f3);
        }

        private void button5_Click(object sender, EventArgs e) // Cut
        {
            Fraction f = new Fraction(A1 = Convert.ToInt32(textBox1.Text), B1 = Convert.ToSingle(textBox2.Text));
            Fraction cuted = Fraction.Cut(f);
            label3.Text = "Сокращение дроби: " + Convert.ToString(cuted);
        }

        private void button6_Click(object sender, EventArgs e) // Степень
        {
            Fraction f1 = new Fraction(A1 = Convert.ToInt32(textBox1.Text), B1 = Convert.ToSingle(textBox2.Text));
            Fraction f2 = new Fraction(n = Convert.ToInt32(textBox3.Text), n = Convert.ToInt32(textBox3.Text));
            Fraction f3 = Fraction.Pow(f1,f2);
            label3.Text = "Дробь  " + f1 + "  в степени  " + n + "  =  " + Convert.ToString(f3);
        }

        private void button7_Click(object sender, EventArgs e) // Equal
        {
            Fraction f1 = new Fraction(A1 = Convert.ToInt32(textBox1.Text), B1 = Convert.ToSingle(textBox2.Text));
            Fraction f2 = new Fraction(A2 = Convert.ToInt32(textBox4.Text), B2 = Convert.ToSingle(textBox5.Text));
            bool result = Fraction.FractionEqual(f1, f2);
            if (result == true)
            {
                label3.Text = "Дроби равны";
            }
            else
            {
                label3.Text = "Дроби не равны";
            }
        }

        private void button8_Click(object sender, EventArgs e) // >
        {
            Fraction f1 = new Fraction(A1 = Convert.ToInt32(textBox1.Text), B1 = Convert.ToSingle(textBox2.Text));
            Fraction f2 = new Fraction(A2 = Convert.ToInt32(textBox4.Text), B2 = Convert.ToSingle(textBox5.Text));
            bool result = Fraction.FractionBigger(f1, f2);
            if (result == true)
            {
                label3.Text = "Дробь  " + f1 + "  больше  " + f2;
            }
            else
            {
                label3.Text = "Дробь  " + f2 + "  больше  " + f1;
            }
        }

        private void button9_Click(object sender, EventArgs e) // <
        {
            Fraction f1 = new Fraction(A1 = Convert.ToInt32(textBox1.Text), B1 = Convert.ToSingle(textBox2.Text));
            Fraction f2 = new Fraction(A2 = Convert.ToInt32(textBox4.Text), B2 = Convert.ToSingle(textBox5.Text));
            bool result = Fraction.FractionSmaller(f1, f2);
            if (result == true)
            {
                label3.Text = "Дробь  " + f1 + "  меньше  " + f2;
            }
            else
            {
                label3.Text = "Дробь  " + f2 + "  меньше  " + f1;
            }
        }

        private void button10_Click(object sender, EventArgs e) // >=
        {
            Fraction f1 = new Fraction(A1 = Convert.ToInt32(textBox1.Text), B1 = Convert.ToSingle(textBox2.Text));
            Fraction f2 = new Fraction(A2 = Convert.ToInt32(textBox4.Text), B2 = Convert.ToSingle(textBox5.Text));
            bool result = Fraction.FractionBiggerOrEqual(f1, f2);
            if (result == true)
            {
                label3.Text = "Дробь  " + f1 + "  больше либо равна  " + f2;
            }
            else
            {
                label3.Text = "Дробь  " + f2 + "  больше либо равна  " + f1;
            }
        }

        private void button11_Click(object sender, EventArgs e) // <=
        {
            Fraction f1 = new Fraction(A1 = Convert.ToInt32(textBox1.Text), B1 = Convert.ToSingle(textBox2.Text));
            Fraction f2 = new Fraction(A2 = Convert.ToInt32(textBox4.Text), B2 = Convert.ToSingle(textBox5.Text));
            bool result = Fraction.FractionSmallerOrEqual(f1, f2);
            if (result == true)
            {
                label3.Text = "Дробь  " + f1 + "  меньше либо равна  " + f2;
            }
            else
            {
                label3.Text = "Дробь  " + f2 + "  меньше либо равна  " + f1;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Fraction f1 = new Fraction(A1 = Convert.ToInt32(textBox4.Text), B1 = Convert.ToSingle(textBox5.Text));
            Fraction f2 = new Fraction(n = Convert.ToInt32(textBox6.Text), n = Convert.ToInt32(textBox6.Text));
            Fraction f3 = Fraction.Pow(f1, f2);
            label3.Text = "Дробь  " + f1 + "  в степени  " + n + "  =  " + Convert.ToString(f3);
        }
    }

    public class Fraction
    {
        private int p;
        private float q;

        public int P
        {
            get
            {
                return p;
            }
        }

        public float Q
        {
            get
            {
                return q;
            }
        }

        public Fraction(int givenP, float givenQ)
        {
            p = givenP;
            q = givenQ;
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", p, q);
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            float denominator = f1.Q + f2.Q;
            int numerator = (int)(f1.P + f2.P);
            return new Fraction(numerator, denominator);
        }   // Оператор сложения

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            float denominator = f1.Q + f2.Q;
            int numerator = (int)(f1.P - f2.P);
            return new Fraction(numerator, denominator);
        }   // Оператор вычитания

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            float denominator = f1.Q * f2.Q;
            int numerator = (int)(f1.P * f2.P);
            return new Fraction(numerator, denominator);
        }   // Оператор умножения

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            float denominator = f1.Q * f2.P;
            int numerator = (int)(f1.P * f2.Q);
            return new Fraction(numerator, denominator);
        }   // Оператор деления

        public static Fraction Cut(Fraction f)
        {
            int min = (int)Math.Min(f.P, f.Q);
            bool cut = false;
            for (int i = min; i >= 2; i--)
            {
                if (f.P % i == 0 && f.Q % i == 0)
                {
                    cut = true;
                    break;
                }
            }
            if (!cut)
            {
                return f;
            }
            else
            {
                return new Fraction(f.P / min, f.Q / min);
            }
        }   // Сокращение дроби.

        public static bool FractionEqual(Fraction f1, Fraction f2)
        {
            if (f1.P == f2.P && f2.Q == f1.Q)
            {
                return true;
            }
            Decimal d1 = Convert.ToDecimal(f1.P) / Convert.ToDecimal(f1.Q);
            Decimal d2 = Convert.ToDecimal(f2.P) / Convert.ToDecimal(f2.Q);
            return d1 == d2;
        }
        // Эквивалент

        public static bool FractionBigger(Fraction f1, Fraction f2)
        {
            Decimal d1 = Convert.ToDecimal(f1.P) / Convert.ToDecimal(f1.Q);
            Decimal d2 = Convert.ToDecimal(f2.P) / Convert.ToDecimal(f2.Q);
            return d1 == d2;

        }
        // >

        public static bool FractionSmaller(Fraction f1, Fraction f2)
        {
            Decimal d1 = Convert.ToDecimal(f1.P) / Convert.ToDecimal(f1.Q);
            Decimal d2 = Convert.ToDecimal(f2.P) / Convert.ToDecimal(f2.Q);
            return d1 == d2;
        }
        // <

        public static bool FractionBiggerOrEqual(Fraction f1, Fraction f2)
        {
            Decimal d1 = Convert.ToDecimal(f1.P) / Convert.ToDecimal(f1.Q);
            Decimal d2 = Convert.ToDecimal(f2.P) / Convert.ToDecimal(f2.Q);
            if (d1 > d2 || d1 == d2)
            {
                return true;
            }
            return false;
        }
        // >=

        public static bool FractionSmallerOrEqual(Fraction f1, Fraction f2)
        {
            Decimal d1 = Convert.ToDecimal(f1.P) / Convert.ToDecimal(f1.Q);
            Decimal d2 = Convert.ToDecimal(f2.P) / Convert.ToDecimal(f2.Q);
            if (d1 < d2 || d1 == d2)
            {
                return true;
            }
            return false;
        }
        // <=
        public static Fraction Pow (Fraction f1, Fraction f2)
        {
            double denominator = Math.Pow(f1.Q,f2.Q);
            double numerator = Math.Pow(f1.P,f2.P);          
            return new Fraction(Convert.ToInt32(numerator), Convert.ToSingle(denominator));
        }
    }

}