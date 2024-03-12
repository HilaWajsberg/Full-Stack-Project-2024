using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLModels
{
    public class UICourse
    {
        public string Name { get; set; }
        public int NumOfMembers { get; set; }
        public int Day { get; set; }
        public float Hour { get; set; }
        public string Ageing { get; set; }
        public int Price { get; set; }
        public string Level { get; set; }
        public UICourse(string name, int num, int day, float hour, string age, int price,string level) {
            Name = name;
            NumOfMembers = num;
            Day = day;
            Hour = hour;
            Ageing = age;
            Price = price;
            Level = level;
        }
        public UICourse()
        {
            
        }


    }
}
