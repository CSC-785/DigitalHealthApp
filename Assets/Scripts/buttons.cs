using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public void changeToMainMenu()
    {
        UnityEngine.Debug.Log("Pressed for menu");
        SceneManager.LoadScene("Menu");
    }

    public void changeToHome()
    {
        UnityEngine.Debug.Log("Pressed for home");
        SceneManager.LoadScene("HomeScreen");
    }

    public void changeToSettings()
    {
        UnityEngine.Debug.Log("Pressed for settings");
        SceneManager.LoadScene("Settings");
    }

    public void changeToExplore()
    {
        UnityEngine.Debug.Log("Pressed for explore");
        SceneManager.LoadScene("Explore");
    }

    public void changeToFAQ()
    {
        UnityEngine.Debug.Log("Pressed for FAQ");
        SceneManager.LoadScene("FAQ");
    }

    public void changeToContact()
    {
        UnityEngine.Debug.Log("Pressed for contact");
        SceneManager.LoadScene("Contact");
    }

    public void changeToInfo()
    {
        UnityEngine.Debug.Log("Pressed for info");
        SceneManager.LoadScene("Info");
    }

    public void changeTosurvey()
    {
        UnityEngine.Debug.Log("Pressed for survey");
        SceneManager.LoadScene("Survey");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
