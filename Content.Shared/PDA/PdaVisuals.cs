using Robust.Shared.Serialization;

namespace Content.Shared.PDA
{
    [Serializable, NetSerializable]
    public enum PdaVisuals
    {
        IdCardInserted,
        PenInserted,//goob addition for pen visual
        PdaType
    }

    [Serializable, NetSerializable]
    public enum PdaUiKey
    {
        Key
    }

}
