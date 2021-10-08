using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_linkedlist
{
    class LinkedList
    {
        private Node _head;

        public Node Head
        {
            get { return _head; }
            set { _head = value; }
        }

        public void add(string item)
        {
            Node n = new Node(item);

            if (_head != null)
            {
                Node current = _head;
                while (current != null)
                {
                    if (current.Next != null)
                    {
                        current = current.Next;
                    } else
                    {
                        current.Next = n;
                        break;
                    }
                }
            } else
            {
                _head = n;
            }
        }

        public Node contains(string item)
        {
            // If no head, there can be no search
            if (_head == null)
            {
                return null;
            } else // Otherwise search nodes
            {
                Node current = _head;

                while (current != null)
                {
                    if (current.Data == item)
                    {
                        return current;
                    }
                    else
                    {
                        if (current.Next != null)
                        {
                            current = current.Next;
                        } else
                        {
                            break;
                        }
                    }
                }
            }

            return null;
        }

        public bool remove(string item)
        {
            if (_head == null)
            {
                return false;
            } else // Implies head exists
            {
                if (_head.Data == item)
                {
                    if (_head.Next != null)
                    {
                        _head = _head.Next;
                    } else
                    {
                        _head = null;
                    }

                    return true;
                } // If this point is reached, implies head does not contain target data

                Node current = _head;

                // In which case we look through the next nodes for the value
                while (current != null)
                {
                    if (current.Next != null)
                    {
                        if (current.Next.Data == item)
                        {
                            // If there is a node on the other side of the target, make that node the new next
                            // The target is then lost
                            if (current.Next.Next != null)
                            {
                                current.Next = current.Next.Next;
                                return true;
                            } else // Else drop the end; either way, return true as something was removed from the list
                            {
                                current.Next = null;
                                return true;
                            }
                        }

                        current = current.Next;
                    } else
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        public void print_all_nodes()
        {
            if (_head == null)
            {
                Console.WriteLine("No nodes!");
            } else
            {
                Node current = _head;

                while (current != null)
                {
                    Console.WriteLine(current.Data);
                    if (current.Next != null)
                    {
                        current = current.Next;
                    } else
                    {
                        break;
                    }
                }
            }
        }
    }
}
