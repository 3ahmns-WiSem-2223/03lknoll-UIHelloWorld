using UnityEngine;
using UnityEngine.UI;

public class ZahlPlusMinus : MonoBehaviour
{
    int zahl;
    public Text zahlAnzeigen;
    
    public void addOne()
    {
        zahl += 1;
    }
    public void MinusOne()
    {
        zahl -= 1;
    }
    void Update()
    {
        zahlAnzeigen.text = zahl.ToString();
    }
}
