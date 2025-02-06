using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Mylist<T> where T : IComparable
    {
         public int size;
         public int lastOndexed;
         public  T[] genreicList;


        public Mylist(int _size = 20)
        {
            this.size = _size;
            int last_indexed = -1;
            genreicList = new T[size];
        }



        public  virtual void Add(T item)
        {
            if (lastOndexed < size - 1)
            {
                lastOndexed++; // as last index in the list is full of data T

                genreicList[lastOndexed] = item;
            }
            else
            {
                Console.WriteLine("unvalid! list is limited ...");
            }
        }

        public  virtual void Remove(T item)
        {
            for (int i = 0; i <= lastOndexed; i++)
            {
                if (item.CompareTo(genreicList[i]) == 0)
                {
                    for (int j = i; i < lastOndexed; i++)
                    {
                        genreicList[j] = genreicList[j + 1];

                    }
                    lastOndexed--;
                    break;
                }

            }
        }


        public void clear()
        {
            lastOndexed = -1;
        }
        public void Print()
        {
            for (int i = 0; i <= lastOndexed; i++)
            {
                Console.WriteLine(genreicList[i]);

            }
        }


    }






}

