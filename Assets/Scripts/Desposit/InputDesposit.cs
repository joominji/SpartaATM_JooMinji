using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class InputDesposit : MonoBehaviour
{

    public TMP_InputField DespositMoney;
    public Button InputBtn;
    public CashBox cashbox;
    public BalanceBox balanceBox;
    public GameObject ErrorImage;
    public int InputDespositCash { get { return inputDespositCash; } }
    private int inputDespositCash;
    public int InputDespositBalance { get { return inputDespositBalance; } }
    private int inputDespositBalance;

    public void Deposit()
    {

        inputDespositCash = int.Parse(DespositMoney.text);
        inputDespositBalance = int.Parse(DespositMoney.text);
        if (inputDespositCash <= cashbox.Cash )
        {
            cashbox.Cash -= inputDespositCash;
            balanceBox.Balance += inputDespositBalance;
        }
        else
        {
            ErrorImage.SetActive(true);
        }

    }
}
