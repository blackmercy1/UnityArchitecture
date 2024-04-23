using Game.Systems.AbilitySystem;
using UnityEngine;

namespace Game.Common.Configs.Ability
{
    [CreateAssetMenu(fileName = "FireAbilityConfig", menuName = "ScriptableObject/Configs/Abilities/FireAbility")]
    public class FireAbilityConfig : ScriptableObject
    {
        [SerializeField] private FireAbility _rangedAbilityPrefab;
        [SerializeField] private int _flySpeed;
        [SerializeField] private int _damage;

        public FireAbility RangedAbility => _rangedAbilityPrefab;
        public int FlySpeed => _flySpeed;
        public int Damage => _damage;
    }
}