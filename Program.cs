using System;

namespace assignment_4
{
    class Program
    {
        static void Main(string [] args)
        {

                                                  //LOOP ASSIGNMENT


                                                     //NUMBER 1

            // Console.WriteLine("enter the number you want your number to range to N = ");
            // int n = Convert.ToInt32(Console.ReadLine());
            // for(int i = 1; i <= n ; i++)
            // {
            //     Console.Write($" {i} ");
            // }

                                                      //NUMBER 2

            // Console.WriteLine("enter the number you wish to print the numbers between it and one \n such that N are not divisible by 3 and 7 simultaneously: N = ");
            // int n = Convert.ToInt32(Console.ReadLine());
            //  for(int i = 1; i <= n ; i++)
            // {
            //     if( i % (3*7) == 0)
            //     {
            //     continue;
            //       }
            //     Console.Write($" {i} ");
            //     }
            

                                                      //NUMBER 3

            //  Console.WriteLine("enter your first number");
            // int n1 = Convert.ToInt32(Console.ReadLine());
            //  Console.WriteLine("enter your second number number");
            // int n2 = Convert.ToInt32(Console.ReadLine());
            //  Console.WriteLine("enter your third number");
            // int n3 = Convert.ToInt32(Console.ReadLine());
            // int [] numbers = { n1, n2, n3};
            // int max = Int32.MaxValue;
            //  int min = Int32.MinValue;
            //  foreach (int number in numbers)
            //  { 
            //     Console.Write(number + " ");
            //  }




            // Console.WriteLine("enter your number for row");
            // int row = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("enter your number for coloumn");
            // int coloumn = Convert.ToInt32(Console.ReadLine());

            // int [ , ] numbers = new int [row,coloumn];
            // for(int i = 0; i < row ; i++)
            // {
            //   for(int j = 0; j < coloumn; j++)
            //   {
            //   Console.WriteLine($"enter [{i} ,{j}] number");
            //   numbers[i,j] = Convert.ToInt32(Console.ReadLine());
            //   }
            // }
            //  for(int k = 0; k < coloumn; k++)
            // {
            //    for(int l = 0; l < coloumn; l++)
            //    {
            //   Console.Write($"{numbers[k,l]} ");
            //    }
            //     Console.WriteLine();
            // }


            
            // Console.WriteLine("enter where you want your table to stop");
            // int stop = Convert.ToInt32(Console.ReadLine());
            
            // for(int tables = 2; tables <= stop; tables++)
            // {
            //   Console.WriteLine($"Table {tables} to {stop}");
            // for (int i = 1; i <= stop; i++ )
            // {
            //   Console.WriteLine($"{tables} X {i} = {tables*i} \t");
            // }
            // Console.WriteLine();
            // }




          //    Console.WriteLine($"enter amount of numbers");
          //    int number = Convert.ToInt32(Console.ReadLine());
          //    int [] numbers = new int [number];
          //    int largest = 0;
          //   for(int i = 0; i < number; i++ )
          //   {
          //   Console.WriteLine($"enter {i} number");
          //   numbers[i] = Convert.ToInt32(Console.ReadLine());
          //   }
          //  for(int j = 0; j < number; j++ )
          //  {
          //   for(int k = 1; k < number; k++ )
          //   {
          //     if(numbers[j] > numbers[k])
          //     {
          //        largest = numbers[j];
          //        numbers[k] = largest;
          //     }
          //   }
          //  }
          //  Console.Write(largest);
           

            

                                                     //NUMBER 4


         // Console.WriteLine("These are all the 52 cards in a standard deck");

         //  var spadesSymbol = '\u2660';
         //  var heartsSymbol = '\u2665';
         //var diamondsSymbol = '\u2666';
         //var clubsSymbol = '\u2663';
         // for (int i = 0; i < 13; i++)// "for" loop used to change the card
         // {

        //     for (int j = 0; j < 4; j++) // "for" loop used to change the color of the card
        //     {
        //         string color = "";
        //         char[] colorSymbol = new char[4];
        //         colorSymbol[0] = '\u2663';
        //         colorSymbol[1] = '\u2666';
        //         colorSymbol[2] = '\u2665';
        //         colorSymbol[3] = '\u2660';
        //         switch (j) // switch case used for the color of the card
        //         {
        //             case 0:
        //                 color = "Clubs";
        //                 Console.ResetColor();// reset the console color
        //                 break;
        //             case 1:
        //                 color = "Diamonds";
        //                 Console.ForegroundColor = ConsoleColor.Red;// make the console color red

        //                 break;
        //             case 2:
        //                 color = "Hearts";
        //                 Console.ForegroundColor = ConsoleColor.Red;// make the console color red

        //                 break;
        //             case 3:
        //                 color = "Spades";
        //                 Console.ResetColor();// reset the console color

        //                 break;
        //             default:
        //                 Console.WriteLine("There is a mistake!");
        //                 break;
        //         }

        //         switch (i) // switch case used for the card
        //         {
        //             case 0:
        //                 Console.WriteLine("2{0}: Two of {1}", colorSymbol[j], color);
        //                 break;
        //             case 1:
        //                 Console.WriteLine("3{0}: Three of {1}", colorSymbol[j], color);
        //                 break;
        //             case 2:
        //                 Console.WriteLine("4{0}: Four of {1}", colorSymbol[j], color);
        //                 break;
        //             case 3:
        //                 Console.WriteLine("5{0}: Five of {1}", colorSymbol[j], color);
        //                 break;
        //             case 4:
        //                 Console.WriteLine("6{0}: Six of {1}", colorSymbol[j], color);
        //                 break;
        //             case 5:
        //                 Console.WriteLine("7{0}: Seven of {1}", colorSymbol[j], color);
        //                 break;
        //             case 6:
        //                 Console.WriteLine("8{0}: Eight of {1}", colorSymbol[j], color);
        //                 break;
        //             case 7:
        //                 Console.WriteLine("9{0}: Nine of {1}", colorSymbol[j], color);
        //                 break;
        //             case 8:
        //                 Console.WriteLine("10{0}: Ten of {1}", colorSymbol[j], color);
        //                 break;
        //             case 9:
        //                 Console.WriteLine("J{0}: Jack of {1}", colorSymbol[j], color);
        //                 break;
        //             case 10:
        //                 Console.WriteLine("Q{0}: Queen of {1}", colorSymbol[j], color);
        //                 break;
        //             case 11:
        //                 Console.WriteLine("K{0}: King of {1}", colorSymbol[j], color);
        //                 break;
        //             case 12:
        //                 Console.WriteLine("A{0}: Ace of {1}", colorSymbol[j], color);
        //                 break;
        //             default:
        //                 Console.WriteLine("There is a mistake!");
        //                 break;
        //              }
        //         }
        //     }


                                            //NUMBER5
                                            

            // int text1 = 0;
            // int text2 = 1;
            // int text3 = 0;
            // Console.Write($" {text1}{text2} ");
            // for(int i=0; i<=20; i++)
            // {
            //     text3 = text1+ text2;
            //     Console.Write($" {text3}  ");
            //     text1 = text2;
            //     text2 = text3;
            // }


                                             // //NUMBER 6
                                             

            // Console.WriteLine("Enter N: such that (1<K<N) ");
            // int n = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter k: such that (1<K<N)");
            // int k = Convert.ToInt32(Console.ReadLine());

            // for(int b = n-1; b > 0; b--)
            // {
            //     n *= b;
            // }
            // for(int b = k-1; b > 0; b--)
            // {
            //     k *= b;
            // }
            //  n /= k;
            // Console.WriteLine($"Result is: {n}");


                                          //NUMBER 7


            // Console.WriteLine("Enter N: such that (1<K<N) ");
            // int n = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter k: such that (1<K<N)");
            // int k = Convert.ToInt32(Console.ReadLine());
            // int denominator = n - k ;
            // for(int i = n - 1; i > 0 ; i--)
            // {
            //     n *= i;
            // }
            //  for(int j = k - 1; j > 0 ; j--)
            // {
            //     k *= j;
            // }
            //  for(int v = denominator - 1; v > 0 ; v--)
            // {
            //     denominator *= v;
            // }
            // Console.WriteLine($"Result is {(n*k)/denominator}  ");



                                                //NUMBER 8

                  //  Console.WriteLine("Enter Your N:  such that N must not be more than 0 ");
                  //  int n = Convert.ToInt32(Console.ReadLine());
                  //  int numerator = 2*n;
                  //  int subDenominator = (n+1);
                  //  for(int i = n - 1; i > 0 ; i--)
                  //  {
                  //     n *= i;
                  //   }
                  //   for(int j = subDenominator - 1; j > 0 ; j--)
                  //  {
                  //     subDenominator *= j;
                  //   }
                  //   for(int k = numerator - 1; k > 0 ; k--)
                  //  {
                 //     numerator *= k ;
                  //   }
                  //   Console.WriteLine(numerator/(subDenominator*n));



                                                   //NUMBER 9

            // Console.WriteLine("Enter N:  ");
            // int n = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter X:   ");
            // int x = Convert.ToInt32(Console.ReadLine());
            // int add = 1;
            // int power = 1;
            // for( int g = 1; g <= n;  g++)
            // {
            //     power *= g/x;
            //     add    += power;
            // }
            // Console.WriteLine($"Your result is: {add}");



                                         //NUMBER 10


                    // Console.WriteLine("Enter N: such that N must be less than 20");
                    // int n = Convert.ToInt32(Console.ReadLine());
                    // for(int d = 1; d <= n; d++)
                    // {
                    //     for(int e = d; e <= n ; e++)
                    //     {
                    //         Console.Write(e);
                    //     }
                       
                    // }



                                         //NUMBER 11


      //  Console.WriteLine("enter your number to calculate the number of zero its factorial has");
      // int n = int.Parse(Console.ReadLine());

      //  static int findTrailingZeros(int n)
      // {
      //     int count = 0;
      //     for (int i = 5; n / i >= 1; i *= 5)
      //         count += n / i;
      //         return count;
      // }
      //  Console.WriteLine("Number of Zeros in "+ n + "! is " + findTrailingZeros(n));
    

 

                                           // NUMBER  12

    //    int  n, i;       
    //    int[] a = new int[10];     
    //    Console.Write("Enter the number to convert: ");    
    //    n= int.Parse(Console.ReadLine());     
    //    for(i=0; n>0; i++)      
    //     {      
    //      a[i]=n%2;      
    //      n= n/2;    
    //     }      
    //    Console.Write("Binary of the given number= ");      
    //    for(i=i-1 ;i>=0 ;i--)      
    //    {      
    //     Console.Write(a[i]);      
    //    }


                                           // NUMBER 13

         
        //  int num, binVal, decVal = 0, baseVal = 1, rem;
        //  num = 101;
        //  binVal = num;
        //  while (num > 0) {
        //     rem = num % 10;
        //     decVal = decVal + rem * baseVal;
        //     num = num / 10 ;
        //     baseVal = baseVal * 2;
        //  }
        //  Console.Write("Binary Number: "+binVal);
        //  Console.Write("\nDecimal: "+decVal);
        //  Console.ReadLine();


                                              // NUMBER14


      //  int decn,q,dn=0,m,l;
      // 	int tmp;
      //     int s;
          
      // 	Console.Write("\n\n");
      //     Console.Write("Convert a number in decimal to hexadecimal:\n");
      //     Console.Write("---------------------------------------------");
      //     Console.Write("\n\n");		

      // 	Console.Write("Input  any Decimal number: ");
      //     decn = Convert.ToInt32(Console.ReadLine());	
      // 	q = decn;
      //         for(l=q;l>0;l=l/16)
      //                {
      // 		     tmp = l % 16;
      // 		           if( tmp < 10)
      // 		           tmp += 48; 
      // 				   else
      // 		           tmp = tmp + 55;
      //                    dn=dn*100+tmp;
      // 	           }

      //                Console.Write("\nThe equivalent Hexadecimal Number : ");
      //          for(m=dn;m>0;m/=100)
      //             {
      //                s=m % 100;
      //                Console.Write("{0}",(char)s);
      //             }
      //     Console.Write("\n\n");

       

                                             // NUMBER15


      //           string hexval = "4B0";
      //  Console.WriteLine("Hexadecimal number: "+hexval);
      //  int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
      //  Console.WriteLine("Convert to-");
      //  Console.WriteLine("Decimal number: "+decValue);


                                            // NUMBER 16


      //          int[] ints = new int[11];
      //         Random rand = new Random();

      //        for (int i = 0; i < ints.Length; i++)
      // {
      //   ints[i] = rand.Next(11);
      // }
      //     foreach (int i in ints)
      // {
      //   Console.WriteLine(i.ToString());
      // }

                                           // NUMBER 17


      //  long num1, num2, hcf, lcm;
      //             Console.WriteLine("\n\n Recursion : Find the LCM and GCD of two numbers :");
      // 		    Console.WriteLine("------------------------------------------------------");      
            
      //             Console.Write(" Input the first number : "); 
      //             num1 = Convert.ToInt64(Console.ReadLine());
      //             Console.Write(" Input the second number : "); 
      //             num2 = Convert.ToInt64(Console.ReadLine());
      
      //             hcf = gcd(num1, num2);
      //             lcm = (num1 * num2) / hcf;
      
      //             Console.WriteLine($"\n The GCD of : {num1}\t and\t {num2}\t =\t {hcf}");
      //             Console.WriteLine($"The LCM of : {num1}\t  and\t  {num2}\t =\t {lcm}");
                  
      
      //         }
      
      //        static long gcd(long n1, long n2)
      //         {
      //            if (n2 == 0)
      //            {
      //                return n1;
      //            }
      //            else
      //            {
      //                return gcd(n2, n1 % n2);
      //            }
            


                                            // NUMBER18


        //  public static List<int> spiralOrder(int[,] matrix)
        // {
        //     List<int> ans = new List<int>();
      
        //     if (matrix.Length == 0)
        //         return ans;
      
        //     int R = matrix.GetLength(0), C = matrix.GetLength(1);
        //     bool[,] seen = new bool[R,C];
        //     int[] dr = { 0, 1, 0, -1 };
        //     int[] dc = { 1, 0, -1, 0 };
        //     int r = 0, c = 0, di = 0;
      
        //     // Iterate from 0 to R * C - 1
        //     for (int i = 0; i < R * C; i++) {
        //         ans.Add(matrix[r,c]);

        //          seen[r,c] = true;
        //         int cr = r + dr[di];
        //         int cc = c + dc[di];
      
        //         if (0 <= cr && cr < R && 0 <= cc && cc < C
        //             && !seen[cr,cc]) {
        //             r = cr;
        //             c = cc;
        //         }
        //         else {
        //             di = (di + 1) % 4;
        //             r += dr[di];
        //             c += dc[di];
        //         }
        //     }
        //     return ans;
        // }

        //  public static void Main(String[] args)
        // {
        //     int[,]a = { { 1, 2, 3, 4 },
        //                   { 5, 6, 7, 8 },
        //                   { 9, 10, 11, 12 },
        //                   { 13, 14, 15, 16 } };
      
        //     spiralOrder(a).ForEach(i=>Console.Write(i+" "));
        // }

         

      // int x = 1;
      // for(int i = 1;i <= 5; i++)
      // {
      //   x *= i;
        
      // }
      // Console.WriteLine(x);












        }
    }
}

