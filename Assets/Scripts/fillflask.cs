using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fillflask : MonoBehaviour
{
    private Vector3 target = new Vector3(0.0802f, -0.2757f, 0.0258f);
    private float speed = 0.08f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target, speed * Time.deltaTime);
    }
}
