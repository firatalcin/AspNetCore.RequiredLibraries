using Open_Closed_Principle;

//BestPractise bestPractise = new BestPractise();
//Console.WriteLine("Salary : " + bestPractise.Calculate(7000, new MiddleSalaryCalculate()));

BestPractise2 bestPractise2 = new BestPractise2();
Console.WriteLine("Salary: " + bestPractise2.Calculate(8500,new MiddleSalaryCalculate().Calculate));