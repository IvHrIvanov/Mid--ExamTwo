using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> shopingList = Console.ReadLine().Split("!").ToList();

            string[] comand = Console.ReadLine().Split(" ").ToArray();

            while (comand[0] != "Go")
            {

                if (comand[0] == "Urgent")
                {
                    if (!shopingList.Contains(comand[1]))
                    {
                        shopingList.Insert(0, comand[1]);
                    }
                   
                }

                else if (comand[0] == "Unnecessary" && shopingList.Contains(comand[1]))
                {
                    shopingList.Remove(comand[1]);
                }

                else if (comand[0] == "Correct" && shopingList.Contains(comand[1]))
                {
                    string oldItem = comand[1];
                    string newItem = comand[2];
                    int index = 0;
                    foreach (var item in shopingList)
                    {
                        index++;
                        if (item == oldItem)
                        {
                            shopingList.Insert(index, newItem);
                            break;
                        }
                    }
                    
                    shopingList.Remove(oldItem);
                    
                }
                else if(comand[0]=="Rearrange")
                {
                    shopingList.Insert(shopingList.Count, comand[1]);
                    shopingList.Remove(comand[1]);
                }

                comand = Console.ReadLine().Split(" ").ToArray();
            }
            Console.WriteLine(string.Join(", ",shopingList));
        }
    }
}