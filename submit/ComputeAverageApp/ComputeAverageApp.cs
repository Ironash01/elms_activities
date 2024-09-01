using System;

namespace ComputeAverageApp {
    class ComputeAverageProgram {

        double [] input_grades = new double [5];
        int query_status = 1;
        double sum;
            // query
        static double result;
        String [] queryList = new String[2];

        bool verifyGrade(double grade) {
            if (grade > 100) {
                return false;
            } else if (grade <= 100) {
                return true;
            } else {
                return false;
            }
        }
        void promptGrades() {
            
            queryList[0] = "Enter five grades";
            Console.WriteLine(queryList[0]);
            for (int i = 0; i < input_grades.Length; i++) {
                queryList[1] = "Enter ["+ query_status + "] grade: ";
    
                Console.Write(queryList[1]);
                input_grades[i] = Convert.ToDouble(Console.ReadLine());
                if (verifyGrade(input_grades[i]) == true) {
                    ;
                } else {
                    Console.WriteLine("Invalid Grade");
                    Environment.Exit(1);
                }
                query_status++;
            }
        }

        double computeAverage() {
            foreach(double x in input_grades) {
                sum += x;
            }

            return (sum/input_grades.Length);
        }
        static void Main() {
            // Create an object reference for other methods
            ComputeAverageProgram run = new ComputeAverageProgram(); 
    
            run.promptGrades();
            result = run.computeAverage();
            Console.WriteLine("Average: " + result);
            Console.WriteLine("Rounded: " + Math.Round(result));
        }
    }
}