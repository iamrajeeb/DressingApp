using DressingApp.Model;
using System.Collections.Generic;
using static DressingApp.Model.Enums;

namespace DressingApp
{
    public class DressingHelper
    {
        List<int> processedCommand = new List<int>();
        TemperatureEnum HCTemp;
        public List<string> checkDress(TemperatureEnum temp, int[] commands, List<DressModel> DressModelList)
        {
            HCTemp = temp;
            List<string> result = new List<string>();
            for (int i = 0; i < commands.Length; i++)
            {
                if (checkRule(commands[i]))
                {
                    DressModel dm = DressModelList.Find(m => m.Id == commands[i]);
                    result.Add(temp == TemperatureEnum.HOT ? dm.HotResponse : dm.ColdResponse);
                }
                else
                {
                    result.Add("fail");
                    return result;
                }
            }
            return result;
        }
        public bool checkRule(int command)
        {
            if (processedCommand.Contains(command))
            {
                return false;
            }
            switch (command)
            {
                case 1:
                    processedCommand.Add(1);
                    if (processedCommand.Contains(6) && (HCTemp == TemperatureEnum.COLD && processedCommand.Contains(3)))
                    {
                        return true;
                    }
                    return false;
                case 2:
                    processedCommand.Add(2);
                    return processedCommand.Contains(4) ? true : false;
                case 3:
                    processedCommand.Add(3);
                    return (HCTemp == TemperatureEnum.HOT) ? false : true;

                case 4:
                    processedCommand.Add(4);
                    break;
                case 5:
                    processedCommand.Add(5);
                    return (HCTemp != TemperatureEnum.HOT && processedCommand.Contains(4)) ? true : false;

                case 6:
                    processedCommand.Add(6);
                    break;
                case 7:
                    processedCommand.Add(7);
                    if (HCTemp == TemperatureEnum.HOT && processedCommand.Count == 6)
                    {
                        return true;
                    }
                    if (HCTemp == TemperatureEnum.COLD && processedCommand.Count == 8)
                    {
                        return true;
                    }
                    return false;
                    break;
                case 8:
                    processedCommand.Add(8);
                    return (processedCommand.Count > 1) ? false : true;
            }
            return true;
        }
    }
}
