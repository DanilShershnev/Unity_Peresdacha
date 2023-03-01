using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Opener : MonoBehaviour
{
    [SerializeField] private GameObject Red;
    [SerializeField] private GameObject Yellow;
    [SerializeField] private GameObject Orange;

    public void RedActivate()
    {
        Red.SetActive(true);
        Yellow.SetActive(false);
        Orange.SetActive(false);
    }

    public void YellowActivate()
    {
        Yellow.SetActive(true);
        Red.SetActive(false);
        Orange.SetActive(false);
    }

    public void OrangeActivate()
    {
        Orange.SetActive(true);
        Red.SetActive(false);
        Yellow.SetActive(false);
    }
}
