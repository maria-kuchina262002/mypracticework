using mypracticework.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace mypracticework.Repository
{
    public class Staff
    {
        public class StaffStorage
        {
            private Dictionary<int, Staff> Staffies { get; } = new Dictionary<int, Staff>();

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
}