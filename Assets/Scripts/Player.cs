using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float CurrentHealPoints { get; private set; }

    private void Start()
    {
        CurrentHealPoints = 50f;
    }

    public void RaiseHealPoints()
    {
        CurrentHealPoints += 10;

        if (CurrentHealPoints >= 100)
        {
            CurrentHealPoints = 100;
        }
    }
    
    public void LowerHealPoints()
    {
        CurrentHealPoints -= 10;

        if (CurrentHealPoints <= 0)
        {
            CurrentHealPoints = 0;
        }
    }
}
