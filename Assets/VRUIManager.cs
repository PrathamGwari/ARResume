using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VRUIManager : MonoBehaviour
{
    public VirtualButtonBehaviour[] virtualButtons;//creates virtual buttons

    public GameObject educationPanel;
    private bool showEducationPanel = false;

    public GameObject workExperiencePanel;
    private bool showWorkExperiencePanel = false;

    public GameObject personalProjectsPanel;
    private bool showPersonalProjectsPanel = false;

    public GameObject achievementsPanel;
    private bool showAchievementsPanel = false;

    // Start is called before the first frame update
    void Start()
    {
        showEducationPanel = false;
        educationPanel.SetActive(false);

        showWorkExperiencePanel = false;
        workExperiencePanel.SetActive(false);

        showPersonalProjectsPanel = false;
        personalProjectsPanel.SetActive(false);

        showAchievementsPanel = false;
        achievementsPanel.SetActive(false);

        for (int i = 0; i < virtualButtons.Length; i++)
        {
            virtualButtons[i].RegisterOnButtonReleased(OnButtonPressed);// this statement creates a button release event for all the virtual buttons
        }

    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "EducationButton")
        {
            Debug.LogError("Clicked on EducationButton");
            showWorkExperiencePanel = false;
            workExperiencePanel.SetActive(false);

            showPersonalProjectsPanel = false;
            personalProjectsPanel.SetActive(false);

            showAchievementsPanel = false;
            achievementsPanel.SetActive(false);

            showEducationPanel = !showEducationPanel;
        }
        if (vb.VirtualButtonName == "WorkButton")
        {
            Debug.LogError("Clicked on WorkButton");
            showEducationPanel = false;
            educationPanel.SetActive(false);

            showPersonalProjectsPanel = false;
            personalProjectsPanel.SetActive(false);

            showAchievementsPanel = false;
            achievementsPanel.SetActive(false);
            
            showWorkExperiencePanel = !showWorkExperiencePanel;
        }
        if (vb.VirtualButtonName == "ProjectsButton")
        {
            
            Debug.LogError("Clicked on Button");
            showEducationPanel = false;
            educationPanel.SetActive(false);

            showWorkExperiencePanel = false;
            workExperiencePanel.SetActive(false);

            showAchievementsPanel = false;
            achievementsPanel.SetActive(false);
            
            showPersonalProjectsPanel = !showPersonalProjectsPanel;
        }
        if (vb.VirtualButtonName == "AchievementsButton")
        {
            Debug.LogError("Clicked on AchievementsButton");
            showEducationPanel = false;
            educationPanel.SetActive(false);

            showWorkExperiencePanel = false;
            workExperiencePanel.SetActive(false);

            showPersonalProjectsPanel = false;
            personalProjectsPanel.SetActive(false);
            
            showAchievementsPanel = !showAchievementsPanel;
        }
    }

   

    void Update()
    {
        if (showEducationPanel == true)
        {
            educationPanel.SetActive(true);
        }
        else
        {
            educationPanel.SetActive(false);
        }
        if (showWorkExperiencePanel == true)
        {
            workExperiencePanel.SetActive(true);
        }
        else
        {
            workExperiencePanel.SetActive(false);
        }
        if (showPersonalProjectsPanel == true)
        {
            personalProjectsPanel.SetActive(true);
        }
        else
        {
            personalProjectsPanel.SetActive(false);
        }
        if (showAchievementsPanel == true)
        {
            achievementsPanel.SetActive(true);
        }
        else
        {
            achievementsPanel.SetActive(false);
        }
    }
}
