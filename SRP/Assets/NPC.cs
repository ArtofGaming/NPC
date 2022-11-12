using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NPC : MonoBehaviour
{
    [SerializeField]
    private int startingHp = 100;
    [SerializeField]
    private ParticleSystem deathParticlePrefab;
    private int currentHp;
    private float CurrentHpPct
    {
        get
        {
            return (float)currentHp / (float)startingHp;
        }
    }

    public event Action<float> OnHPPctChanged = delegate { };
    public event Action OnNPCDied = delegate { };

    // Start is called before the first frame update
    void Start()
    {
        currentHp = startingHp;
    }

    internal void TakeDamage(int amount)
    {
        GetComponent<IHealth>().TakeDamage(amount);
    }

}
