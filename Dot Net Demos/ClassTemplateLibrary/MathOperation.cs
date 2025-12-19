namespace ClassTemplateLibrary
{
    public class MathOperation
    {
        public void add(int a,int b)
        {
            int res = a + b;
            Console.WriteLine($"{a} + {b} = {res}");
        }

        private void sub(int a,int b)
        {
            int res = a - b;
            Console.WriteLine($"{a} - {b} = {res}");
        }

        protected void mul(int a,int b)
        {
            int res = a * b;
            Console.WriteLine($"{a} * {b} = {res}");
        }

        internal void div(int a,int b)
        {
            int res = a / b;
            Console.WriteLine($"{a} / {b} = {res}");
        }

        protected internal void mod(int a,int b)
        {
            int res = a % b;
            Console.WriteLine($"{a} % {b} = {res}");
        }
    }

    public class Math : MathOperation
    {
        public void Math_Wrapper()
        {
            Console.WriteLine("In Math Wrapper.........");
            base.add(1,2);
            base.mul(2,2);
            base.div(2,2);
            base.mod(2,2);
        }
    }
}
