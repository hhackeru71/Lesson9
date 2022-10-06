using System;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {

            //לקלוט מהשתמש מחרוזת 
            //לבדוק אם במחרוזת קיים האות y
            //במידה וכן יש לשרשר את המחרוזת hello להשתמש בפונקציה Concat
            //אחרת לשרשר את המחרוזת bye
            //להדפיס את המחרוזת 

            CheckString();

            //while (true)
            //{
            //    Console.WriteLine("enter a course");
            //    string str2 = Console.ReadLine();
            //    Console.WriteLine(str2.IndexOf('a'));
            //}

            //לקלוט מהשתמש מחרוזת בגודל לפחות 10
            //במידה והגודל של המחרוזת קטן מ10 לרשום error 
            //ולקלוט מחדש מחרוזת תקינה
            //במידה וקיים האות f
            //יש למחוק את שאר התווים מאינדקס 5
            //אחרת למחוק מאינדס 3
            //להדפיס את המחרוזת

            string str2 = "blsadfdsfForYarin";
            Console.WriteLine(str2.Remove(5));

            Console.WriteLine("enter a course");
            string course = Console.ReadLine();
            
            if (course.IndexOf("y") == -1)
            {
                Console.WriteLine("buy");
            }
            else
            {
                string str1 = "hello ";
                str1 = string.Concat(str1, course);
                Console.WriteLine(str1);
            }

            //string str1 = "hello";
            //str1 = string.Concat(str1, "world");
            //Console.WriteLine(str1);
            
            ////לקלוט מהשתמש מחרוזת לבדוק ע"י פונקציה startwith  
            //אם המחרוזת מתחילה בשם שלכם באנגלית
            //במידה וכן לרשום אוקיי
            //אחרת לרשום לא

            //לקלוט מהשתמש מחרוזת לבדוק ע"י endwith 
            //אם המחרוזת מסתיימת בשם משפחה שלכם
            //אם כן לרשום אוקיי
            //אחרת לרשום לא

            //System.Console.WriteLine("Please enter a string:");
            //string test = Console.ReadLine();

            //if (test.StartsWith("Isaac"))
            //    System.Console.WriteLine("OK");
            //else
            //    System.Console.WriteLine("No");

            //if (test.EndsWith("F"))
            //    System.Console.WriteLine("OK");
            //else
            //    System.Console.WriteLine("No");



            //Console.WriteLine("please enter a string for testing:");
            //string mystr = Console.ReadLine();
            //if(mystr.StartsWith("hello"))
            //{
            //    Console.WriteLine("start");
            //}
            //else
            //{
            //    Console.WriteLine("not start");
            //}

            //if(mystr.EndsWith("world"))
            //{
            //    Console.WriteLine("start");
            //}
            //else
            //{
            //    Console.WriteLine("not start");
            //}




            //Console.WriteLine("please enter a string for testing:");
            //string mystr = Console.ReadLine();

            //if (mystr.IndexOf("la") != -1)
            //{
            //    Console.WriteLine(mystr.Replace("la", "good"));
            //}
            //else
            //{
            //    Console.WriteLine("not good");
            //}



            //- מחרוזת עם רווח בהתחלה  לקלוט מהשתמש מחרוזת באנגלית 
            //לעשות הורדת רווח בהתחלה 
            //להדפיס את המחרוזת
            //לקלוט מחרוזת עם רווח בסוף ולהוריד את הרווח 
            //להדפיס את המחרוזת
            //לקלוט מחרוזת עם רווח בהתחלה וגם בסוף 
            //למחוק את הרווחים בהתחלה ובסוף
            //ולהדפיס את המחרוזת

            //string before = "good morning ,what bla";
            //string after = before.Replace("morning", "night");
            //Console.WriteLine(after);

            //לקלוט מהשתמש מחרוזת 
            //לאחר מכן לבדוק אם במחרוזת קיים מחרוזת la 
            //נשנה את החרוזת la  ל good 
            //אחרת not good
            //להדפיס את המחרוזת

            //string str1 = " yar in ";
            ////str1 = str1.TrimStart();
            //str1 = str1.Trim(); 
            ////str1 = str1.TrimEnd();
            //string str2 = "gg";
            //Console.WriteLine(str1+str2);
            //Console.WriteLine(name);
            ////Console.WriteLine(name.TrimStart());
            //Console.WriteLine(name.TrimEnd());
            //Console.WriteLine(name[0]);
            //Console.WriteLine(name[name.Length-1]);
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //Console.WriteLine(name.ToLower());//
            // Console.WriteLine(name.ToUpper());

            //Console.WriteLine(index);
           // int index = name.IndexOf('a');
            //index = name.IndexOf("ari");
            //Console.WriteLine(index);
            //Console.WriteLine(name.Length);
            //string name2 = "Yaridsfgfdn";
            //Console.WriteLine(name2 == name);
            //Console.WriteLine(name.Equals(name2))
            

        }
        static void CheckString()
        {
            string str = GetStringFromUser();
            while (str.Length < 10)
            {
                str = GetStringFromUser();
            }

            if (str.IndexOf('f') != -1)
            {
                
                string newSt = str.Remove(5);
                Console.WriteLine(newSt);

            }

            else
            {
                string newSt = str.Remove(3);
                Console.WriteLine(newSt);
            }
        }

         static string GetStringFromUser()
        {
            string str;
            Console.WriteLine("Enter a string of length at least 10!");
            str = Console.ReadLine();
            return str;
        }
        
    }
}
