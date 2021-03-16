namespace CodeKata.Kata02
{
    struct SplitOffset
    {
        public SplitOffset(int position, int[] source)
        {
            this.Offset = position;
            this.Source = source;
        }

        public int Offset { get; private set; }

        public int[] Source { get; private set; }
    }
}
