using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private float _damagePoints = 10f;
    private float _healPoints = 10f;

    public float CurrentHealthPoints { get; private set; }

    private void Start()
    {
        CurrentHealthPoints = Mathf.Clamp(50f, 0f, 100f);
    }

    public void Heal()
    {
        CurrentHealthPoints = Mathf.Clamp(CurrentHealthPoints += _healPoints, 0f, 100f);
    }
    
    public void Damage()
    {
        CurrentHealthPoints = Mathf.Clamp(CurrentHealthPoints -= _damagePoints, 0f, 100f);
    }
}
