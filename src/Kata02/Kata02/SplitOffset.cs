namespace CodeKata.Kata02
{
    internal struct SplitOffset
    {
        internal SplitOffset(int position, int[] source)
        {
            this.Offset = position;
            this.Source = source;
        }

        public int Offset { get; }

        public int[] Source { get; }
    }
}
