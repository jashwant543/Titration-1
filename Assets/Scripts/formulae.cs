using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class formulae : MonoBehaviour
{
    public InputField finalvol;
    public InputField initialvol;
    public Text difference;
    public Text molarity;
    public Text strength;
    public Text error;
    public GameObject cal;
    // Start is called before the first frame update
    void Start()
    {
        //var initial = initialvol.gameObject.GetComponent<InputField>();
        //var final = finalvol.gameObject.GetComponent<InputField>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void calculation()
    {
        float dif = float.Parse(finalvol.text) - float.Parse(initialvol.text);
        difference.text = dif.ToString();
        float mol = 5 * 158 * dif / 10 * 2;
        molarity.text = mol.ToString();
        float stre = mol * 90000;
        strength.text = stre.ToString();
        float er = (stre - 12) / stre;
        error.text = er.ToString();
        
    }
}
