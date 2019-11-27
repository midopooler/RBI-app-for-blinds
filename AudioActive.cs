using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioActive : MonoBehaviour
{
    MeshRenderer MR;
    AudioSource AS;


    // Start is called before the first frame update
    void Start()
    {
        MR = transform.GetComponent<MeshRenderer>();
        AS = transform.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(MR.enabled == true)
        {
            AS.enabled = true;
        }
        else
        {
            AS.enabled = false;
        }
    }
}
