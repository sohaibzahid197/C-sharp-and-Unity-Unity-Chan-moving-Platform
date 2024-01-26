using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedgeScript : MonoBehaviour
{

    public GameObject ledge;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        player.transform.parent = ledge.transform;
    }
    private void OnTriggerExit(Collider other)
    {
        player.transform.parent = null;
    }

}