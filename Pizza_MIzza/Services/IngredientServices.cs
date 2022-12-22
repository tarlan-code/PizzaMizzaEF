using Microsoft.EntityFrameworkCore;
using Pizza_MIzza.DLA;
using Pizza_MIzza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_MIzza.Services
{
    static class IngredientServices
    {
        public static void CreateAdd(string name,int pizzaId)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Ingredients.Add(new Ingredient()
                {
                    Name = name,
                    PizzaId = pizzaId
                });
                context.SaveChanges();
                Console.WriteLine("Ingredient elave olundu");
            }
        }

        public static List<Ingredient> GetAll()
        {
            List<Ingredient> list = null;
            using (AppDbContext context = new AppDbContext())
            {
                list = context.Ingredients.Include("Pizza").ToList();
            }
            return list;
        }

        public static Ingredient GetById(int id)
        {
            Ingredient ingredient = null;
            using (AppDbContext context = new AppDbContext())
            {
                ingredient = context.Ingredients.Include("Pizza").FirstOrDefault(i => i.Id == id);

            }
            return ingredient;
        }

        public static void Update(int id, string name)
        {
            Ingredient ingredient = null;
            using (AppDbContext context = new AppDbContext())
            {
                ingredient = context.Ingredients.FirstOrDefault(i => i.Id == id);

                if (ingredient != null)
                {
                    context.Ingredients.Update(ingredient);
                    ingredient.Name = name;
                    context.SaveChanges();
                    Console.WriteLine($"{id} Id-li Ingredient update oldu");

                }

                else Console.WriteLine("Bu Id ye uygun Ingredient yoxdur");
            }
        }

        public static void Delete(int id)
        {
            Ingredient existed = null;
            using (AppDbContext context = new AppDbContext())
            {

                existed = context.Ingredients.First(p => p.Id == id);
                if (existed != null)
                {
                    context.Ingredients.Remove(existed);
                    context.SaveChanges();
                    Console.WriteLine($"{id} Id li Ingredient silindi");
                }

                else Console.WriteLine("Bu Id ye uygun Ingredient yoxdur");
            }
        }
        }
}
