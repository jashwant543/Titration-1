using UnityEngine;

public class stop : MonoBehaviour
{
    public GameObject particles;
    // Start is called before the first frame update

    public void process()
    {
        particles.SetActive(false);
    }
    // Update is called once per frame
}
