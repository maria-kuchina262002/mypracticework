using mypracticework.Domain;
using System.Collections.Generic;

namespace mypracticework.Repository
{
        public class MenuStorage
        {
            private Dictionary<int, Menu> Menues { get; } = new ();

            public void Create(Menu menu)
            {
                Menues.Add(menu.MenuId, menu);
            }

            public Menu Read(int menuId)
            {
                return Menues[menuId];
            }

            public Menu Update(int menuId, Menu newMenu)
            {
                Menues[menuId] = newMenu;
                return Menues[menuId];
            }

            public bool Delete(int menuId)
            {
                return Menues.Remove(menuId);
            }

        }
}







