using System;
namespace program
{
   public class ATM
    {
        public void balancecheck(int balance)
        {
            Console.WriteLine("Your Balance = "+balance);
        }
        public int debit(int balance)
        {
            int c;
            Console.WriteLine("Enter the amount to debit:");
            c = Convert.ToInt32(Console.ReadLine());
            if(c<=balance)
            {
            balance = balance - c;
            Console.WriteLine("Updated balance of your account = " + balance);
            }
            else
            Console.WriteLine("Insufficient balance ");
            return balance;
        }
        public int credit(int balance)
        {
            int c;
            Console.WriteLine("Enter the amount to credit:");
            c = Convert.ToInt32(Console.ReadLine());
            balance = balance + c;
            Console.WriteLine("Your balance after amount credited is " + balance);
            return balance;
        }
        public void get_info(string Name, int balance , int Acc_no)
        {
            Console.WriteLine("Name=" + Name);
            Console.WriteLine("Balance = "+ balance);
            Console.WriteLine("Account No " + Acc_no);
        }
        static void Main(string[] args)
        {
            int a, Ano, p, Acc_no = 12345, pswd = 123, balance = 50000;
            String Name = "Snahil Singh Dasawat";
            Console.WriteLine("Enter Account No:");
            Ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter password: ");
            p = Convert.ToInt32(Console.ReadLine());
            if(Acc_no==Ano && pswd==p)
            {
                Console.WriteLine("Welcome");
            l:
                ATM A = new ATM();
                Console.WriteLine("Give your choice:");
                Console.WriteLine("1.Check_Balance \n2.Debit \n3.Credit \n4.Get_info");
                a = Convert.ToInt32(Console.ReadLine());
                switch(a)
                {
                    case 1:
                        A.balancecheck(balance);
                        goto l;
                    case 2:
                        balance = A.debit(balance);
                        goto l;
                    case 3:
                        balance = A.credit(balance);
                        goto l;
                    case 4:
                        A.get_info(Name, balance, Acc_no);
                        goto l;
                    case 5:
                        break;
                }
            }
        }
    }
}
