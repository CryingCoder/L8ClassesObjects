namespace L8ClassAndObj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students s = new Students("Rone", 33);

            //PRINT OUT THE DATA TYPE ABOVE WITH THE PARAMETERS SUPPLIED
            //Console.WriteLine(s);

            //LIST INITIALIZED FOR CAR CLASS
            List<Students> students = new List<Students>();
            

            students.Add(new Students("Jimmy", 13));
            students.Add(new Students("Hannah Banana", 21));
            students.Add(new Students("Justin", 30));
            students.Add(new Students("Sarah", 53));
            students.Add(new Students("Hannibal", 15));
            students.Add(new Students("Phillip", 16));
            students.Add(new Students("Maria", 63));
            students.Add(new Students("Abe", 33));
            students.Add(new Students("Curtis", 10));


            //LINQ QUERIES TO CHECK ALL CONDITIONS AGAINST LIST
            //DrinkingAge
            List<Students> drinkingAge = students.Where(s => s.StudentAge >= 21).ToList();
            PrintStudents(drinkingAge);
            Console.WriteLine("------------");//FORMATTING

            //Oldest Student
            int oldStudent = students.Max(s => s.StudentAge);
            List<Students> oldestStudent = students.Where(s => s.StudentAge == oldStudent).ToList();
            PrintStudents(oldestStudent);
            Console.WriteLine("------------");//FORMATTING

            //Youngest Student
            List<Students> youngestStudent = students.Where(s => s.StudentAge == oldStudent).ToList();
            int youngStudent = students.Min(s => s.StudentAge);
            PrintStudents(youngestStudent);
            Console.WriteLine("------------");//FORMATTING

            //Oldest under 25
            List<Students> under25 = students.Where(s => s.StudentAge < 25).ToList();
            int max25 = under25.Max(s => s.StudentAge);
            List<Students> max25L = under25.Where(s => s.StudentAge == max25).ToList();
            PrintStudents(max25L);
            Console.WriteLine("------------");//FORMATTING

            //Over 21 and age is even
            List<Students> above21 = students.Where(s => s.StudentAge > 21 && s.StudentAge % 2 == 0).ToList();
            PrintStudents(above21);
            Console.WriteLine("------------");//FORMATTING

            //Teenage Studens (13-19 Inclusive)
            List<Students> teenage = students.Where(s => s.StudentAge <= 19 && s.StudentAge >= 13).ToList();
            PrintStudents(teenage);
            Console.WriteLine("------------");//FORMATTING

            //Name starts with vowel
            char[] vowel = { 'A', 'E', 'I', 'O', 'U' };
            List<Students> vowels = students.Where(s => vowel.Contains(s.Student.First())).ToList();
            PrintStudents(vowels);
            Console.WriteLine("------------");//FORMATTING

            //Order by age ascending
            List<Students> ascending = students.OrderByDescending(s => s.Student).ToList();
            PrintStudents(ascending);
            Console.WriteLine("------------");//FORMATTING


        }

        public static void PrintStudents(List<Students> pupil)
        {
            for (int i = 0; i < pupil.Count; i++)
            {
                Students s = pupil[i];
                Console.WriteLine($"Student:{s.Student} Age:{s.StudentAge}\n");
            }
        }
    }
}