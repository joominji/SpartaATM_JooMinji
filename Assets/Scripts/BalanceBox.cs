using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalanceBox : MonoBehaviour
{
    public Text BalanceTxt;
    public int Balance { get { return balance; } set { balance = value; } }
    private int balance = 50000;
   
  

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BalanceTxt.text = Balance.ToString();   
        if(Balance <= 0)
        {
            Balance = 0;
        }

    }
}
