using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    //create singleton
    public static LevelManager main;

    public Transform startPoint;
    public Transform[] path;

    private void Awake()
    {
        main = this;
    }
}
