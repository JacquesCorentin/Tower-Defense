using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UiManager : MonoBehaviour
{
    public static UiManager instance { get; set; } = null;

    public Text _timerText = null;

    private Text timerText { get { return _timerText; } }


    public Text _goldText = null;

    private Text goldText { get { return _goldText; } }

    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTimer(float timer)
    {
        /*if (timer < 0)
        {
            timer = 0;
        }*/
        timerText.text = "Timer : " + timer.ToString("F1") + " s";
    }

    public void SetGold(int gold)
    {
        goldText.text = "Gold : " + gold + " Po";
    }
}
