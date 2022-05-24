using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFighter : Fighter
{
    [Header ("UI")]
    public PlayerSkillPanel skillPanel;
    void Awake()
    {
        this.stats = new Stats(21,60,50,45,20);

    }

    public override void InitTurn()
    {
        this.skillPanel.Show();
        //for (int i=0; i< this.skillss.Length; i++)
        //{
          //  this.skillPanel.ConfigureButton(i,this.skills[i].skillName);
       // }

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
