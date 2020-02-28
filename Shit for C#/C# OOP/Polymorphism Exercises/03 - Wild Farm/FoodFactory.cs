namespace WildFarm
{
    using System;

    public class FoodFactory
    {
        public Food GetFood(string[] tokens)
        {
            string foodType = tokens[0].ToLower();

            switch (foodType)
            {
                case "vegetable":
                    return new Vegetable(int.Parse(tokens[1]));
                case "fruit":
                    return new Fruit(int.Parse(tokens[1]));
                case "meat":
                    return new Meat(int.Parse(tokens[1]));
                case "seeds":
                    return new Seeds(int.Parse(tokens[1]));
                default:
                    return null;
            }
        }
    }
}