using Pizza_MIzza.DLA;
using Pizza_MIzza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_MIzza.Services
{
    static class PizzaServices
    {
        public static void CreateAdd(string name,string img)
        {
            using(AppDbContext context = new AppDbContext())
            {
                context.Pizzas.Add(new Pizza()
                {
                    Name = name,
                    Img = img
                });
                context.SaveChanges();
                Console.WriteLine("Pizza elave olundu");
            }
        }

        public static List<Pizza> GetAll()
        {
            List<Pizza> list = null;
            using(AppDbContext context = new AppDbContext())
            {
                list = context.Pizzas.ToList();
            }
            return list;
        }
        
        public static Pizza GetById(int id)
        {
            Pizza pizza = null;
            using(AppDbContext context = new AppDbContext())
            {
                pizza = context.Pizzas.FirstOrDefault(p => p.Id == id);
            
            }
            return pizza;
        }

        public static void Update(int id,string name,string img)
        {
            Pizza pizza = null;
            using (AppDbContext context = new AppDbContext())
            {
                pizza = context.Pizzas.FirstOrDefault(p => p.Id == id);

                if (pizza != null)
                {
                    pizza.Name = name;
                    pizza.Img = img;    
                    context.SaveChanges();
                    Console.WriteLine($"{id} Id-li Pizza update oldu");

                }

                else Console.WriteLine("Bu Id ye uygun Pizza yoxdur");
            }
        }

        public static void Delete(int id)
        {
            Pizza existed = null;
            using (AppDbContext context = new AppDbContext())
            {
                
                existed = context.Pizzas.First(p => p.Id == id);
                if (existed != null)
                {
                    context.Pizzas.Remove(existed);
                    context.SaveChanges();
                    Console.WriteLine($"{id}-li Pizza silindi");
                }

                else Console.WriteLine("Bu Id ye uygun Pizza yoxdur");
            }
        }

        
    }
}
