using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemScript : MonoBehaviour
{
    public AudioSource source;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0.3f,0);
    }

    private void OnTriggerEnter(Collider other)
    {
        source.Play();
        Destroy(gameObject);
    }
}
