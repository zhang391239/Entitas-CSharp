﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public PrimaryEntityIndexComponent primaryEntityIndex { get { return (PrimaryEntityIndexComponent)GetComponent(GameComponentsLookup.PrimaryEntityIndex); } }
    public bool hasPrimaryEntityIndex { get { return HasComponent(GameComponentsLookup.PrimaryEntityIndex); } }

    public void AddPrimaryEntityIndex(string newValue) {
        var index = GameComponentsLookup.PrimaryEntityIndex;
        var component = CreateComponent<PrimaryEntityIndexComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePrimaryEntityIndex(string newValue) {
        var index = GameComponentsLookup.PrimaryEntityIndex;
        var component = CreateComponent<PrimaryEntityIndexComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePrimaryEntityIndex() {
        RemoveComponent(GameComponentsLookup.PrimaryEntityIndex);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherPrimaryEntityIndex;

    public static Entitas.IMatcher<GameEntity> PrimaryEntityIndex {
        get {
            if(_matcherPrimaryEntityIndex == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PrimaryEntityIndex);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPrimaryEntityIndex = matcher;
            }

            return _matcherPrimaryEntityIndex;
        }
    }
}