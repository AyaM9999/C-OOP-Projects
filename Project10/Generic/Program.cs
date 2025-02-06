namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Mylist<int> list = new Mylist<int>(3);

            list.Add(2);
            list.Add(5);
            list.Add(6);
            list.Add(13);//unvalid! .. unsaved 
            list.Print();

            // 2 5 6 13 => 2 6 13
            list.Remove(5);
            list.Print();

            list.clear();
            list.Print();




            // Generic Stack 


            Stack<double > doubleStack = new Stack<double >();
            doubleStack.Push(3d);
            doubleStack.Push(30.0d);
            doubleStack.Push(300.0d); // accept duplicated data but not nullable values 
            doubleStack.Push(300.0d); // => 300  300 30 3

            foreach (var  dItem in doubleStack)
            {
                Console.WriteLine(dItem);
            }


            Console.WriteLine(doubleStack.Pop());// delete 300 and return it


            foreach (var dItem in doubleStack)
            {
                Console.WriteLine(dItem);
            } //=> 300 30 3


            Console.WriteLine(doubleStack.Peek());//return the item that exist on the top of stack.






            // Genreic list 

            List<String> strList = new List<string>(); // capcity=0
            strList.Add(" C#oop"); // capacity=4
            strList.Add(" Adv oop");// capacity=4
            strList.Add(" SQl db");// capacity=4
            strList.Add(" Non-SQl db");// capacity=4  
            strList.Add(" CST");// capacity=8

            foreach (string str in strList)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine(strList.Count);
            Console.WriteLine(strList.Capacity);

            strList.Remove("C#oop");// do linear search


            foreach (string str in strList)
            {
                Console.WriteLine(str);
            }


        }
    }
}
