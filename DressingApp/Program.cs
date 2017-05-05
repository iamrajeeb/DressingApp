using DressingApp.Model;
using System;
using System.Collections.Generic;
using static DressingApp.Model.Enums;

namespace DressingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialized data
            List<DressModel> DressModelList = Data.initializeData();

            //Take input

            string[] inputs = { "COLD", "8,6,3,4,2,5,7" };//Console.ReadLine().Split(' ');
            TemperatureEnum temp = inputs[0].Equals("HOT") ? TemperatureEnum.HOT : TemperatureEnum.COLD;
            int[] commandArray = Array.ConvertAll(inputs[1].Split(','), Int32.Parse);

            //validate dress
            List<string> result = new DressingHelper().checkDress(temp, commandArray, DressModelList);

        }
    }
}
