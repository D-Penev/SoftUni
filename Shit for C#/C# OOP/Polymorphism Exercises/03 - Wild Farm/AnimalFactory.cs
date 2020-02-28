namespace WildFarm
{
    using System;

    public class AnimalFactory
    {
        public Animal GetAnimal(string[] animalData)
        {
            string animalType = animalData[0].ToLower();

            switch (animalType)
            {
                case "owl":
                    return new Owl(animalData[1], double.Parse(animalData[2]), double.Parse(animalData[3]));
                    
                case "hen":
                    return new Hen(animalData[1], double.Parse(animalData[2]), double.Parse(animalData[3]));
                    
                case "mouse":
                    return new Mouse(animalData[1], double.Parse(animalData[2]), animalData[3]);
                   
                case "dog":
                    return new Dog(animalData[1], double.Parse(animalData[2]), animalData[3]);
                    
                case "cat":
                    return new Cat(animalData[1], double.Parse(animalData[2]), animalData[3], animalData[4]);
                   
                case "tiger":
                    return new Tiger(animalData[1], double.Parse(animalData[2]), animalData[3], animalData[4]);
                   
                default:
                    return null;
                    
            }
        }
    }
}