using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{
    public class LinkedList<T> : IEnumerable<T>  // односвязный список
    {
        public Node<T> head { get; set; } // головной/первый элемент
        public Node<T> tail; // последний/хвостовой элемент
        public int count;  // количество элементов в списке

        public LinkedList()
        {
            count = 0;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        // добавление элемента
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
        }

        public bool Empty()
        {
            if (count != 0)
                return false;
            else return true;
        }

        public bool Contains(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

    }
}
