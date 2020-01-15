using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrigger : MonoBehaviour
{
    public bool Shaking = false;
    public float duration;
    public float magnitude;
    public CameraShake cameraShake;
    // Update is called once per frame
    void Update()
    {
        if (Shaking == true)
        {
            StartCoroutine(cameraShake.Shake(duration, magnitude));
        }
        else {
        }
    }
}
