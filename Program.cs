using System;

namespace ConsoleApp2_TopLearn_Method
{
    class Program
    {
        //متدها جلوشون پرانتز دارن و زیر کلاس هستند
        static void Main(string[] args)
        {
            SayHello();


            string UserName = Console.ReadLine();
            SayHello(UserName);


            Say();//    ریترن اجرا نمیشه چون باید دستور بدیم که اجراشه مثل پایین یا بریزیمش توی متغیر ولی باقی کد هاش اجرا میشه
            string say = Say();//اینجا هم فقط ریترن وارد متغیر میشه نه باقی کد ها ولی باقی کد ها اجرا میشوند 
            Console.WriteLine(Say() + say);//اینجا هم متد سِی هم ریترنش اجرا میشود و هم باقی کد هاش و متغیر سِی بعدی چون فقط ریترن واردش شده ریترن اجرا میشود


            string FirstName = Console.ReadLine();
            string LastName = Console.ReadLine();
            Console.WriteLine(Name(FirstName, LastName));
            Console.WriteLine(Name("Ali", "Ajib"));


            Console.WriteLine("Number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Multi(a, b));
            Console.WriteLine(Multi(10, 55));
            int multi = Multi(10, 55);
            int SecondMulti = Multi(a, b);
            Console.WriteLine(multi + " " + SecondMulti);
        }

        public static void SayHello()
        {
            Console.WriteLine("Hello");
        }

        static void SayHello(string UserName) //نمیشه از اسم یکسان برای متد استفاده کرد مگر اینکه ورودی ها نوعشان و یا تعدادشان متفاوت باشد
        {
            Console.WriteLine("Hello" + " " + UserName);
        }
        //هیچ گونه نمیشه متد ووید را درون متغیر ریخت یا دستور به چاپش بدیم مانند متد های ریترن دار با کنسول دات رایت لاین

        static string Say()
        {
            Console.WriteLine("SAY");
            return "Whaaaaat?";
        }

        static string Name(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
        static int Multi(int a, int b)
        {
            return a * b;
        }
    }
}
