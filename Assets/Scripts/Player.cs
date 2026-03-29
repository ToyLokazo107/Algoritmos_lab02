using UnityEngine;

public class Player : MonoBehaviour
{
    public int nivel;
    public Skill[] habilidades;

    public bool PuedeUsarSkill(Skill skill)
    {
        return nivel >= skill.nivelRequerido;
    }
}
