namespace LiskovSubstitutionPrinciple
{
    class Fruit : TypeProduct
    {
        public int NumberFruit { get; set; }

        public override void GetTypeProductsCount(int quantity)
        {
            NumberFruit += quantity;
        }

        public override int ReturnQuantityLiter()
        {
            // What? The weight of fruit is not measured in liters...
            return QuantityLiter;
        }
    }
}
