using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private float _damagePoints;
    [SerializeField] private float _healPoints;

    public event UnityAction HealthChanged;
     
    private float _maxHealth = 100f;
    private float _minHealth = 0f;
    private float _startHealth = 50f;

    public float CurrentHealthPoints { get; private set; }

    private void Start()
    {
        CurrentHealthPoints = Mathf.Clamp(_startHealth, _minHealth, _maxHealth);
    }

    public void Heal()
    {
        CurrentHealthPoints = Mathf.Clamp(CurrentHealthPoints += _healPoints, _minHealth, _maxHealth);
        HealthChanged?.Invoke();
    }
    
    public void Damage()
    {
        CurrentHealthPoints = Mathf.Clamp(CurrentHealthPoints -= _damagePoints, _minHealth, _maxHealth);
        HealthChanged?.Invoke();
    }
}
