using System;

namespace FRI_FEB_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator e = new Elevator();
            e.setup();
        }
    }

    class Node
    {
        public Node() { }
        public Node floor;
        public Node elevatorUp;
        public string FloorNumber;
    }  
    
    class Elevator
    {
        Node Head;
        Node FirstFloor;
        Node SecondFloor;
        Node ThirdFloor;
        Node FourthFloor;
        
        public void setup()
        {
            FirstFloor = new Node();
            SecondFloor = new Node();
            ThirdFloor = new Node();
            FourthFloor = new Node();

            FirstFloor.FloorNumber = "First Floor";
            FirstFloor.elevatorUp = SecondFloor;
            SecondFloor.FloorNumber = "Second Floor";
            SecondFloor.elevatorUp = ThirdFloor;
            ThirdFloor.FloorNumber = "Third Floor";
            ThirdFloor.elevatorUp = FourthFloor;
            FourthFloor.FloorNumber = "Fourth Floor";
            FourthFloor.elevatorUp = null;
        }

        public void TraverseList()
        {
            while (true)
            {

            }

        }
    }
}
