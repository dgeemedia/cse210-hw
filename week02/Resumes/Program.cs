using System;

class Program
{
        static void Main(string[] args)
    {
        // Create first job
        Job job1 = new Job();
        job1._jobTitle   = "Associate, Customer Support";
        job1._company    = "Edutech Network Africa";
        job1._startYear  = 2015;
        job1._endYear    = 2018;

        // Create second
        Job job2 = new Job();
        job2._jobTitle   = "Lead, Customer Service";
        job2._company    = "First Bank of Nigeria Limited";
        job2._startYear  = 2019;
        job2._endYear   = 2025;

        // Build the resume
        Resume myResume = new Resume();
        myResume._name = "Lucky George Olumah";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display everything
        myResume.Display();
    }
}