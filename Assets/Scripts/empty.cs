using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empty : MonoBehaviour
{
    public filling fscript;
    public GameObject old;
    public GameObject newc;
    public GameObject acid;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void resetexp()
    {
        old.SetActive(false);
        newc.SetActive(true);
        fscript.startfilling();
        acid.gameObject.GetComponent<Renderer>().material.color = Color.clear;
    }
}
