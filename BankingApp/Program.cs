// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;

BuildBankingApp();

void BuildBankingApp()
{
    int choice;
    double DepositAmount;
    double WithdrawelAmount;
    double AccountBalance = 1000.00;

    Console.WriteLine("Please Choose an option");
    Console.WriteLine("=======================");
    Console.WriteLine("1- Deposit or Withdraw Funds");
    Console.WriteLine("2- View Current Account Information");
    Console.WriteLine("Please Choose Between Option 1 and 2");

    choice = Convert.ToInt32(Console.ReadLine());

    if(choice == 1||choice == 2)
    {
        

        //choice = Convert.ToInt32(Console.ReadLine());

        if(choice == 1)
        {
            Console.WriteLine("How much do you want to deposit?");
            Console.WriteLine("Enter the amount including the pence as a decimal point");

            DepositAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The original balance was {0}", AccountBalance);

            AccountBalance += DepositAmount;
            Console.WriteLine("The new balance is now {0}", AccountBalance);

        }
        if (choice == 2)
        {
            Console.WriteLine("How much do you want to withdraw from your account?");
            Console.WriteLine("Enter the amount including the pence as a decimal point");

            WithdrawelAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The original balance was {0}", AccountBalance);
            AccountBalance -= WithdrawelAmount;
            Console.WriteLine("The new balance for your account is {0}", AccountBalance);
        }
    }
    else
    {
        Console.WriteLine("Please choose either option 1 or 2");
        Console.WriteLine("Please Choose an option");
        Console.WriteLine("1- Deposit or Withdraw Funds");
        Console.WriteLine("2- View Current Account Information");
        Console.WriteLine("Please Choose Between Option 1 and 2");
    }
}