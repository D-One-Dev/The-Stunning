using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAnimation : MonoBehaviour
{
    [SerializeField] private Text txt;
    [SerializeField] private Outline ol;
    private float alpha;
    public bool animEnable;
    void Start()
    {
    }
    void FixedUpdate()
    {
        if (animEnable)
        {
            alpha = Mathf.PingPong(Time.time / 1.5f, 1f);
            txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, alpha);
            ol.effectColor = new Color(ol.effectColor.r, ol.effectColor.g, ol.effectColor.b, alpha);
        }
        else
        {
            txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, 1f);
            ol.effectColor = new Color(ol.effectColor.r, ol.effectColor.g, ol.effectColor.b, 1f);
        }
    }
}
