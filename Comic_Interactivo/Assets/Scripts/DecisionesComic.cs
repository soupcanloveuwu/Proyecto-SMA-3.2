using NUnit.Framework.Constraints;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;

public class DecisionesComic : MonoBehaviour
{
    public TMP_Text TextPanel;
    public Image PanelCOlor;

    public int Decision = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {

    }

    public void decision1()
    {
        TextPanel.text = "Resultado 1";
        PanelCOlor.color = Color.red;

    }

    public void decision2()
    {
        TextPanel.text = "Resultado 2";
        PanelCOlor.color = Color.yellow;
    }

    public void decision3()
    {
        TextPanel.text = "Resultado 3";
        PanelCOlor.color = Color.green;
    }
}
