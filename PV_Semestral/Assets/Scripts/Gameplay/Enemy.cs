using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public HealthBar HealthBar;
    // Start is called before the first frame update
    public float Hitpoints;
    public float MaxHitPoints = 5;
    
    void Start()
    {
        Hitpoints = MaxHitPoints;
        HealthBar.SetHealth(Hitpoints, MaxHitPoints);     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeHit(float damage)
    {
        Hitpoints -= damage;
        HealthBar.SetHealth(Hitpoints, MaxHitPoints);

        if(Hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
