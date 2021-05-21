using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Growl
    {
        public readonly static ModKey ModKey = ModKey.FromNameAndExtension("Growl - Werebeasts of Skyrim.esp");

        public static class Spell
        {
            private static FormLink<ISpellGetter> Construct(uint id) => new(ModKey.MakeFormKey(id));
            public static FormLink<ISpellGetter> HRI_Mortal_Spell_NPCCanMorph_Ab_Passives => Construct(0xaa06);
            public static FormLink<ISpellGetter> HRI_Mortal_Spell_NPCCanMorph_CD => Construct(0x2905a);
            public static FormLink<ISpellGetter> HRI_Howl_Spell_RevertForm => Construct(0x29060);
            public static FormLink<ISpellGetter> HRI_Werewolf_Spell_Attack => Construct(0x2e166);
            public static FormLink<ISpellGetter> HRI_Werewolf_Spell_Attack_FrenzyAttack => Construct(0x2e16b);
            public static FormLink<ISpellGetter> HRI_PerkTree_Spell_SetWerebearGlobal_Ab => Construct(0x3d47b);
            public static FormLink<ISpellGetter> HRI_Mortal_Spell_Beastblood_Drawbacks_Ab => Construct(0x4c7a7);
            public static FormLink<ISpellGetter> HRI_Mortal_Spell_Beastblood_HuntersMoon_Ab => Construct(0x4c7ae);
            public static FormLink<ISpellGetter> HRI_Lycan_Spell_BattleReset_CloakProc => Construct(0x518bb);
            public static FormLink<ISpellGetter> HRI_Lycan_Spell_BeastForm_ReplacerOnCooldown => Construct(0x569c3);
            public static FormLink<ISpellGetter> HRI_Lycan_Spell_BeastForm_HardCastIndicator => Construct(0x569c7);
            public static FormLink<ISpellGetter> HRI_Werewolf_Spell_Attack_LeapAttack => Construct(0x5bad0);
            public static FormLink<ISpellGetter> HRI_Mortal_Spell_Beastblood_RegenerateHealthAndStamina_Ab_1 => Construct(0xc0f46);
            public static FormLink<ISpellGetter> HRI_Mortal_Spell_Beastblood_FortifySpeed_Ab => Construct(0xc0f49);
            public static FormLink<ISpellGetter> HRI_Mortal_Spell_Beastblood_RegenerateHealthAndStamina_Ab_2 => Construct(0xc0f4f);
            public static FormLink<ISpellGetter> HRI_Mortal_Spell_Beastblood_SpreadTheBeastblood_Ab => Construct(0xcb156);
            public static FormLink<ISpellGetter> HRI_Mortal_Spell_Beastblood_SpreadTheBeastblood_Stagger => Construct(0xcb159);
            public static FormLink<ISpellGetter> HRI_Mortal_Spell_NPCCanMorph_Ab_BeastForm => Construct(0xcb16a);
            public static FormLink<ISpellGetter> HRI_Racial_Spell_Argonian_Ab => Construct(0xd0277);
            public static FormLink<ISpellGetter> HRI_Racial_Spell_Imperial_Ab => Construct(0xd0279);
            public static FormLink<ISpellGetter> HRI_Racial_Spell_WoodElf_Ab => Construct(0xd027b);
            public static FormLink<ISpellGetter> HRI_Racial_Spell_Breton_Ab => Construct(0xd027e);
            public static FormLink<ISpellGetter> HRI_Racial_Spell_HighElf_Ab => Construct(0xd0280);
            public static FormLink<ISpellGetter> HRI_Racial_Spell_Orc_Ab => Construct(0xd0286);
            public static FormLink<ISpellGetter> HRI_Racial_Spell_Nord_Ab => Construct(0xd028a);
            public static FormLink<ISpellGetter> HRI_Racial_Spell_Redguard_Ab => Construct(0xd028e);
            public static FormLink<ISpellGetter> HRI_Racial_Spell_DarkElf_Ab => Construct(0xd0291);
            public static FormLink<ISpellGetter> HRI_Racial_Spell_Khajiit_Ab => Construct(0xd0295);
            public static FormLink<ISpellGetter> HRI_Alternate_Spell_IsAlternate_Ab => Construct(0xdf5b9);
            public static FormLink<ISpellGetter> HRI_Lycan_Spell_BeastFormCooldown => Construct(0x13a7d7);
        }
    }
}
