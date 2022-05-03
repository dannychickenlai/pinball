using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightPulsate : MonoBehaviour
{
    [SerializeField] float maxIntensity = 1.0f;
    [SerializeField] float minIntensity = 0.2f;
    private Light pulsateLight;
    private float x = 1.0f;
    void Start()
    {
        pulsateLight = this.gameObject.GetComponent<Light>();
        Debug.Log(pulsateLight);
    }

    // Update is called once per frame
    void Update()
    {
        pulsateLight.intensity += 0.01f * x;
        if(pulsateLight.intensity >= maxIntensity)
        {
            x = -1.0f;
        }
        if(pulsateLight.intensity <= minIntensity)
        {
            x = 1.0f;
        }
    }
}
