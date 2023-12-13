using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DespositBtn : MonoBehaviour
{
    public GameObject DespositImage;

    public BalanceBox balanceBox;
    public CashBox cashBox;
    public int DespositCash { get { return despositCash; } }
    private int despositCash;
    public int DespositBalance { get { return despositBalance; } }
    private int despositBalance;
    public GameObject ErrorImage;

    public void IntoDesposit()
    {
        DespositImage.SetActive(true);
    }
    public void DespositToMain()
    {
        DespositImage.SetActive(false);
    }
    public void TenThDesposit()
    {
        despositCash = -10000;
        despositBalance = 10000;

        if (cashBox.Cash >= 10000)
        {
            Desposit();
        }
        else
        {
            ErrorImage.SetActive(true);
        }
    }
    public void ThirtyThDesposit()
    {
        despositCash = -30000;
        despositBalance = 30000;

        if (cashBox.Cash >= 30000)
        {
            Desposit();
        }
        else
        {
            ErrorImage.SetActive(true);
        }
    }
    public void FiftyThDesposit()
    {
        despositCash = -50000;
        despositBalance = 50000;

        if (cashBox.Cash >= 50000)
        {
            Desposit();
        }
        else
        {
            ErrorImage.SetActive(true);
        }
    }
    public void Desposit()
    {
        cashBox.Cash += despositCash;
        balanceBox.Balance += despositBalance;
    }


}
