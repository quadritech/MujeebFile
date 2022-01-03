using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadritech
{
    public class Animation : IAnimation
    {
        //Instantiation
        public Animation()
        {

        }

        //Methods
        public int GetMax(int first, int second)
        {
            int a;
            if (first > second) a = first;
            else a = second;

            return a;
        }

        public bool ToCheckEqualityOfArray()
        {
            bool arrayEqual = true;
            return arrayEqual;
        }

        public int arrayexcercise()
        {
            int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
            }

            return arr.Length;
        }

        public string CreateStudentProfile(CreateStudentProfileModel model)
        {
            return default;
        }
    }

    

    
}
