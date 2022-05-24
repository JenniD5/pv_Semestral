using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillPanel : MonoBehaviour
{

    public GameObject[] skillButtons;
   // public Text skillButtonsLabels;
     public Skill skills;
     public Stats stats;


    void Awake()
    {
        this.stats = new Stats(21,60,50,50,20);
    }

    public void ConfigureButtons(int index, string skillName)
    {
        this.skillButtons[index].SetActive(true);
        //this.skillButtonsLabels[index].text = skillName;
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
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
