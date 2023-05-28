using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ValueAdd : MonoBehaviour
{
    private static TMP_Text _money;
   
    private static int money = 0;
    
    private bool _eventfound;

    public void AddScore()
    {
        money += 100;
            
    }

    public void Start()
    {
        _money = GameObject.Find("MoneyCount").GetComponent<TMP_Text>();
        
    }

    public void Update()
    {
        
        _money.text = money.ToString();
        
        
    }
}
