string EmpName = "";
string EmpId = "";
string[] monthsArray = { "July", "August", "September", "October", "November", "December" };
int[] savingArray = new int[monthsArray.Length];


Console.WriteLine("============ Summary of the last 5 Savings ============");
Console.Write("Enter your name : ");
EmpName = Console.ReadLine();
Console.Write("Enter your EmpId: ");
EmpId = Console.ReadLine();

for (int i = 0; i < monthsArray.Length; i++)
{
    Console.Write($"Enter the saving of {monthsArray[i]} month: ");
    savingArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("============ Saving Summary ============");
Console.WriteLine("Employee Name : " + EmpName);
Console.WriteLine("Employee Id : " + EmpId);
Console.WriteLine($"Total savings of last {monthsArray.Length} months :" + savingArray.Sum());
Console.WriteLine($"Avg of last {monthsArray.Length} months : " + savingArray.Average() );
int max = savingArray.Max();
int min = savingArray.Min();
int maxIndex = Array.IndexOf(savingArray, max);
int minIndex = Array.IndexOf(savingArray, min);
Console.WriteLine($"Highest saving was in {monthsArray[maxIndex]}: {max}");
Console.WriteLine($"Lowest saving was in {monthsArray[minIndex]}: {min}");




