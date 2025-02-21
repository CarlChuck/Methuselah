using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Attribute blood;
    [SerializeField] private Attribute favour;
    [SerializeField] private Attribute finances;

    [SerializeField] private GameObject mainMenuWindow;
    [SerializeField] private GameObject settingsWindow;
    [SerializeField] private GameObject mainGameWindow;
    [SerializeField] private GameObject newGameWindow;
    [SerializeField] private GameObject loadGameWindow;

    [SerializeField] private GameObject actionsPane;
    [SerializeField] private GameObject alliesPane;
    [SerializeField] private GameObject retainersPane;
    [SerializeField] private GameObject influencePane;
    [SerializeField] private GameObject domainPane;
    [SerializeField] private GameObject havenPane;

    [SerializeField] private Player player;
    [SerializeField] private TextMeshProUGUI playerInputName;
    [SerializeField] private TMP_Dropdown clanDropdown;

    [SerializeField] private Image clanSymbolIcon;
    [SerializeField] private ClanSymbols clanSymbols;
    [SerializeField] private TextMeshProUGUI playerDisplayName;
    [SerializeField] private TextMeshProUGUI playerDisplayRank;

    private void Start()
    {
        SetMainMenuWindow();
        CloseAllPanes();
    }

    #region SetGameMode
    public void SetMainMenuWindow()
    {
        mainMenuWindow.SetActive(true);
        settingsWindow.SetActive(false);
        mainGameWindow.SetActive(false);
        newGameWindow.SetActive(false);
        loadGameWindow.SetActive(false);
    }
    public void SetMainGameWindow()
    {
        mainMenuWindow.SetActive(false);
        settingsWindow.SetActive(false);
        mainGameWindow.SetActive(true);
        newGameWindow.SetActive(false);
        loadGameWindow.SetActive(false);
    }
    public void SetNewGameWindow()
    {
        mainMenuWindow.SetActive(false);
        settingsWindow.SetActive(false);
        mainGameWindow.SetActive(false);
        newGameWindow.SetActive(true);
        loadGameWindow.SetActive(false);
    }
    public void SetLoadGameWindow()
    {
        mainMenuWindow.SetActive(false);
        settingsWindow.SetActive(false);
        mainGameWindow.SetActive(false);
        newGameWindow.SetActive(false);
        loadGameWindow.SetActive(true);
    }
    public void SetSettingsWindow()
    {
        settingsWindow.SetActive(true);
    }
    public void UnSetSettingsWindow()
    {
        settingsWindow.SetActive(false);
    }
    #endregion

    #region MainMenu
    public void SetName()
    {
        player.SetName(playerInputName.text);
    }
    public void SetClan()
    {
        Clan selectedClan;
        int dropDownValue = clanDropdown.value;
        switch (dropDownValue)
        {
            case 1:
                selectedClan = Clan.BanuHaqim;
                break;
            case 2:
                selectedClan = Clan.Brujah;
                break;
            case 3:
                selectedClan = Clan.Gangrel;
                break;
            case 4:
                selectedClan = Clan.Hecata;
                break;
            case 5:
                selectedClan = Clan.Lasombra;
                break;
            case 6:
                selectedClan = Clan.Malkavian;
                break;
            case 7:
                selectedClan = Clan.Ministry;
                break;
            case 8:
                selectedClan = Clan.Nosferatu;
                break;
            case 9:
                selectedClan = Clan.Ravnos;
                break;
            case 10:
                selectedClan = Clan.Toreador;
                break;
            case 11:
                selectedClan = Clan.Tremere;
                break;
            case 12:
                selectedClan = Clan.Tzimisce;
                break;
            case 13:
                selectedClan = Clan.Ventrue;
                break;
            default:
                selectedClan = Clan.Brujah;
                break;
        }
        player.SetClan(selectedClan);
    }

    public void StartGame()
    {
        if (player.GetName().Length > 30)
        {

        }
        else if (player.GetName().Length > 2 && player.GetClan() !=Clan.Unset)
        {
            SetMainGameWindow();
        }
        clanSymbolIcon.sprite = clanSymbols.GetSpriteByClan(player.GetClan());
        playerDisplayName.text = player.GetName();
        playerDisplayRank.text = player.GetRankAsString();
        blood.UpdateAttributeValue(player.GetBloodPool());
        favour.UpdateAttributeValue(player.GetFavour());
        finances.UpdateAttributeValue(player.GetFinances());
    }
    #endregion

    #region Settings

    #endregion

    #region MainGame
    public void UpdateAttributes(int newBlood, int newFavour, int newFinances)
    {
        blood.UpdateAttributeValue(newBlood);
        favour.UpdateAttributeValue(newFavour);
        finances.UpdateAttributeValue(newFinances);
    }
    private void CloseAllPanes()
    {
        actionsPane.SetActive(false);
        alliesPane.SetActive(false);
        retainersPane.SetActive(false);
        influencePane.SetActive(false);
        domainPane.SetActive(false);
        havenPane.SetActive(false);
    }

    public void OpenPane(int pane)
    {
        CloseAllPanes();
        switch (pane) 
        {
            case 1:
                actionsPane.SetActive(true);
                break;
            case 2:
                alliesPane.SetActive(true);
                break;
            case 3:
                retainersPane.SetActive(true);
                break;
            case 4:
                influencePane.SetActive(true);
                break;
            case 5:
                domainPane.SetActive(true);
                break;
            case 6:
                havenPane.SetActive(true);
                break;
            default:
                actionsPane.SetActive(true);
                break;
        }
    }

    public void EndNight()
    {
        //TODO
    }

    #endregion

    public void ExitGame()
    {
        Application.Quit();
    }
}