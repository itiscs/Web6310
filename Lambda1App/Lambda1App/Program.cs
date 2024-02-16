namespace Lambda1App
{
    internal class Program
    {

        public delegate int MyOper(int k, int l);
        public delegate void Hellod();
        static void Main(string[] args)
        {
            //var op = new MyOper(ArrOper.Div);
            var op = new Func<int,int,int>(ArrOper.Div);

            //var hello = new Hellod(ArrOper.Hello1);
            var hello = new Action(ArrOper.Hello1);

            int k = op.Invoke(16, 5);
            Console.WriteLine(k);

            op = ArrOper.Sum;

            k = op(16, 5);
            Console.WriteLine(k);

            op = ArrOper.Minus;

            k = op(16, 5);
            Console.WriteLine(k);

            op = delegate (int x, int y)
            {
                return x % y;
            };

            k = op(16, 5);
            Console.WriteLine(k);

            op = (x,y) => 2 * x - y; 

            k = op(16, 5);
            Console.WriteLine(k);



            hello();
            Console.WriteLine("*************************");
            hello += ArrOper.Hello2;
            //hello += ArrOper.Hello2;
            //hello += ArrOper.Hello2;
            //hello += ArrOper.Hello2;
            //hello += ArrOper.Hello2;
            //hello -= ArrOper.Hello1;
            //if(hello != null)
            hello?.Invoke();
            Console.WriteLine("*************************");

            hello += delegate ()
            {
                Console.WriteLine("Anonim method");
            };
            hello += () => Console.WriteLine("Lambda expression");

            hello();

            Console.WriteLine("*************************");

            var arr = new List<int>() { 1,2,3,4,5,13,6,7,8,9,-3,-4,
                    5,5,5,3,9,10};

            var names = new List<string>() { "aaaaa", "bbbbbb", "ccccc" };

            var lst = arr.Where(l => l % 2 == 1).OrderBy(l => l % 3)
                .Skip(4);

            foreach (var x in names.Where(s => s.Length == 5))
                Console.WriteLine(x);
            
            

            


        }
    }
}
