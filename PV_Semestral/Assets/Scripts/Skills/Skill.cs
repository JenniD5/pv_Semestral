using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill : MonoBehaviour
{

    [Header ("Base skills")]
    public string skillName;
    public float animationDuration;
    public bool selfInflicted;
    public GameObject effectPrfb;

    protected Fighter emitter;
    protected Fighter receiver;


    private void Animate()
    {
        var go = Instantiate(this.effectPrfb, this.receiver.transform.position, Quaternion.identity);
        Destroy(go, this.animationDuration);
    }

    public void Run()
    {
        if (this.selfInflicted)
        {
            this.receiver = this.emitter;
        }
        this.Animate();
        this.OnRun();
    }



    public void SetEmmitterAndReceiver(Fighter _emitter, Fighter _receiver)
    {
        this.emitter = _emitter;
        this.receiver = _receiver;
    }
    protected abstract void OnRun();
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
