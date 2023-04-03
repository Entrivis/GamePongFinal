using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
//using UnityEngine.Animations;

public class PressToPlay : MonoBehaviour
{
    //[SerializeField]private GameObject showWinner;
    private BallControl Bola;

    private void Start()
    {
        Bola = GameObject.Find("Ball").GetComponent<BallControl>();
    }
    public void ShowText()
    {
        gameObject.SetActive(false);
        Bola.EnableScript();
    }
}
