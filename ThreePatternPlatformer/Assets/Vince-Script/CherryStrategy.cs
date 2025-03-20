using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Vince Herrera
 */
public class CherryStrategy : MovementStrategy
{
    public float GetSpeed()
    {
        return 7.5f;
    }
    public float GetJumpForce()
    {
        return 10f;
    }
}
