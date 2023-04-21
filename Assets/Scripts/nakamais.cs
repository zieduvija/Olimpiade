using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace nakamais
{
    public class nakamais : MonoBehaviour
    {
        public int skaitlis = 0;
        public void limenis(){

             if(skaitlis == 10)
             {
                 Application.Quit();
             }else SceneManager.LoadScene(skaitlis);
        }

        public void Quit(){
             Application.Quit();
             }
    }
}
