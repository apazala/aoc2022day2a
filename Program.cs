internal class Program
{
    static int[,] resultsTree = new int[3, 3];
    private static void Init()
    {
        //rock choice
        resultsTree[0, 0] = 1 + 3;
        resultsTree[1, 0] = 1;
        resultsTree[2, 0] = 1 + 6;
        //paper choice
        resultsTree[0, 1] = 2 + 6;
        resultsTree[1, 1] = 2 + 3;
        resultsTree[2, 1] = 2;
        //scissors choice
        resultsTree[0, 2] = 3;
        resultsTree[1, 2] = 3 + 6;
        resultsTree[2, 2] = 3 + 3;
    }
    private static void Main(string[] args)
    {
        Init();
        
        int total = 0;
        string[] lines = File.ReadAllLines("input.txt");
        foreach (string line in lines)
        {
            total += resultsTree[line[0]-'A', line[2]-'X'];
        }

        Console.WriteLine(total);
    }
}