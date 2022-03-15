using System;

namespace HometasksCsharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Verilmis array-deki reqemlerinin cemi 10-dan kicik olan
            //ededlerin sayini tapan alqoritm

            //int[] arr = { 12, 54, 87, 29, 92, 62, 26, 9 };
            //int count = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int num = arr[i];
            //    int sum = 0;
            //    int remainderPart, mainPart;
            //        remainderPart = num % 10;
            //        mainPart = num / 10;
            //        sum = remainderPart + mainPart;
            //    if (sum < 10)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);



            //2. 1-den 8000-dek ededler icerisinde cut olanlarin sayini tapan proqram

            // int count = 0;
            // for(int i=1; i<=8000; i++)
            // {
            //     if (i % 2 == 0)
            //     {
            //         count++;
            //     }
            // }
            //Console.WriteLine(count);



            // 3. Verilmis ededin en yaxin asagi kokalti deyerini tapan alqoritm
            // (ilk ders etdiyimize uygun, misalcun eded 20-dirse 4 qaytarmalidi,
            // 25-dise 5 qaytarmalidi, 16-drisa 4 ve s.)

            int num = 25;

            int i = 2;
            int answer = 1;

            if (num==0 || num == 1)
            {
                Console.WriteLine(num);
            }
            else if(num>1){
                while (i*i <= num)
                {
                    answer = i;
                    i++;
                }
                 
                Console.WriteLine(answer);
            }
            
        }
    }
}