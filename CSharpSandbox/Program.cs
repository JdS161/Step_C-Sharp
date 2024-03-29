﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpSandbox
{
    class Program
    {
        // class Line holds an information regarding line edged with 2 points

        class Foo
        {

            public int foo;

            public Foo() { foo = -1; }
            public Foo(int a) { foo = a; }

            public override string ToString()
            {
                return $"FOO ({foo})";
            }
        }

        struct Bar
        {
            public int bar;
        }

        interface IDiggingCapable
        {
            //desription of methods which has to be implemented in inharits

            void Dig();

        }

        // interface implementation
        class Handyman : IDiggingCapable
        {
            public void Dig()
            {
                Console.WriteLine("Handyman is dgging");
            }
        }
        class Tractor : IDiggingCapable
        {
            public void Dig()
            {
                Console.WriteLine("Tractor is digging using scoop");
            }
        }

        static void DigBigCrater(IDiggingCapable[] resources)
        {
            foreach (IDiggingCapable resource in resources)
            {
                resource.Dig();
            }
        }
        static void Main(string[] args)
        {

            //-------------------------------------------------------------------------------------------------------------------------------------------------------
            //----------------------------------------------------INTRODUCTION TO C# 11/07/2021----------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------------------------------------------------------------
            

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //int a = 0;
            //Console.WriteLine(a);
            //string a_str = a.ToString();
            //Console.WriteLine(a_str);
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(a_str.Length);


            //double foo = 1;
            //foo /= 3;
            //Console.WriteLine("foo = {0}", foo);
            //foo *= 3;
            //Console.WriteLine("foo = {0}", foo);


            //decimal foo = 1;
            //foo /= 3;
            //Console.WriteLine("foo = {0}", foo);
            //foo *= 3;
            //Console.WriteLine("foo = {0}", foo);

            //char symb = (char)48;
            //Console.WriteLine(symb);
            //Console.WriteLine(sizeof(char));
            //Console.WriteLine("Русский язык выводится без подключения setlocale");


            //string str_1 = null;
            //string str_2 = "";
            //int? a = null;
            //int b = a ?? 3;
            //Console.WriteLine(b);


            ////ax + b = 0

            //double a, b;
            //Console.Write("Write down a: ");
            //a = double.Parse(Console.ReadLine());
            //Console.Write("Write down b: ");
            //b = Convert.ToDouble(Console.ReadLine());
            //double x = -b / a;
            //Console.WriteLine(x);  

            //Console.WriteLine("x = {0}; a = {1}, b = {2}", x, a, b);
            //Console.WriteLine($"x = {x}; a = {a}, b = {b}");


            //int a = 0b1010;
            //Console.WriteLine(a);




            //double a, b, x;
            //Console.Write("A = ");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("B = ");
            //b = Convert.ToDouble(Console.ReadLine());
            //Console.Write("X = ");
            //x = Convert.ToDouble(Console.ReadLine());

            //if (a > b)
            //{
            //    double temp = a;
            //    a = b;
            //    b = temp;
            //}
            //if (x>a && x <b)
            //{
            //    Console.WriteLine($"Number {x} is in range ({a}, {b})");
            //}
            //else if (x ==a || x == b)
            //{
            //        Console.WriteLine($"Number {x} is on the border of the range ({a}, {b})");
            //}
            //else
            //{
            //        Console.WriteLine($"Number {x} is out of the range ({a}, {b})");
            //}

            //int num;
            //num = Convert.ToInt32(Console.ReadLine());
            //bool isSimple = true;
            //for (int i = 2; i < num && isSimple; i++)
            //{
            //    if (num% i == 0)
            //    {
            //        isSimple = false;
            //    }
            //}

            //if (isSimple)
            //{
            //    Console.WriteLine($"Number {num} is simple");
            //}
            //else
            //{
            //    Console.WriteLine($"Number {num} is not simple");
            //}
            ////isSimple ? Console.WriteLine($"Number {num} is simple") : Console.WriteLine($"Number {num} is not simple"); // TODO: Check this line



            //-------------------------------------------------------------------------------------------------------------------------------------------------------
            //---------------------------------------------------------ARRAYS 11/14/2021-----------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------------------------------------------------------------

            //int[] arr = new int[10];
            //for (int i=0; i< arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}


            //Console.WriteLine();

            //foreach (int elem in arr)
            //    Console.Write($"{elem} ");

            //Console.WriteLine();

            //int[] marks = new int[8];

            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.Write("Input a mark");
            //    marks[i] = Convert.ToInt32(Console.ReadLine());
            //}

            ////average:
            //double average = marks.Average();
            //Console.WriteLine($"Average = {average}");

            ////marks values counter
            //int[] countMarks = new int[marks.Max() + 1];
            //for (int i=0; i < countMarks.Length; i++)
            //{
            //    countMarks[i] = marks.Count(elem => elem == i);
            //}

            //for (int  i = 0; i < countMarks.Length; i++)                            //      TODO: UNDERSTAND THIS!!!
            //{                                                                       //          LINES 145-155
            //    Console.WriteLine($"Number of marks {i} = {countMarks[i]}");
            //}



            //int[] arr_1 = new int[] { 1, 2, 3 };
            //int[] arr_2 = arr_1;
            //arr_2[0] = 0;
            //Console.WriteLine(arr_1[0]);

            ////DEEP COPY
            //arr_1 = new int[] { -1, -2, -3 };
            //arr_1.CopyTo(arr_2, 0);
            //arr_2[0] = 0;
            //Console.WriteLine(arr_1[0]);


            ////rectangular 2-dimensional array
            //int rows = 3, cols = 5;
            //double[,] matrix = new double [rows,cols];

            //for (int i = 0; i < rows; i++)
            //{
            //    for ( int j=0; j< cols; j++)
            //    {
            //        matrix[i, j] = i * j ;
            //    }
            //} 

            //for (int i = 0; i < rows; i++)
            //{
            //    for ( int j=0; j< cols; j++)
            //    {
            //        Console.Write($"{matrix[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            //    Console.WriteLine();

            //foreach(double elem in matrix)
            //{
            //        Console.Write($"{elem} ");
            //}
            //    Console.WriteLine();




            //----------------------------------------------------triangle array----------------------------------------------------------------------------
            //int[][] trArr = new int[3][]; // 3 empty rows created here
            //trArr[0] = new int[1];
            //trArr[1] = new int[2];
            //trArr[2] = new int[3];


            //for (int i = 0; i < trArr.Length; i++)
            //{
            //    for (int j = 0; j < trArr[i].Length; j++)
            //    {
            //        trArr[i][j] = i - j - 10;
            //        Console.Write($"{trArr[i][j]} ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            //foreach ( int[] str in trArr)
            //{
            //    foreach(int elem in str)
            //    {
            //        Console.Write($"{elem} ");
            //    }
            //    Console.WriteLine();
            //}


            //-------------------------------------------------------------------------------------------------------------------------------------------------------
            //--------------------------------------------------------ARRAYS 11/21/2021------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------------------------------------------------------------

            //int[] arr = new int[10];

            ////filling of the array using RANDOM

            //Random rand = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //    arr[i] = rand.Next(10, 20);

            ////print array
            //foreach (int elem in arr)
            //    Console.Write($"{elem} ");
            //Console.WriteLine();

            ////array sort
            //Array.Sort(arr);

            ////print array
            //foreach (int elem in arr)
            //    Console.Write($"{elem} ");
            //Console.WriteLine();



            //-------------------------------------------------------------------------------------------------------------------------------------------------
            //-------------------------------------------------------------STRING------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------------------------------------------------------


            //String str = null;
            //string str1;
            //string[] str2 = new string[10];

            //Console.Write(str2.Length);

            //Console.Write("Write down a string: ");
            //str = Console.ReadLine();

            //Console.WriteLine($"You've written down: " + str);

            ////Parsing of 2nd word in string SOME TRING SOME STRING
            //int space_index = str.IndexOf(' ');
            //if (space_index == -1)
            //    Console.WriteLine("ONE WORD IN A STRING");
            //str = str.Substring(space_index + 1);
            //space_index = str.IndexOf(' ');
            //if (space_index != -1)
            //    str = str.Substring(0, space_index);
            //Console.WriteLine("Second word is: " + str);


            //TASK: divide strings for tokens

            ////String str = null;
            //Console.Write("Write down a string: ");
            //str = Console.ReadLine();

            //Console.WriteLine("You've written: " + str);

            ////spliting
            //string[] strs =str.Split(new char[]{' ', ',');
            //for ( int i=0; i< strs.Length; i++)
            //{
            //    Console.WriteLine($"Word {i + 1}: {strs[i]}");
            //}


            //String comparison

            //string pass = "1234abc";


            //MARKS LIST TASK

            //string[] subjects = null;
            //int[][] marks = null;


            //Console.Write("Number of subjecs: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //subjects = new string[n];
            //for (int i=0; i< n; i++)
            //{
            //    Console.Write($"Write subject ({i + 1}/{n}: ");
            //    subjects[i] = Console.ReadLine();
            //}

            //marks = new int[n][];

            //for(int i =0; i<n; i++)
            //{
            //    Console.Write($"Write down number of marks {subjects[i]}");
            //    int m = Convert.ToInt32(Console.ReadLine());
            //    marks[i] = new int[m];
            //    for( int j =0; j < m; j++)
            //    {
            //        Console.Write($"Fill the mark ({j + 1}/{m}): ");
            //        marks[i][j] = Convert.ToInt32(Console.ReadLine());

            //    }
            //}

            ////printing of array

            //for (int i=0; i< subjects.Length; i++)
            //{
            //    Console.Write($"{subjects[i]}: ");
            //    foreach(int mark in marks[i])
            //    {
            //        Console.Write($" {mark} ");
            //    }
            //    Console.WriteLine();
            //}

            ////count average
            //double total_sum = 0;
            //for(int i=0; i< subjects.Length; i++)
            //{
            //    double av = marks[i].Average();
            //    total_sum += av;
            //    Console.WriteLine($"Average for {subjects[i]} = {av}");
            //}

            //Console.WriteLine($"Total average : {total_sum / subjects.Length}");


            //-------------------------------------------------------------------------------------------------------------------------------------------------
            //------------------------------------------------COMMAND LINE ARGUMENTS---------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------------------------------------------------------


            //Console.Write("COMMANDLINE ARGUMENTS");

            //-------------------------------------------------------------------------------------------------------------------------------------------------------
            //---------------------------------------------------STRUCTURES AND CLASSES 11/28/2021-------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------------------------------------------------------------

            // ----------------------------------------------------------STRUCTURES----------------------------------------------------------------------------------


            ////1) creating of a structure - is Value Type

            //Point p;
            //Point p2 = new Point("P2", 10, 10);

            ////2) Initialization of a structure
            //p.name = "P1";
            //p.x = 1;
            //p.y = 2;
            //Console.WriteLine($"Initial point: {p}");
            //Console.WriteLine($"Initial point: {p2}");

            ////3) Some ations with struture's fields
            //p.x *= p.x;
            //p.y *= p.y;

            ////4)Output of struct to console

            //Console.WriteLine($"Point after manipulation: {p}, distnace = {p.Distance()}");

            //------------------------------------------------------------CLASSES------------------------------------------------------------------------------------

            //Point p1 = new Point("A", 1, 1);
            //Point p2 = new Point("B", 2, 1);


            //Line firstLine = new Line("AB", p1, p2);

            //Console.WriteLine(firstLine);
            //Console.WriteLine(firstLine.LineDistance());

            //string oldName = firstLine.LineName;
            //firstLine.LineName = "NEW_NAME";
            //Console.WriteLine(firstLine);
            //Console.WriteLine($"Old name = {oldName}");
            //firstLine.P1 = new Point("A`", 10, 20);
            //Console.WriteLine(firstLine);

            //Foo foo1 = new Foo();
            //foo1.foo = 100;
            //Foo foo2 = foo1;
            //foo2.foo = 0;
            //Console.WriteLine(foo1);
            //Console.WriteLine(foo2);
            //Console.WriteLine();

            //Bar bar1 = new Bar();
            //bar1.bar = 30;
            //Bar bar2 = bar1;
            //bar2.bar = 0;
            //Console.WriteLine(bar1);
            //Console.WriteLine(bar2);



            //Foo[] fooArr = new Foo[10];

            //Random rand = new Random();
            //for (int i=0; i<fooArr.Length; i++)
            //{
            //    fooArr[i] = new Foo(rand.Next(10,20));
            //}

            //foreach (Foo elem in fooArr)
            //{
            //    Console.WriteLine($"{elem}");
            //}


            //-------------------------------------------------------------------------------------------------------------------------------------------------------
            //--------------------------------------------- INHERITANCE POLYMORPHISM INTERFACES 12/05/2021 ----------------------------------------------------------
            //-------------------------------------------------------------------------------------------------------------------------------------------------------


            //Foo1 foo = new Foo1();
            //foo.Bar = 10;
            //Console.WriteLine(foo.Bar);
            //Foo1.StaticBar = 3;
            //Foo1.StaticBarSpam();

            //Shape figure = new Shape();
            //figure.Draw();
            //Rectangle rect = new Rectangle("TEST",5,5);
            //Console.WriteLine(rect);
            //rect.Draw();

            //Rectangle rect = new Rectangle("TEST",5,5);

            //Shape figure = rect;
            //DrawShape(figure);
            //Console.WriteLine(figure.ToString());

            //Console.WriteLine(rect.GetDiagonal());



            //Handyman man = new Handyman();
            //man.Dig();
            //Tractor tractor = new Tractor();
            //tractor.Dig();

            //IDiggingCapable[] digCrew = new IDiggingCapable[2] { man, tractor };
            //DigBigCrater(digCrew);



            Rectangle rect = new Rectangle("TEST", 4, 6);
            ConsoleDraw(rect);
            
        }

        static void ConsoleDraw(IDrawable drawable)
        {
            drawable.Draw();
            drawable.Print();
        }
         static void DrawShape(Shape figure)
        {
            //figure.Draw();
            //Rectangle rect = (Rectangle)figure;       // direct casting is FORBIDDEN, implicit casting is not so good
            //Console.WriteLine(rect.GetDiagonal());

            ////1. as
            //Rectangle rect = figure as Rectangle; // if everything id fine => rect != null, otherwise rect == null
            //if (rect !=null)
            //{
            //    Console.WriteLine(rect.GetDiagonal());
            //}
            //else
            //{
            //    Console.WriteLine("Can't cast base type");
            //}

            //2. is
            if (figure is Rectangle)
            {
                Rectangle rect = (Rectangle)figure;                
                Console.WriteLine(rect.GetDiagonal());
            }
            else
            {
                Console.WriteLine("Can't cast base type");
            }


           
        }


    }
}
