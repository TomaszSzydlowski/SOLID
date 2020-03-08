namespace LiskovSubstitutionPrinciple
{
    class Drink : TypeProduct
    {
        public int NumberDrinks { get; set; }

        public override void GetTypeProductsCount(int quantity)
        {
            NumberDrinks += quantity;
        }

        public override int ReturnQuantityLiter()
        {
            return QuantityLiter;
        }
    }
}
