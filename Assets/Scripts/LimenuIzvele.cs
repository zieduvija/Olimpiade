using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LimenuIzvele : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI vietasNosaukums;
    public TextMeshProUGUI vietasApraksts;
    public GameObject bildesPanelis;
    Sprite pirmais,otrais;


    public void pirmaisLimenis() {
        vietasNosaukums.text = "Liepājas pludmale";
        vietasApraksts.text = "Pludmale Liepājas krastā.\nUzdevums: Attīrīt no atkritumiem!";
        bildesPanelis.gameObject.GetComponent<Image>().sprite = pirmais;
    }

    public void otraisLimenis()
    {
        vietasNosaukums.text = "Dienvidu forti";
        vietasApraksts.text = "Forti Liepājas dienvidos.\nUzdevums: Attīrīt no atkritumiem!";
        bildesPanelis.gameObject.GetComponent<Image>().sprite = otrais;
    }

}
