using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GE_Program_240527
{
    public class Vector<T>
    {
        private T[] array;

        public Vector()
        {
            array = new T[5];
        }

        public T Array
        {
            get { return array[0]; }
            set { array[0] = value; }
        }
    }

    internal class Program
    {
        public static void Debug<T>(T data)
        {
            Console.WriteLine($"data 변수의 값 : {data}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("【일반화】\n");
            {
                #region 일반화 프로그램
                // 특정 데이터 타입에 의존하지 않고 모든 타입의 멤버 변수를
                // 타입으로 설정할 수 있는 프로그래밍 기법

                Debug<char>('A');
                Debug<int>(10);
                Debug<float>(20.5f);
                Debug<string>("Hello World");

                Vector<int> vector = new Vector<int>();

                vector.Array = 20;

                Console.WriteLine($"vector의 [0] index 값 : {vector.Array}");
                #endregion
            }

            Console.WriteLine("\n【Colletions】\n");
            {
                #region 컬렉션
                // 많은 데이터 요소를 효율적으로 관리하기 위한 자료 구조



                Console.WriteLine("냉무");
                #endregion
            }

            Console.WriteLine("\n【List】\n");
            {
                #region 리스트


                List<int> list = new List<int>();

                list.Capacity = 5;
                list.Add(10);       //  [10]
                list.Add(20);       //  [10]    [20]
                list.Add(30);       //  [10]    [20]    [30]
                list.Add(40);
                list.Add(50);

                list.Remove(40);

                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"list [{i}] : {list[i]}");
                }

                Console.WriteLine($"list의 count 값 : {list.Count}");
                Console.WriteLine($"list의 Capacity 값 : {list.Capacity}");
                #endregion
            }

            Console.WriteLine("\n【Linked List】\n");
            {
                #region Linked List
                // 데이터에 다음의 데이터를 가리킬 주소가 포함된 자료구조
                // 가장 마지막의 데이터가 가장 처음의 데이터를 가리킨다면 선형 자료구조

                LinkedList<int> linkedList = new LinkedList<int>();

                linkedList.AddFirst(10);      //  [10]
                linkedList.AddFirst(5);       //  [5]→[10]
                linkedList.AddLast(99);       //  [5]→[10]→[99]

                foreach (int element in linkedList)
                {
                    Console.WriteLine(element);
                }
                #endregion

                Console.WriteLine($"linkedList의 count 값 : {linkedList.Count}");
            }

            Console.WriteLine("\n【스택】\n");
            {
                #region Stack
                // 아래에서부터 쌓이는 자료 구조

                Stack<int> iStack = new Stack<int>();

                iStack.Push(1);
                iStack.Push(2);
                iStack.Push(3);
                iStack.Push(4);
                //iStack.Push(5);

                //iStack.Pop();   // 데이터 가장 위의 값 제거

                Console.WriteLine($"Stack의 가장 위의 값 : {iStack.Peek()}");
                Console.WriteLine($"Stack 길이 : {iStack.Count()}");

                foreach (int element in iStack)
                {
                    Console.WriteLine(element);
                }

                for (int i = iStack.Count(); i > 0; i--)
                {
                    Console.WriteLine($"Stack [{i}] 값 : {iStack.Peek()}");
                    iStack.Pop();
                }

                #endregion
            }

            Console.WriteLine("\n【큐】\n");
            {
                #region Queue
                // First in First out
                // 먼저 입력된 데이터가 먼저 출력되는 데이터 구조

                Queue<int> queue = new Queue<int>();

                queue.Enqueue(1);
                queue.Enqueue(2);
                queue.Enqueue(3);
                queue.Enqueue(4);
                queue.Enqueue(5);


                Console.WriteLine($"Queue의 총 요소수 : {queue.Count()}");

                foreach (int element in queue)
                {
                    Console.WriteLine($"Queue의 값 : {element}");
                }
                #endregion
            }

            Console.WriteLine("\n【사전형】\n");
            {
                #region Dictionary
                // List는 인덱스 번호를 사용하여 요소의 값을 얻지만
                // Dictionary는 인덱스에 key값을 넣으며, 문자열로 배치할 수 있다.
                // Dictionary는 key값의 중복을 허용하지 않음

                Dictionary<string, int> dic = new Dictionary<string, int>();

                dic.Add("Sword", 10000);
                dic.Add("Armor", 7500);
                dic.Add("Gloves", 5000);
                dic.Add("Shoes", 2000);

                string sString = "Sword";
                if(dic.ContainsKey(sString))
                {
                    Console.WriteLine($"{sString} 존재함");
                }
                else
                {
                    Console.WriteLine($"{sString} 부재함");
                }

                foreach (KeyValuePair<string, int> item in dic)
                {
                    Console.Write($"item의 key 값 : {item.Key}");
                    Console.WriteLine($"（{item.Value}）");
                }

                #endregion
            }


        }
    }
}