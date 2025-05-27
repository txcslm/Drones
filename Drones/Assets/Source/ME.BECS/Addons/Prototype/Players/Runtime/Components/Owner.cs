namespace ME.BECS.Players {

    public struct UnitOwnerComponentGroup {
        
        public static UnityEngine.Color color = UnityEngine.Color.white;
        
    }

    [ComponentGroup(typeof(UnitOwnerComponentGroup))]
    public struct OwnerComponent : IComponent {

        public Ent ent;

    }

    [ComponentGroup(typeof(PlayersComponentGroup))]
    public struct OwnerChangedEvent : IComponent {

        public Ent prevOwner;

    }

}