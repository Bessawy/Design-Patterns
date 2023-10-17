namespace State;

abstract class State
{
    protected WashingMachine machine;

    public State(WashingMachine machine)
    {
        this.machine = machine;
    }

    abstract public void Toggle();
}

class OnState : State
{
    public OnState(WashingMachine machine) : base(machine){}
    public override void Toggle()
    {
        machine.ChangeState(new OffState(machine));
        machine.TurnOff();
    }
}

class OffState : State
{
    public OffState(WashingMachine machine) : base(machine){}
    public override void Toggle()
    {
        machine.ChangeState(new OnState(machine));
        machine.TurnOn();
    }
}



class WashingMachine
{
    State current;
    public int led = 0;

    public WashingMachine()
    {
        current = new OffState(this);
    } 

    public void ChangeState(State newState)
    {
        current = newState;
    }

    public void Toggle()
    {
        current.Toggle();
    }
 
    public void TurnOn()
    {
        led = 1;
    }

    public void TurnOff()
    {
        led = 0;
    }
}