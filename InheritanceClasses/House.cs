using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClasses
{

    public enum HouseType { Cottage, Duplex, Ranch, Mansion }
    public enum  FloorType { Wood, Carpet, vinyl, Tile}
    public class House
    {
        public int NumberOfBedRooms { get; set; }
        public int SquareFeet{ get; set; }

        public FloorType Flooring { get; set; }
        public bool DoesItHaveBasement { get; set; }
        public HouseType TypeOfHouse { get; set; }
        
    }

}
