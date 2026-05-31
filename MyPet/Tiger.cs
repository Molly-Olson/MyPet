using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPet
{
    public class Tiger : FSM.StateMachine
    {
        public int Health;
        public string Name;
        public Room location;
        public List<Item> inventory = new List<Item>();

        public Tiger() : base(FSM.State.idle)
        {
        }
        public void Sleep()
        {
            this.transition(FSM.State.sleeping);
        }
    }
}
