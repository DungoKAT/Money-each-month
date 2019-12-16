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

namespace Money_Management
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
        /* เมื่อคุณใช้เงินไม่เพียงพอในแต่ละวัน คุณจึงต้องคำนวณเพื่อหาว่าวันๆหนึ่งคุณควรใช้เงินเท่าไร เพื่อให้พอใช้ต่อไปในวันข้างหน้า
         นี่จึงเป็นโปรแกรมที่จะช่วยคำนวณเงินที่คุณควรใช้ในแต่ละวัน */

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            // คำนวณเงินจากเดือนที่ลงท้ายด้วย "คม" หรือมี 31 วัน
            if (int.Parse(Money_now.Text) > 0 && int.Parse(Date_of_month.Text) <= 31 && int.Parse(Date_of_month.Text) >= 1 && (int.Parse(Month.Text) == 1 || int.Parse(Month.Text) == 3 || int.Parse(Month.Text) == 5 || int.Parse(Month.Text) == 7 || int.Parse(Month.Text) == 8 || int.Parse(Month.Text) == 10 || int.Parse(Month.Text) == 12))
            {// คำนวณเงินที่ควรใช้ในแต่ละวัน โดยการนำเงินที่มีอยู่ ณ ปัจจุบันหารแบบปัดเศษด้วยจำนวนวันที่เหลือของเดือน(รวมวันที่ใส่ด้วย)
                int money_each_day = int.Parse(Money_now.Text) / (31-int.Parse(Date_of_month.Text)+1);
                MessageBox.Show("Money that should be spent each day : " + money_each_day.ToString());
            }

            // คำนวณเงินจากเดือนที่ลงท้ายด้วย "ยน" หรือมี 30 วัน
            else if (int.Parse(Money_now.Text) > 0 && int.Parse(Date_of_month.Text) <= 30 && int.Parse(Date_of_month.Text) >= 1 && (int.Parse(Month.Text) == 4 || int.Parse(Month.Text) == 6 || int.Parse(Month.Text) == 9 || int.Parse(Month.Text) == 11))
            {// คำนวณเงินที่ควรใช้ในแต่ละวัน โดยการนำเงินที่มีอยู่ ณ ปัจจุบันหารแบบปัดเศษด้วยจำนวนวันที่เหลือของเดือน(รวมวันที่ใส่ด้วย)
                int money_each_day = int.Parse(Money_now.Text) / (30 - int.Parse(Date_of_month.Text) + 1);
                MessageBox.Show("Money that should be spent each day : " + money_each_day.ToString());
            }

            // คำนวณเงินจากเดือนกุมภาพันธ์ที่มี 28 วัน #จริงๆมีปีอธิกสุรทินด้วย แต่ไม่ได้แก้ปัญหาตรงนี้
            else if (int.Parse(Month.Text) == 2 && int.Parse(Money_now.Text) > 0 && int.Parse(Date_of_month.Text) <= 28 && int.Parse(Date_of_month.Text) >= 1)
            {// คำนวณเงินที่ควรใช้ในแต่ละวัน โดยการนำเงินที่มีอยู่ ณ ปัจจุบันหารแบบปัดเศษด้วยจำนวนวันที่เหลือของเดือน(รวมวันที่ใส่ด้วย)
                int money_each_day = int.Parse(Money_now.Text) / (28 - int.Parse(Date_of_month.Text) + 1);
                MessageBox.Show("Money that should be spent each day : " + money_each_day.ToString());
            }

            // เมื่อใส่ข้อมูลผิดพลาดอย่างเช่น ใส่เงินติดลบ หรือใส่เดือนที่ไม่มีอยู่จริง หรือใส่วันที่ไม่มีอยู่จริงหรือเกินเดือนนั้นๆ ก็จะขึ้นว่า "Wrong!!" เพื่อแสดงให้รู้ว่าข้อมูลผิดพลาด
            else
            {
                MessageBox.Show("Wrong!!"); 
            }
        }

        private void Button_Loaded(object sender, RoutedEventArgs e)
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
