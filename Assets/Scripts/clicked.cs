using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicked : MonoBehaviour
{
    public GameObject beakerr;
    
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;
    
    public void onclicked()
    {
        beakerr.SetActive(true);
    }
    public void ShowPanels()
    {
        p1.SetActive(true);
        p2.SetActive(false);

        p3.SetActive(false);
        p4.SetActive(false);
        p5.SetActive(false);
        
    }
}
