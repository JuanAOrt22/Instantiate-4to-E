using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataInputManager : MonoBehaviour
{
    public Text TxtUsername;
    
    public void ShowGreetings(){
    Debug.Log("Hola " + TxtUsername.text);
    }

    public void ShowDouble(){
    
    if(TxtUsername.text != "")
        {
        Debug.Log(int.Parse(TxtUsername.text) * 2);
        }
    else
        {
        Debug.LogError("Invalid Input: Empty");
        }
    }
}
