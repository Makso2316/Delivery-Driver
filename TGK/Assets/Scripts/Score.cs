using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int hits = 0;

    private void OnCollisionEnter(Collision other) 
    {
        hits = hits + 1;
     Debug.Log("You;ve been somthing this many times: " + hits);   
    }
}
