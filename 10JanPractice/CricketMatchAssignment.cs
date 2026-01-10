// using System;
// class CricketMatch
// {
//    int[] playerScores=new int[5];
//    int currentIndex=0;

//    public void AddPlayerScore(int score)
//     {
//         if(score<0 || score > 50)
//         {
//          	throw new ArgumentException("Invalid score. Score must be between 0 and 50.");
//         }
//         if (currentIndex >= 5)
//         {
//             throw new InvalidOperationException("Cannot add more than 5 player scores.");
//         }
//        playerScores[currentIndex] = score;
//        currentIndex++;
//     }
//     int CalculateTotalScores()
//     {
//         int sum=0;
//        for (int i = 0; i < currentIndex; i++)
//         {
//             sum += playerScores[i];
//         }
//         return sum;
//     }
//     public static void Main(string[] args)
//     {
//     CricketMatch c=new CricketMatch();
//     try{
//     string input=Console.ReadLine();
//     for(int i = 0; i < input.Length; i=i+2)
//             {
//                int score= input[i]-'0';
//                c.AddPlayerScore(score);
//             }
//      int total = c.CalculateTotalScores();
//      Console.WriteLine("Total score of the cricket team: " + total);
//     }
//         catch (ArgumentException e)
//         {
//             Console.WriteLine("Error: " + e.Message);
//         }
//         catch (InvalidOperationException e)
//         {
//             Console.WriteLine("Error: " + e.Message);
//         }
//     }

// }
