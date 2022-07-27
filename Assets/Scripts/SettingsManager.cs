using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsManager : MonoBehaviour
{
    private ObjectManager objectManager;

    [Header("Screens")]
    [SerializeField] private GameObject settingsScreen;


    //[SerializeField] private


    public bool SimulationOn { get { return !settingsScreen.activeSelf; } }


    private void Awake()
    {
        objectManager = GetComponent<ObjectManager>();
    }




    // ### Functions ###

    /// <summary>
    /// Opens the settings screen and stop the simulation
    /// </summary>
    public void OpenSettings()
    {
        settingsScreen.SetActive(true);
        StopSimulation();
    }

    /// <summary>
    /// Closes the settings screen and resume the simulation
    /// </summary>
    public void CloseSettings()
    {
        settingsScreen.SetActive(false);
        ResumeSimulation();
    }

    /// <summary>
    /// Stops the simulation
    /// </summary>
    public void StopSimulation()
    {
        Time.timeScale = 0;
    }
    /// <summary>
    /// Resumes the simulation
    /// </summary>
    public void ResumeSimulation()
    {
        Time.timeScale = 1;
    }
}
