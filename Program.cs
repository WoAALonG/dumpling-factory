using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dumpling_factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double productionLineProductivityPelmenny;
            double productionLineProductivityTesta;
            double productionLineProductivityFarsha;
            double machinePerformancePelmenny;
            double machinePerformanceTesta;
            double machinePerformanceFarsha;

            double dailyOutput; // суточная выработка готовой продукции 
            int shiftTime; // продолжительность рабочей смены
            double massFractionOfDough; //массовая доля теста 
            double massFractionOfMincedMeat; //массовая доля фарша

            //==================== Технологическая линия изготовления пельменей =====================================================================
            Console.WriteLine("Технологическая линия изготовления пельменей.");

            Console.Write("Введите производительность пельменного автомата в т/ч.\n=> ");
            machinePerformancePelmenny = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите суточную выработку готовой продукции в т.\n=> ");
            dailyOutput = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите продолжительность рабочей смены в ч.\n=> ");
            shiftTime = Convert.ToInt32(Console.ReadLine());

            productionLineProductivityPelmenny = dailyOutput / (2 * shiftTime);

            Console.WriteLine("Кол-во автоматов для изготовления пельменей равно: " + Math.Ceiling(productionLineProductivityPelmenny / machinePerformancePelmenny));

            //==================== Технологическая линия подготовки теста =====================================================================
            

            //==================== Технологическая линия подготовки фарша =====================================================================
            

        }
    }
}
