using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LimenuIzvele : MonoBehaviour
{


    public TextMeshProUGUI vietasNosaukums;
    public TextMeshProUGUI vietasApraksts;
    public GameObject bildesPanelis;
    public Sprite pirmais,otrais;
    public int level = 0;

    public Button viens;
    public Button divi;
    public Button tris;


    public void Start(){
;
    }
    public void pirmaisLimenis() {
        vietasNosaukums.SetText("Liepājas pludmale");
        vietasApraksts.SetText("Pludmale Liepājas krastā.\nUzdevums: Attīrīt no atkritumiem!"); 
        bildesPanelis.gameObject.GetComponent<Image>().sprite = pirmais;
        level = 1;
    }

    public void otraisLimenis()
    {
        vietasNosaukums.SetText("Depozita punkts");
        vietasApraksts.SetText("Vieta kur nodot atkritumus.\nUzdevums: Saliec atkritumus atbilstošajos konteineros!");
        bildesPanelis.gameObject.GetComponent<Image>().sprite = otrais;
        level = 2;
    }

    
    public void Update(){

    }

    public void resetlevel(){
        level = 1;
    }



}
