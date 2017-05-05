using DressingApp.Model;
using System.Collections.Generic;

namespace DressingApp
{
    public static class Data
    {
        public static List<DressModel> initializeData()
        {
            List<DressModel> DressModelList = new List<DressModel>();
            DressModelList.Add(new DressModel(1, "Put on footwear", "sandles", "boots"));
            DressModelList.Add(new DressModel(2, "Put on headwear", "sun visor", "hat"));
            DressModelList.Add(new DressModel(3, "Put on socks", "fail", "socks"));
            DressModelList.Add(new DressModel(4, "Put on shirt", "t - shirt", "shirt"));
            DressModelList.Add(new DressModel(5, "Put on jacket", "fail", "jacket"));
            DressModelList.Add(new DressModel(6, "Put on pants", "shorts", "pants"));
            DressModelList.Add(new DressModel(7, "Leave house", "leaving house", "leaving house"));
            DressModelList.Add(new DressModel(8, "Take off pajamas", "Removing PJs", "Removing PJs"));
            return DressModelList;
        }
    }
}
