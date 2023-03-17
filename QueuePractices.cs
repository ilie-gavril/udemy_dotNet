using System;
using System.Collections.Generic;

namespace Udemy_dotNet
{
    public class QueuePractices
    {
        public static void Run()
        {
            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(1);

            //queue.Enqueue(2);

            //queue.Enqueue(3);

            //int queueItem = queue.Dequeue();

            //Console.WriteLine("Value removed from the begining is {0}", queueItem);
            //Console.Write("The value at the front of the queue is: {0}", queue.Peek());



            //while (queue.Count > 0)
            //{
            //    Console.WriteLine("The front value {0} was removed from the queue", queue.Dequeue());

            //    Console.WriteLine("the count of the queue is {0}", queue.Count);

            //    Console.Write("The value at the front of the queue is: {0}", queue.Peek());
            //}

            Queue<Order> ordersQueue = new Queue<Order>();

            foreach(Order o in RecieveOrdersFromBranch1())
            {
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in RecieveOrdersFromBranch2())
            {
                ordersQueue.Enqueue(o);
            }

            while(ordersQueue.Count > 0)
            {
                Order currentOrder = ordersQueue.Dequeue();

                currentOrder.ProcessOrder();
            }


        }


        class Order
        {
            public int OrderId { get; set; }

            public int OrderQuantity { get; set; }

            public Order(int id, int orderquantity)
            {
                this.OrderId = id;
                this.OrderQuantity = orderquantity;
            }

            public void ProcessOrder()
            {
                Console.WriteLine($"Order {OrderId} processed! ");
            }

        }

        static Order[] RecieveOrdersFromBranch1()
        {
            Order[] orders = new Order[]
            {
            new Order(1,5),
            new Order(3,6),
            new Order(6,10)

            };
            return orders;
        }

        static Order[] RecieveOrdersFromBranch2()
        {
            Order[] orders = new Order[]
            {
            new Order(2,24),
            new Order(4,423),
            new Order(5,11)

            };
            return orders;
        }
    }
}
