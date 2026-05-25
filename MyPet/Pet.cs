using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPet
{
    public class Pet : FSM.StateMachine
    {
        public int Health;
        public string Name;
        //public Room location;
        public List<Item> inventory = new List<Item>();

        public Pet() : base(FSM.StateMachine.idle)
        {
        }
        public void Sleep()
        {
            this.transition(FSM.StateMachine.sleeping);
        }
    }
}
