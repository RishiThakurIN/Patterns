namespace Factory
{
    internal class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "NY style sauce and cheese pizza";
            dough = "Thin crust dough";
            sauce = "Marinara sauce";

            toppingList.Add("Grated Reggiano cheese");
        }
    }
}