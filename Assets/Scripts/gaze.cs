using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gaze : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            RaycastHit hit;
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                Renderer r = hit.collider.GetComponent<Renderer>();
                if(r != null)
                {
                    r.material.SetColor("_EmissionColor", r.material.color * Mathf.Sin(Time.deltaTime * 0.1f));
                }
            }
            }
        
    }
}
