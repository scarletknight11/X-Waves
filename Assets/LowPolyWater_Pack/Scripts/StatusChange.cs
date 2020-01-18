using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusChange : MonoBehaviour
{
    public GameObject Ocean;
    Renderer rend;
    public Color Color1 = new Color(.54f, .95f, .99f, 0.5f);
    public Color Color2 = new Color(.54f, .95f, .99f, 0.5f);
    public GameObject Light;
    public Color ColorLight1 = new Color(1f, .95f, .83f, 1f);
    public Color ColorLIght2 = new Color(1f, .95f, .83f, 1f);
    // Start is called before the first frame update
    void Start()
    {
        rend = Ocean.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Ocean.GetComponent<LowPolyWater.LowPolyWater>().setwaveHeight((10f - (float)(GetComponent<FocusStatusControl>().getvalue())) * 0.3f + 0.5f);
        float value = 0.1f * (float)(GetComponent<FocusStatusControl>().getvalue());
        Color colortemp = Color.Lerp(Color1, Color2, value);
        rend.material.SetColor("_BaseColor", colortemp);
        Light.GetComponent<Light>().color = Color.Lerp(ColorLight1, ColorLIght2, value); ;
    }
}
