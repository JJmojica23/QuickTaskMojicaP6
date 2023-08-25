using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject goalScreen;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        goalScreen.SetActive(true);
    }
}
