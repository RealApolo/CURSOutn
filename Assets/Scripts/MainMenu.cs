using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button btnEasy;
    [SerializeField] private Button btnHard;

    private void Start()
    {
        btnEasy.onClick.AddListener(GoToLevelEasy);
        btnHard.onClick.AddListener(GoToLevelHard);
    }

    private void GoToLevelEasy()
    {
        SceneManager.LoadScene("EasyLevel");
    }

    private void GoToLevelHard()
    {
       // SceneManager.LoadScene(1);
       SceneManager.LoadScene("HardLevel");
    }

    //SE ASIGNÓ EN EL EVENTO OnClick del Button
    public void ExitGame()
    {
        Debug.Log("Exit Game! :(");
        Application.Quit();
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Escalable")
        {
            //enPoseDeEscalar = trreue;
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Escalera")
        {
            //enPoseDeEscalar = false;
        }
    }
}
