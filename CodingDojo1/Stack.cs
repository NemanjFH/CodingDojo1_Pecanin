using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1
{
    class Stack
    {
        private StackElement currentElement;

        public void Push(Person item)
        {
            if (currentElement == null)
            {
                currentElement = new StackElement() { ValueOfElement = item, Successor = null };
            }
            else
            {
                StackElement temp = new StackElement() { ValueOfElement = item, Successor = currentElement };
                currentElement = temp;
            }

        }

        public Person Pop()
        {
            if (currentElement != null)
            {
                Person temp = currentElement.ValueOfElement;
                currentElement = currentElement.Successor;
                return temp;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public Person Peek()
        {
            if (currentElement != null)
            {
                return currentElement.ValueOfElement;
            }
            else
            {
                return default(Person);
            }
        }
    }

    
}
