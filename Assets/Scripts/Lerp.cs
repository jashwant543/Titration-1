using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject one;
    public GameObject two;
    private Vector3 startpos;
    private Vector3 endpos;
    //private float dsitance = 15f;
    private float lerptime = 5;
    private float currentlerptime=0;

    void Start()
    {
        startpos = one.transform.position;
        endpos = two.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        currentlerptime += Time.deltaTime;
        if(currentlerptime>=lerptime)
        {
            currentlerptime = lerptime;
        }
        float p = currentlerptime / lerptime;
        one.transform.position = Vector3.Lerp(startpos, endpos, p);
    }
}
