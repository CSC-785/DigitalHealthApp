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
        SceneManager.LoadScene("DocContactTo");
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

    public void changeToDocInfo()
    {
        UnityEngine.Debug.Log("Pressed for DocInfo");
        SceneManager.LoadScene("DocInfo");
    }

    public void changeToDocFrom()
    {
        UnityEngine.Debug.Log("Pressed for DocContactFrom");
        SceneManager.LoadScene("DocContactFrom");
    }

    public void OpenPreURL()
    {
        Application.OpenURL("https://docs.google.com/forms/d/e/1FAIpQLSc2IyZjIDl1nzWm0wNog8DFWDE9hpcRL9fh5Kelse8SjiirdA/viewform?usp=sf_link");
        UnityEngine.Debug.Log("Going to preop survey.");
    }

    public void OpenPostURL()
    {
        Application.OpenURL("https://docs.google.com/forms/d/e/1FAIpQLSf0wxX0mZ7s4gVxg2y-0L5vVc0uFCJe2wIWeGF8RjP2tkVlrQ/viewform?usp=sf_link");
        UnityEngine.Debug.Log("Going to postop survey.");
    }

    public void OpenAdminURL()
    {
        Application.OpenURL("https://docs.google.com/forms/u/0/");
        UnityEngine.Debug.Log("Going to admin survey.");
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
