using DataS.DataStructure.LList;

namespace DataS.DataStructure.BT
{
    public class BinaryTree<T> where T : IComparable
    {
        public int Count { get; private set; }

        private Node<T> _root;

        public void Add(T value)
        {
            if (_root is null)
            {
                _root = new Node<T>(value);
            }
            else
            {
                var current = _root;

                while (current is not null)
                {
                    if (value.CompareTo(current.Value) < 0)
                    {
                        if (current.Left is not null)
                        {
                            current = current.Left;
                        }
                        else
                        {
                            current.Left = new Node<T>(value);
                            break;
                        }
                    }
                    else
                    {
                        if (current.Right is not null)
                        {
                            current = current.Right;
                        }
                        else
                        {
                            current.Right = new Node<T>(value);
                            break;
                        }
                    }
                }
            }

            Count++;
        }
    }
}
