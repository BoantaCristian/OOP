using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        public List<object> stackElements = new List<object>();
        public void Push(object obj)
        {
            try
            {
                if(obj != null)
                {
                    stackElements.Add(obj);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }
        public object Pop() //in tutorial: return type object
        {
            try
            {
                //check if list empty
                bool isEmpty = !(stackElements.Any<object>());
                if (stackElements != null || stackElements.Count() != 0 || !isEmpty)
                {
                    object removed = stackElements[stackElements.Count - 1];
                    stackElements.RemoveAt(stackElements.Count - 1);
                    return removed;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
            return 0;
        }
        public void Clear()
        {
            stackElements.Clear();
        }
    }
}
