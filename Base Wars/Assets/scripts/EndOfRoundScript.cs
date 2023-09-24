using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfRoundScript : MonoBehaviour
{

    public void restartRound()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }


}
