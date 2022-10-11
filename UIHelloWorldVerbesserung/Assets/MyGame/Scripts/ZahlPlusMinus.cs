using UnityEngine;
using UnityEngine.UI;

public class ZahlPlusMinus : MonoBehaviour
{
    private int zahl;
    [SerializeField] private Text zahlAnzeigen;
    
    public void AddOne()
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
