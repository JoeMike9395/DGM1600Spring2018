using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : ScriptableObject {
    //abstract makes this a template for other Scriptable Objects. CreateAssetMenu is not used here.

    public int PowerLevel;
    public int ExtraPower;

}