using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ErrorBtn : MonoBehaviour
{
    public GameObject ErrorImage;


    public void ErrorToMain()
    {
        ErrorImage.SetActive(false);
    }

}
