using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementSystemEntities
{
    public class Human
    {
        public int HumanID { get; set; }
        public string Name { get; set; }
        private string BaseProperty { get; set; }

        public virtual string ReturnBaseProperty()
        {
            BaseProperty = "Set Value";
            return BaseProperty;
        }
        public virtual string GetName()
        {
            return "Human Name";
        }
    }
}
