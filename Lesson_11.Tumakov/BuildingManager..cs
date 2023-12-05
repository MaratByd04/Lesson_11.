using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11.Tumakov
{
    class BuildingManager
    {
        private Building[] buildings = new Building[10];

        public BuildingManager()
        {
            for (int i = 0; i < buildings.Length; i++)
            {
                buildings[i] = new Building();
            }
        }

        public Building this[int index]
        {
            get
            {
                if (index >= 0 && index < buildings.Length)
                {
                    return buildings[index];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
