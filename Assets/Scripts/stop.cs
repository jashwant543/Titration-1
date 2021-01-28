using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour
{
    public GameObject particles;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void process()
    {
        particles.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
