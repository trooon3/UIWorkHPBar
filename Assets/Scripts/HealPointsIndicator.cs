using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealPointsIndicator : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Slider _sliderHealPoints;
    [SerializeField] private float _healPointChangeSpeed;

    private void Update()
    {
        if (_sliderHealPoints.value != _player.CurrentHealPoints)
        {
            _sliderHealPoints.value = Mathf.MoveTowards(_sliderHealPoints.value, _player.CurrentHealPoints, _healPointChangeSpeed * Time.deltaTime);
        }
    }
}

