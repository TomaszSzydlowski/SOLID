namespace LiskovSubstitutionPrinciple
{
    abstract class TypeProduct
    {
        public int QuantityLiter { get; set; }
        public abstract void GetTypeProductsCount(int quantity);
        public abstract int ReturnQuantityLiter();
    }
}
