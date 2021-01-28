using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showpanel : MonoBehaviour
{

    public GameObject g1;
    public GameObject g2;
    public GameObject g3;
    public GameObject g4;
    public GameObject g5;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject b5;
    public GameObject startbutton;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject self;
    public GameObject component;
    public GameObject orpos;
    public GameObject component2;
    public GameObject orpos2;
    public GameObject component3;
    public GameObject orpos3;
    public GameObject component4;
    public GameObject orpos4;
    public GameObject component5;
    public GameObject orpos5;
    public GameObject BPM;


    public void ShowPanels()
    {
       

        if (g1.activeSelf == true && g2.activeSelf == true && g3.activeSelf == true && g4.activeSelf == true && g5.activeSelf == true && component2.transform.localPosition == orpos2.transform.localPosition)
        {
            b1.SetActive(false);
            b2.SetActive(false);
            b3.SetActive(false);
            b4.SetActive(false);
            b5.SetActive(false);
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(false);
            text5.SetActive(false);
            startbutton.SetActive(true);
            self.SetActive(false);
            BPM.SetActive(false);



        }
        else
        {
            b1.SetActive(true);
            b2.SetActive(true);
            b3.SetActive(true);
            b4.SetActive(true);
            b5.SetActive(true);
            BPM.SetActive(true);
            component.transform.localPosition = orpos.transform.localPosition;
            component.transform.rotation = orpos.transform.rotation;
            component.SetActive(false);
            component2.transform.localPosition = orpos2.transform.localPosition;
            component2.transform.rotation = orpos2.transform.rotation;
            component2.SetActive(false);
            component3.transform.localPosition = orpos3.transform.localPosition;
            component3.transform.rotation = orpos3.transform.rotation;
            component3.SetActive(false);
            component4.transform.localPosition = orpos4.transform.localPosition;
            component4.transform.rotation = orpos4.transform.rotation;
            component4.SetActive(false);
            component5.transform.localPosition = orpos5.transform.localPosition;
            component5.transform.rotation = orpos5.transform.rotation;
            component5.SetActive(false);


        }
    }
   
}
