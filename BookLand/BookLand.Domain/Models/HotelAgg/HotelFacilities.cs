using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLand.Domain.Models.HotelAgg
{
    internal class HotelFacilities : BaseModel
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public long ParentID { get; set; }
        public HotelFacilities(string title, string picture, long parentID)
        {
            Title = title;
            Picture = picture;
            ParentID = parentID;
        }
    }
}
