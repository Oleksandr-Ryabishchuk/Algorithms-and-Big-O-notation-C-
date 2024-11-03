using Greedy;

List<Item> items = new List<Item>
        {
            new Item(60, 10),
            new Item(100, 20),
            new Item(120, 30)
        };

int capacity = 50;

Console.WriteLine("Maximum value in Knapsack = " + Knapsack.FractionalKnapsack(capacity, items));

string X = "ABCBDAB";
string Y = "BDCABA";

// Find the length of LCS
int lcsLength = LongestCommonSubsequence.FindLCS(X, Y);
Console.WriteLine("Length of LCS: " + lcsLength);

// Print the LCS
string lcsString = LongestCommonSubsequence.GetLCS(X, Y);
Console.WriteLine("LCS: " + lcsString);