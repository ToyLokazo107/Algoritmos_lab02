using UnityEngine;

[CreateAssetMenu(fileName = "NewSkill", menuName = "Game/Skill")]
public class Skill : ScriptableObject
{
    public int id;
    public string nombre;
    public int costo;
    public int nivelRequerido;
}