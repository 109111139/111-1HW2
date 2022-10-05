# 第2次作業-作業-HW2
>
>學號：109111139 
><br />
>姓名：繆昊廷 
><br />
>作業撰寫時間：90mins
><br />
>最後撰寫文件日期：2022/10/6
>

本份文件包含以下主題：(至少需下面兩項，若是有多者可以自行新增)
- [x]說明內容
- [x]個人認為完成作業須具備觀念

## 說明程式與內容


下段程式碼則為使用後結果：第一段是將10個索引值放入ia_Mindex，然後建立10*10的二維陣列，然後將每一格代入字串0。
第二段是將ia_Mindex的左上角，判斷是否大於等於0，然後+1。
第三段是將ia_MIndex除以10直的取整數，橫的取餘數，然後宣告為地雷。
第四段是將每一格的a和b輸出，b執行完就換行，然後重複10次。


```csharp
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
```


下段程式碼則為使用後結果：無

```html
<%@ Page Language="C#" AutoEventWireup="true" ...>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" ...>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
```


## 個人認為完成作業須具備觀念

一開始看老師的影片，然後自己做作業的時候，執行結果都不會加一，後來才發現是從上執行到下面，所以把輸出移到最後一段，也因為這樣，我把地雷的宣告移到第三段，因為在加一的時候，有一個地方是地雷旁邊還有地雷，如果加一會出問題，所以加一完再宣告地雷。

