namespace PrimalCivilisation
{
    interface IGameResource
    {
        double Value { get; set; }
        int Max { get; set; }
        void Add(double value);
    }
}
