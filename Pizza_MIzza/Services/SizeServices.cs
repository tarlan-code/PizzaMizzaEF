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
    static class SizeServices
    {
        public static void CreateAdd(string name,int pizzaId)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Sizes.Add(new Size()
                {
                    Name = name,
                    PizzaId = pizzaId
                });
                context.SaveChanges();
                Console.WriteLine("Size elave olundu");
            }
        }

        public static List<Size> GetAll()
        {
            List<Size> list = null;
            using (AppDbContext context = new AppDbContext())
            {
                list = context.Sizes.Include("Pizza").ToList();
            }
            return list;
        }

        public static Size GetById(int id)
        {
            Size ingredient = null;
            using (AppDbContext context = new AppDbContext())
            {
                ingredient = context.Sizes.Include("Pizza").FirstOrDefault(i => i.Id == id);

            }
            return ingredient;
        }

        public static void Update(int id, string name)
        {
            Size ingredient = null;
            using (AppDbContext context = new AppDbContext())
            {
                ingredient = context.Sizes.FirstOrDefault(i => i.Id == id);

                if (ingredient != null)
                {
                    context.Sizes.Update(ingredient);
                    ingredient.Name = name;
                    context.SaveChanges();
                    Console.WriteLine($"{id} Id-li Size update oldu");

                }

                else Console.WriteLine("Bu Id ye uygun Size yoxdur");
            }
        }

        public static void Delete(int id)
        {
            Size existed = null;
            using (AppDbContext context = new AppDbContext())
            {

                existed = context.Sizes.First(p => p.Id == id);
                if (existed != null)
                {
                    context.Sizes.Remove(existed);
                    context.SaveChanges();
                    Console.WriteLine($"{id}-li Ingredient silindi");
                }

                else Console.WriteLine("Bu Id ye uygun Ingredient yoxdur");
            }
        }
    }
}
