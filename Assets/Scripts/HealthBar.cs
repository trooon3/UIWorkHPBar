using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Slider _sliderHealPoints;
    [SerializeField] private float _healPointChangeSpeed;

    private Coroutine _coroutine;

    private void Start()
    {
       if (_sliderHealPoints.value != _player.CurrentHealPoints)
	   {
            StartControlHealth();
       }
    }

    public void StartControlHealth()
    {
        _coroutine = StartCoroutine(ControlHealth());
    }

    private IEnumerator ControlHealth()
    {
        while (_sliderHealPoints.value != _player.CurrentHealPoints)
        {
            _sliderHealPoints.value = Mathf.MoveTowards(_sliderHealPoints.value, _player.CurrentHealPoints, _healPointChangeSpeed * Time.deltaTime);
            
            yield return null;
        }
    }

}

