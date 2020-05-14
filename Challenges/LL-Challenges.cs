using System;
using DataStructures;

namespace Challenges
{
    public class LL_Challenges
    {
        public static LinkedList mergeLists(LinkedList list1, LinkedList list2)
        {
            Node current1 = list1.Head;
            Node current2 = list2.Head;

            while(current1 != null)
            {
                list1.InsertAfter(current1.Data, current2.Data);
                current1 = current1.Next.Next;
                current2 = current2.Next;
            }

            return list1;
        }
    }
}
