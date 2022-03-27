using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    private static bool firstRiddleSolved = false;
    private static bool secondRiddleSolved = false;
    
    public static void changeScene(int i) {
        SceneManager.LoadScene(i);
    }

    public static bool GetFirstRiddleSolved()
    {
        return firstRiddleSolved;
    }
    
    public static bool GetSecondRiddleSolved()
    {
        return secondRiddleSolved;
    }
    
    public static void SetFirstRiddleSolved(bool solved)
    {
        firstRiddleSolved = solved;
    }
    
    public static void SetSecondRiddleSolved(bool solved)
    {
        secondRiddleSolved = solved;
    }
}