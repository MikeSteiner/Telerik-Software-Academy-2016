/*
 * 
Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
Check all input parameters to avoid accessing elements at invalid positions.
 * 
 */

namespace GenericClass
{
    using GenericListATo;
    using CoordinateSystem;

    public class StartPoint
    {
        public static void Main()
        {
            GenericList<int> myList = new GenericList<int>(6);

            // Adding elements
            for (int i = 0; i < 10; i++)
            {
                myList.Add(i);
            }

            //Select element by index
            int sellectedElement = myList[4];
            myList[5] = 55;
            // Uncomment next line for Out of Range exeption
            //testList[100] = 100;

            // Remove element at given position
            myList.RemoveAt(4);

            // Insert elemetn at a given position
            myList.InsertAt(22, 4);

            //Clear the collection
            //myList.Clear();



            //Find first occurence by given a searched element

            // Vlaue type chack
            GenericList<int> myInts = new GenericList<int>(6);
            for (int i = 11; i < 11 + 6; i++)
            {
                myInts.Add(i);
            }
            int foundIx = myInts.FindFirst(13);

            // Reference type check
            Point3D A = new Point3D(1, 2, 3);
            Point3D B = new Point3D(2, 1, 3);
            Point3D C = new Point3D(3, 2, 1);

            GenericList<Point3D> myPoints = new GenericList<Point3D>(6);
            myPoints.Add(A);
            myPoints.Add(B);
            myPoints.Add(C);

            Point3D searchedPoint = new Point3D(2, 1, 3);

            foundIx = myPoints.FindFirst(searchedPoint); 




            


        }
    }
}
