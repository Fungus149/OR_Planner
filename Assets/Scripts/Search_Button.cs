using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchButton : MonoBehaviour
{
    public bool searching = false;
    public void Search(){
        searching = true;
        Debug.Log("Searching with entry");
    }

}
