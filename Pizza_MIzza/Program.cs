using Pizza_MIzza.Models;
using Pizza_MIzza.Services;

using System;

namespace Pizza_MIzza
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Pizza CRUD
            /*PIZZA ADD*/

            //PizzaServices.CreateAdd("Marqarita", "1.png");
            //PizzaServices.CreateAdd("Vegetarian", "2.png");
            //PizzaServices.CreateAdd("Fungi Kon Pollo", "3.png");
            //PizzaServices.CreateAdd("Speçiale", "4.png");
            //PizzaServices.CreateAdd("Mista", "5.png");


            /*PIZZA GetById*/
            //Pizza pizza = PizzaServices.GetById(1);

            //if (pizza != null)
            //{
            //    Console.WriteLine($"{pizza.Name}  {pizza.Img}");
            //}

            //else Console.WriteLine("Bu Id ye uygun Pizza yoxdur");


            /*PIZZA UPDATE*/
            //PizzaServices.Update(1, "Tonno e Cipolla", "13.png");

            /*PIZZA DELETE*/
            //PizzaServices.Delete(6);


            /*PIZZA Get All*/
            //foreach (Pizza p in PizzaServices.GetAll())
            //{
            //    Console.WriteLine($"{p.Id}.{p.Name}  {p.Img}");

            //}
            #endregion

            #region Ingredient CRUD
            /*Ingredient Add*/
            //IngredientServices.CreateAdd("Pomidor",1);
            //IngredientServices.CreateAdd("Pizza sous",2);
            //IngredientServices.CreateAdd("Gouda pendiri",2);
            //IngredientServices.CreateAdd("Toyuq filesi",1);
            //IngredientServices.CreateAdd("Qarğıdalı",3);
            //IngredientServices.CreateAdd("Qırmızı soğan",4);


            /*Ingredient GetById*/
            //Ingredient ing = IngredientServices.GetById(3);

            //if (ing is not null) Console.WriteLine($"{ing.Id}. {ing.Name}  {ing.Pizza.Name}");

            /*Ingredient Update*/
            //IngredientServices.Update(3, "Sucuk");

            /*Ingredient Delete*/
            //IngredientServices.Delete(5);

            /*Ingredient GetAll*/
            //foreach (Ingredient ing in IngredientServices.GetAll())
            //{
            //    Console.WriteLine($"{ing.Id}.{ing.Name} {ing.Pizza.Name}");
            //}
            #endregion


            #region Size CRUD
            /*Size Add*/
            //SizeServices.CreateAdd("Small", 1);
            //SizeServices.CreateAdd("Medium", 2);
            //SizeServices.CreateAdd("Large", 4);

            /*Size GetById*/
            //Size sz = SizeServices.GetById(3);

            //if (sz is not null) Console.WriteLine($"{sz.Id}. {sz.Name}  {sz.Pizza.Name}");


            /*Size Update*/
            //SizeServices.Update(3, "L");



            /*Size Delete*/
            //SizeServices.Delete(3);



            /*Size GetAll*/
            //foreach (Size size in SizeServices.GetAll())
            //{
            //    Console.WriteLine($"{size.Id}.{size.Name}  {size.Pizza.Name}");
            //}
            #endregion


        }
    }
}

