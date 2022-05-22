using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
  {
      if (other.tag == "Player")
      {
          //cambio de escena
          SceneManager.LoadScene("battle");
      }
    }
    public enum Levels{rpg = 0, battle=1}
    public void CambiarNivel(Levels level)
    {
        SceneManager.LoadScene((int)level);
    }
    
}
