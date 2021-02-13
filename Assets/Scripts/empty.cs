using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empty : MonoBehaviour
{
    //public filling fscript;
    private bool isfull = false;
    private float speed = 0.1f;
    public GameObject acid;
    private GameObject KMnO4;


    void Start()
    {
        KMnO4 = GameObject.Find("Burette/burette/Kmno4");
    }
    public void resetexp()
    {
        //fscript.startfilling();
        acid.gameObject.GetComponent<Renderer>().material.color = Color.clear;
    }

    //public void RefillBurette()
    //{
    //    StartCoroutine(FillLiquid());
    //}

    //public IEnumerator FillLiquid()
    //{
    //    while (true)
    //    {
    //        if (!isfull)
    //        {
    //            KMnO4.transform.localScale += new Vector3(0, speed, 0) * Time.deltaTime;
    //            yield return new WaitForEndOfFrame();
    //        }
    //        else
    //        {
    //            Debug.Log("IS working");
    //            break;
    //        }
    //        //if (this.transform.localScale.y > 0.838f)
    //        //{
    //        //    particles.SetActive(false);
    //        //    fillbuettebut.SetActive(false);
    //        //    fillpipettebut.SetActive(true);
    //        //    beaker.SetActive(false);
    //        //}
    //    }
    //    yield return null;
    //}
    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("Burette Full");
    //    if (other.gameObject.name == "0mlTrigger")
    //    {
    //        isfull = true;
    //    }
    //}
}
