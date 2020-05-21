using System;
using DataStructures.Stack;
using DataStructures.Queue;

namespace DataStructures
{
	public class PseudoNode
	{
		public Animal Type { get; set; }
		public PseudoNode Next { get; set; }

		public PseudoNode(Animal n)
		{
			this.Type = n;
		}
	}

	public enum Animal
	{
		Dog = 1,
		Cat = 2
	}

	public class AnimalShelter
	{
		public NewQueue Dogs { get; set; }
		public NewQueue Cats { get; set; }
		public NewQueue All { get; set; }

		public AnimalShelter()
		{
			Dogs = new NewQueue();
			Cats = new NewQueue();
			All = new NewQueue();
		}

		public void EnqueueAnimal(PseudoNode animal)
		{
            All.Enqueue(animal);

			if (animal.Type == Animal.Cat)
				Cats.Enqueue(animal);
			else
				Dogs.Enqueue(animal);
		}

		public void DequeueDog()
		{
			//Remove from the dog list.
			var adoptedDog = Dogs.Dequeue();

			//Then remove from the overall list.
			All.DequeueAny(adoptedDog);
		}

		public void DequeueCat()
		{
			//Remove from the cat list.
			var adoptedCat = Cats.Dequeue();

			//Then remove from the overall list.
			All.DequeueAny(adoptedCat);
		}

		public void DequeueAny(PseudoNode item)
		{
			//Remove from the all list.
			var animal = All.Dequeue();

			//Then remove from either the dog list or cat list.
			if (animal.Type == Animal.Cat)
				Cats.DequeueAny(animal);
			else
				Dogs.DequeueAny(animal);
		}
	}

	public class NewQueue
	{
		//Private members.
		PseudoNode head = null;
		PseudoNode tail = null;
		int count = 0;

		public PseudoNode Head
		{
			get
			{
				return head;
			}
		}

		public PseudoNode Tail
		{
			get
			{
				return tail;
			}
		}

		//Add to the tail of the list.
		public void Enqueue(PseudoNode newItem)
		{
			if (count == 0)
			{
				head = newItem;
			}
			else
			{
				tail.Next = newItem;
			}

			tail = newItem;
			count++;
		}

		//Remove any element from the list at any position.
		public PseudoNode DequeueAny(PseudoNode item)
		{
			PseudoNode current = head;
			PseudoNode previous = null;

			PseudoNode dequeued = null;

			while (current != null)
			{
				PseudoNode next = current.Next;

				if (current == item)
				{
					dequeued = current;

					if (previous == null)
					{
						head = next;
						current = null;
						break;
					}
					else
					{
						//Copy down the next pointer into the current node
						//to override it. Otherwise it will still be in the 
						//list when setting previous in line 101.
						current = next;
						previous.Next = current;

						//Adjust the tail
						if (current.Next == null)
							tail = current;
					}

					count--;
				}

				previous = current;
				current = current.Next;
			}


			return dequeued;
		}

		//Remove from the head of the list.
		public PseudoNode Dequeue()
		{
			PseudoNode dequeued = null;
			PseudoNode current = head;

			if (count > 0)
			{
				dequeued = head;
				head = head.Next;
				count--;
			}

			return dequeued;
		}

	}
}