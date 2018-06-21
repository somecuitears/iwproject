using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengesOne.Lib
{
    public class Handler
    {
        private String forS ="dep";
        int tHr = 0, tMin = 0;
        bool hrCheck, minCheck;
        public void Execute()
        {
            //_time = Console.ReadLine();
            //String[] subStringH = _time.Split(" ");
            //bool hrCheck = Int32.TryParse(subStringH[0], out int departureHour);
            //bool minCheck = Int32.TryParse(subStringH[1], out int departureMinute);
            //if (hrCheck && minCheck && departureHour >= 0 && departureHour <= 23 && departureMinute >= 0 && departureMinute <= 59)
            //{
            //    _duration = Console.ReadLine();
            //    String[] subStringM = _duration.Split(" ");
            //    bool hrDurCheck = Int32.TryParse(subStringM[0], out int durationHour);
            //    bool minDurCheck = Int32.TryParse(subStringM[1], out int durationMinute);
            //    if (hrDurCheck && minDurCheck && durationHour >= 0 && durationHour <= 23 && durationMinute >= 0 && durationMinute <= 59)
            //    {
            //        int nHr = departureHour + durationHour;
            //        int nMin = departureMinute + durationMinute;
            //        nHr = OffSet(nHr, 24);
            //        nMin = OffSet(nMin, 60);

            //        Console.WriteLine(ZeroFormat(nHr) + " " + ZeroFormat(nMin));
            //    }
            //}
            if (Initi(forS="dep") && Initi(forS="dur"))
            {
                tHr = OffSet(tHr, 24);
                if (tMin >= 60)
                    tHr++;
                tMin = OffSet(tMin, 60);
                DisplayResult(null);
            }
            else
            {
                DisplayResult("error");
            }

        }

        private bool Initi(String _tempInput)
        {
            if(_tempInput == "dep")
            {
                Console.WriteLine("Enter Departure Time (HH MM) : ");
            }
            else
            {
                Console.WriteLine("Enter Duration of the Travel (HH MM) : ");
            }
            do
            { 
                try
                {
                    _tempInput = Console.ReadLine();
                    String[] subString = _tempInput.Split(" ");
                    hrCheck = Int32.TryParse(subString[0], out int hour);
                    minCheck = Int32.TryParse(subString[1], out int minute);
                    if (hrCheck && minCheck && hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    {
                        tHr += hour;
                        tMin += minute;
                        return true;
                    }

                }
                catch (Exception e)
                {

                    Console.Write("Enter 24 Hour time format \n");

                }
            } while (!hrCheck && !minCheck);




            return true;
        }

        private void DisplayResult(String message)
        {
            if (message != null)
            {
                Console.Write("Invalid Date Format");
            }
            Console.WriteLine();
            Console.WriteLine("======= You will reach at : =======");
            Console.WriteLine();
            Console.WriteLine(ZeroFormat(tHr) + " " + ZeroFormat(tMin));
            Console.WriteLine();
            Console.WriteLine("======= =================== =======");
            Console.WriteLine();
        }

        private int OffSet(int temp, int val)
        {
            if (temp >= val)
            {
                temp -= val;
            }
            return temp;
        }

        private String ZeroFormat(int temp)
        {
            if (temp <= 9)
            {
                return "0" + temp.ToString();
            }
            return temp.ToString();
        }
    }
}
