using System;

class Program {
    static int cpuChoice(){
        Random rand = new Random(); 
        
        return rand.Next(3);
    }

    static string cpuOutput(int choice){
        switch (choice){
            case 1:
                return "CPU chooses...rock!";

            case 2:
                return "CPU chooses...paper!";

            case 3:
                return "CPU chooses...scissors!";
        }
        return "NULL";
    }
    public static void Main (string[] args) {
        //UI displays choice between CPU or Player
        Console.WriteLine("Would you like to play against a CPU [1] or a second player? [2]");
        int choice = Convert.ToInt32(Console.ReadLine());

        //Check choice
        if (choice == 1){
            Console.WriteLine(cpuOutput(cpuChoice()));
        }
    }
}