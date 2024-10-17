using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BaldinAA.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            switch (m)
            {
                case 1:
                    return n == 31 ? "1.02" : $"{n + 1}.01";
                case 2:
                    return n == 28 ? "1.03" : $"{n + 1}.02";
                case 3:
                    return n == 31 ? "1.04" : $"{n + 1}.03";
                case 4:
                    return n == 30 ? "1.05" : $"{n + 1}.04";
                case 5:
                    return n == 31 ? "1.06" : $"{n + 1}.05";
                case 6:
                    return n == 30 ? "1.07" : $"{n + 1}.06";
                case 7:
                    return n == 31 ? "1.08" : $"{n + 1}.07";
                case 8:
                    return n == 31 ? "1.09" : $"{n + 1}.08";
                case 9:
                    return n == 30 ? "1.10" : $"{n + 1}.09";
                case 10:
                    return n == 31 ? "1.11" : $"{n + 1}.10";
                case 11:
                    return n == 30 ? "1.12" : $"{n + 1}.11";
                case 12:
                    return $"{n + 1}.12";
            }
            return "";
        }
    };
}
    

