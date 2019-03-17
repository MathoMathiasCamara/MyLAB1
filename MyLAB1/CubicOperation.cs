using System;


namespace MyLAB1
{
    public class CubicOperation
    {
        //my varibles 
        private int _numberOne;
        private int _numberTwo;


        public int NumberOne
        {
            get
            {
                return _numberOne;
            }
            set
            {
                _numberOne = value;
            }
        }
        public int NumberTwo
        {
            get
            {
                return _numberTwo;
            }
            set
            {
                _numberTwo = value;
            }
        }
        

        //methodes
        public int Substraction()
        {
            return (NumberOne - NumberTwo);
        }

        //cubic operation
        public int Cube()
        {
            return (CubicFunction(Substraction()));
        }


        //print method
        public void Print()
        {
            Console.Write(_numberOne);
            Console.Write(_numberTwo);
        }

        //print method with a message
        public void Print(string message)
        {
            Console.Write(message);
            Console.Write(_numberOne);
            Console.Write(_numberTwo);
        }

        //my exponatial function
        private int CubicFunction(int value)
        {
            return value*value*value;
        }
    }
}
