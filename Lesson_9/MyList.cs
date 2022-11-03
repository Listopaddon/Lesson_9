using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    public class MyList<T>
    {
        private T[] massive;
        private int length = 0;
        private int size = 0;

        public T this[int index]
        {
            get { return massive[index]; }
            set { massive[index] = value; }
        }

        protected int Size
        {
            get { return size; }
        }

        public MyList(int size)
        {
            this.massive = new T[size];
            this.size = size;
        }

        public void Add(T value)
        {
            massive[length] = value;
            length++;
        }

        public void Delete(int index)
        {
            massive[index] = default;
        }

        public T GetValue(int index)
        {
            return massive[index];
        }

        public int GetLenth()
        {
            return size;
        }
    }
}
