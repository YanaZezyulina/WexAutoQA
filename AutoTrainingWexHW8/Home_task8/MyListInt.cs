using System;
using System.Collections.Generic;
using System.Text;

namespace Home_task8
{
    class MyNode<T> //какой-то тип, абстракция
    {
        T data;
        public MyNode<T> nextNode { get; set; }
        public MyNode(T dt)
        {
            data = dt;
        }
    }
    class MyList<T>
    {
        public MyNode<T> Head { get; private set;}
        public void Add(MyNode<T> data)
        {
            if (Head == null)
            {
                Head = data;
            }
            else
            {
                Head.nextNode = data;
            }
        }
    }
}
