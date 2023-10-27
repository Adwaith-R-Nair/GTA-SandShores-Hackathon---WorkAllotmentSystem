using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAllotmentSystem
{
    internal class Manager
    {
        public int skillFactor;
        public Employee[] employeeList = new Employee[5];
        public Work[] workList = new Work[4];
        public float minValue;
        public float maxValue;
        public Work currentWork;

        public void workAssigner()
        {
            foreach(Work i in workList)
            {
                if (i.isAssigned == false)
                {
                    currentWork = i;
                    i.isAssigned = true;
                    break;
                }
            }
        }

        public void eligibilityCalculator()
        {

            foreach(Employee j in employeeList)
            {
                var skillfactor = j.skillset.Intersect(currentWork.requiredSkills);
                skillFactor = skillfactor.Count();
                j.workEligibilty = (skillFactor) * j.experience / j.workCompletionTime * j.workLoad;
                

            }
        }
        public void scheduler()
        {
            foreach (Employee j in employeeList)
            {
                if(j.workEligibilty > minValue&& j.workLoad < maxValue)
                {
                    j.assignedWork.Append(currentWork);
                }
            }
        }
        


    }
}
