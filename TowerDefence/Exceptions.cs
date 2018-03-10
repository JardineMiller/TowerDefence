using System;
namespace TowerDefence
{
    public class TreehouseDefenceException : Exception
    {
        public TreehouseDefenceException()
        {
        }

        public TreehouseDefenceException(string message) : base(message)
        {
        }
    }

    public class OutOfBoundsException : TreehouseDefenceException
    {
        public OutOfBoundsException()
        {
        }

        public OutOfBoundsException(string message) : base(message)
        {
        }
    }


}
