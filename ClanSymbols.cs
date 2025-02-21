using UnityEngine;
using static UnityEditor.VersionControl.Message;

public class ClanSymbols : MonoBehaviour
{
    [SerializeField] private Sprite banuHaqim;
    [SerializeField] private Sprite brujah;
    [SerializeField] private Sprite gangrel;
    [SerializeField] private Sprite hecata;
    [SerializeField] private Sprite lasombra;
    [SerializeField] private Sprite malkavian;
    [SerializeField] private Sprite ministry;
    [SerializeField] private Sprite nosferatu;
    [SerializeField] private Sprite ravnos;
    [SerializeField] private Sprite toreador;
    [SerializeField] private Sprite tremere;
    [SerializeField] private Sprite tzimisce;
    [SerializeField] private Sprite ventrue;

    public Sprite GetSpriteByClan(Clan clan)
    {
        Sprite sprite = null;
        switch (clan) 
        {
            case Clan.BanuHaqim:
                sprite = banuHaqim;
                break;
            case Clan.Brujah:
                sprite = brujah;
                break;
            case Clan.Gangrel:
                sprite = gangrel;
                break;
            case Clan.Hecata:
                sprite = hecata;
                break;
            case Clan.Lasombra:
                sprite = lasombra;
                break;
            case Clan.Malkavian:
                sprite = malkavian;
                break;
            case Clan.Ministry:
                sprite = ministry;
                break;
            case Clan.Nosferatu:
                sprite = nosferatu;
                break;
            case Clan.Ravnos:
                sprite = ravnos;
                break;
            case Clan.Toreador: 
                sprite = toreador;
                break;
            case Clan.Tremere:
                sprite = tremere;
                break;
            case Clan.Tzimisce:
                sprite = tzimisce;
                break;
            case Clan.Ventrue:
                sprite = ventrue;
                break;
        }
        return sprite;
    }
}
