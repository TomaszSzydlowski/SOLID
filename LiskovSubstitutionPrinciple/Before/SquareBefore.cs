namespace LiskovSubstitutionPrinciple
{
    public class SquareBefore : RectangleBefore
    {

        public new int Width
        {
            set { base.Width = base.Height = value; }
        }
        public new int Height
        {
            set { base.Height = base.Width = value; }
        }
    }
}
