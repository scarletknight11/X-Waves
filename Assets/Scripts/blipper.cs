using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blipper : MonoBehaviour
{

    public AudioSource source;
    public Animator blipLight;
    public Animator blipOcean;

    int finishedCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(source.clip.length);
        if (-source.time + source.clip.length < 0.1f)
        {
                blipLight.SetTrigger("blip");
                blipOcean.SetTrigger("blip");
        }
        
    }
}
