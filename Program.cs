using System.Text;

string[] product = new string[] { "ruler", "sock", "notebook", "pen", "pencil", "Scotch tape", "scissors", "basket", "needle", "plastic glass", "torch", "perfume", "notebook","toys", "mirror" };
int[] orderbuy= new int[100];
int ordernumber = 0,orderno = 0,orderselect = 0;

do
{
    Console.WriteLine("MOMO 20shop");

    Console.WriteLine("amount = " + ordernumber * 20);
    Console.WriteLine("ordernumber = " + ordernumber);
 
    Console.WriteLine("===========================MENU===========================");

    for (int i = 0; i < product.Length; i++)
    {
        orderno = i + 1;
        Console.WriteLine(orderno + " " + product[i]);
    }

    Console.WriteLine("===========================END BUY SELECT 0 ===========================");
    Console.WriteLine("0 End Buy");
    Console.Write("select menu : ");
    orderselect = Int32.Parse(Console.ReadLine());
    Console.Clear();
    if (orderselect != 0 && ( orderselect>0 && orderselect <=15))
    {
        orderbuy[ordernumber] = orderselect-1;
        ordernumber++;

    }
} while (orderselect != 0);
int payamount = 0;
do
{
    Console.Write("pay amount = ");
    payamount = Int32.Parse(Console.ReadLine());

} while (payamount < ordernumber * 20);
int change = payamount - ordernumber * 20;
int b100 = change/100;
int b50 = change%100/50;
int b20 = change%100%50/20;
int b10 = change%100%50%20/10;
int b5 = change%100%50%20%10/5;
int b1 = change%100%50%20%10%5 ;
Console.Clear();
Console.WriteLine("===========================BILL===========================");

for (int y = 0; y < ordernumber; y++)
{  
    Console.WriteLine(product[orderbuy[y]]);
}

Console.WriteLine("=======================================================");
Console.WriteLine("paymount = " + payamount);
Console.WriteLine("chang = " + change);
Console.WriteLine("b100 = " + b100);
Console.WriteLine("b50 = " + b50);
Console.WriteLine("b20 = " + b20);
Console.WriteLine("b10 = " + b10);
Console.WriteLine("b5 = " + b5);
Console.WriteLine("b1 = " + b1);







