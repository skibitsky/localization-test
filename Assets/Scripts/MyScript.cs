using UnityEngine;
using UnityEngine.Localization;

public class MyScript : MonoBehaviour
{
    // Player's name to be used as an argument in _myString
    public string PlayerName => "Neo";
    
    [SerializeField] private LocalizedString _myString;
}
