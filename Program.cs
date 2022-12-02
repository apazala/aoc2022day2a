internal class Program
{
    private static void Main(string[] args)
    {
        const int diff = 'X'-'A';
        int[] results = new int [26];
        results[diff] = 3; //A X, B Y, C Z
        results[diff+1] = 6; //A Y, B Z
        results[diff-2] = 6; //X C
        int total = 0;
        string[] lines = File.ReadAllLines("input.txt");
        foreach(string line in lines){
            char cP1 = line[0];
            char cP2 = line[2];
            total += 1 + cP2 - 'X';
            total += results[cP2-cP1]; 
        }

        Console.WriteLine(total);
    }
}