using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HPController : MonoBehaviour
{
    [SerializeField] private Player _player;

    public void GetHeal()
    {
        _player.RaiseHealPoints();
    }

    public void GetDamage()
    {
        _player.LowerHealPoints();
    }
}
