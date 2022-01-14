using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class HapticController : MonoBehaviour
{
    public const string HapticPlayerPrefId = "Haptic_enabled";
    public static Action<bool> OnHapticChanged;
    private static HapticControllerChecker check = new HapticControllerChecker();
    private Toggle toggle;

    private const int On = 1;
    private const int Off = 0;

    public static void ChangeHaptic(bool isEnabled){
        Haptic.Enabled = isEnabled;
        PlayerPrefs.SetInt(HapticPlayerPrefId,isEnabled? On : Off);
        PlayerPrefs.Save();
        OnHapticChanged?.Invoke(isEnabled);
    } 
    private void Awake() {
        toggle = GetComponent<Toggle>();
        toggle.onValueChanged.AddListener((enable)=>{
            ChangeHaptic(enable);
        });
    }

    private void OnEnable()
    {
        Check();
    }
    private void Check(){
        toggle.isOn = PlayerPrefs.GetInt(HapticPlayerPrefId,On) == On;
    }
}

public class HapticControllerChecker{
    private const int On = 1;
    private const int Off = 1;

    private bool isEnabled { 
        get { 
            return PlayerPrefs.GetInt(HapticController.HapticPlayerPrefId, On) == On;
        }
    }
    public HapticControllerChecker(){ 
        SceneManager.sceneLoaded+=(scene,mode)=>{
            HapticController.ChangeHaptic(isEnabled);
        };
    }
}
