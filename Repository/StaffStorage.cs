using mypracticework.Domain;
using System.Collections.Generic;

namespace mypracticework.Repository
{
        public class StaffStorage
        {
            private Dictionary<int, Staff> Staffies { get; } = new();

            public void Create(Staff staff)
            {
                Staffies.Add(staff.StaffId, staff);
            }

            public Staff Read(int staffId)
            {
                return Staffies[staffId];
            }

            public Staff Update(int staffId, Staff newStaff)
            {
                Staffies[staffId] = newStaff;
                return Staffies[staffId];
            }

            public bool Delete(int staffId)
            {
                return Staffies.Remove(staffId);
            }

        }
}






      
    }
}