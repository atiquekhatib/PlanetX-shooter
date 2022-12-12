using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menutogame : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void Gotohome()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
