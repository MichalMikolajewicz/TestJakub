using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Drawing;
using System.Drawing.Text;
using static System.Console;

namespace ConsoleApp1
{
    public interface ITest {
        int WTF { get; }

    }

    public abstract class Test : ITest
    {
        public int WTF1 { get; set; }
        int ITest.WTF => WTF1;
    }
    public class A : Test
    {
    }
    public class Product
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
    public static class Extensions
    {
        public static IEnumerable<string> Cast(this IEnumerable<List<string>> listList)
        {
            return listList.SelectMany(x => x);
        }

    }
    class grpitem
    {
        public string groupCode;
        public string item;
    }

  
    class Program
    {


        static List<grpitem> list123 = new List<grpitem>()
        {
             new grpitem() {groupCode="3", item="b"},
             new grpitem() {groupCode="1", item="b"},
             new grpitem() {groupCode="3", item="c"},
             new grpitem() {groupCode="2", item="b"},
             new grpitem() {groupCode="2", item="a"},
             new grpitem() {groupCode="2", item="c"},
             new grpitem() {groupCode="1", item="a"},
             new grpitem() {groupCode="3", item="a"},
             new grpitem() {groupCode="3", item="d"}
        };
        public static void ConvertToBitmapSource(string name, string text)
        {
            Bitmap bitmap = new Bitmap(500, 500, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(System.Drawing.Color.White);
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(System.Drawing.Color.Black);
            g.DrawString(text, drawFont, drawBrush, 250, 250);
            bitmap.Save(name);
        }

        static void Main(string[] args)
        {
            checked
            {
                int max = 500;
                for (byte i = 0; i < max; i++)
                {
                    WriteLine(i);
                }
            }

            object d = 6.4;
            switch (d)
            {
                case string _:
                    Console.WriteLine("it is string");
                    break;
                case double _:
                    Console.WriteLine("it is double");
                    break;
                case int _:
                    Console.WriteLine("it is int");
                    break;
                default:
                    Console.WriteLine("it is Unknown type");
                    break;
            }
            foreach (var item in Enumerable.Range(1,5))
            {
                if (item > 2)
                {
                    return;
                }
            }

            int a = -1;
            var a1 = int.MaxValue;
            var a2 = int.MaxValue;
            //var dsacxzxz = checked(a1 + a2);
            var x1 = a++;
            var x2 = ++a;
            //ConvertToBitmapSource(args.First(), args.Last());

            var abc = Enumerable.Range(1, 10);

            var simple = abc;
            var sdad = abc.Select((item, index) => new { item, index })
                .GroupBy(x => x.index / 2)
                .Select(g => g.Select(x => x.item).ToList()).ToList();
                
            IEnumerable<List<string>> listListString = new List<List<string>> {new List<string>{"One", "Two", "Three" },
                   new List<string> {"Four", "Five", "Six" },
                   new List<string>{"Seven", "Eight"} }.AsEnumerable();

            var hm = listListString.Cast<string>();
            
            var myArray = new int[,,,]
            {
                {
                    {
                        { 1, 2, 3, 4 },
                        { 3, 4, 4, 4 },
                        { 4, 5, 6, 7 }
                    } 
                }
            };
            var arrayType = myArray.GetType();
            var test = myArray.Cast<int>().Sum();
            var test1 = myArray.Cast<int>().Aggregate((x,y) => x * y);

            var arrSum = (from int val in myArray
                         select val)
                         .Sum();

            Console.WriteLine(arrSum);

             IEnumerable<grpitem> ordered = list123.GroupBy(grp => grp.groupCode)
            .SelectMany(g => g.OrderBy(grp => grp.item));

            var list = new List<Product> { new Product { Category = "C1", Name = "c2", Quantity = 1 }, new Product { Category = "C1", Name = "c2cxz", Quantity = 2 },
                new Product { Category = "C2", Name = "c2ds", Quantity = 6 }, new Product { Category = "C2", Name = "c2dsa", Quantity = 5 } };

            var test321 = list.GroupBy(x => x.Category).SelectMany(x => x.OrderByDescending(y => y.Quantity)).ToList();

        }

    }

}
