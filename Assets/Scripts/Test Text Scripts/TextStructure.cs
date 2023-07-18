using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Prase
{
    [TextArea(2, 5)] public String speaker;
    [TextArea(2, 5)] public String words;
}

[CreateAssetMenu(fileName = "New Dialog", menuName = "Dialog")]
public class Dialog : ScriptableObject
{
    public Prase[] prases;
}
