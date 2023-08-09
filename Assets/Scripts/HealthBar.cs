using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    [SerializeField] private Player _player;
    [SerializeField] private Slider _sliderHealthPoints;
    [SerializeField] private float _healPointChangeSpeed;

    private Coroutine _coroutine;

    private void OnEnable()
    {
        _player.HealthChanged += StartDisplayHealth;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= StartDisplayHealth;
    }

    public void StartDisplayHealth()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }

        _coroutine = StartCoroutine(DisplayHealth());
    }

    private IEnumerator DisplayHealth()
    {
        while (_sliderHealthPoints.value != _player.CurrentHealthPoints)
        {
            _sliderHealthPoints.value = Mathf.MoveTowards(_sliderHealthPoints.value, _player.CurrentHealthPoints, _healPointChangeSpeed * Time.deltaTime);

            yield return null;
        }
    }
}
