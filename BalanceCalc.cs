/*******************************************************************
* Name: Nevaiha Adams
*
* Main application (program) class.
*/
using System.Formats.Asn1;

public class AccountBalance
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nNevaiha - Account Balance Calculations");

        bool cont = true;

        Console.Write("Please enter the starting balance: ");
        decimal startBal = Convert.ToDecimal(Console.ReadLine());

        do
        {  
            try
            {
                Console.Write("Please enter a credit or debit amount (0 to quit): ");
                decimal amt = Convert.ToDecimal(Console.ReadLine());
                if (amt == 0)
                {
                    break;
                }                 
                else if(startBal+amt>0)
                {
                    startBal += amt;
                    Console.WriteLine($"The updated balance is: {startBal:C}");
                }
                else
                {
                    throw new Exception("Error. The amount entered will cause the account to go into the negatives.");
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } while(cont);
    }
}