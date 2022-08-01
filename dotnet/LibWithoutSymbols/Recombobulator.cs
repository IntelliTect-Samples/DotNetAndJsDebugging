namespace LibWithoutSymbols
{
    public class Recombobulator
    {
        public Recombobulator(string discombobulatedData)
        {
            DiscombobulatedData = discombobulatedData;
        }

        public string DiscombobulatedData { get; }

        public string Recombobulate()
        {
            if (DiscombobulatedData.Contains("e"))
            {
                throw new InvalidOperationException("This is a completely unhelpful message about what you did wrong to the recombobulator.");
            }

            return new string(DiscombobulatedData.Reverse().ToArray());
        }
    }
}