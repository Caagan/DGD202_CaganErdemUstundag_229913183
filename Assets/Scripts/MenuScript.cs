using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject CreditsImage;
    bool creditshidden = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartNewGame()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Quitgame()
    {
        Application.Quit(); //cikis islemi
    }
    public void ShowCredits()
    {
        if (creditshidden)
        {
            CreditsImage.SetActive(true);
            creditshidden = false;
        }
        else
        {

            CreditsImage.SetActive(false);
            creditshidden = true;
        }
       
    }
}
