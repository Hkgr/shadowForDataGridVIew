using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            dataGridView1.CellPainting += dataGridView1_CellPainting;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.table_1TableAdapter.Fill(this.tESTINGDataSet2.Table_1);
            this.table_1TableAdapter1.Fill(this.tESTINGDataSet1.Table_1);
            this.table_1TableAdapter.Fill(this.tESTINGDataSet.Table_1);

            dataGridView1.CellPainting += dataGridView1_CellPainting;

        }

        public class CellTarget
        {
            public int RowIndex { get; set; }
            public int ColumnIndex { get; set; }
            public string TargetWord { get; set; }
            public Color ShadowColor { get; set; }
            public bool IsBold { get; set; }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // قائمة الخلايا المستهدفة والكلمات المستهدفة
            List<CellTarget> targets = new List<CellTarget>
    {
        new CellTarget { RowIndex = 3, ColumnIndex = 3, TargetWord = "this", ShadowColor = Color.DarkCyan, IsBold = true },
        new CellTarget { RowIndex = 3, ColumnIndex = 3, TargetWord = "text", ShadowColor = Color.Red, IsBold = true },
        new CellTarget { RowIndex = 2, ColumnIndex = 2, TargetWord = "R", ShadowColor = Color.Red, IsBold = false },
        new CellTarget { RowIndex = 1, ColumnIndex = 2, TargetWord = "R", ShadowColor = Color.Blue, IsBold = true }

    };

            foreach (var target in targets)
            {
                if (e.RowIndex == target.RowIndex && e.ColumnIndex == target.ColumnIndex && e.Value != null)
                {
                    string text = e.FormattedValue.ToString();
                    if (text.Contains(target.TargetWord))
                    {
                        // رسم الخلفية الافتراضية للخلية
                        e.PaintBackground(e.CellBounds, true);

                        // إعدادات النص
                        FontStyle fontStyle = target.IsBold ? FontStyle.Bold : FontStyle.Regular;
                        Font textFont = new Font(e.CellStyle.Font, fontStyle);
                        Color textColor = e.CellStyle.ForeColor;
                        TextFormatFlags flags = TextFormatFlags.VerticalCenter | TextFormatFlags.Left;

                        // إيجاد موضع الكلمة المستهدفة داخل النص
                        int startIndex = text.IndexOf(target.TargetWord);
                        if (startIndex >= 0)
                        {
                            // قياس النص قبل الكلمة المستهدفة
                            string beforeWord = text.Substring(0, startIndex);
                            Size beforeSize = TextRenderer.MeasureText(e.Graphics, beforeWord, textFont, e.CellBounds.Size, flags);

                            // قياس الكلمة المستهدفة
                            Size wordSize = TextRenderer.MeasureText(e.Graphics, target.TargetWord, textFont, e.CellBounds.Size, flags);

                            // قياس النص بعد الكلمة المستهدفة
                            string afterWord = text.Substring(startIndex + target.TargetWord.Length);
                            Size afterSize = TextRenderer.MeasureText(e.Graphics, afterWord, textFont, e.CellBounds.Size, flags);

                            // تحديد موضع النص داخل الخلية
                            int textHeight = TextRenderer.MeasureText(e.Graphics, text, textFont, e.CellBounds.Size, flags).Height;
                            Point textLocation = new Point(e.CellBounds.X + 2, e.CellBounds.Y + (e.CellBounds.Height - textHeight));

                            // رسم النص قبل الكلمة المستهدفة
                            TextRenderer.DrawText(e.Graphics, beforeWord, textFont, textLocation, textColor, flags);

                            // رسم الظل
                            Point shadowLocation = new Point(textLocation.X + beforeSize.Width + 2, textLocation.Y + 2);
                            TextRenderer.DrawText(e.Graphics, target.TargetWord, textFont, shadowLocation, target.ShadowColor, flags);

                            // رسم الكلمة المستهدفة
                            Point wordLocation = new Point(textLocation.X + beforeSize.Width, textLocation.Y);
                            TextRenderer.DrawText(e.Graphics, target.TargetWord, textFont, wordLocation, textColor, flags);

                            // رسم النص بعد الكلمة المستهدفة
                            Point afterLocation = new Point(wordLocation.X + wordSize.Width, wordLocation.Y);
                            TextRenderer.DrawText(e.Graphics, afterWord, textFont, afterLocation, textColor, flags);
                        }

                        // منع الرسم الافتراضي
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
