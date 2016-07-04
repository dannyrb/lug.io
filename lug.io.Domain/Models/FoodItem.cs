using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lug.io.Domain.Enumerations;

namespace lug.io.Domain.Models
{
    public class FoodItem
    {
        public int Id { get; set; }

        // Value
        public string Name { get; set; }
        public string AlternateNames { get; set; }
        public double Quantity { get; set; }
        public Unit DefaultUnit { get; set; }


        // Nutrition
        public int Calories { get; set; }
        public double Fat { get; set; }
        public double SaturatedFat { get; set; }
        public double MonounsaturatedFat { get; set; }
        public double PolyunsaturatedFat { get; set; }
        public double Cholesterol { get; set; }
        public double Sodium { get; set; }
        public double Potassium { get; set; }
        public double Carbohydrate { get; set; }
        public double DietaryFiber { get; set; }
        public double Sugar { get; set; }
        public double Protein { get; set; }

        // Vitamins (%) (Switch to list?)
        public double VitaminA { get; set; }
        public double VitaminC { get; set; }
        public double Calcium { get; set; }
        public double Iron { get; set; }

    }
}
