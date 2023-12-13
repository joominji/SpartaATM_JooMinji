using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputWithdraw : MonoBehaviour
{
    public TMP_InputField WithdrawMoney;
    public Button InputBtn;
    public CashBox cashbox;
    public BalanceBox balanceBox;
    public GameObject ErrorImage;
    public int InputWithdrawMoneyCash { get { return inputWithdrawCash; } }
    private int inputWithdrawCash;
    public int InputWithdrawMoneyBalance { get { return inputWithdrawBalance; } }
    private int inputWithdrawBalance;

    public void Withdraw()
    {

        inputWithdrawCash = int.Parse(WithdrawMoney.text);
        inputWithdrawBalance = int.Parse(WithdrawMoney.text);
        if (inputWithdrawCash <= balanceBox.Balance)
        {
            cashbox.Cash += inputWithdrawCash;
            balanceBox.Balance -= inputWithdrawBalance;
        }
        else
        {
            ErrorImage.SetActive(true);
        }
    }
}
