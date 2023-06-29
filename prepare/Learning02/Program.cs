using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Web Developer";
        job1._company = "Microsoft";
        job1._startYear = 2018;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Full Stack Developer";
        job2._company = "Accumen";
        job2._startYear = 2021;
        job2._endYear = 2023;

        // job1.Display();
        // job2.Display();

        Resume resume1 = new Resume();
        resume1._candidateName = "Kate Paletta";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
    }
}