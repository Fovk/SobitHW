namespace JdHw
{
    public class Vagon
    {
        public VagonType VagonType { get; set; } = 0;
        public Polka Polka { get; set; } = 0;
        public Vagon()
        {
            VagonType = new VagonType();
            Polka = new Polka();
        }
    }
}