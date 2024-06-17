using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        Job job2 = new Job();
        Resume jobList = new Resume();

        job1._jobTitle = "Software Developer";
        job1._company = "Microsoft";
        job2._company = "Google";
        job1._startYear = 2010;
        job1._endYear = 2015;
        Console.WriteLine($"{job1._company} {job2._company}");
        job1.Display();

        jobList._name = "John Doe";
        jobList._jobs.Add(job1);
        jobList._jobs.Add(job2);

        jobList.Display();

    }
}