using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour {

public bool Key = false;

void OnMouseDown()
{
    if(Key == true)
    {
        print("The door was unlocked");
    }
}

}
