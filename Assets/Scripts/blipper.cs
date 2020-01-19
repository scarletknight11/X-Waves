using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blipper : MonoBehaviour
{

    public AudioSource source;
    public AudioClip clip;
    public Animator blipLight;
    public Animator blipOcean;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!source.isPlaying)
        {
            //source.Stop();
            Debug.Log(source.clip.length);

            source.Play();
            blipLight.SetTrigger("blip");
            blipOcean.SetTrigger("blip");
        }
        
    }
}
