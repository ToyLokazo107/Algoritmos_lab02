using UnityEngine;

[CreateAssetMenu(fileName = "SkillManager", menuName = "Game/SkillManager")]
public class SkillManager : ScriptableObject
{
    public Skill[] todasLasSkills;

    public bool PuedeAprender(Player player, Skill skill)
    {
        return GameUtils.Validar<Skill>(skill, x => player.nivel >= x.nivelRequerido);
    }

    public void UsarSkill(Skill skill)
    {
        GameUtils.Ejecutar<Skill>(skill, x => Debug.Log("Usando habilidad: " + x.nombre));
    }
}