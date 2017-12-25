namespace Chapter11_LinqToObject
{
    public static class StaticCounter
    {
        static int next = 1;

        public static int Next()
        {
            return next++;
        }
    }
}
