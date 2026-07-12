using System;

namespace LinkedList
{
	internal class Program
	{
		static Random random = new Random();
		static void Main(string[] args)
		{
			LinkedList linkedList = new LinkedList();

			for (int i = 0; i < 10; i++)
			{
				linkedList.Add(random.Next(0, 10));
			}

			WriteToConsole("Print()");
			linkedList.Print();
			Console.WriteLine();

			WriteToConsole("Count()");
			Console.WriteLine($"Antal element i listan är: {linkedList.Count()}");
			Console.WriteLine();

			WriteToConsole("GetFirstValue()");
			Console.WriteLine($"Första elementet i listan har värdet: {linkedList.GetFirstValue()}");
			Console.WriteLine();

			WriteToConsole("GetLastValue()");
			Console.WriteLine($"Sista elementet i listan har värdet: {linkedList.GetLastValue()}");
			Console.WriteLine();

			WriteToConsole("GetValue(index)");
			int randomValue = random.Next(0, linkedList.Count());
			Console.WriteLine($"Värdet på index " + randomValue + $" i listan är: {linkedList.GetValue(randomValue)}");
			Console.WriteLine();

			//Console.WriteLine("\nTömmer listan..");
			//linkedList.Clear();
			//Console.WriteLine($"\nAntal element i listan är: {linkedList.Count()}");

			randomValue = random.Next(0, 10);
			WriteToConsole("InsertFirst(int value)");
			Console.WriteLine($"Skapar ett nytt element med värdet {randomValue} och lägger det först i listan.");
			linkedList.InsertFirst(randomValue);
			linkedList.Print();
			Console.WriteLine();

			randomValue = random.Next(0, 10);
			WriteToConsole("GetFirstIndex(int value)");
			int? index = linkedList.GetFirstIndex(randomValue);
			Console.WriteLine(
				index == null
					? $"Värdet {randomValue} finns inte i listan."
					: $"Värdet {randomValue} finns första gången på index {index} i listan."
			);
			Console.WriteLine();

			randomValue = random.Next(0, 10);
			WriteToConsole("GetNextValue(int value)");
			int? nextValue = linkedList.GetNextValue(randomValue);
			Console.WriteLine(
				nextValue == null
					? $"Värdet {randomValue} finns inte i listan."
					: $"Värdet {randomValue} finns i listan och värdet efter är {nextValue}."
			);
			Console.WriteLine();

			randomValue = random.Next(0, 10);
			WriteToConsole("GetPrevValue(int value)");
			int? prevValue = linkedList.GetPrevValue(randomValue);
			Console.WriteLine(
				prevValue == null
					? $"Värdet {randomValue} finns inte i listan."
					: $"Värdet {randomValue} finns i listan och värdet före är {prevValue}."
			);
			Console.WriteLine();

			randomValue = random.Next(0, 10);
			WriteToConsole("Remove(int value)");
			bool elementRemoved = linkedList.Remove(randomValue);
			Console.WriteLine(
				elementRemoved
					? $"Värdet {randomValue} fanns i listan och togs bort."
					: $"Värdet {randomValue} fanns inte i listan."
			);
			linkedList.Print();
			Console.WriteLine();

			randomValue = random.Next(0, 10);
			WriteToConsole("RemoveAt(int index)");
			elementRemoved = linkedList.RemoveAt(randomValue);
			Console.WriteLine(
				elementRemoved
					? $"Index {randomValue} finns i listan och togs bort."
					: $"Index {randomValue} fanns inte i listan."
			);
			linkedList.Print();
			Console.WriteLine();

			randomValue = random.Next(0, 10);
			int randomIndex = random.Next(0, 10);
			WriteToConsole("InsertAt(int index)");
			bool elementInserted = linkedList.InsertAt(randomIndex, randomValue);
			Console.WriteLine(
				elementInserted
					? $"Elementet med värdet {randomValue} las till i listan på index {randomIndex}."
					: $"Elementet med värdet {randomValue} gick inte att lägga till i listan på index {randomIndex}."
			);
			linkedList.Print();
			Console.WriteLine();

			randomIndex = random.Next(0, 10);
			int randomIndex2 = random.Next(0, 10);
			WriteToConsole("Swap(int index1, int index2)");
			bool elementSwaped = linkedList.Swap(randomIndex, randomIndex2);
			Console.WriteLine(
				elementSwaped
					? $"Elementet med index {randomIndex} bytte värde med elementet med index {randomIndex2}."
					: $"Det gick inte att byta värden på index {randomIndex} och index {randomIndex2}."
			);
			linkedList.Print();
			Console.WriteLine();

			randomValue = random.Next(0, 10);
			int randomValue2 = random.Next(0, 10);
			WriteToConsole("SwapValue(int value1, int value2)");
			bool valuesSwaped = linkedList.SwapValues(randomValue, randomValue2);
			Console.WriteLine(
				valuesSwaped
					? $"Elementet med värde {randomValue} bytte värde med elementet med värde {randomValue2}."
					: $"Värde {randomValue} och värde {randomValue2} finns inte i listan."
			);
			linkedList.Print();
			Console.WriteLine();

			WriteToConsole("Sort()");
			linkedList.Sort();
			linkedList.Print();
			Console.WriteLine();

			WriteToConsole("Clear()");
			linkedList.Clear();
			linkedList.Print();
			Console.WriteLine();
		}

		static void WriteToConsole(string text)
		{
			Console.BackgroundColor = ConsoleColor.Cyan;
			Console.ForegroundColor = ConsoleColor.Black;

			Console.Write(text);       // Ingen radbrytning ännu

			Console.ResetColor();      // Återställ terminalens färger
			Console.WriteLine();       // Skriv radbrytningen efteråt

			Console.WriteLine("-----------------");
		}
	}

	internal class Element
	{
		private int value;
		private Element? prev;
		private Element? next;

		public int Value
		{
			get { return value; }
			set { this.value = value; }
		}

		public Element? Prev
		{
			get { return prev; }
			set { prev = value; }
		}

		public Element? Next
		{
			get { return next; }
			set { next = value; }
		}

		public Element(int value, Element? prev, Element? next)
		{
			this.value = value;
			this.prev = prev;
			this.next = next;
		}
	}

	internal class LinkedList
	{
		Element? element;
		public LinkedList()
		{

		}

		// Lägger till ett nytt element sist i listan
		public void Add(int value)
		{
			Element newElement = new Element(value, null, null);

			if (element == null)
			{
				element = newElement;
				return;
			}

			Element current = element;

			while (current.Next != null)
			{
				current = current.Next;
			}

			current.Next = newElement;
			newElement.Prev = current;
		}

		// Skriver ut alla element i listan
		public void Print()
		{
			if (element == null)
				return;

			Element current = element;

			while (current != null)
			{
				Console.Write($"[{current.Value}] ");
				current = current.Next;
			}
			Console.WriteLine();
		}

		// Sätt listan till null. 
		public void Clear()
		{
			element = null;
		}

		public int Count()
		{
			int count = 0;

			if (element is null)
				return 0;

			Element current = element;

			while (current != null)
			{
				count++;
				current = current.Next;
			}

			return count;
		}

		// Returnerar null om listan är tom 
		// eller om det inte finns något element 
		// på position index eller om index är  
		// negativt 
		public int? GetValue(int index)
		{
			if (element is null || index < 0)
				return null;

			Element current = element;

			int i = 0;

			while (current != null)
			{
				if (i == index)
					return current.Value;
				current = current.Next;
				i++;
			}

			return null;
		}

		// Returnerar null om listan är tom 
		public int? GetFirstValue()
		{
			if (element is null)
				return null;

			return element.Value;
		}

		// Returnerar null om listan är tom 
		public int? GetLastValue()
		{
			if (element is null)
				return null;

			Element current = element;

			while (current.Next != null)
			{
				current = current.Next;
			}

			return current.Value;
		}

		public void InsertFirst(int value)
		{
			Element newElement = new Element(value, null, null);
			if (element is null)
			{
				element = newElement;
			}
			else
			{
				element.Prev = newElement;
				newElement.Next = element;
				element = newElement;
			}
		}

		// Returnerar null om inget element har 
		// värdet value eller om listan är tom. 
		// Returnerar index för första elementet
		// som har värdet value 
		public int? GetFirstIndex(int value)
		{
			if (element is null)
				return null;

			Element current = element;

			int index = 0;

			while (current != null)
			{
				if (current.Value == value)
					return index;
				current = current.Next;
				index++;
			}

			return null;
		}

		// Returnernar null om det inte finns 
		// något element innan eller om listan  
		// är tom. 
		public int? GetPrevValue(int value)
		{
			if (element is null)
				return null;

			Element current = element;

			while (current != null)
			{
				if (current.Value == value && current.Prev != null)
					return current.Prev.Value;
				current = current.Next;
			}

			return null;
		}

		// Returnerar null om det inte finns 
		// något element efter eller om listan  
		// är tom 
		public int? GetNextValue(int value)
		{
			if (element is null)
				return null;

			Element current = element;

			while (current != null)
			{
				if (current.Value == value && current.Next != null)
					return current.Next.Value;
				current = current.Next;
			}

			return null;
		}

		// Returnerar false om det inte fanns något  
		// element med värdet value, annars true på  
		// det gick att ta bort elementet 
		public bool Remove(int value)
		{
			if (element == null)
				return false;

			Element current = element;

			while (current != null)
			{
				if (current.Value == value)
				{
					if (current.Prev != null)
					{
						Element previous = current.Prev;
						previous.Next = current.Next;
						if (current.Next != null)
						{
							Element next = current.Next;
							next.Prev = current.Prev;
						}
						return true;
					}
					if (current.Next != null)
					{
						element = current.Next;
					}
					else
					{
						element = null;
					}
					return true;
				}
				current = current.Next;
			}
			return false;
		}

		// Returnerar false om det inte fanns något  
		// element på position index i listan,  
		// annars true 
		public bool RemoveAt(int index)
		{
			if (element == null)
				return false;

			Element current = element;

			int currentIndex = 0;

			while (current != null)
			{
				if (index == currentIndex)
				{
					if (current.Prev != null)
					{
						Element previous = current.Prev;
						previous.Next = current.Next;
						if (current.Next != null)
						{
							Element next = current.Next;
							next.Prev = current.Prev;
						}
						return true;
					}
					if (current.Next != null)
					{
						element = current.Next;
					}
					else
					{
						element = null;
					}
					return true;
				}
				currentIndex++;
				current = current.Next;
			}
			return false;
		}

		// Returnerar true om det gick 
		// att stoppa in värdet på  
		// position index 
		public bool InsertAt(int index, int value)
		{
			if (index < 0 || index > this.Count())
				return false;

			// Lägg nya elementet först i listan
			if (index == 0)
			{
				this.InsertFirst(value);
				return true;
			}

			// Lägg nya elementet sist i listan
			if (index == this.Count())
			{
				this.Add(value);
				return true;
			}

			Element current = element;
			Element newElement = new Element(value, null, null);

			int currentIndex = 0;

			while (current != null)
			{
				if (index == currentIndex)
				{
					Element previousElement = current.Prev;
					previousElement.Next = newElement;
					newElement.Prev = previousElement;
					newElement.Next = current;
					current.Prev = newElement;
					return true;
				}
				currentIndex++;
				current = current.Next;
			}
			return false;
		}

		// Returnerar false om det inte gick, 
		// true om det fick att byta platspå  
		// värdena. OBS! Byt inte plats på noderna utan 
		// bara värdena.  
		public bool Swap(int index1, int index2)
		{
			if (index1 < 0 || index2 < 0 || index1 > this.Count() - 1 || index2 > this.Count() - 1 || index1 == index2)
				return false;

			Element current = element;
			Element firstElement = null;
			Element secondElement = null;
			Element tempElement = new Element(0, null, null);
			int currentIndex = 0;

			while (current != null)
			{
				if (index1 == currentIndex)
					firstElement = current;
				if (index2 == currentIndex)
					secondElement = current;
				current = current.Next;
				currentIndex++;
			}

			tempElement.Value = firstElement.Value;
			firstElement.Value = secondElement.Value;
			secondElement.Value = tempElement.Value;

			return true;
		}

		// Returnerar false om det  
		// inte gick 
		public bool SwapValues(int value1, int value2)
		{
			int? firstIndex = this.GetFirstIndex(value1);
			int? SecondIndex = this.GetFirstIndex(value2);

			if (firstIndex == null || SecondIndex == null)
				return false;
			else
				return Swap(firstIndex.Value, SecondIndex.Value);
		}

		//Bubble sort
		public void Sort()
		{
			int max = Count() - 1;
			for (int i = 0; i < max; i++)
			{
				int nrLeft = max - i;
				for (int j = 0; j < nrLeft; j++)
				{
					if (GetValue(j).Value > GetValue(j + 1).Value)
						Swap(j, j + 1);
				}
			}
		}
	}
}
