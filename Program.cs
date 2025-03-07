// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");



// //task1
// int a = int.Parse(System.Console.ReadLine());
// if (a<100){
//     a=a+(a*5/100);
// }
// else if(a>=100 && a<=200){
//     a=a+(a*7/100);
// }
// else{
//     a=a+(a*10/100);
// }
// System.Console.WriteLine(a);


// using System.Runtime.InteropServices;

// // task2
// int a = int.Parse(System.Console.ReadLine());
// int[] arr = new int[a];
// int mult = 1;
// for (int x = 0; x < a; x++)
// {
//     arr[x] = int.Parse(Console.ReadLine());
// }
// for (int x = 0; x < a - 1; x++)
// {
//     if (arr[x] > 0)
//     {
//         System.Console.Write(arr[x] + "*");
//     }
//     else
//     {
//         System.Console.Write("(" + (arr[x]) + ")" + "*");
//     }
//     mult *= arr[x];
// }
// if (arr[a - 1] > 0)
// {
//     System.Console.Write(arr[a - 1] + "=" + mult * arr[a - 1]);
// }
// else
// {
//     System.Console.Write("(" + arr[a - 1] + ")" + "=" + mult * arr[a - 1]);
// }



// // Task3
// int a = int.Parse(System.Console.ReadLine());
// int[] arr = new int[a];
// int mx = -999999;
// int mxi=0;
// for (int x = 0; x < a; x++)
// {
//     arr[x] = int.Parse(Console.ReadLine());
// }
// for (int x = 0; x < a; x++)
// {
//     if (arr[x] > mx)
//     {
//         mx=arr[x];
//         mxi=x;
//     }
// }
// System.Console.WriteLine(mxi);




// // task4
// int a = int.Parse(System.Console.ReadLine());
// int[] arr = new int[a];
// for (int x = 0; x < a; x++)
// {
//     arr[x] = int.Parse(Console.ReadLine());
// }
// for (int x = 0; x < a; x++)
// {
//     bool b = false;
//     for (int j = 0; j < a; j++)
//     {
//         if (x != j && arr[x] == arr[j])
//         {
//             b = true;
//             break;
//         }
//     }
//     if (!b)
//     {
//         Console.Write(arr[x] + " ");
//     }
// }



// // Task5
// int a = int.Parse(System.Console.ReadLine());
// int[] arr = new int[a];
// int mn = 999999;
// int mni=0;
// for (int x = 0; x < a; x++)
// {
//     arr[x] = int.Parse(Console.ReadLine());
// }
// for (int x = 0; x < a; x++)
// {
//     if (arr[x] < mn)
//     {
//         mn=arr[x];
//         mni=x;
//     }
// }
// System.Console.WriteLine(mni);









using System.Security.Cryptography;
// // Task6
// int a = int.Parse(System.Console.ReadLine());
// int[] arr = new int[a];
// int cnt = 0;
// for (int x = 0; x < a; x++)
// {
//     arr[x] = int.Parse(Console.ReadLine());
// }
// for (int x = 1; x < a - 1; x++)
// {

//     if (arr[x] > arr[x - 1] && arr[x] > arr[x + 1])
//     {

//         cnt++;

//     }

// }
// System.Console.Write(cnt);



// // Task7
// int a = int.Parse(System.Console.ReadLine());
// int[] arr = new int[a];
// int cnt = 0;
// for (int x = 0; x < a; x++)
// {
//     arr[x] = int.Parse(Console.ReadLine());
// }
// for (int x = a - 1; x >= 0; x--)
// {
//     if ((arr[x] > 0 && arr[x - 1] > 0) || (arr[x] < 0 & arr[x - 1] < 0))
//     {
//         System.Console.WriteLine(arr[x - 1] + " " + arr[x]);
//         break;
//     }
// }




// // Task8
// int a = int.Parse(System.Console.ReadLine());
// int[] arr = new int[a];
// int cnt = 0;
// for (int x = 0; x < a; x++)
// {
//     arr[x] = int.Parse(Console.ReadLine());
// }
// for(int x=0;x<a;x++)
// {
//     if(arr[x]%2!=0)
//     {
//         System.Console.Write(x + " " );
//     }
// }





// // Task9
// int a = int.Parse(System.Console.ReadLine());
// int[] arr = new int[a];
// int cnt = 0;
// for (int x = 0; x < a; x++)
// {
//     arr[x] = int.Parse(Console.ReadLine());
// }
// int b = int.Parse(System.Console.ReadLine());
// int c = int.Parse(System.Console.ReadLine());
// for(int x=b;x<c;x++)
// {
//     if(arr[x]%2!=0)
//     {
//         System.Console.Write(arr[x] + " " );
//     }
// }





// // Task10
// int a = int.Parse(System.Console.ReadLine());
// int[] arr = new int[a];
// int cnt = 0;
// for (int x = 0; x < a; x++)
// {
//     arr[x] = int.Parse(Console.ReadLine());
// }
// for(int x=0;x<a;x++)
// {
//     if(arr[x]%2!=0)
//     {
//         System.Console.Write(arr[x]*arr[x] + " " );
//     }
// }