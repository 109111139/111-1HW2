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
            for (int Row = 0; Row < 10; Row++)
            {
                for (int Col = 0; Col < 10; Col++)
                {
                    ia_Map[Row, Col] = '0';
                }
            }

            for (int Ct = 0; Ct < 10; Ct++)
            {
                int Row = ia_MIndex[Ct] / 10;
                int Col = ia_MIndex[Ct] % 10;
                ia_Map[Row, Col] = '*';
            }

            for (int Row = 0; Row < 10; Row++)
            {
                for (int Col = 0; Col < 10; Col++)
                {
                    Response.Write(ia_Map[Row, Col]);
                }
                Response.Write("<br />");
            }

            for (int Row = 0; Row < 10; Row++)
            {
                for (int Col = 0; Col < 10; Col++)
                {
                    if (ia_Map[Row, Col] == '*')
                    {
                        continue;
                    }
                    int bombcounter = 0;
                    if ((Row -1) >= 0 && (Col -1) >= 0) //左上
                    {
                        if (ia_Map[Row - 1, Col - 1] == '*')
                        {
                            bombcounter++;
                        }                        
                    }
                    if ((Row - 1) >= 0) //上
                    {
                        if (ia_Map[Row - 1, Col] == '*')
                        {
                            bombcounter++;
                        }
                    }
                    if ((Row - 1) >= 0 && (Col + 1) < 10) //右上
                    {
                        if (ia_Map[Row - 1, Col + 1] == '*')
                        {
                            bombcounter++;
                        }
                    }
                    if ((Col + 1) < 10) //右
                    {
                        if (ia_Map[Row , Col + 1] == '*')
                        {
                            bombcounter++;
                        }
                    }
                    if ((Row + 1) < 10 && (Col + 1) < 10) //右下
                    {
                        if (ia_Map[Row + 1, Col + 1] == '*')
                        {
                            bombcounter++;
                        }
                    }
                    if ((Row + 1) < 10 ) //下
                    {
                        if (ia_Map[Row + 1, Col] == '*')
                        {
                            bombcounter++;
                        }
                    }
                    if ((Row + 1) < 10 && (Col - 1) >= 0) //左下
                    {
                        if (ia_Map[Row + 1, Col - 1] == '*')
                        {
                            bombcounter++;
                        }
                    }
                    if ((Col - 1) >= 0) //左
                    {
                        if (ia_Map[Row , Col - 1] == '*')
                        {
                            bombcounter++;
                        }
                    }
                    ia_Map[Row,Col] = Convert.ToChar(bombcounter);
                }
            }
        }
    }
}