/* We are making a program for auction with a maximum bid set. The count of bids is variable.
Write a program to trake the max bid as input, then take all bid from auction participants until the max bid is exceeded.
The program should output the corresponding message with the winning bid.

Sample Input:
1600
800
1300
1700

Sample Output:
SOLD: 1700

Explanation:
The first input represents the maximum bid, followed by the bids offered from all particiapants. The last participant suggested a bid (1700) 
which is above the maximum (1600) and won the auction.Thus, that bid is outputted.

Hint: 
In order to make continuous input accpectance you need to use while(true) condition. */

Console.WriteLine("What is the maximum bid?");
double MaxBid = Convert.ToDouble(Console.ReadLine());
double OtherBids;

do
{
    Console.WriteLine("Enter a bid.");
    OtherBids = Convert.ToDouble(Console.ReadLine());

    if (OtherBids > MaxBid)
    {
        Console.WriteLine("SOLD: " + OtherBids);
    }
    else
    {
        Console.WriteLine("Still up for auction.");
    }
}
while ( OtherBids != MaxBid);

Console.WriteLine("Press any key to exit.");
Console.ReadKey();