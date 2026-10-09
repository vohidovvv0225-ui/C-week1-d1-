
// taski1

// int Factoreal(int a)
// {
//     if(a<=1)
//     {
//         return 1;
//     }
//     return a*Factoreal(a-1);
// }
// int a=Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Factoreal(a));

// ________________________________________________

// taski 2
// int Finobacci(int a)
// {
//     if (a <= 1)
//     {
//         return a;
//     }
//     return Finobacci(a-1)+Finobacci(a-2);
// }
// int a=Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Finobacci(a));

// ________________________________________________

// taski 3
// int Factoreal(int a)
// {
//     if (a <= 1)
//     {
//         return a;
//     }
//     return a*Factoreal(a-2);
// }

// int a=Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Factoreal(a));

// ________________________________________________
// home task

// taski 1
// void   RR(int a)
// {
//     if (a <= 0) return;

//     RR(a-1);
//     System.Console.Write(a + " ");

// }
// int a=Convert.ToInt32(Console.ReadLine());
// RR(a);

// ________________________________________________
// taski 2
// void   RR(int a)
// {
//     if (a <= 0) return;

//     System.Console.Write(a + " ");
//     RR(a-1);


// }
// int a=Convert.ToInt32(Console.ReadLine());
// RR(a);

// ________________________________________________
// taski 3

// int RR(int a)
// {
//     if (a <= 0)
//     {
//         return 0;
//     }

//     return a+RR(a-1);
// }
// int a=Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(RR(a));

// ________________________________________________
// taski 4

// void RR(int a)
// {
//     if (a == 0)
//     {
//         return ;
//     }
//     RR(a/10);
//  System.Console.Write(a%10 + " ");


// }
// int a=Convert.ToInt32(Console.ReadLine());
// RR(a);

// ________________________________________________
// taski 5

// int  RR(int a)

// {

//     if (a == 0)
//     {
//         return 0;
//     }


//   return 1+RR(a/10);



// }
// int a=Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(RR(a));

// ________________________________________________
// taski 6
// void RR(int a, int b)
// {
//     if (a > b)
//     {
//         return ;
//     }
//     if (a % 2 == 0)
//     {
//         System.Console.Write(a+" ");
//     }
//     RR(a+1,b);
// }
// void RR2(int a, int b)
// {
//     if (a > b)
//     {
//         return ;
//     }
//     if (a % 2 != 0)
//     {
//         System.Console.Write(a+" ");
//     }
//     RR2(a+1,b);
// }

// int a=Convert.ToInt32(Console.ReadLine());
// int b=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"All even numbers from {a} to {b} are :");
// RR(a, b);

// Console.WriteLine();

// Console.WriteLine($"All odd numbers from {a} to {b} are :");
// RR2(a, b);



// ________________________________________________
// taski 1

// using System.Data;

// void PrintFromNumberToOne(int a)
// {
//     if (a == 0)
//     {
//         return;
//     }
//     System.Console.Write(a+" ");
//     PrintFromNumberToOne(a-1);

    
   
//     }
//     int a=Convert.ToInt32(Console.ReadLine());
//     PrintFromNumberToOne(a); 

// ________________________________________________
// taski 2
// int Sum(int a, int b, int c, int d)
// {
//     int cnt=a+b+c+d;
//     return cnt;
    
// }
//  int a=Convert.ToInt32(Console.ReadLine());
//  int b=Convert.ToInt32(Console.ReadLine());
//  int c=Convert.ToInt32(Console.ReadLine());
//  int d=Convert.ToInt32(Console.ReadLine());
//  System.Console.WriteLine(Sum(a,b,c,d));

// ________________________________________________
// taski 3
// int Reverse (int n)
// {
//     int cnt=0;
//    for(;n>0; n/= 10)
//     {
//         cnt=cnt*10+n%10;
//     }
//     return cnt;
// }
// int n=Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Reverse(n));

// ________________________________________________

// taski 1

int EvenCount(int n)
{
    int cnt = 0;

    for (; n > 0; n /= 10)
    {
        if (n % 10 % 2 == 0)
        {
            cnt++;
        }
    }

    return cnt;
}

int OddCount(int n)
{
    int cnt = 0;

    for (; n > 0; n /= 10)
    {
        if (n % 10 % 2 != 0)
        {
            cnt++;
        }
    }

    return cnt;
}

int DigitCount(int n)
{
    int cnt = 0;

    for (; n > 0; n /= 10)
    {
        cnt++;
    }

    return cnt;
}

int SumDigit(int n)
{
    int sum = 0;

    for (; n > 0; n /= 10)
    {
        sum += n % 10;
    }

    return sum;
}

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Even: {EvenCount(n)}");
Console.WriteLine($"Odd: {OddCount(n)}");
Console.WriteLine($"Digit: {DigitCount(n)}");
Console.WriteLine($"Sum: {SumDigit(n)}");



