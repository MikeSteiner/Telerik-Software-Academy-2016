namespace CallNs
{
    using System;
    using System.Collections.Generic;

    public class Calls
    {
        public const decimal MINUTE_PRICE = 0.37m;

        private static List<Calls> history;
        private List<string> historyInfo;

        private DateTime callStartDT;
        private DateTime callEndDT;
        private TimeSpan callDuration;
        private double callDurationSec;
        private string number;
        private Direction direction;
        private State state;
        
        public Calls()
        {
            history = new List<Calls>();
        }

        // Properties
        public DateTime CallStart
        {
            get
            {
                return this.callStartDT;
            }

            protected set
            {
                this.callStartDT = value;
            }
        }

        public DateTime CallEnd
        {
            get
            {
                return this.callEndDT;
            }

            protected set
            {
                this.callEndDT = value;
            }
        }

        public string Number
        {
            get
            {
                return this.number;
            }

            protected set
            {
                bool isValidNumber = true;
                if (isValidNumber)
                {
                    this.number = value;
                }
            }
        }

        public Direction CallDirection
        {
            get
            {
                return this.direction;
            }

            protected set
            {
                this.direction = value;
            }
        }

        public State CallState
        {
            get
            {
                return this.state;
            }

            protected set
            {
                this.state = value;
            }
        }

        public int HistoryCount
        {
            get
            {
                return history.Count;
            }
        }

        // Methods
        public void StartNewCall(string callNumber, Direction callDirection)
        {
            bool isValidNumber = true;
            if (!isValidNumber)
            {
                throw new ArgumentOutOfRangeException("Phosne number is not valid");
            }

            this.CallStart = DateTime.Now; 
            this.Number = callNumber;
            this.CallDirection = callDirection;
        }

        public void EndCall(State callState)
        {
            this.CallEnd = DateTime.Now;
            this.CallState = callState;

            this.CalcCallDuration();
            this.AddToHistory();
        }

        public string GetHistory(int callIndex)
        {
            this.HistoryInfo(callIndex);

            return string.Join("; ", this.historyInfo);
        }

        private static decimal CallsTotalTimeInSec()
        {            
            decimal totalCallSeconds = 0.0m;
            foreach (var call in Calls.history)
            {
                totalCallSeconds += (decimal)call.callDuration.TotalSeconds;
            }
           
            return totalCallSeconds;
        }

        public decimal GetCallsTotalPrice()
        {
            decimal totalCallsDurationInSec = CallsTotalTimeInSec();
            //totalCallsDurationInSec = totalCallsDurationInSec / 60.0m * MINUTE_PRICE;

            totalCallsDurationInSec = totalCallsDurationInSec / 60.0m;
            totalCallsDurationInSec = totalCallsDurationInSec * MINUTE_PRICE;

            return totalCallsDurationInSec;
        }

        public int FindLongestCall()
        {            
            int bestIx = -1;
            double bestCallDuration = double.MinValue;

            foreach (Calls call in history)
            {
                bool isCurrentBestCall = (call.callDurationSec > bestCallDuration);
                if (isCurrentBestCall)
                {
                    bestCallDuration = call.callDurationSec;
                    bestIx = history.IndexOf(call);
                }                
            }

            return bestIx;
        }

        public void RemoveSingleCall(int index)
        {
            RemoveFromHistory(index);
        }

        public void RemoveAllCalls()
        {
            int callsInHistCout = history.Count;

            for (int i = callsInHistCout - 1; i >= 0; i--)
            {
                RemoveFromHistory(i);
            }            
        }

        private void CalcCallDuration()
        {
            // TimeSpan callDuration;
            if (this.callEndDT > this.callStartDT)
            {
                this.callDuration = this.callEndDT - this.callStartDT;
            }
            else
            {
                this.callDuration = TimeSpan.Parse("0");
            }

            this.callDurationSec = this.callDuration.TotalSeconds;
        }

        private void AddToHistory()
        {
            // Calls currentCall = new Calls();
            var currentCall = (Calls)this.MemberwiseClone();
            history.Add(currentCall);
        }

        private static void RemoveFromHistory(int index)
        {
            history.RemoveAt(index);
        }

        // Provide Info
        private void HistoryInfo(int callIx)
        {
            this.historyInfo = new List<string>();

            // Fill the indexte call date in the list
            this.historyInfo.Add(history[callIx].callDurationSec.ToString());
            this.historyInfo.Add(history[callIx].number);
            this.historyInfo.Add(history[callIx].state.ToString());            
            this.historyInfo.Add(history[callIx].callStartDT.ToString());
            this.historyInfo.Add(history[callIx].callEndDT.ToString());
            this.historyInfo.Add(history[callIx].callDuration.ToString());           
        }                
    }
}
