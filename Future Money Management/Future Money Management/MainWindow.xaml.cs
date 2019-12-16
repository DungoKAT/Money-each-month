using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Future_Money_Management
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /* เมื่อคุณต้องการเก็บเงินในอนาคต เพื่อที่จะนำไปซื้อของที่อยากได้ หรือต้องการเก็บเพื่อนำไปใช้จ่ายสิ่งต่างๆ 
         นี่จึงเป็นโปรแกรมที่ช่วยคำนวณเงินของคุณได้ */

        // คำนวณเงินที่ต้องการจะเก็บในอนาคต โดยการคำนวณว่าควรใช้เงินกี่บาทต่อวัน
        private void Button_Click(object sender, RoutedEventArgs e)
        {// คำนวณจากการนำเงินที่ต้องการจะเก็บในอนาคต มาหารกับระยะเวลาที่ต้องการจะเก็บ (จำนวนวัน)
            if (int.Parse(Amout_to_collect.Text) > 0 && int.Parse(number_of_the_day.Text) > 0)
            { 
                int total = int.Parse(Amout_to_collect.Text) / int.Parse(number_of_the_day.Text);
                MessageBox.Show("Should be collect " + total.ToString() + " Baht per day");
            }
            // เมื่อใส่ข้อมูลผิดพลาดอย่างเช่น เงินติดลบ ก็จะขึ้นข้อความว่า Wrong!! เพื่อแสดงถึงข้อมูลที่ผิดพลาด
            else
            {
                MessageBox.Show("Wrong!!");
            }
        }
        private void Button_Loaded(object sender, RoutedEventArgs e)
        {

        }

        // คำนวณเงินที่ต้องการจะเก็บในอนาคต โดยการคำนวณว่าต้องใช้เวลาประมาณเท่าไรถึงจะได้เงินตามจำนวนที่ต้องการ
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {// คำนวณจากการนำเงินที่ต้องการจะเก็บในอนาคต มาหารกับจำนวนเงินที่เก็บในแต่ละวัน ซึ่งจะได้จำนวนวันมา จากนั้นนำมาหาว่าต้องใช้ประมาณ กี่ปี กี่เดือน กี่วัน เพื่อให้ดูง่ายขึ้น
            if (int.Parse(Amout_to_collect.Text) > 0 && int.Parse(daily_amount_to_collect.Text) > 0)
            { 
                int day = int.Parse(Amout_to_collect.Text) / int.Parse(daily_amount_to_collect.Text);
                int year = day / 365;
                int yearmodday = day % 365;
                int month = yearmodday / 30;
                int monthmodday = yearmodday % 30;
                MessageBox.Show("About " + year.ToString() + " Year " + month.ToString() + " Month " + monthmodday.ToString() + " Day ");
            }
            // เมื่อใส่ข้อมูลผิดพลาดอย่างเช่น เงินติดลบ ก็จะขึ้นข้อความว่า Wrong!! เพื่อแสดงถึงข้อมูลที่ผิดพลาด
            else
            {
                MessageBox.Show("Wrong!!");
            }

        }
        private void Button_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}
