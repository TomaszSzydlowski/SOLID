namespace LiskovSubstitutionPrinciple
{
    public class RectangleAfter
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public RectangleAfter()
        {

        }

        public RectangleAfter(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}:{Width}, {nameof(Height)}:{Height}";
        }
        public int Area() => Width * Height;
    }
}
