namespace _2Darray
{
    public class Program
    {
        public static int[] FindStudentsRank(int[,] stdMarks)
        {
            int numStudents = stdMarks.GetLength(0); 
            int[] totalMarks = new int[numStudents]; 
            int[] ranks = new int[numStudents]; 

            for (int i = 0; i < numStudents; i++)
            {
                int sum = 0;
                for (int j = 0; j < 5; j++)
                {
                    sum += stdMarks[i, j];
                }
                totalMarks[i] = sum;
            }
            for (int i = 0; i < numStudents; i++)
            {
                ranks[i] = 1; 
                for (int j = 0; j < numStudents; j++)
                {
                    if (totalMarks[i] < totalMarks[j])
                    {
                        ranks[i]++; 
                    }
                }
            }

            return ranks;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students:");
            int numStudents = int.Parse(Console.ReadLine());

            int[,] studentMarks = new int[numStudents, 5];

            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Enter marks for Student {i + 1}:");
                for (int j = 0; j < 5; j++)
                {
                    studentMarks[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[] ranks = FindStudentsRank(studentMarks);

            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Rank of student {i + 1} is {ranks[i]}");
            }
        }
    }
}
