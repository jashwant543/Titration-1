using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// right not this script is not being used
/// </summary>

public class PipetteScript : MonoBehaviour
{
    //public GameObject Pipette;
    public GameObject PipetteCyl;
    private Vector3 InitialScale;
    private bool isFull = false;
    private float Speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        InitialScale = PipetteCyl.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FillPipette()
    {
        StartCoroutine(EmptyPipette());
    }

    private IEnumerator EmptyPipette()
    {
        while (true)
        {
            if(!isFull)
            {
                transform.localScale += new Vector3(0, Speed, 0) * Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }
            else
            {
                break;
            }
        }
        yield return null;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "10mlTrigger")
        {
            isFull = true;
        }
    }

    //public void emptyburette(bool status)
    //{
    //    isemptying = status;
    //    StartCoroutine(emptyliquid());
    //}
    //public IEnumerator emptyliquid()
    //{
    //    while (true)
    //    {
    //        if (isemptying && this.transform.localScale.y > originalscale.y)
    //        {

    //            transform.localScale -= new Vector3(0, speed, 0) * Time.deltaTime;
    //            if (this.transform.localScale.y < 0.657054f && !colorchanged)
    //            {
    //                changeacidcolor();
    //            }

    //            yield return new WaitForEndOfFrame();
    //        }
    //        else if (!isemptying || this.transform.localScale.y < originalscale.y)
    //        {
    //            break;
    //        }

    //    }
    //    yield return null;
    //}
}
