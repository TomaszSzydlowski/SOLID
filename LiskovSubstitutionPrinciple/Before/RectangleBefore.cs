namespace LiskovSubstitutionPrinciple
{
    public class RectangleBefore
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public RectangleBefore()
        {

        }

        public RectangleBefore(int width, int height)
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
