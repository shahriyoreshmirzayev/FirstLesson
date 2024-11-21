internal class BirinchiDars
{
    public int Eni;
    public int Boyi;
    public int Balandligi;
    public int Yuzasi()
    {
        return Eni * Balandligi;
    }
    public int Perimetri()
    {
        return Boyi + Balandligi + Eni;
    }
}

