using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    [SerializeField] private float _currentHealPoints;
    [SerializeField ]private Slider _sliderHealPoints;

    private float healPointChangeSpeed = 20;
    
    private void Start()
    {
        _sliderHealPoints.value = _currentHealPoints;
    }

    private void Update()
    {
        if (_sliderHealPoints.value != _currentHealPoints)
        {
            _sliderHealPoints.value = Mathf.MoveTowards(_sliderHealPoints.value, _currentHealPoints, healPointChangeSpeed * Time.deltaTime);
        }

        if (_currentHealPoints >= 100)
        {
            _currentHealPoints = 100;
        }

        if (_currentHealPoints <= 0)
        {
            _currentHealPoints = 0;
        }
    }

    public void RaiseHealPoints()
    {
        _currentHealPoints += 10;
    }
    
    public void LowerHealPoints()
    {
        _currentHealPoints -= 10;
    }
}
