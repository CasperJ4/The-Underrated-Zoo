using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalState : MonoBehaviour
{
    enum AnimalStates { IDLE, EATING, SLEEPING, HUNTING, FLEEING };

    void Start()
    {
        AnimalStates myState;

        myState = AnimalStates.IDLE;
    }

    AnimalStates ReverseDirection(AnimalStates dir)
    {
        if (dir == Direction.North)
            dir = Direction.South;
        else if (dir == Direction.South)
            dir = Direction.North;
        else if (dir == Direction.East)
            dir = Direction.West;
        else if (dir == Direction.West)
            dir = Direction.East;

        return dir;
    }
}
