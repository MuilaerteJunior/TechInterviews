namespace TechInterviews
{
    internal class AmazonApproaches
    {
        internal int[] IdentifyDays(int[] stockValuesByDay)
        {
            if ( stockValuesByDay == null || stockValuesByDay.Length < 2)
                return new int[]{ 0, 0};

            var myCurrentWalletBuy = decimal.MaxValue;
            var myWalletSelling = stockValuesByDay[0];
            var currentMaxProfit = 0;
            var myDayIndexes = new int[2] { 0 , 0  };

            for (int indexDay = 0; indexDay < stockValuesByDay.Length; indexDay++)
            {
                if (stockValuesByDay[indexDay] < myCurrentWalletBuy)
                {
                    myCurrentWalletBuy = stockValuesByDay[indexDay];
                    myDayIndexes[0] = indexDay;
                    myDayIndexes[1] = indexDay;
                }

                var currentProfit = stockValuesByDay[indexDay] - myWalletSelling;
                if (currentProfit > currentMaxProfit)
                {
                    currentMaxProfit = currentProfit;
                    myDayIndexes[1] = indexDay;
                }
            }

            return myDayIndexes;
        }
    }
}
