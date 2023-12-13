using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WithdrawBtn : MonoBehaviour
{
    public GameObject WithdrawImage;
    public GameObject ErrorImage;
    public BalanceBox balanceBox;
    public CashBox cashBox;
    public int WithdrawCash { get { return withdrawCash; } }
    private int withdrawCash;
    public int WithdrawBalance { get { return withdrawBalance; } }
    private int withdrawBalance;
    public void IntoWithdraw()
    {
        WithdrawImage.SetActive(true);
    }
    public void WithdrawToMain()
    {
        WithdrawImage.SetActive(false);
    }
    public void TenThWithdraw()
    {     
        withdrawCash = 10000;
        withdrawBalance = -10000;
     
        if(balanceBox.Balance >= 10000)
        {
            Withdraw();
        }
        else
        {
            ErrorImage.SetActive(true);
        }
    }
    public void ThirtyThWithdraw()
    {
        withdrawCash = 30000;
        withdrawBalance = -30000;

        if (balanceBox.Balance >= 30000)
        {
            Withdraw();
        }
        else
        {
            ErrorImage.SetActive(true);
        }
    }
    public void FiftyThWithdraw()
    {
        withdrawCash = 50000;
        withdrawBalance = -50000;

        if (balanceBox.Balance >= 50000)
        {
            Withdraw();
        }
        else
        {
            ErrorImage.SetActive(true);
        }
    }

    public void Withdraw()
    {
        cashBox.Cash += withdrawCash;
        balanceBox.Balance += withdrawBalance;
    }

}
