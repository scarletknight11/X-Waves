using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusStatusControl : MonoBehaviour
{
    
    [Header("Control parameters")]
    [Range(0, 10)]
    public int focusstatus = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public int getvalue()
    {
        return focusstatus;
    }
}
