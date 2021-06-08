namespace OOP_OperatorOverloading
{//2  + - * /
    public class MC
    {
        int value;

        public  MC(int value)
        {
            this.value = value;
        }

        public static int operator + ( MC mc,int offset)
        {
            return 10+offset;
        }

        public static int operator /(MC mc, MC offset)
        {
            return mc.value / offset.value;
        }

        public static MC operator -(MC mc, int offset)
        {
            return new MC(offset-10);
        }
    }
}
