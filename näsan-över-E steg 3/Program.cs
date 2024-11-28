// // // // // hello world 

// // // // // static void Hello32()
// // // // // {
// // // // //     for (int i = 0; i < 32; i++)
// // // // //     {
// // // // //         Console.WriteLine("Hello world");
// // // // //     }
// // // // // }
// // // // // Console.ReadLine(); 

// // // // // Hello32();

// // // // Skriv ut kvadraten av n 
// // // // static void square(int n)
// // // // {
// // // //     Console.WriteLine(n*2); 
// // // // }

// // // // square(3);
// // // // Console.ReadLine();

// // // // Gångra två siffror tillsamans. 
// // // // static int Multi(int a , int s ) 
// // // // {
// // // //     return a*s; 
// // // // }
// // // // int r = Multi(3,4); 
// // // // Console.ReadLine(); 

// // // // RightTriangleArea
// // // static float RightTriangleArea(float o  , float p )
// // // {
// // //     return o*p/2; 
// // // }
// // // float area = RightTriangleArea(5.0f, 4.0f);  
// // // Console.WriteLine("Area : " + area);
// // // Console.ReadLine();


// // static float RightCircleArea(float s,float l  )
// // {
// //     return s*l/2; 
// // }
// // float area= RightCircleArea(10.0f,8.0f);
// // Console.WriteLine("Area : "+area);
// // Console.ReadLine(); 

// //  metod och while loop 


// static int GetNumberInput()
// {
//     bool lyckades = false;
//     int n = 0;

//     while (lyckades == false)
//     {
//         string number = "";
//         number = Console.ReadLine();
//         lyckades = int.TryParse(number, out n);
//         if (lyckades== false)
//         {
//             Console.WriteLine("en siffra försök igen"); 
//         }

//     }

//     return n;
// }


// int y = GetNumberInput();

// Console.WriteLine(y);
// Console.ReadLine();





// static int GetChoice(string a,string b,string e)
// {
//    bool lyckades = false; 
//    int c = 0; 
//    while(lyckades == false)
//    {
//    Console.WriteLine("1: Matte " + a);
//    Console.WriteLine("2: Engelska" + b);
//    Console.WriteLine("3: Fysik"+e);
   
//     string number = ""; 
//     number = Console.ReadLine(); 
//      lyckades =int.TryParse(number, out c); 
//      if(lyckades== false)
//      {
//         Console.WriteLine("skriv en godkänt siffra ");
//      }
//    }
   
//    return c; 

// }

// int c = GetChoice("Matte", "Engelska", "Fysik");
// Console.WriteLine(c); 

// Console.ReadLine();
