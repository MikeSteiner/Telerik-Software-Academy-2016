namespace GenericListATo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // Write a generic class GenericList<T> that keeps a list of elements of some parametric type  T.
    public class GenericList<T>
    {
        //private const int INITIAL_CAPACITY = 16;
        private int initialCapacity = 16;

        private T[] container;
        private int index;
        private int capacity;

        // Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
        public GenericList()
        {
            this.container = new T[initialCapacity];
            this.index = 0;
            this.capacity = initialCapacity;
        }

        public GenericList(int capacity) : this()
        {
            this.container = new T[capacity];
            this.capacity = capacity;
            this.initialCapacity = capacity;
        }

        //Implement methods for accessing element by index
        public T this [int index]
        {
            get
            {
                CheckInputIndex(index);

                return this.container[index];
            }
            set
            {
                CheckInputIndex(index);
                this.container[index] = value;
            }    
        }

        private void CheckInputIndex(int index)
        {
            if (index < 0 || index >= this.capacity)
            {
                throw new IndexOutOfRangeException(string.Format("Index must be between [{0} and {1})", 0, this.capacity));
            }
        }

        private void DoubleCapacity()
        {
            // Copy data from container to a temp storage
            List<T> tempContainerCopy = this.container.Select(el => el).ToList();

            this.capacity *= 2;
            this.container = new T[this.capacity];

            //Copy back to container
            int ix = 0;
            foreach (T element in tempContainerCopy)
            {
                this.container[ix] = element;
                ix++;
            }
        }

        private bool CapacityCheck()
        {
            if (this.index + 1 == this.capacity)
            {
                return false;
            }

            return true;
        }

        //Implement methods for adding element,
        public void Add(T element)
        {
            // Check all input parameters to avoid accessing elements at invalid positions.
            if (element == null)
            {
                return;
            }

            // Check all input parameters to avoid accessing elements at invalid positions.
            // False means capacity must be doubled
            bool mustBeDoubled = !CapacityCheck();
            if (mustBeDoubled)
            {
                DoubleCapacity();
            }

            this.container[this.index] = element;
            this.index++;
        }        


        //Implement methods for removing element by index
        public void RemoveAt(int index)
        {
            CheckInputIndex(index);

            // Copy data from container to a temp storage without the indexed element
            T[] tempContainerCopy = this.container
                                    .Select((n, i) => new { val = n, ix = i })
                                    .Where(el => el.ix != index)
                                    .Select(ell => ell.val)
                                    .ToArray();

            this.index--;
            this.container = new T[this.capacity];
            CopyBackToContainer(tempContainerCopy);
        }

        private void CopyBackToContainer(T[] tempContainerCopy)
        {
            //Copy back to container
            int ix = 0;
            foreach (T element in tempContainerCopy)
            {
                this.container[ix] = element;
                ix++;
            }
        }

        //Implement methods for inserting element at given position
        public void InsertAt(T element, int index)
        {
            CheckInputIndex(index);

            // Check and double the capacity
            // False means capacity must be doubled
            bool mustBeDoubled = !CapacityCheck();
            if (mustBeDoubled)
            {
                DoubleCapacity();
            }

            // Copy data from container to a temp storage            
            T[] tempContainerCopy = new T[this.capacity];

            // Copy elemerts before the given index
            for (int i = 0; i < index; i++)
            {
                tempContainerCopy[i] = this.container[i];
            }

            // Add the new element (insert the new element)
            tempContainerCopy[index] = element;

            // Copy elemerts after the given index
            for (int i = index; i < capacity - 1; i++)
            {
                tempContainerCopy[i + 1] = this.container[i];
            }


            this.index++;
            // Clear the container conntent and copy all back
            this.container = new T[this.capacity];
            CopyBackToContainer(tempContainerCopy);

        }

        //Implement methods for clearing the list
        public void Clear()
        {
            this.capacity = initialCapacity;
            this.index = 0;
            this.container = new T[this.capacity];
        }

        // Implement methods for finding element by its value
        public int FindFirst(T searchedElement)
        {
            int ix = 0;
            foreach (T element in this.container)
            {               
                bool isMatch = CompareElements(searchedElement, element);

                if (isMatch)
                {
                    return ix;
                }

                ix++;
            }

            return (-1);
        }

        private bool CompareElements(T firstElement, T secondElement)
        {
            var fType = firstElement.GetType();
            var sType = secondElement.GetType();

            //Check floating point valuesCompareElements

            bool areEqualTypes= firstElement.Equals(secondElement);
            if (areEqualTypes)
            {
                return true;
            }

            return false;
        }

        //Override ToString()
        public override string ToString()
        {
            string result = string.Empty;
            for (int i = 0; i <= this.index; i++)
            {
                result += this.container[i];
                if (i < this.index)
                {
                    result += ", ";
                }
            }
            return result;
        }

        // Generic methods  Min<T>() for finding the minimal element in the GenericList<T>
        public static T Min<T>(GenericList<T> list) where T : IComparable<T>
        {
            var min = list[0];

            for (int i = 0; i <= list.index; i++)
            {
                var result = Comparer<T>.Default.Compare(min, list[i]);

                if (result == 1) min = list[i];
            }

            return min;
        }

        // Generic method Max<T>() for finding the maximal element in the GenericList<T>.
        public static T Max<T>(GenericList<T> list) where T : IComparable<T>
        {
            var max = list[0];

            for (int i = 0; i <= list.index; i++)
            {
                var result = Comparer<T>.Default.Compare(max, list[i]);

                if (result == -1) max = list[i];
            }

            return max;
        }
    }
}
