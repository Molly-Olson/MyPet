using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.FSM
{
    public enum State
    {
        idle,
        sitting,
        eating,
        sleeping,
        dead
    }
    public class StateMachine
    {
        public State CurrentState { get; private set; }
        public StateMachine(State CurrentState)
        {
            this.CurrentState = CurrentState;
        }

        public virtual void transition(State newState)
        {
            CurrentState = newState;
            if (CurrentState == State.dead)
            {
                // dead code here
            }

        }

    }
}
