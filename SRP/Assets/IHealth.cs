using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IHealth
{
    event Action<float> OnHPPctChanged;
    event Action OnDied;
    void TakeDamage(int amount);
}
