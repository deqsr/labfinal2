using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorka2
{
    class Employee
    {
        private string name = "";
        private string surname = "";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public static void Salarry()
        {
            Console.WriteLine("Choose a position as a Surgeon, Nurse, or Cardiologist");
            string job = Console.ReadLine();
            Console.WriteLine("work experience in years:");
            int experience = int.Parse(Console.ReadLine());
            int s = 22000;
            int n = 10000;
            int c = 15000;
            switch (job)
            {
                case "Surgeon":
                    {
                        Console.WriteLine("you have chosen the profession of a surgeon");
                        if (experience <= 5)
                        {
                            Console.WriteLine($"Salarry {s + 500}");
                            Console.WriteLine($"tax fee:{((s + 500) / 100) * 22}");

                        }
                        else if (experience > 5 && experience <= 10)
                        {
                            Console.WriteLine($"Salarry {s + 2000}");
                            Console.WriteLine($"tax fee:{((s + 2000) / 100) * 22}");
                        }
                        else if (experience > 10 && experience <= 100)
                        {
                            Console.WriteLine($"Salarry {s + 10000}");
                            Console.WriteLine($"tax fee:{((s + 10000) / 100) * 22}");
                        }
                    }
                    break;
                case "Nurse":
                    {
                        Console.WriteLine("you have chosen the profession of a surgeon");
                        if (experience <= 5)
                        {
                            Console.WriteLine($"Salarry {n + 500}");
                            Console.WriteLine($"tax fee:{((n + 500) / 100) * 22}");

                        }
                        else if (experience > 5 && experience <= 10)
                        {
                            Console.WriteLine($"Salarry {n + 1500}");
                            Console.WriteLine($"tax fee:{((n + 1500) / 100) * 22}");
                        }
                        else if (experience > 10 && experience <= 100)
                        {
                            Console.WriteLine($"Salarry {n + 5000}");
                            Console.WriteLine($"tax fee:{((n + 5000) / 100) * 22}");
                        }
                    }
                    break;
                case "Cardiologist":
                    {
                        Console.WriteLine("you have chosen the profession of a nurse");
                        if (experience <= 5)
                        {
                            Console.WriteLine($"Salarry {c + 500}");
                            Console.WriteLine($"tax fee:{((c + 500) / 100) * 22}");
                        }
                        else if (experience > 5 && experience <= 10)
                        {
                            Console.WriteLine($"Salarry {c + 4000}");
                            Console.WriteLine($"tax fee:{((c + 4000) / 100) * 22}");
                        }
                        else if (experience > 10 && experience <= 100)
                        {
                            Console.WriteLine($"Salarry {c + 8000}");
                            Console.WriteLine($"tax fee:{((c + 8000) / 100) * 22}");
                        }
                    }
                    break;

            }
        }
    }
}
