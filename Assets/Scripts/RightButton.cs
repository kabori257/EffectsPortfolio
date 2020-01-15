using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightButton : MonoBehaviour
{
    public GameObject effectManagerObj;

    private EffectManager effectManager;

    // Start is called before the first frame update
    void Start()
    {
        effectManager = effectManagerObj.GetComponent<EffectManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onClick()
    {
        effectManager.changeEffect(false);
    }
}
