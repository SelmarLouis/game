using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    /*(SELMAR) Play-knappens funktion är "Startgame()". Denna säger att när knappen trycks ned så spelas nästa scen i build index upp som då är 
    spelscenen. Den säger också att Exit-knappens funktion är att utföra metoden "Exitgame()" som innebär att när Exit-knappen trycks ned så "stängs spelet ned"
    vilket inte går att visa i Unity så spelet visar att det stängs ned genom att skicka EXIT GAME i consolen istället.*/
    public void Startgame()
    
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Exitgame()
    {
        Application.Quit();
        Debug.Log("EXIT GAME");
    }


}
