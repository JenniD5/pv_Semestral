using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Stats : MonoBehaviour
{

    public int level;
    public float attack;
    public float deffense;
    public float spirit;

    public float health;
    public float maxHealth;

    public Stats(int level, float maxHealth, float attack, float deffense, float spirit)
    {
        this.level = level;
        this.maxHealth = maxHealth;
        this.health=health;

        this.attack=attack;
        this.deffense=deffense;
        this.spirit=spirit;
    }

    public Stats Clone()
    {
        return new Stats(this.level,this.maxHealth, this.attack, this.deffense, this.spirit);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
