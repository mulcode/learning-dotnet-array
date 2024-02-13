class Student
{
    public int Id {get; set;}
    public string Name { get; set;}
    public int Roll { get; set;}
    public string Subject { get; set;}

    public void InfoPrint()
    {
        Console.Write("Student id is:" + Id);
        Console.Write("Student Name is:" + Name);
        Console.Write("Student Roll is:" + Roll);
        Console.Write("Student Subject is:" + Subject);   
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many Data To be Store:");
        int number = Convert.ToInt32(Console.ReadLine());

        Student[] students = new Student[number];

        for(int i = 0; i < number; i++){
            students[i] = new Student();
            Console.Write( i+1 + " Enter Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            students[i].Id = id;

            Console.Write( i+1 +" Enter Name: ");
            string name = Console.ReadLine();
            students[i].Name = name;

            Console.Write(i+1 +" Enter Roll: ");
            int roll = Convert.ToInt32(Console.ReadLine());
            students[i].Roll = roll;

            Console.Write(i+1 + " Enter Subject: ");
            string subject = Console.ReadLine();
            students[i].Subject = subject;
        }
        for(int j = 0; j < number; j++){
            students[j].InfoPrint();
        }
    }
}