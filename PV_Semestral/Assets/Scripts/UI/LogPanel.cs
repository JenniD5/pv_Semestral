using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LogPanel : MonoBehaviour
{


    public static LogPanel current;
    public Text logPanel;

    void Awake()
    {
        current = this;
    }

    public static void Write(string message)
    {
        current.logPanel.text = message;
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
