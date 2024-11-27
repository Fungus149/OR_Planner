using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Entry : MonoBehaviour
{
    [Header("Value from impact field")]
    [SerializeField] private string inputText;

    public void GrabFromInputField(string input){
        inputText = input;
        Debug.Log(inputText);
    }
}
