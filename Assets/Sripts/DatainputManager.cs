using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatainputManager : MonoBehaviour
{
    public Text txtUseName;

   public void ShowGreetings()
    {
        Debug.Log("Hola " + txtUseName.text);
    }
}
