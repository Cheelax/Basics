using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalXp : MonoBehaviour
{
    public static int CurentExp;

    public int InternalExp;

    // Update is called once per frame
    void Update()
    {
        InternalExp = CurentExp;
    }
}
