using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Light : MonoBehaviour
{
    [SerializeField] private Image colorLight;
    [SerializeField] private Color color;
    [SerializeField] private int activeTime;

    public Image ColorLight { get => (colorLight == null) ? GetComponent<Image>() : colorLight; set => colorLight = value; }
    public int ActiveTime { get => (activeTime == 0) ? 3 : activeTime; set => activeTime = value; }

    void Start()
    {
        ActivateLight(false);
    }

    public void ActivateLight(bool activate = true)
    {
        if (activate)
        {
            ColorLight.color = color;
            StartCoroutine(Glow());
        }
        else
        {
            ColorLight.color = Color.white;
        }
    }
    private IEnumerator Glow()
    {
        yield return new WaitForSeconds(ActiveTime);
        ActivateLight(false);
    }
}
