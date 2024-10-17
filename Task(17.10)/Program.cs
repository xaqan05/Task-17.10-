namespace Task_17._10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department(1, 20);

            bool condition = false;

            string input;

            string empName;
            string empSurName;
            int empAge;
            int empDepNo;
            double empSalary;

            int empId;
            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("1.Isci elave etmek ucun 1 secin.");
                Console.WriteLine("2.Departmendeki iscileri id-ye gore filterlemek ucun 2 secin.");
                Console.WriteLine("3.Departmendeki iscileri maasa gore filterlemek ucun 3 secin.");
                Console.WriteLine("4.Departmendeki iscileri department no gore filterlemek ucun 4 secin.");
                Console.WriteLine("5.Isciler haqqinda melumat elde etmek ucun 5 secin.");
                Console.WriteLine("Cixis etmek ucun 0 secin.");

                Console.WriteLine(" ");

                Console.WriteLine("Zehmet olmasa qiymet daxil edin:");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Zehmet olmasa isci adini daxil edin:");
                        empName = Console.ReadLine().Trim();

                        Console.WriteLine(" ");

                        Console.Write("Zehmet olmasa isci soyadi daxil edin:");
                        empSurName = Console.ReadLine().Trim();

                        Console.WriteLine(" ");

                        bool isMile;
                        do
                        {
                            Console.Write("Isci yasini daxil edin:");
                            isMile = int.TryParse(Console.ReadLine(), out empAge);
                        } while (!isMile);


                        Console.WriteLine(" ");

                        do
                        {
                            Console.Write("Zehmet olmasa isci maasini daxil edin:");

                            isMile = double.TryParse(Console.ReadLine(), out empSalary);
                        } while (!isMile);

                        Console.WriteLine(" ");

                        do
                        {
                            Console.Write("Zehmet olmasa isci department no daxil edin:");

                            isMile = int.TryParse(Console.ReadLine(), out empDepNo);
                        } while (!isMile);


                        Employee emp = new Employee(empName, empSurName, empAge, empDepNo, empSalary);

                        department.AddEmployee(emp);

                        Console.WriteLine(" ");

                        Console.WriteLine("Daxil etdiyiniz isci ugurla sisteme elave olundu.");

                        Console.WriteLine(" ");

                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine(" ");
                        Console.Write("Zehmet olmasa axtarmaq istediyiniz id daxil edin:");
                        empId = int.Parse(Console.ReadLine());

                        Employee employee = (department.getEmployee(empId));
                        if (employee != null)
                        {
                            department.GetEmpInfo(employee);
                        }
                        else
                        {
                            Console.WriteLine("Isci tapilmadi!!");
                        }
                        break;


                    case "3":
                        Console.Clear();
                        Console.WriteLine(" ");
                        Console.Write("Zehmet olmasa axtarmaq istediyiniz maasi daxil edin:");
                        double employeeSalary = double.Parse(Console.ReadLine());

                        Employee employee1 = (department.getEmpsBySalary(employeeSalary));
                        if (employee1 != null)
                        {
                            department.GetEmpInfo(employee1);
                        }
                        else
                        {
                            Console.WriteLine("Isci tapilmadi!!");
                        }
                        break;
                    case "4":
                        /*Console.WriteLine(" ");
                        Console.WriteLine("Zehmet olmasa department nomresi daxil edin:");
                        int empDepartmentNo = int.Parse(Console.ReadLine());

                        Employee employee2 = department.GetAllEmpByDepNo(empDepartmentNo);

                        department.*/
                        Console.Clear();
                        Console.WriteLine("Mueyyen sebeblerden heleki bu secim islemir,zehmet olmasa basqa secim edin.");
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine(" ");
                        department.getAllEmp();
                        
                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine(" ");
                        Console.WriteLine("Proqramdan cixilir...");
                        condition = !condition;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Yanlis secim etdiniz,zehmet olmasa ancaq verilen sertlerden secim edin.");
                        break;
                }


            } while (!condition);

        }
    }
}
