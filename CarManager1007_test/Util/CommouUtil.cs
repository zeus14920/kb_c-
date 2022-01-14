using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager0811.Util
{
    static class CommouUtil
    {
        public static void setRowColor(ListView list, Color bColor1, Color bColor2)
        {
            foreach(ListViewItem item in list.Items)
            {
                if((item.Index % 2) == 0)
                {
                    item.BackColor = bColor1;
                }
                else
                {
                    item.BackColor = bColor2;
                }
            }
        }

        private static void bodyDraw(object sender, DrawListViewItemEventArgs args)
        {
            args.DrawDefault = true;
        }

        // S1172 오류
        // 객체를 보내줘야함으로 예외처리
        private static void headerDraw(object sender, DrawListViewColumnHeaderEventArgs arg,
            Color backColor, Color foreColor)
        {
            using(SolidBrush backBrush = new SolidBrush(backColor))
            {
                arg.Graphics.FillRectangle(backBrush, arg.Bounds);
            }

            using (SolidBrush foreBrush = new SolidBrush(foreColor))
            {
                arg.Graphics.DrawString(arg.Header.Text, arg.Font, foreBrush, arg.Bounds);
            }
        }

        public static void colorListHeader(ListView list, Color backColor, Color foreColor)
        {
            list.OwnerDraw = true;
            list.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(
                (sender, e) => headerDraw(sender, e, backColor, foreColor));
            list.DrawItem += new DrawListViewItemEventHandler(bodyDraw);
        }
    }
}
