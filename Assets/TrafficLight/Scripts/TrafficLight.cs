using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    [SerializeField] private List<Light> Lights;

    void Start()
    {
        if (Lights == null) return;
        StartCoroutine(Light());
    }

    void Update()
    {
        
    }

    private IEnumerator Light()
    {
        foreach (Light light in Lights)
        {
            light.ActivateLight();
            yield return new WaitForSeconds(5);
        }
    }
}
