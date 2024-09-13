using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DekartSystPoint1
{
    public partial class DeckartSyst : Form
    {   
        // Змінні для збереження координат точки
        private double x;
        private double y;
        public DeckartSyst()
        {
            InitializeComponent();

            // Підключення події Paint для PictureBox
            pbgr.Paint += new PaintEventHandler(pbgr_Paint);
        }

        private void DeckartSyst_Load(object sender, EventArgs e)
        {
            
        }

        // Обробка події натискання на кнопку
        private void btCalc_Click(object sender, EventArgs e)
        { 

            // Перевіряємо коректність введення для координати X
            bool isXValid = double.TryParse(tbX.Text, out x);
            // Перевіряємо коректність введення для координати Y
            bool isYValid = double.TryParse(tbY.Text, out y);

            // Якщо обидві координати коректні, продовжуємо
            if (isXValid && isYValid)
            {
                // Створюємо точку
                Points point = new Points(x, y);

                // Визначаємо чверть
                string position = point.WhereIs();

                // Виводимо результат у MessageBox
                MessageBox.Show($"Точка знаходиться {position}");

                // Відображаємо точку на графіку
                pbgr.Invalidate();
            }
            else
            {
                // Якщо введені дані некоректні, виводимо повідомлення про помилку
                MessageBox.Show("Помилка введення даних! Введіть коректні числові значення для X і Y.");
            }
        }
        
        // Метод для відображення точки на графіку
        private void DrawPointOnGr(Graphics g, double x, double y)
        {
            // Очищаємо поле для малювання
            g.Clear(Color.White);

            // Малюємо осі
            Pen axisPen = new Pen(Color.Black);
            int centerX = pbgr.Width / 2;
            int centerY = pbgr.Height / 2;

            // Вертикальна вісь
            g.DrawLine(axisPen, centerX, 0, centerX, pbgr.Height);

            // Горизонтальна вісь
            g.DrawLine(axisPen, 0, centerY, pbgr.Width, centerY);

            // Масштаб для відображення від 0 до 500, видно точки від 0 до 250, адалі виходить за межі, можна змінювати масштаб
            double scaleX = pbgr.Width / 500.0;   // Ширина PictureBox поділена на 500
            double scaleY = pbgr.Height / 500.0;  // Висота PictureBox поділена на 500


            // Визначення кольору в залежності від чверті
            Brush brush = Brushes.Black;
            if (x > 0 && y > 0) brush = Brushes.Aqua;         // Перша чверть
            else if (x < 0 && y > 0) brush = Brushes.Coral;   // Друга чверть
            else if (x < 0 && y < 0) brush = Brushes.Fuchsia; // Третя чверть
            else if (x > 0 && y < 0) brush = Brushes.Gold;    // Четверта чверть

            // Позиція точки на графіку
            int posX = centerX + (int)(x * scaleX);
            int posY = centerY - (int)(y * scaleY);  // Перевертаємо вісь Y

            // Виводимо координати для перевірки
            Console.WriteLine($"posX: {posX}, posY: {posY}");

            // Перевіряємо, чи точка в межах PictureBox
            if (posX >= 0 && posX <= pbgr.Width && posY >= 0 && posY <= pbgr.Height)
            {
                // Малюємо точку
                g.FillEllipse(brush, posX - 5, posY - 5, 10, 10);
            }
        
        }
        // Обробка події Paint для PictureBox
        private void pbgr_Paint(object sender, PaintEventArgs e)
        {
            DrawPointOnGr(e.Graphics, x, y);
        }
       
    }
    
}
