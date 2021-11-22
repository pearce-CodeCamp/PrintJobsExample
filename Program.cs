using System;
using System.Collections.Generic;

namespace PrintJobsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // in A1, the data that fills our list of dictionaries is our job data from the csv file
            // The list is the whole list of jobs, each dictionary is a job row in our list
            // Each key of each dictionary is a column in the list (name, location, etc...)
            // Each value is the actual name of a particular dictionary
            // Our goal is to print each key value pair of each dictionary
            // In human terms, print all the information about each job
            // A List of Dictionaries behaves a lot like an array of objects is JS
            
            // all keys and all values in these dictionaries will be strings
            // based on these variable typings
            Dictionary<string, string> pearce = new Dictionary<string, string>();
            pearce.Add("name", "Pearce Odegard");
            pearce.Add("role", "TA");
            Dictionary<string, string> todd = new Dictionary<string, string>();
            todd.Add("name", "Todd Romkema");
            todd.Add("role", "Student");
            Dictionary<string, string> claire = new Dictionary<string, string>();
            claire.Add("name", "Claire Troxell");
            claire.Add("role", "Student");

            List<Dictionary<string, string>> people = new List<Dictionary<string, string>>();
            people.Add(pearce);
            people.Add(todd);
            people.Add(claire);

            // let's just loop through the key/value pairs of just the pearce dictionary
            /*foreach (KeyValuePair<string, string> keyValuePair in pearce)
            {
                Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
            }

            // looping through the other 2 dictionaries gets redundant
            // nesting this loop functionality into the foreach in our PrintListOfDictionaries method
            // will make this code much dryer
            foreach (KeyValuePair<string, string> keyValuePair in todd)
            {
                Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
            }

            foreach (KeyValuePair<string, string> keyValuePair in claire)
            {
                Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
            }*/
            // invoking the method and passing in the people list of dictionaries
            PrintListOfDictionaries(people);
        }

        // print off all the data from all of the dictionaries inside whatever list we pass in to this method
        static void PrintListOfDictionaries(List<Dictionary<string, string>> someList)
        {
            // if someList is empty, we need to print some feedback to the console letting us know it is empty
            if (someList.Count == 0) 
            {
                Console.WriteLine("No people in the list :(");
            }
            else
            {
                foreach (Dictionary<string, string> person in someList)
                {
                    // person is each dictionary in our list
                    // this way is on the right path, but we want to not have to hard code
                    // so many print statements
                    /*Console.WriteLine("-----");
                    Console.WriteLine($"name: {person["name"]}");
                    Console.WriteLine($"role: {person["role"]}");*/
                    // loop through each dictionary and print out each key/value pair in each dictionary
                    // instead of hard coding the print statements for each key/value pair
                    foreach (KeyValuePair<string, string> keyValuePair in person)
                    {
                        Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
                    }
                }
            }
            
        }
    }
}
