using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    public class MyListInt : MyList<int>
    {
        public MyListInt(int size) : base(size) { }

        public static MyListInt operator +(MyListInt value1, MyListInt value2)
        {
            if (value1.GetLenth() != value2.GetLenth())
            {
                throw new Exception("Wrong Size objects");
            }

            MyListInt result = new MyListInt(value1.GetLenth());

            for (int i = 0; i < value1.GetLenth(); i++)
            {
                result[i] = value1[i] + value2[i];
            }

            return result;
        }

        public static bool operator ==(MyListInt value1, MyListInt value2)
        {
            if (value1.GetLenth() != value2.GetLenth())
            {
                throw new Exception("Wrong Size objects");
            }


            for (int i = 0; i < value1.GetLenth(); i++)
            {
                if (value1[i] != value2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator !=(MyListInt value1, MyListInt value2)
        {
            if (value1.GetLenth() != value2.GetLenth())
            {
                throw new Exception("Wrong Size objects");
            }

            for (int i = 0; i < value1.GetLenth(); i++)
            {
                if (value1[i] != value2[i])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
