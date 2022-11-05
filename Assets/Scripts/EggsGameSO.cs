using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "EggsGameSO", menuName = "ScriptableObjects/EggsGameSO")]
public class EggsGameSO : ScriptableObject
{
    public int LeftScreenEdge = -10;
    public int RightScreenEdge = 10;
    public int FallingInterval = 1; //1 second
    public float BasketSpeed = 15f;

}
