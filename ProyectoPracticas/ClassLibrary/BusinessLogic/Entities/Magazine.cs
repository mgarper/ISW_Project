using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Magazine
    {
        public Magazine()
        {
            Areas = new List<Area>();
            Issues = new List<Issue>();
        }

        public Magazine(string name, User chiefEditor)
        {
            Name = name;

            ChiefEditor = chiefEditor;
            Areas = new List<Area>();
            Issues = new List<Issue>();
        }

        public User GetChiefEditor() 
        { 
            return ChiefEditor;
        }

        public ICollection<string> GetAreas()
        {
            ICollection<string> result = new List<string>();
            for(int i = 0; i<Areas.Count; i++)
            {
                result.Add(Areas.ElementAt(i).GetName());
            }
            return result;  
        }

        public Area GetAreaByName(string area)
        {
            bool found = false;
            Area res = null;
            for(int i = 0; i<Areas.Count && !found; i++)
            {
                if(Areas.ElementAt<Area>(i).GetName() == area)
                {
                    res = Areas.ElementAt<Area>(i);
                    found = true;
                }
            }
            return res;
        }

        public ICollection<int> GetIssues()
        {
            ICollection<int> issues = new List<int>();
            foreach(Issue i in Issues)
            {
                issues.Add(i.GetNumber());
            }
            return issues;
        }
    }
}
