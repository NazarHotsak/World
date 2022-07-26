using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World
{
    public enum TypeSettlement
    {
        Village = 0,
        City,
        RegionalCenter,
        DistrictCenter
    }

    public static class TypeSettlementExtension
    {
        public static string GetNameOfTypeSettlement(int typeSettlement)
        {
            return typeSettlement switch
            {
                0 => "c",
                1 => "м",
                2 => "м",
                3 => "м",
                _ => "",
            };
        }
    }
}
