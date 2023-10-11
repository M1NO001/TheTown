using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResultInputName : MonoBehaviour
{
    public InputField playerNameInput;
    public Text characterNameText;
    public Button Button_Join;
   
    public void JoinButtonClick()
    {
        if(playerNameInput.text.Length > 1 && playerNameInput.text.Length < 11)
        {
            characterNameText.text = playerNameInput.text;
            SceneManager.LoadScene("MainScene");
        }       
    }
}
