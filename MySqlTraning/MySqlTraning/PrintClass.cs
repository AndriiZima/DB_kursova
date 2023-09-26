using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MySqlTraning
{
    class PrintClass
    {
        public void  Print(string queryName, System.Drawing.Printing.PrintPageEventArgs e, DataGridView dataGridView1)
        {
            // Отримання даних з DataGridView
            DataGridView dataGridView = dataGridView1; // Замініть dataGridView1 на власну DataGridView
            int rowCount = dataGridView.Rows.Count;
            int columnCount = dataGridView.Columns.Count;

            // Налаштування розмірів сторінки
            int pageWidth = e.PageBounds.Width;
            int pageHeight = e.PageBounds.Height;
            int marginLeft = e.MarginBounds.Left;
            int marginTop = e.MarginBounds.Top;

            int cellPadding = 10; // Відступи між комірками
            int rowPadding = 20;
            // Розрахунок ширини стовбців
            int[] columnWidths = new int[columnCount];
            int totalWidth = 50;
            for (int i = 0; i < columnCount; i++)
            {
                columnWidths[i] = dataGridView.Columns[i].Width;
                totalWidth += columnWidths[i];
            }

            // Перевірка, чи потрібно масштабувати стовбці
            if (totalWidth > pageWidth)
            {
                float scaleRatio = (float)pageWidth / totalWidth;
                for (int i = 0; i < columnCount; i++)
                {
                    columnWidths[i] = (int)(columnWidths[i] * scaleRatio);
                }
            }

            // Розрахунок висоти рядків
            int rowHeight = dataGridView.Rows[0].Height + rowPadding;
            int totalHeight = rowHeight * rowCount;

            // Перевірка, чи потрібно масштабувати рядки
            if (totalHeight > pageHeight)
            {
                float scaleRatio = (float)pageHeight / totalHeight;
                rowHeight = (int)(rowHeight * scaleRatio);
            }

            // Відображення даних таблиці на друкованій сторінці
            int x = marginLeft;
            int y = marginTop;
            int x1 = marginLeft;
            int y1 = marginTop;
            // Друк назви запиту
            //string queryName = "Знайти ведучого, прізвище якого починається на літеру А";
            e.Graphics.DrawString(queryName, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(x1, y1));
            y += 100;

            for (int i = 0; i < columnCount; i++)
            {
                Rectangle cellBounds = new Rectangle(x, y, columnWidths[i], rowHeight);
                e.Graphics.FillRectangle(Brushes.LightGray, cellBounds);
                e.Graphics.DrawString(dataGridView.Columns[i].HeaderText, dataGridView.Font, Brushes.Black, cellBounds);
                x += columnWidths[i] + cellPadding;
            }

            y += (2 * rowHeight) + rowPadding;

            for (int j = 0; j < rowCount; j++)
            {
                x = marginLeft;

                for (int i = 0; i < columnCount; i++)
                {
                    Rectangle cellBounds = new Rectangle(x, y, columnWidths[i], rowHeight);
                    e.Graphics.FillRectangle(Brushes.White, cellBounds);
                    e.Graphics.DrawString(dataGridView.Rows[j].Cells[i].FormattedValue.ToString(), dataGridView.Font, Brushes.Black, cellBounds);
                    x += columnWidths[i] + cellPadding;
                }

                y += (2 * rowHeight) + rowPadding;
            }

            // Перевірка наявності інших сторінок для друку
            if (y + rowHeight < pageHeight)
                e.HasMorePages = false;
            else
                e.HasMorePages = true;
        }
    }
}
