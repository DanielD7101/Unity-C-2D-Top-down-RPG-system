using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[System.Serializable]

public class FloatValue : ScriptableObject
{
    public float initialValue;
    public float runtimeValue;

    //public void OnAfterDeserialize()
    //{
    //    runtimeValue = initialValue;
    //}
    //public void OnBeforeSerialize()
    //{

    //}
}