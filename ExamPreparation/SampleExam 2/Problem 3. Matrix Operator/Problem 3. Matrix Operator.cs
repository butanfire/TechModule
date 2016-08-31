namespace Problem_3.Matrix_Operator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MatrixOperator
    {
        public static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            List<List<int>> matrix = new List<List<int>>();
            matrix.Add(new List<int>());
            for (int i = 0; i < lines; i++)
            {
                matrix[i].AddRange(Console.ReadLine().Split(' ').Select(int.Parse));
                matrix.Add(new List<int>());
            }

            var command = Console.ReadLine();
            while (command != "end")
            {
                var arguments = command.Split(' ').ToArray();
                if (arguments[0] == "remove")
                {
                    var type = arguments[1];
                    var posType = arguments[2];
                    var pos = int.Parse(arguments[3]);
                    switch (posType)
                    {
                        case "row":
                            switch (type)
                            {
                                case "odd":
                                    matrix[pos].RemoveAll(s => s % 2 != 0);
                                    break;
                                case "even":
                                    matrix[pos].RemoveAll(s => s % 2 == 0);
                                    break;
                                case "positive":
                                    matrix[pos].RemoveAll(s => s >= 0);
                                    break;
                                case "negative":
                                    matrix[pos].RemoveAll(s => s < 0);
                                    break;
                            }

                            break;
                        case "col":
                            switch (type)
                            {
                                case "odd":
                                    for (int i = 0; i < lines; i++)
                                    {
                                        if (matrix[i].Count <= pos)
                                        {
                                            continue;
                                        }

                                        if (matrix[i][pos] % 2 != 0)
                                        {
                                            matrix[i].RemoveAt(pos);
                                        }

                                    }

                                    break;
                                case "even":
                                    for (int i = 0; i < lines; i++)
                                    {
                                        if (matrix[i].Count <= pos)
                                        {
                                            continue;
                                        }

                                        if (matrix[i][pos] % 2 == 0)
                                        {
                                            matrix[i].RemoveAt(pos);
                                        }
                                    }

                                    break;
                                case "positive":
                                    for (int i = 0; i < lines; i++)
                                    {
                                        if (matrix[i].Count <= pos)
                                        {
                                            continue;
                                        }

                                        if (matrix[i][pos] >= 0)
                                        {
                                            matrix[i].RemoveAt(pos);
                                        }
                                    }

                                    break;
                                case "negative":
                                    for (int i = 0; i < lines; i++)
                                    {
                                        if (matrix[i].Count <= pos)
                                        {
                                            continue;
                                        }

                                        if (matrix[i][pos] < 0)
                                        {
                                            matrix[i].RemoveAt(pos);
                                        }
                                    }

                                    break;
                            }

                            break;
                    }
                }
                else if (arguments[0] == "swap")
                {
                    var indexOld = int.Parse(arguments[1]);
                    var indexNew = int.Parse(arguments[2]);
                    var temp = matrix[indexOld];
                    matrix[indexOld] = matrix[indexNew];
                    matrix[indexNew] = temp;
                }
                else if (arguments[0] == "insert")
                {
                    var row = int.Parse(arguments[1]);
                    var number = int.Parse(arguments[2]);
                    matrix[row].Reverse();
                    matrix[row].Add(number);
                    matrix[row].Reverse();
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine("{0}", string.Join(" ", matrix[i]));
            }
        }
    }
}
