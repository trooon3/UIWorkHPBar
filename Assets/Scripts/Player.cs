using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float CurrentHealPoints { get; private set; }

    private void Start()
    {
        CurrentHealPoints = Mathf.Clamp(50f, 0f, 100f);
    }

    public void Heal()
    {
        CurrentHealPoints += 10;
    }
    
    public void Damage()
    {
        CurrentHealPoints -= 10;
    }
}
