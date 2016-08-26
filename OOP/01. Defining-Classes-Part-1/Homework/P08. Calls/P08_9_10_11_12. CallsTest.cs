/*
 * --------------------------------------------
Problem 8. Calls

Create a class Call to hold a call performed through a GSM.
It should contain date, time, dialled phone number and duration (in seconds).
--------------------------------------------
Problem 9. Call history

Add a property CallHistory in the GSM class to hold a list of the performed calls.
Try to use the system class List<Call>.
--------------------------------------------
Problem 10. Add/Delete calls

Add methods in the GSM class for adding and deleting calls from the calls history.
Add a method to clear the call history.
--------------------------------------------
Problem 11. Call price

Add a method that calculates the total price of the calls in the call history.
Assume the price per minute is fixed and is provided as a parameter.
--------------------------------------------
Problem 12. Call history test

Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
Create an instance of the GSM class.
Add few calls.
Display the information about the calls.
Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
Remove the longest call from the history and calculate the total price again.
Finally clear the call history and print it.
 */

namespace CallsTestNS
{    
    using System;
    using System.Threading;
    using CallNs;

    public class CallsTest
    {
        public static void Main(string[] args)
        {            
            Calls call = new Calls();

            call.StartNewCall("0893 655 921", Direction.Outgo);
            SimulateCallDelay(2000);        // Simulate call delay
            call.EndCall(State.Answered);

            call.StartNewCall("0893 111 111", Direction.Outgo);            
            SimulateCallDelay(1100);        // Simulate call delay
            call.EndCall(State.Rejected);

            call.StartNewCall("0893 222 222", Direction.Outgo);
            SimulateCallDelay(4567);        // Simulate call delay
            call.EndCall(State.Answered);

            call.StartNewCall("0893 333 333", Direction.Outgo);            
            SimulateCallDelay();            // Simulate call delay
            call.EndCall(State.Missed);

            /*
             * First task             
             */
            Console.WriteLine("{0}", new string('-', 20));

            // Get all cals information
            for (int i = 0; i < call.HistoryCount; i++)
            {
                string callInfo = call.GetHistory(i);
                Console.WriteLine(callInfo);
            }

            /****
             * Second task             
             */
            Console.WriteLine("{0}", new string('-', 20));

            // Get total call costs in curretn curency [BGN]
            decimal totalCallsPrice = call.GetCallsTotalPrice();
            Console.WriteLine("Total calls price: {0:F2} lv.", totalCallsPrice);

            /****
             * Third task             
             */
            Console.WriteLine("{0}", new string('-', 20));

            // Delete the longest call from the history list
            int longestCallIx = call.FindLongestCall();
            call.RemoveSingleCall(longestCallIx);

            Console.WriteLine("Delete the longest call from the history list");
            for (int i = 0; i < call.HistoryCount; i++)
            {
                string callInfo = call.GetHistory(i);
                Console.WriteLine(callInfo);
            }
            Console.WriteLine("Total calls price: {0:F2} lv.", call.GetCallsTotalPrice());

            /****
             * Forth task             
             */
            Console.WriteLine("{0}", new string('-', 20));
            // Delete all calls from the history list
            call.RemoveAllCalls();

            Console.WriteLine("Delete all calls from the history list");
            for (int i = 0; i < call.HistoryCount; i++)
            {
                string callInfo = call.GetHistory(i);
                Console.WriteLine(callInfo);
            }
        }

        public static void SimulateCallDelay(int miliseconds = 1000)
        {
            if (miliseconds > 0)
            {
                Thread.Sleep(miliseconds);
            }            
        }
    }
}
