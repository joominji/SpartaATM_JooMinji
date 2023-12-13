using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashBox : MonoBehaviour
{
    public int Cash { get { return cash; } set { cash = value; } }
    private int cash = 100000;
    public Text CurrentCash;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        CurrentCash.text = Cash.ToString();
     
    }
   

}
