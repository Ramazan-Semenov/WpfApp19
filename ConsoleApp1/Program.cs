using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.Name = "22223";
            test.Age = 0;
            var results = new List<ValidationResult>();
            var context = new ValidationContext(test);
            if (!Validator.TryValidateObject(test, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
                Console.WriteLine($"Объект User успешно создан. Name: {test.Name}");

            Console.WriteLine(); // для разделения
            Console.ReadLine();
        }
    }
    public class Test
    {
        [StringLength(6, MinimumLength = 3)]
        public string Name { get; set; }
        [Range(1, 100)]
        public int Age { get; set; }
    }
}
