using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoginHolder : MonoBehaviour
{
    [SerializeField] private TMP_Text _playerLogin;


    private void Start()
    {
        _playerLogin.text = LoginPassHolder.Playername;
    }
}
