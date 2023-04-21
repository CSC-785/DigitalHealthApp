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

    public void changeToSurvey()
    {
        UnityEngine.Debug.Log("Pressed for survey");
        SceneManager.LoadScene("Survey");
    }

    public void changeToDocHome()
    {
        UnityEngine.Debug.Log("Pressed for DoctorHome");
        SceneManager.LoadScene("DoctorHome");
    }

    public void changeToDocMenu()
    {
        UnityEngine.Debug.Log("Pressed for DoctorMenu");
        SceneManager.LoadScene("DoctorMenu");
    }

    public void changeToDocSettings()
    {
        UnityEngine.Debug.Log("Pressed for DoctorSettings");
        SceneManager.LoadScene("DoctorSettings");
    }

    public void changeToDocContact()
    {
        UnityEngine.Debug.Log("Pressed for DoctorContact");
        SceneManager.LoadScene("DoctorContact");
    }

    public void changeToDocSelect()
    {
        UnityEngine.Debug.Log("Pressed for DoctorSelect");
        SceneManager.LoadScene("DoctorSelect");
    }

    public void changeToDocSurvey()
    {
        UnityEngine.Debug.Log("Pressed for DoctorSurvey");
        SceneManager.LoadScene("DoctorSurvey");
    }

    public void changeToLogin()
    {
        UnityEngine.Debug.Log("Pressed for Login");
        SceneManager.LoadScene("Login");
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
