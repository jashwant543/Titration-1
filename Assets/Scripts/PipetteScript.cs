using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipetteScript : MonoBehaviour
{
    //public GameObject Pipette;
    public GameObject PipetteCyl;
    public GameObject AddtoFlask;
    private Vector3 InitialScale;
    private bool isFull = false;
    private float Speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        InitialScale = PipetteCyl.transform.localScale;
    }

    public void FillPipette()
    {
        StartCoroutine(EmptyPipette());
    }

    private IEnumerator EmptyPipette()
    {
        while (true)
        {
            if (!isFull)
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
            Debug.Log("PipetteFull");
            isFull = true;
            AddtoFlask.SetActive(true);
        }
    }
}
