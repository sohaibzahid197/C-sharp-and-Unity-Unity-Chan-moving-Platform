using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int playerSpeed = 10;
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
        transform.position += new Vector3(x, 0, z) * Time.deltaTime * playerSpeed;
        cam.transform.Rotate(0, mx, 0);
        cam.transform.Rotate(my, 0, 0);
    }
}
