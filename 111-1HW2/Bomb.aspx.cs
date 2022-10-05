using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW2
{
    public partial class Bomb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] ia_MIndex = new int[10] { 0, 7, 13, 28, 44, 62, 74, 75, 87, 90 };
            char[,] ia_Map = new char[10, 10];
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    ia_Map[a, b] = '0';
                }
            }
                       
            for (int Ct = 0; Ct < 10; Ct++) //a上下 -上 +下 b左右 -左 +右
            {
                int a = ia_MIndex[Ct] / 10;
                int b = ia_MIndex[Ct] % 10;
                
                if ((a - 1) >= 0 && (b - 1) >= 0) //左上
                {
                    int i_tmp = Convert.ToInt32(ia_Map[a - 1, b - 1]);
                    i_tmp++;
                    ia_Map[a - 1, b - 1] = Convert.ToChar(i_tmp);
                }

                if ((a) >= 0 && (b - 1) >= 0) //左
                {
                    int i_tmp = Convert.ToInt32(ia_Map[a, b - 1]);
                    i_tmp++;
                    ia_Map[a, b - 1] = Convert.ToChar(i_tmp);
                    
                }

                if ((a + 1) >= 0 && (b - 1) >= 0) //左下
                {
                    int i_tmp = Convert.ToInt32(ia_Map[a + 1, b - 1]);
                    i_tmp++;
                    ia_Map[a + 1, b - 1] = Convert.ToChar(i_tmp);
                }

                if ((a + 1) < 10 && (b ) >= 0) //下
                {
                    int i_tmp = Convert.ToInt32(ia_Map[a + 1, b ]);
                    i_tmp++;
                    ia_Map[a + 1, b ] = Convert.ToChar(i_tmp);
                }

                if ((a + 1) < 10 && (b + 1) < 10) //右下
                {
                    int i_tmp = Convert.ToInt32(ia_Map[a + 1, b + 1]);
                    i_tmp++;
                    ia_Map[a + 1, b + 1] = Convert.ToChar(i_tmp);
                }

                if ((a ) >= 0 && (b + 1) < 10) //右
                {
                    int i_tmp = Convert.ToInt32(ia_Map[a, b + 1]);
                    i_tmp++;
                    ia_Map[a, b + 1] = Convert.ToChar(i_tmp);
                    
                }

                if ((a - 1) >= 0 && (b + 1) < 10) //右上
                {
                    int i_tmp = Convert.ToInt32(ia_Map[a - 1, b + 1]);
                    i_tmp++;
                    ia_Map[a - 1, b + 1] = Convert.ToChar(i_tmp);
                }

                if ((a - 1) >= 0 && (b) >= 0) //上
                {
                    int i_tmp = Convert.ToInt32(ia_Map[a - 1, b ]);
                    i_tmp++;
                    ia_Map[a - 1, b ] = Convert.ToChar(i_tmp);
                }
            }

            for (int Ct = 0; Ct < 10; Ct++)
            {
                int a = ia_MIndex[Ct] / 10;
                int b = ia_MIndex[Ct] % 10;
                ia_Map[a, b] = '*';
            }


            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    Response.Write(ia_Map[a, b]);
                }
                Response.Write("<br />");
            }


        }
    }
}