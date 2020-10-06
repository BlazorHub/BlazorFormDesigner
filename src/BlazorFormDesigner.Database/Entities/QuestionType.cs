using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BlazorFormDesigner.Database.Entities
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QuestionType
    {
        [EnumMember(Value = "Binary question")]
        Binary,
        [EnumMember(Value = "Proportional question")]
        Proportional,
        [EnumMember(Value = "Single chioce question")]
        SingleChoice,
        [EnumMember(Value = "Multiple chioce question")]
        MultipleChoice,
        [EnumMember(Value = "Preference order question")]
        PreferenceOrder,
    }
}
