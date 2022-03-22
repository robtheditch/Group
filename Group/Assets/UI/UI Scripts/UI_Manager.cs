using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [SerializeField]
    private Text moneyText;
    [SerializeField]
    private Text energyRatingText;
    [SerializeField]
    private GameObject HUD;

    private Scene currentScene;
    private string currentSceneName;

    public float moneyAmount;
    public float energyRating;

    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        currentSceneName = currentScene.name;
        Time.timeScale = 1;
        moneyAmount = 0;
        energyRating = 41;
    }

    // Update is called once per frame
    void Update()
    {
        if (moneyText)
        {
            moneyText.text = "� " + moneyAmount.ToString();
        }
        if (energyRatingText)
        {
            energyRatingText.text = energyRating.ToString() + "/61"; 
        }
        
    }

    public void OpenMenu(GameObject Menu)
    {
        Menu.SetActive(true);
        Time.timeScale = 0;

        if(Menu.name == "Codex_Menu")
        {
            HUD.SetActive(false);
        }
    }

    public void close(GameObject button)
    {
        button.transform.parent.gameObject.SetActive(false);
        Time.timeScale = 1;
        HUD.SetActive(true);
    }

    public void ButtonPress(string buttonName)
    {
        switch(buttonName)
        {
            case "Home":
                SceneManager.LoadScene("Home");
                break;
            case "Restart":
                SceneManager.LoadScene(currentSceneName);
                break;
            case "LevelSelect":
                SceneManager.LoadScene("Level_Select");
                break;
            case "EndLevel":
                SceneManager.LoadScene("Score_Screen");
                break;
            case "Level1":
                SceneManager.LoadScene("ss");
                break;
            default:
                print("No Button Selected");
                break;
        }
    }
}
