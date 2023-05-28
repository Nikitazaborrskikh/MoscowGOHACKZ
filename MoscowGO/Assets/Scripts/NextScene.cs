
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    
    [SerializeField] private TMP_InputField _login;
    [SerializeField] private TMP_InputField _pass;
    [SerializeField] private TMP_InputField _passcheck;
    [SerializeField] private GameObject _errorText;
    [SerializeField] private GameObject _ShortLoginText;
    
   

    
    public void OnClick()
    {
        if (_login.text.Length > 3 && _pass.text == _passcheck.text)
        {
            LoginPassHolder.Playername = _login.text;
            SceneManager.LoadScene(1);
        }
        
        if (_login.text.Length < 3 )
        {
            _ShortLoginText.SetActive(true);
            _login.text = "";
            
        }
        if (_pass.text != _passcheck.text)
        {
            _errorText.SetActive(true);
            _pass.text = "";
            _passcheck.text = "";
        }
    }
}
