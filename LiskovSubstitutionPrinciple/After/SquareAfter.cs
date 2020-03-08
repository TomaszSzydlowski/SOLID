namespace LiskovSubstitutionPrinciple
{
    public class SquareAfter : RectangleAfter
    {

        public override int Width
        {
            set { base.Width = base.Height = value; }
        }
        public override int Height
        {
            set { base.Height = base.Width = value; }
        }
    }
}
