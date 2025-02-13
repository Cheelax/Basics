﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q001Objective01 : MonoBehaviour
{
    public GameObject TheObjective;

    public int CloseObjective;

    // Update is called once per frame
    void Update()
    {
        if (CloseObjective == 1)
        {
            if (TheObjective.transform.localScale.y <= 0.00f)
            {
                CloseObjective = 0;
                TheObjective.SetActive(false);
            }
            else
            {
                TheObjective.transform.localScale -= new Vector3(0.0f, 0.0f, 0.0f);
            }
        }
    }

    void OnTriggerEnter()
    {
        StartCoroutine(FinishObjective());
    }

    IEnumerator FinishObjective()
    {
        TheObjective.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        CloseObjective = 1;
    }
}
